using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace LoginRegistrationForm
{
    public partial class Signup : Form
    {
        DataClassesDBDataContext db = new DataClassesDBDataContext();
        public Signup()
        {
            InitializeComponent();
        }

        private void signup_loginHere_Click(object sender, EventArgs e)
        {
            Form1 lForm = new Form1();
            lForm.Show();
            this.Hide();
        }

        private void signup_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
                        // Lấy dữ liệu từ TextBox
            string tenDangNhap = txtTenDangNhap.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();
            string nhapLaiMatKhau = txtNhapLaiMatKhau.Text.Trim();
            string hoTen = txtHoTen.Text.Trim();
            string maXacNhan = txtMaXacNhan.Text.Trim();

            // Kiểm tra rỗng
            if (string.IsNullOrEmpty(tenDangNhap) ||
                string.IsNullOrEmpty(matKhau) ||
                string.IsNullOrEmpty(nhapLaiMatKhau) ||
                string.IsNullOrEmpty(hoTen) ||
                string.IsNullOrEmpty(maXacNhan))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                return;
            }

            // Kiểm tra mật khẩu nhập lại
            if (matKhau != nhapLaiMatKhau)
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp!");
                return;
            }

            // Kiểm tra tên đăng nhập trùng
            bool tonTai = db.TAI_KHOANs.Any(t => t.Ten_Dang_Nhap == tenDangNhap);
            if (tonTai)
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại!");
                return;
            }

            try
            {
                // Tạo tài khoản mới
                TAI_KHOAN tk = new TAI_KHOAN
                {                   
                    Ten_Dang_Nhap = tenDangNhap,
                    Mat_Khau = matKhau, 
                    Ho_Ten = hoTen,
                    Ngay_Tao = DateTime.Now,
                    Trang_Thai = false, 
                    Ma_Xac_Nhan = maXacNhan
                };

                db.TAI_KHOANs.InsertOnSubmit(tk);
                db.SubmitChanges();

                MessageBox.Show("Thêm tài khoản thành công!");
                Form1 lForm = new Form1();
                lForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        }
    }
