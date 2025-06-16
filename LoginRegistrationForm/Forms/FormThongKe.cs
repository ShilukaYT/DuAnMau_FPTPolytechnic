using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace LoginRegistrationForm.Forms
{
    public partial class FormThongKe : Form
    {
        DataClassesDBDataContext db = new DataClassesDBDataContext();
        public FormThongKe()
        {
            InitializeComponent();
        }

        private void ThongKeVaVeBieuDo()
        {
            DateTime tuNgay = dtpNgayDau.Value.Date;
            DateTime denNgay = dtpNgayCuoi.Value.Date.AddDays(1).AddSeconds(-1);
            int maNguoiDung = Session.MaTaiKhoan;

            var giaoDichTrongKhoang = from gd in db.GIAO_DICHes
                                      join dm in db.DANH_MUCs on gd.Ma_Danh_Muc equals dm.Ma_Danh_Muc
                                      where gd.Ngay_Giao_Dich.HasValue &&
                                            gd.Ngay_Giao_Dich.Value >= tuNgay &&
                                            gd.Ngay_Giao_Dich.Value <= denNgay &&
                                            dm.Ma_Tai_Khoan == maNguoiDung
                                      select new
                                      {
                                          gd.So_Tien,
                                          dm.Loai_Thu_Chi,
                                          gd.Ngay_Giao_Dich
                                      };

            var tongThu = giaoDichTrongKhoang
                .Where(x => x.Loai_Thu_Chi == "Thu")
                .Sum(x => (decimal?)x.So_Tien) ?? 0;

            var tongChi = giaoDichTrongKhoang
                .Where(x => x.Loai_Thu_Chi == "Chi")
                .Sum(x => (decimal?)x.So_Tien) ?? 0;

            labelThu.Text = tongThu.ToString("N0") + " đ";
            labelChi.Text = tongChi.ToString("N0") + " đ";

            // Vẽ lại biểu đồ theo ngày
            VeBieuDoTheoNgay(tuNgay, denNgay);
        }

        private void VeBieuDoTheoNgay(DateTime tuNgay, DateTime denNgay)
        {
            int maNguoiDung = Session.MaTaiKhoan;

            var giaoDichTheoNgay = from gd in db.GIAO_DICHes
                                   join dm in db.DANH_MUCs on gd.Ma_Danh_Muc equals dm.Ma_Danh_Muc
                                   where gd.Ngay_Giao_Dich >= tuNgay && gd.Ngay_Giao_Dich <= denNgay
                                         && dm.Ma_Tai_Khoan == maNguoiDung
                                   group new { gd.So_Tien, dm.Loai_Thu_Chi }
                                   by gd.Ngay_Giao_Dich.Value.Date into g
                                   select new
                                   {
                                       Ngay = g.Key,
                                       TongThu = g.Where(x => x.Loai_Thu_Chi == "Thu").Sum(x => (decimal?)x.So_Tien) ?? 0,
                                       TongChi = g.Where(x => x.Loai_Thu_Chi == "Chi").Sum(x => (decimal?)x.So_Tien) ?? 0
                                   };

            // Xoá dữ liệu cũ
            chartBieuDo.Series.Clear();
            chartBieuDo.ChartAreas.Clear();
            chartBieuDo.ChartAreas.Add(new ChartArea("ChartArea1"));

            // Tạo 2 Series: Thu và Chi
            Series seriesThu = new Series("Thu");
            seriesThu.ChartType = SeriesChartType.Column;
            seriesThu.Color = Color.Green;
            seriesThu.IsValueShownAsLabel = true;

            Series seriesChi = new Series("Chi");
            seriesChi.ChartType = SeriesChartType.Column;
            seriesChi.Color = Color.Red;
            seriesChi.IsValueShownAsLabel = true;

            // Thêm dữ liệu vào biểu đồ
            foreach (var item in giaoDichTheoNgay.OrderBy(x => x.Ngay))
            {
                string ngay = item.Ngay.ToString("dd/MM/yyyy");

                seriesThu.Points.AddXY(ngay, item.TongThu);
                seriesChi.Points.AddXY(ngay, item.TongChi);
            }

            chartBieuDo.Series.Add(seriesThu);
            chartBieuDo.Series.Add(seriesChi);
        }


        private void buttonHienThi_Click(object sender, EventArgs e)
        {
            if (dtpNgayDau.Value > dtpNgayCuoi.Value)
            {
                MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc.");
                return;
            }
            ThongKeVaVeBieuDo();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dtpNgayDau.Value = DateTime.Parse("2010-01-01");
            dtpNgayCuoi.Value = DateTime.Parse("2010-01-01");

            // Gọi lại hàm thống kê và vẽ biểu đồ như ban đầu
            ThongKeVaVeBieuDo();
        }

        private void chartBieuDo_Click(object sender, EventArgs e)
        {

        }

        private void FormThongKe_Load(object sender, EventArgs e)
        {
            ThongKeVaVeBieuDo();

        }
    }
}
