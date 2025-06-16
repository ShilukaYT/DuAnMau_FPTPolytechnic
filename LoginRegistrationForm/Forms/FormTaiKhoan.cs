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
    public partial class FormTaiKhoan : Form
    {
        public FormTaiKhoan()
        {
            InitializeComponent();
            LoadThongTinNguoiDung();
        }
        private void LoadThongTinNguoiDung()
        {
            using (var db = new DataClassesDBDataContext())
            {
                var taiKhoan = db.TAI_KHOANs.FirstOrDefault(tk => tk.Ma_Tai_Khoan == Session.MaTaiKhoan);
                if (taiKhoan != null)
                {
                    tbHoTen.Text = taiKhoan.Ho_Ten;
                }
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string hoTen = tbHoTen.Text.Trim();

            if (string.IsNullOrEmpty(hoTen))
            {
                MessageBox.Show("Vui lòng nhập họ và tên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var db = new DataClassesDBDataContext())
            {
                var taiKhoan = db.TAI_KHOANs.FirstOrDefault(tk => tk.Ma_Tai_Khoan == Session.MaTaiKhoan);
                if (taiKhoan != null)
                {
                    taiKhoan.Ho_Ten = hoTen;
                    db.SubmitChanges();

                    MessageBox.Show("Cập nhật họ tên thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void buttonDoiMk_Click(object sender, EventArgs e)
        {
            string mkCu = tbMkCu.Text;
            string mkMoi = textBoxMkMoi.Text;
            string mkNhapLai = textBoxNhapLaiMk.Text;

            if (string.IsNullOrWhiteSpace(mkCu) || string.IsNullOrWhiteSpace(mkMoi) || string.IsNullOrWhiteSpace(mkNhapLai))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (mkMoi != mkNhapLai)
            {
                MessageBox.Show("Mật khẩu mới không khớp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var db = new DataClassesDBDataContext())
            {
                var taiKhoan = db.TAI_KHOANs.FirstOrDefault(tk => tk.Ma_Tai_Khoan == Session.MaTaiKhoan);
                if (taiKhoan != null)
                {
                    if (taiKhoan.Mat_Khau != mkCu)
                    {
                        MessageBox.Show("Mật khẩu cũ không đúng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    taiKhoan.Mat_Khau = mkMoi;
                    db.SubmitChanges();

                    MessageBox.Show("Đổi mật khẩu thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Xoá dữ liệu
                    tbMkCu.Clear();
                    textBoxMkMoi.Clear();
                    textBoxNhapLaiMk.Clear();
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_ShowOldPass.Checked)
            {
                tbMkCu.UseSystemPasswordChar = true;
            }
            else
            {
                tbMkCu.UseSystemPasswordChar = false;
            }
        }

        private void chk_ShowNewPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_ShowNewPass.Checked)
            {
                textBoxMkMoi.UseSystemPasswordChar = true;
                textBoxNhapLaiMk.UseSystemPasswordChar = true;
            }
            else
            {
                textBoxMkMoi.UseSystemPasswordChar = false;
                textBoxNhapLaiMk.UseSystemPasswordChar = false;
            }
        }
    }
}
