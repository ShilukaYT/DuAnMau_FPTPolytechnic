using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace LoginRegistrationForm.Forms
{
    public partial class FormThemDanhMuc : Form
    {
        public FormThemDanhMuc()
        {
            InitializeComponent();
        }
        int id = 0;
        void loadData()
        {
            int maNguoiDung = Session.MaTaiKhoan;
            dgvDanhMuc.AutoGenerateColumns = false;

            using (var db = new DataClassesDBDataContext())
            {
                var query = db.DANH_MUCs.Where(s => s.Ma_Tai_Khoan == maNguoiDung);

                // Sử dụng radiobutton để lọc
                if (rbThu.Checked)
                {
                    query = query.Where(s => s.Loai_Thu_Chi == "Thu");
                }
                else if (rbChi.Checked)
                {
                    query = query.Where(s => s.Loai_Thu_Chi == "Chi");
                }
                // nếu rbTatCa.Checked thì không lọc gì thêm

                dgvDanhMuc.DataSource = query.ToList();
            }

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        // hàm clear form rỗng
        void ClearForm()
        {
            tbTenDanhMuc.Clear();
            rbThu.Checked = false;
            rbChi.Checked = false;
            id = 0;
        }

        private void btnAddDanhMuc_Click(object sender, EventArgs e)
        {
            int maNguoiDung = Session.MaTaiKhoan;
            string tenDanhMuc = tbTenDanhMuc.Text.Trim();
            string loaiThuChi = rbThu.Checked ? "Thu" : (rbChi.Checked ? "Chi" : null);

            if (string.IsNullOrEmpty(tenDanhMuc) || loaiThuChi == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            using (var db = new DataClassesDBDataContext())
            {
                DANH_MUC danhMucMoi = new DANH_MUC
                {
                    Ten_Danh_Muc = tenDanhMuc,
                    Loai_Thu_Chi = loaiThuChi,
                    Ma_Tai_Khoan = maNguoiDung,
                };

                db.DANH_MUCs.InsertOnSubmit(danhMucMoi);
                db.SubmitChanges();

                MessageBox.Show("Thêm danh mục thành công!");
                tbTenDanhMuc.Clear();
                rbThu.Checked = false;
                rbChi.Checked = false;
                loadData();
            }
        }

        private void FormThemDanhMuc_Load(object sender, EventArgs e)
        {
            loadData();
        }

        void getDataByID()
        {
            using (var db = new DataClassesDBDataContext())
            {
                var danhMuc = db.DANH_MUCs.FirstOrDefault(k => k.Ma_Danh_Muc == id);
                if (danhMuc != null)
                {
                    tbTenDanhMuc.Text = danhMuc.Ten_Danh_Muc;
                    if (danhMuc.Loai_Thu_Chi == "Thu")
                    {
                        rbThu.Checked = true;
                    }

                    else if (danhMuc.Loai_Thu_Chi == "Chi")
                    {
                        rbChi.Checked = true;
                    }
                }
            }


        }
        private void dgvDanhMuc_DoubleClick(object sender, EventArgs e)
        {
            if (dgvDanhMuc.CurrentRow.Index != -1)
            {
                id = Convert.ToInt32(dgvDanhMuc.CurrentRow.Cells[0].Value);
                getDataByID();

                // 🔄 Đổi trạng thái nút HUỶ khi đang sửa
                btnHuy.Text = "HUỶ SỬA";
                btnHuy.BackColor = Color.OrangeRed;
                btnHuy.ForeColor = Color.White;
                btnHuy.Font = new Font(btnHuy.Font, FontStyle.Bold);

            }
        }

        private void btnXoaDanhMuc_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                MessageBox.Show("Vui lòng chọn danh mục cần xoá.");
                return;
            }
            using (var db = new DataClassesDBDataContext())
            {
                var danhMuc = db.DANH_MUCs.FirstOrDefault(d => d.Ma_Danh_Muc == id);
                if (danhMuc != null)
                {
                    if (MessageBox.Show("Bạn có chắc muốn xoá danh mục này và tất cả giao dịch liên quan?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        try
                        {
                            // Xoá giao dịch liên quan
                            db.GIAO_DICHes.DeleteAllOnSubmit(danhMuc.GIAO_DICHes);

                            // Sau đó xoá danh mục
                            db.DANH_MUCs.DeleteOnSubmit(danhMuc);

                            db.SubmitChanges();

                            MessageBox.Show("Đã xoá danh mục và các giao dịch liên quan.");
                            loadData();
                            ClearForm();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi khi xoá: " + ex.Message);
                        }
                    }
                }
            }

        }

        private void btnSuaDanhMuc_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                MessageBox.Show("Vui lòng chọn danh mục cần sửa.");
                return;
            }

            string tenDanhMuc = tbTenDanhMuc.Text.Trim();
            string loaiThuChi = rbThu.Checked ? "Thu" : (rbChi.Checked ? "Chi" : null);
            int maNguoiDung = Session.MaTaiKhoan;

            if (string.IsNullOrEmpty(tenDanhMuc) || loaiThuChi == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }
            using (var db = new DataClassesDBDataContext())
            {
                // 🔍 Kiểm tra tên danh mục đã tồn tại (trừ chính nó)
                bool isTrungTen = db.DANH_MUCs.Any(d =>
                    d.Ten_Danh_Muc.ToLower() == tenDanhMuc.ToLower()
                    && d.Ma_Tai_Khoan == maNguoiDung
                    && d.Ma_Danh_Muc != id
                );

                if (isTrungTen)
                {
                    MessageBox.Show("Tên danh mục này đã tồn tại. Vui lòng nhập tên khác.");
                    return;
                }

                // ✅ Cho phép sửa nếu không trùng
                var danhMuc = db.DANH_MUCs.FirstOrDefault(d => d.Ma_Danh_Muc == id);
                if (danhMuc != null)
                {
                    danhMuc.Ten_Danh_Muc = tenDanhMuc;
                    danhMuc.Loai_Thu_Chi = loaiThuChi;

                    try
                    {
                        db.SubmitChanges();
                        MessageBox.Show("Cập nhật danh mục thành công!");
                        loadData();
                        ClearForm();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ClearForm();

            // 🔁 Reset nút HUỶ về mặc định
            btnHuy.Text = "HUỶ";
            btnHuy.BackColor = SystemColors.Control;
            btnHuy.ForeColor = Color.Black;
            btnHuy.Font = new Font(btnHuy.Font, FontStyle.Regular);
            loadData();
        }

        private void rbThu_CheckedChanged(object sender, EventArgs e)
        {
            if (rbThu.Checked)
                loadData();
        }

        private void rbChi_CheckedChanged(object sender, EventArgs e)
        {
            if (rbChi.Checked)
                loadData();
        }
    }
}
