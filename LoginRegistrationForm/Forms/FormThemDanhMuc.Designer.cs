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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comboBoxDM = new System.Windows.Forms.ComboBox();
            this.groupLoaiDanhMuc = new System.Windows.Forms.GroupBox();
            this.tbTenDanhMuc = new System.Windows.Forms.TextBox();
            this.btnAddDanhMuc = new System.Windows.Forms.Button();
            this.gbLoaiDanhMuc = new System.Windows.Forms.GroupBox();
            this.dgvDanhMuc = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.MaDanhMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDanhMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiDanhMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rbThu = new System.Windows.Forms.RadioButton();
            this.rbChi = new System.Windows.Forms.RadioButton();
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
            this.groupLoaiDanhMuc.Name = "groupLoaiDanhMuc";
            this.groupLoaiDanhMuc.Size = new System.Drawing.Size(545, 68);
            this.groupLoaiDanhMuc.TabIndex = 10;
            this.groupLoaiDanhMuc.TabStop = false;
            this.groupLoaiDanhMuc.Text = "Tên danh mục";
            // 
            // tbTenDanhMuc
            // 
            this.tbTenDanhMuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTenDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenDanhMuc.Location = new System.Drawing.Point(3, 23);
            this.tbTenDanhMuc.Margin = new System.Windows.Forms.Padding(4);
            this.tbTenDanhMuc.Multiline = true;
            this.tbTenDanhMuc.Name = "tbTenDanhMuc";
            this.tbTenDanhMuc.Size = new System.Drawing.Size(539, 42);
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
            this.btnAddDanhMuc.Location = new System.Drawing.Point(761, 12);
            this.btnAddDanhMuc.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddDanhMuc.Name = "btnAddDanhMuc";
            this.btnAddDanhMuc.Size = new System.Drawing.Size(160, 68);
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
            this.gbLoaiDanhMuc.Location = new System.Drawing.Point(568, 9);
            this.gbLoaiDanhMuc.Name = "gbLoaiDanhMuc";
            this.gbLoaiDanhMuc.Size = new System.Drawing.Size(181, 68);
            this.gbLoaiDanhMuc.TabIndex = 24;
            this.gbLoaiDanhMuc.TabStop = false;
            this.gbLoaiDanhMuc.Text = "Loại danh mục";
            // 
            // dgvDanhMuc
            // 
            this.dgvDanhMuc.BackgroundColor = System.Drawing.Color.White;
            this.dgvDanhMuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhMuc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDanhMuc,
            this.TenDanhMuc,
            this.LoaiDanhMuc});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDanhMuc.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDanhMuc.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvDanhMuc.Location = new System.Drawing.Point(15, 87);
            this.dgvDanhMuc.Name = "dgvDanhMuc";
            this.dgvDanhMuc.ReadOnly = true;
            this.dgvDanhMuc.RowHeadersWidth = 51;
            this.dgvDanhMuc.RowTemplate.Height = 24;
            this.dgvDanhMuc.Size = new System.Drawing.Size(906, 461);
            this.dgvDanhMuc.TabIndex = 25;
            this.dgvDanhMuc.DoubleClick += new System.EventHandler(this.dgvDanhMuc_DoubleClick);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
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
            // rbThu
            // 
            this.rbThu.AutoSize = true;
            this.rbThu.Location = new System.Drawing.Point(6, 38);
            this.rbThu.Name = "rbThu";
            this.rbThu.Size = new System.Drawing.Size(58, 24);
            this.rbThu.TabIndex = 26;
            this.rbThu.TabStop = true;
            this.rbThu.Text = "Thu";
            this.rbThu.UseVisualStyleBackColor = true;
            // 
            // rbChi
            // 
            this.rbChi.AutoSize = true;
            this.rbChi.Location = new System.Drawing.Point(117, 38);
            this.rbChi.Name = "rbChi";
            this.rbChi.Size = new System.Drawing.Size(55, 24);
            this.rbChi.TabIndex = 26;
            this.rbChi.TabStop = true;
            this.rbChi.Text = "Chi";
            this.rbChi.UseVisualStyleBackColor = true;
            // 
            // FormThemDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 560);
            this.Controls.Add(this.dgvDanhMuc);
            this.Controls.Add(this.gbLoaiDanhMuc);
            this.Controls.Add(this.btnAddDanhMuc);
            this.Controls.Add(this.groupLoaiDanhMuc);
            this.Controls.Add(this.comboBoxDM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
    }
}