using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginRegistrationForm.Forms
{
    public partial class FormTaoViTien : Form
    {

        DataClassesDBDataContext db = new DataClassesDBDataContext();
        int id = 0;

        public FormTaoViTien()
        {
            InitializeComponent();
        }

        void loadData()
        {
            int maNguoiDung = Session.MaTaiKhoan;
            dgvViTien.AutoGenerateColumns = false;
            var dataGridView = from s in db.VI_TIENs where s.Ma_Tai_Khoan == maNguoiDung select s;
            dgvViTien.DataSource = dataGridView.ToList<VI_TIEN>();
        }

        void getDataByID()
        {
            var viTien = db.VI_TIENs.FirstOrDefault(k => k.Ma_Vi == id);
            if (viTien != null)
            {
                tbTenVi.Text = viTien.Ten_Vi;
                tbSoDu.Text = viTien.So_Du.ToString();
            }

        }

        private void FormTaoViTien_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void dgvViTien_DoubleClick(object sender, EventArgs e)
        {
            if (dgvViTien.CurrentRow.Index != -1)
            {
                id = Convert.ToInt32(dgvViTien.CurrentRow.Cells[0].Value);
                getDataByID();

            }
        }

        private void button_TaoVi_Click(object sender, EventArgs e)
        {
            int maNguoiDung = Session.MaTaiKhoan;
            string tenVi = tbTenVi.Text.Trim();

            bool tonTai = db.VI_TIENs.Any(t => t.Ten_Vi == tenVi);
            if (tonTai)
            {
                MessageBox.Show("Tên ví đã tồn tại!");
                return;
            }
            if (!int.TryParse(tbSoDu.Text, out int soDu))
            {
                MessageBox.Show("Vui lòng nhập số dư là một số nguyên.");
                return;
            }

            if (string.IsNullOrEmpty(tenVi) || soDu == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            using (var db = new DataClassesDBDataContext())
            {
                    VI_TIEN vitien = new VI_TIEN
                {
                    Ten_Vi = tenVi,
                    So_Du = soDu,
                    Ma_Tai_Khoan = maNguoiDung,
                };

                db.VI_TIENs.InsertOnSubmit(vitien);
                db.SubmitChanges();

                MessageBox.Show("Thêm ví tiền thành công!");
                tbSoDu.Clear();
                tbTenVi.Clear();
                loadData();
            }
        }
    }
}
