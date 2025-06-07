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
    public partial class FormCapNhatViTien : Form
    {
        DataClassesDBDataContext db = new DataClassesDBDataContext();
        int id = -1;

        public FormCapNhatViTien()
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormCapNhatViTien_Load(object sender, EventArgs e)
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

        private void btnSuaVi_Click(object sender, EventArgs e)
        {
            if (id == -1)
            {
                MessageBox.Show("Vui lòng chọn ví cần sửa.");
                return;
            }

            if (!decimal.TryParse(tbSoDu.Text, out decimal soDuMoi))
            {
                MessageBox.Show("Số dư không hợp lệ.");
                return;
            }

            using (var db = new DataClassesDBDataContext())
            {
                var vi = db.VI_TIENs.FirstOrDefault(v => v.Ma_Vi == id);
                if (vi != null)
                {
                    vi.Ten_Vi = tbTenVi.Text.Trim();
                    vi.So_Du = soDuMoi;
                    db.SubmitChanges();

                    MessageBox.Show("Cập nhật ví thành công!");
                    id = -1;
                    tbTenVi.Clear();
                    tbSoDu.Clear();
                    loadData();
                }
            }
        }

        private void buttonXoaVi_Click(object sender, EventArgs e)
        {
            if (id == -1)
            {
                MessageBox.Show("Vui lòng chọn ví cần xóa.");
                return;
            }

            var confirm = MessageBox.Show("Bạn có chắc muốn xóa ví này? (sẽ xóa luôn các giao dịch liên quan)", "Xác nhận", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                using (var db = new DataClassesDBDataContext())
                {
                    var vi = db.VI_TIENs.FirstOrDefault(v => v.Ma_Vi == id);
                    if (vi != null)
                    {
                        // Xóa các giao dịch liên quan nếu muốn
                        db.GIAO_DICHes.DeleteAllOnSubmit(vi.GIAO_DICHes);

                        db.VI_TIENs.DeleteOnSubmit(vi);
                        db.SubmitChanges();

                        MessageBox.Show("Đã xóa ví.");
                        id = -1;
                        loadData();
                    }
                }
            }
        }
    }
}
