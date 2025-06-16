namespace LoginRegistrationForm.Forms
{
    partial class FormTaiKhoan
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
            this.labelTittleTen = new System.Windows.Forms.Label();
            this.labelTittleMk = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbHoTen = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbMkCu = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxMkMoi = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBoxNhapLaiMk = new System.Windows.Forms.TextBox();
            this.buttonDoiMk = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chk_ShowOldPass = new System.Windows.Forms.CheckBox();
            this.chk_ShowNewPass = new System.Windows.Forms.CheckBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTittleTen
            // 
            this.labelTittleTen.AutoSize = true;
            this.labelTittleTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTittleTen.Location = new System.Drawing.Point(267, 136);
            this.labelTittleTen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTittleTen.Name = "labelTittleTen";
            this.labelTittleTen.Size = new System.Drawing.Size(214, 26);
            this.labelTittleTen.TabIndex = 4;
            this.labelTittleTen.Text = "Cập nhật thông tin ";
            // 
            // labelTittleMk
            // 
            this.labelTittleMk.AutoSize = true;
            this.labelTittleMk.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTittleMk.Location = new System.Drawing.Point(268, 234);
            this.labelTittleMk.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTittleMk.Name = "labelTittleMk";
            this.labelTittleMk.Size = new System.Drawing.Size(214, 26);
            this.labelTittleMk.TabIndex = 6;
            this.labelTittleMk.Text = "Thay đổi mật khẩu ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbHoTen);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(102, 164);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(311, 55);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Họ và tên";
            // 
            // tbHoTen
            // 
            this.tbHoTen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHoTen.Location = new System.Drawing.Point(2, 18);
            this.tbHoTen.Multiline = true;
            this.tbHoTen.Name = "tbHoTen";
            this.tbHoTen.Size = new System.Drawing.Size(307, 35);
            this.tbHoTen.TabIndex = 5;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(472, 173);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 42);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "CẬP NHẬT";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbMkCu);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(102, 270);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(311, 55);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mật khẩu cũ";
            // 
            // tbMkCu
            // 
            this.tbMkCu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbMkCu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMkCu.Location = new System.Drawing.Point(2, 18);
            this.tbMkCu.Multiline = true;
            this.tbMkCu.Name = "tbMkCu";
            this.tbMkCu.PasswordChar = '*';
            this.tbMkCu.Size = new System.Drawing.Size(307, 35);
            this.tbMkCu.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxMkMoi);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(102, 330);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(311, 55);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mật khẩu mới";
            // 
            // textBoxMkMoi
            // 
            this.textBoxMkMoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxMkMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMkMoi.Location = new System.Drawing.Point(2, 18);
            this.textBoxMkMoi.Multiline = true;
            this.textBoxMkMoi.Name = "textBoxMkMoi";
            this.textBoxMkMoi.PasswordChar = '*';
            this.textBoxMkMoi.Size = new System.Drawing.Size(307, 35);
            this.textBoxMkMoi.TabIndex = 5;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBoxNhapLaiMk);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(102, 390);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(311, 55);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Nhập lại mật khẩu";
            // 
            // textBoxNhapLaiMk
            // 
            this.textBoxNhapLaiMk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxNhapLaiMk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNhapLaiMk.Location = new System.Drawing.Point(2, 18);
            this.textBoxNhapLaiMk.Multiline = true;
            this.textBoxNhapLaiMk.Name = "textBoxNhapLaiMk";
            this.textBoxNhapLaiMk.PasswordChar = '*';
            this.textBoxNhapLaiMk.Size = new System.Drawing.Size(307, 35);
            this.textBoxNhapLaiMk.TabIndex = 5;
            // 
            // buttonDoiMk
            // 
            this.buttonDoiMk.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDoiMk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonDoiMk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDoiMk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDoiMk.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDoiMk.ForeColor = System.Drawing.Color.Black;
            this.buttonDoiMk.Location = new System.Drawing.Point(448, 398);
            this.buttonDoiMk.Name = "buttonDoiMk";
            this.buttonDoiMk.Size = new System.Drawing.Size(100, 42);
            this.buttonDoiMk.TabIndex = 20;
            this.buttonDoiMk.Text = "ĐỔI MẬT KHẨU";
            this.buttonDoiMk.UseVisualStyleBackColor = false;
            this.buttonDoiMk.Click += new System.EventHandler(this.buttonDoiMk_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::LoginRegistrationForm.Properties.Resources._219983;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(293, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 113);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // chk_ShowOldPass
            // 
            this.chk_ShowOldPass.AutoSize = true;
            this.chk_ShowOldPass.Location = new System.Drawing.Point(453, 292);
            this.chk_ShowOldPass.Name = "chk_ShowOldPass";
            this.chk_ShowOldPass.Size = new System.Drawing.Size(95, 17);
            this.chk_ShowOldPass.TabIndex = 25;
            this.chk_ShowOldPass.Text = "Hiện mật khẩu";
            this.chk_ShowOldPass.UseVisualStyleBackColor = true;
            this.chk_ShowOldPass.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // chk_ShowNewPass
            // 
            this.chk_ShowNewPass.AutoSize = true;
            this.chk_ShowNewPass.Location = new System.Drawing.Point(453, 352);
            this.chk_ShowNewPass.Name = "chk_ShowNewPass";
            this.chk_ShowNewPass.Size = new System.Drawing.Size(95, 17);
            this.chk_ShowNewPass.TabIndex = 26;
            this.chk_ShowNewPass.Text = "Hiện mật khẩu";
            this.chk_ShowNewPass.UseVisualStyleBackColor = true;
            this.chk_ShowNewPass.CheckedChanged += new System.EventHandler(this.chk_ShowNewPass_CheckedChanged);
            // 
            // FormTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 455);
            this.Controls.Add(this.chk_ShowNewPass);
            this.Controls.Add(this.chk_ShowOldPass);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonDoiMk);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.labelTittleMk);
            this.Controls.Add(this.labelTittleTen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormTaiKhoan";
            this.Text = "FormTaiKhoan";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelTittleTen;
        private System.Windows.Forms.Label labelTittleMk;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbHoTen;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbMkCu;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxMkMoi;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBoxNhapLaiMk;
        private System.Windows.Forms.Button buttonDoiMk;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox chk_ShowOldPass;
        private System.Windows.Forms.CheckBox chk_ShowNewPass;
    }
}