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
        DataClassesDBDataContext db = new DataClassesDBDataContext();
        int id = 0;
        void loadData()
        {
            int maNguoiDung = Session.MaTaiKhoan;
            dgvDanhMuc.AutoGenerateColumns = false;
            var dataGridView = from s in db.DANH_MUCs where s.Ma_Tai_Khoan == maNguoiDung select s;
            dgvDanhMuc.DataSource = dataGridView.ToList<DANH_MUC>();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

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
        private void dgvDanhMuc_DoubleClick(object sender, EventArgs e)
        {
            if (dgvDanhMuc.CurrentRow.Index != -1)
            {
                id = Convert.ToInt32(dgvDanhMuc.CurrentRow.Cells[0].Value);
                getDataByID();
                                              
            }
        }
    }
}
