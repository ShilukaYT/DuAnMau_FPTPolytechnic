using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LoginRegistrationForm
{
    public partial class Form1 : Form
    {
        DataClassesDBDataContext db = new DataClassesDBDataContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void login_registerHere_Click(object sender, EventArgs e)
        {
            Signup sForm = new Signup();
            sForm.Show();
            this.Hide();
        }

        private void closeLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtTenDangNhap.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();

            // Kiểm tra thông tin đăng nhập
            var nguoiDung = db.TAI_KHOANs
                              .FirstOrDefault(t => t.Ten_Dang_Nhap == tenDangNhap && t.Mat_Khau == matKhau);

            if (nguoiDung != null)
            {
                // Đăng nhập thành công - lưu vào Session
                Session.MaTaiKhoan = nguoiDung.Ma_Tai_Khoan;
                Session.TenDangNhap = nguoiDung.Ten_Dang_Nhap;
                Session.HoTen = nguoiDung.Ho_Ten;

                // Chuyển sang form chính
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                if (tenDangNhap == string.Empty && matKhau == string.Empty)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                }
                else if (tenDangNhap == string.Empty)
                {
                    MessageBox.Show("Vui lòng nhập tên đăng nhập!");
                }
                else if (db.TAI_KHOANs.Any(t => t.Ten_Dang_Nhap == tenDangNhap) == false)
                    {
                        MessageBox.Show("Tên đăng nhập không đúng!");
                    }

                else if (matKhau == string.Empty)
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu!");
                }
                else if (db.TAI_KHOANs.Any(t => t.Mat_Khau == matKhau) == false)
                {
                    MessageBox.Show("Mật khẩu không đúng!");
                }
                {
                     
                }

            }
        }

        private void login_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void login_close_Click(object sender, EventArgs e)
        {

        }

    }
}
