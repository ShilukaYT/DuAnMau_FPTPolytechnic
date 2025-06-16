
namespace LoginRegistrationForm
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTitle = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTenApp = new System.Windows.Forms.Label();
            this.panelButton = new System.Windows.Forms.Panel();
            this.buttonDangXuat = new System.Windows.Forms.Button();
            this.buttonTaiKhoan = new System.Windows.Forms.Button();
            this.buttonThemGiaoDich = new System.Windows.Forms.Button();
            this.buttonCapNhatVi = new System.Windows.Forms.Button();
            this.buttonThemDanhMuc = new System.Windows.Forms.Button();
            this.buttonThongKe = new System.Windows.Forms.Button();
            this.panelTopButton = new System.Windows.Forms.Panel();
            this.panelMainContent = new System.Windows.Forms.Panel();
            this.pictureClose = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTitle.SuspendLayout();
            this.panelButton.SuspendLayout();
            this.panelTopButton.SuspendLayout();
            this.panelMainContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelTitle.Controls.Add(this.pictureClose);
            this.panelTitle.Controls.Add(this.label2);
            this.panelTitle.Controls.Add(this.labelTenApp);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Margin = new System.Windows.Forms.Padding(2);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(700, 65);
            this.panelTitle.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(757, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "x";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelTenApp
            // 
            this.labelTenApp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTenApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenApp.ForeColor = System.Drawing.Color.White;
            this.labelTenApp.Location = new System.Drawing.Point(0, 0);
            this.labelTenApp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTenApp.Name = "labelTenApp";
            this.labelTenApp.Size = new System.Drawing.Size(700, 65);
            this.labelTenApp.TabIndex = 1;
            this.labelTenApp.Text = "Ứng dụng quản lý chi tiêu cá nhân";
            this.labelTenApp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelButton
            // 
            this.panelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelButton.Controls.Add(this.buttonDangXuat);
            this.panelButton.Controls.Add(this.buttonTaiKhoan);
            this.panelButton.Controls.Add(this.buttonThemGiaoDich);
            this.panelButton.Controls.Add(this.buttonCapNhatVi);
            this.panelButton.Controls.Add(this.buttonThemDanhMuc);
            this.panelButton.Controls.Add(this.buttonThongKe);
            this.panelButton.Controls.Add(this.panelTopButton);
            this.panelButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelButton.Location = new System.Drawing.Point(0, 0);
            this.panelButton.Margin = new System.Windows.Forms.Padding(2);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(200, 521);
            this.panelButton.TabIndex = 1;
            // 
            // buttonDangXuat
            // 
            this.buttonDangXuat.BackColor = System.Drawing.Color.Red;
            this.buttonDangXuat.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDangXuat.FlatAppearance.BorderSize = 0;
            this.buttonDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDangXuat.ForeColor = System.Drawing.Color.White;
            this.buttonDangXuat.Location = new System.Drawing.Point(0, 390);
            this.buttonDangXuat.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDangXuat.Name = "buttonDangXuat";
            this.buttonDangXuat.Size = new System.Drawing.Size(200, 65);
            this.buttonDangXuat.TabIndex = 14;
            this.buttonDangXuat.Text = "Đăng xuất";
            this.buttonDangXuat.UseVisualStyleBackColor = false;
            this.buttonDangXuat.Click += new System.EventHandler(this.buttonDangXuat_Click);
            // 
            // buttonTaiKhoan
            // 
            this.buttonTaiKhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.buttonTaiKhoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonTaiKhoan.FlatAppearance.BorderSize = 0;
            this.buttonTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.buttonTaiKhoan.Location = new System.Drawing.Point(0, 325);
            this.buttonTaiKhoan.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTaiKhoan.Name = "buttonTaiKhoan";
            this.buttonTaiKhoan.Size = new System.Drawing.Size(200, 65);
            this.buttonTaiKhoan.TabIndex = 13;
            this.buttonTaiKhoan.Text = "Tài khoản";
            this.buttonTaiKhoan.UseVisualStyleBackColor = false;
            this.buttonTaiKhoan.Click += new System.EventHandler(this.buttonTaiKhoan_Click);
            // 
            // buttonThemGiaoDich
            // 
            this.buttonThemGiaoDich.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.buttonThemGiaoDich.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonThemGiaoDich.FlatAppearance.BorderSize = 0;
            this.buttonThemGiaoDich.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThemGiaoDich.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThemGiaoDich.ForeColor = System.Drawing.Color.White;
            this.buttonThemGiaoDich.Location = new System.Drawing.Point(0, 260);
            this.buttonThemGiaoDich.Margin = new System.Windows.Forms.Padding(2);
            this.buttonThemGiaoDich.Name = "buttonThemGiaoDich";
            this.buttonThemGiaoDich.Size = new System.Drawing.Size(200, 65);
            this.buttonThemGiaoDich.TabIndex = 11;
            this.buttonThemGiaoDich.Text = "Quản lí giao dịch";
            this.buttonThemGiaoDich.UseVisualStyleBackColor = false;
            this.buttonThemGiaoDich.Click += new System.EventHandler(this.buttonThemGiaoDich_Click);
            // 
            // buttonCapNhatVi
            // 
            this.buttonCapNhatVi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.buttonCapNhatVi.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCapNhatVi.FlatAppearance.BorderSize = 0;
            this.buttonCapNhatVi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCapNhatVi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCapNhatVi.ForeColor = System.Drawing.Color.White;
            this.buttonCapNhatVi.Location = new System.Drawing.Point(0, 195);
            this.buttonCapNhatVi.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCapNhatVi.Name = "buttonCapNhatVi";
            this.buttonCapNhatVi.Size = new System.Drawing.Size(200, 65);
            this.buttonCapNhatVi.TabIndex = 10;
            this.buttonCapNhatVi.Text = "Quản lí ví tiền";
            this.buttonCapNhatVi.UseVisualStyleBackColor = false;
            this.buttonCapNhatVi.Click += new System.EventHandler(this.buttonCapNhatVi_Click);
            // 
            // buttonThemDanhMuc
            // 
            this.buttonThemDanhMuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.buttonThemDanhMuc.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonThemDanhMuc.FlatAppearance.BorderSize = 0;
            this.buttonThemDanhMuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThemDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThemDanhMuc.ForeColor = System.Drawing.Color.White;
            this.buttonThemDanhMuc.Location = new System.Drawing.Point(0, 130);
            this.buttonThemDanhMuc.Margin = new System.Windows.Forms.Padding(2);
            this.buttonThemDanhMuc.Name = "buttonThemDanhMuc";
            this.buttonThemDanhMuc.Size = new System.Drawing.Size(200, 65);
            this.buttonThemDanhMuc.TabIndex = 9;
            this.buttonThemDanhMuc.Text = "Quản lí danh mục";
            this.buttonThemDanhMuc.UseVisualStyleBackColor = false;
            this.buttonThemDanhMuc.Click += new System.EventHandler(this.buttonThemDanhMuc_Click);
            // 
            // buttonThongKe
            // 
            this.buttonThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.buttonThongKe.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonThongKe.FlatAppearance.BorderSize = 0;
            this.buttonThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThongKe.ForeColor = System.Drawing.Color.White;
            this.buttonThongKe.Location = new System.Drawing.Point(0, 65);
            this.buttonThongKe.Margin = new System.Windows.Forms.Padding(2);
            this.buttonThongKe.Name = "buttonThongKe";
            this.buttonThongKe.Size = new System.Drawing.Size(200, 65);
            this.buttonThongKe.TabIndex = 8;
            this.buttonThongKe.Text = "Thống kê";
            this.buttonThongKe.UseVisualStyleBackColor = false;
            this.buttonThongKe.Click += new System.EventHandler(this.buttonThongKe_Click);
            // 
            // panelTopButton
            // 
            this.panelTopButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelTopButton.Controls.Add(this.pictureBox1);
            this.panelTopButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopButton.Location = new System.Drawing.Point(0, 0);
            this.panelTopButton.Name = "panelTopButton";
            this.panelTopButton.Size = new System.Drawing.Size(200, 65);
            this.panelTopButton.TabIndex = 0;
            // 
            // panelMainContent
            // 
            this.panelMainContent.Controls.Add(this.panelTitle);
            this.panelMainContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMainContent.Location = new System.Drawing.Point(200, 0);
            this.panelMainContent.Margin = new System.Windows.Forms.Padding(2);
            this.panelMainContent.Name = "panelMainContent";
            this.panelMainContent.Size = new System.Drawing.Size(700, 521);
            this.panelMainContent.TabIndex = 2;
            // 
            // pictureClose
            // 
            this.pictureClose.BackgroundImage = global::LoginRegistrationForm.Properties.Resources.close_x_svgrepo_com;
            this.pictureClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureClose.Location = new System.Drawing.Point(21, 0);
            this.pictureClose.Margin = new System.Windows.Forms.Padding(2);
            this.pictureClose.Name = "pictureClose";
            this.pictureClose.Size = new System.Drawing.Size(34, 65);
            this.pictureClose.TabIndex = 2;
            this.pictureClose.TabStop = false;
            this.pictureClose.Click += new System.EventHandler(this.pictureClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::LoginRegistrationForm.Properties.Resources.anh_mo_ta;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 64);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 521);
            this.Controls.Add(this.panelMainContent);
            this.Controls.Add(this.panelButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panelButton.ResumeLayout(false);
            this.panelTopButton.ResumeLayout(false);
            this.panelMainContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelMainContent;
        private System.Windows.Forms.Panel panelTopButton;
        private System.Windows.Forms.Button buttonDangXuat;
        private System.Windows.Forms.Button buttonTaiKhoan;
        private System.Windows.Forms.Button buttonThemGiaoDich;
        private System.Windows.Forms.Button buttonCapNhatVi;
        private System.Windows.Forms.Button buttonThemDanhMuc;
        private System.Windows.Forms.Button buttonThongKe;
        private System.Windows.Forms.Label labelTenApp;
        private System.Windows.Forms.PictureBox pictureClose;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}