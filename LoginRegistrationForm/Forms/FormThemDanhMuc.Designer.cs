namespace LoginRegistrationForm.Forms
{
    partial class FormThemDanhMuc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comboBoxDM = new System.Windows.Forms.ComboBox();
            this.groupLoaiDanhMuc = new System.Windows.Forms.GroupBox();
            this.tbTenDanhMuc = new System.Windows.Forms.TextBox();
            this.btnAddDanhMuc = new System.Windows.Forms.Button();
            this.gbLoaiDanhMuc = new System.Windows.Forms.GroupBox();
            this.rbChi = new System.Windows.Forms.RadioButton();
            this.rbThu = new System.Windows.Forms.RadioButton();
            this.dgvDanhMuc = new System.Windows.Forms.DataGridView();
            this.MaDanhMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDanhMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiDanhMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnSuaDanhMuc = new System.Windows.Forms.Button();
            this.btnXoaDanhMuc = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.groupLoaiDanhMuc.SuspendLayout();
            this.gbLoaiDanhMuc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMuc)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxDM
            // 
            this.comboBoxDM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDM.FormattingEnabled = true;
            this.comboBoxDM.Items.AddRange(new object[] {
            "Thu",
            "Chi"});
            this.comboBoxDM.Location = new System.Drawing.Point(169, 52);
            this.comboBoxDM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxDM.Name = "comboBoxDM";
            this.comboBoxDM.Size = new System.Drawing.Size(0, 28);
            this.comboBoxDM.TabIndex = 6;
            this.comboBoxDM.Text = "Thu";
            // 
            // groupLoaiDanhMuc
            // 
            this.groupLoaiDanhMuc.Controls.Add(this.tbTenDanhMuc);
            this.groupLoaiDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupLoaiDanhMuc.Location = new System.Drawing.Point(12, 12);
            this.groupLoaiDanhMuc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupLoaiDanhMuc.Name = "groupLoaiDanhMuc";
            this.groupLoaiDanhMuc.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupLoaiDanhMuc.Size = new System.Drawing.Size(380, 68);
            this.groupLoaiDanhMuc.TabIndex = 10;
            this.groupLoaiDanhMuc.TabStop = false;
            this.groupLoaiDanhMuc.Text = "Tên danh mục";
            // 
            // tbTenDanhMuc
            // 
            this.tbTenDanhMuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTenDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenDanhMuc.Location = new System.Drawing.Point(3, 22);
            this.tbTenDanhMuc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbTenDanhMuc.Multiline = true;
            this.tbTenDanhMuc.Name = "tbTenDanhMuc";
            this.tbTenDanhMuc.Size = new System.Drawing.Size(374, 44);
            this.tbTenDanhMuc.TabIndex = 5;
            // 
            // btnAddDanhMuc
            // 
            this.btnAddDanhMuc.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddDanhMuc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddDanhMuc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddDanhMuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDanhMuc.ForeColor = System.Drawing.Color.Black;
            this.btnAddDanhMuc.Location = new System.Drawing.Point(559, 17);
            this.btnAddDanhMuc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddDanhMuc.Name = "btnAddDanhMuc";
            this.btnAddDanhMuc.Size = new System.Drawing.Size(80, 57);
            this.btnAddDanhMuc.TabIndex = 23;
            this.btnAddDanhMuc.Text = "THÊM";
            this.btnAddDanhMuc.UseVisualStyleBackColor = false;
            this.btnAddDanhMuc.Click += new System.EventHandler(this.btnAddDanhMuc_Click);
            // 
            // gbLoaiDanhMuc
            // 
            this.gbLoaiDanhMuc.Controls.Add(this.rbChi);
            this.gbLoaiDanhMuc.Controls.Add(this.rbThu);
            this.gbLoaiDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLoaiDanhMuc.Location = new System.Drawing.Point(397, 10);
            this.gbLoaiDanhMuc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbLoaiDanhMuc.Name = "gbLoaiDanhMuc";
            this.gbLoaiDanhMuc.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbLoaiDanhMuc.Size = new System.Drawing.Size(155, 68);
            this.gbLoaiDanhMuc.TabIndex = 24;
            this.gbLoaiDanhMuc.TabStop = false;
            this.gbLoaiDanhMuc.Text = "Loại danh mục";
            // 
            // rbChi
            // 
            this.rbChi.AutoSize = true;
            this.rbChi.Location = new System.Drawing.Point(79, 38);
            this.rbChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbChi.Name = "rbChi";
            this.rbChi.Size = new System.Drawing.Size(55, 24);
            this.rbChi.TabIndex = 26;
            this.rbChi.TabStop = true;
            this.rbChi.Text = "Chi";
            this.rbChi.UseVisualStyleBackColor = true;
            this.rbChi.CheckedChanged += new System.EventHandler(this.rbChi_CheckedChanged);
            // 
            // rbThu
            // 
            this.rbThu.AutoSize = true;
            this.rbThu.Location = new System.Drawing.Point(5, 38);
            this.rbThu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbThu.Name = "rbThu";
            this.rbThu.Size = new System.Drawing.Size(58, 24);
            this.rbThu.TabIndex = 26;
            this.rbThu.TabStop = true;
            this.rbThu.Text = "Thu";
            this.rbThu.UseVisualStyleBackColor = true;
            this.rbThu.CheckedChanged += new System.EventHandler(this.rbThu_CheckedChanged);
            // 
            // dgvDanhMuc
            // 
            this.dgvDanhMuc.BackgroundColor = System.Drawing.Color.White;
            this.dgvDanhMuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhMuc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDanhMuc,
            this.TenDanhMuc,
            this.LoaiDanhMuc});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDanhMuc.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDanhMuc.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvDanhMuc.Location = new System.Drawing.Point(15, 84);
            this.dgvDanhMuc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDanhMuc.Name = "dgvDanhMuc";
            this.dgvDanhMuc.ReadOnly = true;
            this.dgvDanhMuc.RowHeadersWidth = 51;
            this.dgvDanhMuc.RowTemplate.Height = 24;
            this.dgvDanhMuc.Size = new System.Drawing.Size(907, 462);
            this.dgvDanhMuc.TabIndex = 25;
            this.dgvDanhMuc.DoubleClick += new System.EventHandler(this.dgvDanhMuc_DoubleClick);
            // 
            // MaDanhMuc
            // 
            this.MaDanhMuc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaDanhMuc.DataPropertyName = "Ma_Danh_Muc";
            this.MaDanhMuc.HeaderText = "Mã danh mục";
            this.MaDanhMuc.MinimumWidth = 6;
            this.MaDanhMuc.Name = "MaDanhMuc";
            this.MaDanhMuc.ReadOnly = true;
            // 
            // TenDanhMuc
            // 
            this.TenDanhMuc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenDanhMuc.DataPropertyName = "Ten_Danh_Muc";
            this.TenDanhMuc.HeaderText = "Tên danh mục";
            this.TenDanhMuc.MinimumWidth = 6;
            this.TenDanhMuc.Name = "TenDanhMuc";
            this.TenDanhMuc.ReadOnly = true;
            // 
            // LoaiDanhMuc
            // 
            this.LoaiDanhMuc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LoaiDanhMuc.DataPropertyName = "Loai_Thu_chi";
            this.LoaiDanhMuc.HeaderText = "Loại danh mục";
            this.LoaiDanhMuc.MinimumWidth = 6;
            this.LoaiDanhMuc.Name = "LoaiDanhMuc";
            this.LoaiDanhMuc.ReadOnly = true;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // btnSuaDanhMuc
            // 
            this.btnSuaDanhMuc.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSuaDanhMuc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSuaDanhMuc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuaDanhMuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaDanhMuc.ForeColor = System.Drawing.Color.Black;
            this.btnSuaDanhMuc.Location = new System.Drawing.Point(647, 17);
            this.btnSuaDanhMuc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSuaDanhMuc.Name = "btnSuaDanhMuc";
            this.btnSuaDanhMuc.Size = new System.Drawing.Size(80, 57);
            this.btnSuaDanhMuc.TabIndex = 26;
            this.btnSuaDanhMuc.Text = "SỬA";
            this.btnSuaDanhMuc.UseVisualStyleBackColor = false;
            this.btnSuaDanhMuc.Click += new System.EventHandler(this.btnSuaDanhMuc_Click);
            // 
            // btnXoaDanhMuc
            // 
            this.btnXoaDanhMuc.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnXoaDanhMuc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnXoaDanhMuc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaDanhMuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaDanhMuc.ForeColor = System.Drawing.Color.Black;
            this.btnXoaDanhMuc.Location = new System.Drawing.Point(735, 17);
            this.btnXoaDanhMuc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoaDanhMuc.Name = "btnXoaDanhMuc";
            this.btnXoaDanhMuc.Size = new System.Drawing.Size(80, 57);
            this.btnXoaDanhMuc.TabIndex = 27;
            this.btnXoaDanhMuc.Text = "XÓA";
            this.btnXoaDanhMuc.UseVisualStyleBackColor = false;
            this.btnXoaDanhMuc.Click += new System.EventHandler(this.btnXoaDanhMuc_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.Black;
            this.btnHuy.Location = new System.Drawing.Point(823, 17);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(99, 57);
            this.btnHuy.TabIndex = 28;
            this.btnHuy.Text = "HỦY";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // FormThemDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 560);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnXoaDanhMuc);
            this.Controls.Add(this.btnSuaDanhMuc);
            this.Controls.Add(this.dgvDanhMuc);
            this.Controls.Add(this.gbLoaiDanhMuc);
            this.Controls.Add(this.btnAddDanhMuc);
            this.Controls.Add(this.groupLoaiDanhMuc);
            this.Controls.Add(this.comboBoxDM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormThemDanhMuc";
            this.Text = "FormThemDanhMuc";
            this.Load += new System.EventHandler(this.FormThemDanhMuc_Load);
            this.groupLoaiDanhMuc.ResumeLayout(false);
            this.groupLoaiDanhMuc.PerformLayout();
            this.gbLoaiDanhMuc.ResumeLayout(false);
            this.gbLoaiDanhMuc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMuc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxDM;
        private System.Windows.Forms.GroupBox groupLoaiDanhMuc;
        private System.Windows.Forms.TextBox tbTenDanhMuc;
        private System.Windows.Forms.Button btnAddDanhMuc;
        private System.Windows.Forms.GroupBox gbLoaiDanhMuc;
        private System.Windows.Forms.DataGridView dgvDanhMuc;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDanhMuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDanhMuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiDanhMuc;
        private System.Windows.Forms.RadioButton rbChi;
        private System.Windows.Forms.RadioButton rbThu;
        private System.Windows.Forms.Button btnSuaDanhMuc;
        private System.Windows.Forms.Button btnXoaDanhMuc;
        private System.Windows.Forms.Button btnHuy;
    }
}