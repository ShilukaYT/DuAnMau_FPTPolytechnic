using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginRegistrationForm
{
    public partial class MainForm : Form
    {

        private Button currentButton;
        private Form activeForm;
        private Random random;
        private int tempIndex;

        public MainForm()
        {
            InitializeComponent();
            random = new Random();
            pictureClose.Visible = false;
        }

        List<string> listColor = new List<string>() { "#CC0000", "#54FF9F",
        "#00F5FF", "#FF4500","#E066FF","#FFE4E1"};
        List<string> listColorTop = new List<string>() { "#880000", "#43CD80",
        "#00C5CD", "#CD3700","#B452CD","#CDB7B5"};
        
        private List<String> SelectTColor()
        {
            List<string> list = new List<string>();
            int index = random.Next(0, listColor.Count);
            while (tempIndex == index)
            {
                index = random.Next(0, listColor.Count);
            }
            tempIndex = index;
            string color = listColor[index];
            string colorTop = listColorTop[index];
            list.Add(color);
            list.Add(colorTop);
            return list;
        }

        private void ActiveButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender )
                {
                    DisableButton();
                    List<String> color = SelectTColor();
                    String color1 = color[0];
                    String color2 = color[1];
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = ColorTranslator.FromHtml(color1);
                    panelTitle.BackColor = ColorTranslator.FromHtml(color1);
                    panelTopButton.BackColor = ColorTranslator.FromHtml(color2);
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    pictureClose.Visible = true;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelButton.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51,51,76);
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();             
            } 
            ActiveButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelMainContent.Controls.Add(childForm);
            this.panelMainContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonThongKe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormThongKe(), sender);
            labelTenApp.Text = "Thống Kê";
            labelTenApp.Anchor = System.Windows.Forms.AnchorStyles.None;

        }

        private void buttonThemDanhMuc_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormThemDanhMuc(), sender);
            labelTenApp.Text = "Thêm Danh Mục";
            labelTenApp.Anchor = System.Windows.Forms.AnchorStyles.None;

        }

        private void buttonCapNhatVi_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormCapNhatViTien(), sender);
            labelTenApp.Text = "Cập Nhật Ví";
            labelTenApp.Anchor = System.Windows.Forms.AnchorStyles.None;

        }

        private void buttonThemGiaoDich_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormThemGiaoDich(), sender);
            labelTenApp.Text = "Thêm Giao Dịch";
            labelTenApp.Anchor = System.Windows.Forms.AnchorStyles.None;

        }


        private void buttonTaiKhoan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormTaiKhoan(), sender);
            labelTenApp.Text = "Tài Khoản";
            labelTenApp.Anchor = System.Windows.Forms.AnchorStyles.None;

        }

        private void buttonDangXuat_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }

        private void pictureClose_Click(object sender, EventArgs e)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            Reset();
        }
        private void Reset()
        {
            DisableButton();
            labelTenApp.Text = "Ứng dụng quản lý chi tiêu cá nhân";
            panelTopButton.BackColor = Color.FromArgb(39,39,58);
            panelTitle.BackColor = Color.FromArgb(51, 51, 76);
            currentButton = null;
            pictureClose.Visible = false;
        }
    }
}
