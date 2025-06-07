using System.Drawing;

namespace LoginRegistrationForm.Forms
{
    partial class FormThemGiaoDich
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comboBoxChonVi = new System.Windows.Forms.ComboBox();
            this.buttonAddGiaoDich = new System.Windows.Forms.Button();
            this.groupLoaiDanhMuc = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxChonDanhMuc = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbSoTien = new System.Windows.Forms.TextBox();
            this.buttonSuaGiaoDich = new System.Windows.Forms.Button();
            this.buttonXoaDanhMuc = new System.Windows.Forms.Button();
            this.dgvGiaoDich = new System.Windows.Forms.DataGridView();
            this.gbLoaiDanhMuc = new System.Windows.Forms.GroupBox();
            this.rbChuaThanhToan = new System.Windows.Forms.RadioButton();
            this.rbThanhToan = new System.Windows.Forms.RadioButton();
            this.MaGiaoDich = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDanhMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupLoaiDanhMuc.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaoDich)).BeginInit();
            this.gbLoaiDanhMuc.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxChonVi
            // 
            this.comboBoxChonVi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxChonVi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxChonVi.FormattingEnabled = true;
            this.comboBoxChonVi.IntegralHeight = false;
            this.comboBoxChonVi.Location = new System.Drawing.Point(3, 23);
            this.comboBoxChonVi.Name = "comboBoxChonVi";
            this.comboBoxChonVi.Size = new System.Drawing.Size(369, 33);
            this.comboBoxChonVi.TabIndex = 9;
            // 
            // buttonAddGiaoDich
            // 
            this.buttonAddGiaoDich.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAddGiaoDich.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonAddGiaoDich.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddGiaoDich.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddGiaoDich.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddGiaoDich.ForeColor = System.Drawing.Color.Black;
            this.buttonAddGiaoDich.Location = new System.Drawing.Point(787, 13);
            this.buttonAddGiaoDich.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddGiaoDich.Name = "buttonAddGiaoDich";
            this.buttonAddGiaoDich.Size = new System.Drawing.Size(133, 43);
            this.buttonAddGiaoDich.TabIndex = 6;
            this.buttonAddGiaoDich.Text = "Thêm";
            this.buttonAddGiaoDich.UseVisualStyleBackColor = false;
            this.buttonAddGiaoDich.Click += new System.EventHandler(this.buttonAddGiaoDich_Click);
            // 
            // groupLoaiDanhMuc
            // 
            this.groupLoaiDanhMuc.Controls.Add(this.comboBoxChonVi);
            this.groupLoaiDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupLoaiDanhMuc.Location = new System.Drawing.Point(12, 12);
            this.groupLoaiDanhMuc.Name = "groupLoaiDanhMuc";
            this.groupLoaiDanhMuc.Size = new System.Drawing.Size(375, 68);
            this.groupLoaiDanhMuc.TabIndex = 11;
            this.groupLoaiDanhMuc.TabStop = false;
            this.groupLoaiDanhMuc.Text = "Chọn ví";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxChonDanhMuc);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(405, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 68);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn danh mục";
            // 
            // comboBoxChonDanhMuc
            // 
            this.comboBoxChonDanhMuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxChonDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxChonDanhMuc.FormattingEnabled = true;
            this.comboBoxChonDanhMuc.IntegralHeight = false;
            this.comboBoxChonDanhMuc.Location = new System.Drawing.Point(3, 23);
            this.comboBoxChonDanhMuc.Name = "comboBoxChonDanhMuc";
            this.comboBoxChonDanhMuc.Size = new System.Drawing.Size(369, 33);
            this.comboBoxChonDanhMuc.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbSoTien);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(375, 68);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Số tiền";
            // 
            // tbSoTien
            // 
            this.tbSoTien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSoTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSoTien.Location = new System.Drawing.Point(3, 23);
            this.tbSoTien.Margin = new System.Windows.Forms.Padding(4);
            this.tbSoTien.Multiline = true;
            this.tbSoTien.Name = "tbSoTien";
            this.tbSoTien.Size = new System.Drawing.Size(369, 42);
            this.tbSoTien.TabIndex = 5;
            // 
            // buttonSuaGiaoDich
            // 
            this.buttonSuaGiaoDich.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSuaGiaoDich.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonSuaGiaoDich.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSuaGiaoDich.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSuaGiaoDich.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSuaGiaoDich.ForeColor = System.Drawing.Color.Black;
            this.buttonSuaGiaoDich.Location = new System.Drawing.Point(787, 64);
            this.buttonSuaGiaoDich.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSuaGiaoDich.Name = "buttonSuaGiaoDich";
            this.buttonSuaGiaoDich.Size = new System.Drawing.Size(133, 43);
            this.buttonSuaGiaoDich.TabIndex = 6;
            this.buttonSuaGiaoDich.Text = "Sửa";
            this.buttonSuaGiaoDich.UseVisualStyleBackColor = false;
            this.buttonSuaGiaoDich.Click += new System.EventHandler(this.buttonSuaGiaoDich_Click);
            // 
            // buttonXoaDanhMuc
            // 
            this.buttonXoaDanhMuc.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonXoaDanhMuc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonXoaDanhMuc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonXoaDanhMuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonXoaDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXoaDanhMuc.ForeColor = System.Drawing.Color.Black;
            this.buttonXoaDanhMuc.Location = new System.Drawing.Point(787, 115);
            this.buttonXoaDanhMuc.Margin = new System.Windows.Forms.Padding(4);
            this.buttonXoaDanhMuc.Name = "buttonXoaDanhMuc";
            this.buttonXoaDanhMuc.Size = new System.Drawing.Size(133, 43);
            this.buttonXoaDanhMuc.TabIndex = 6;
            this.buttonXoaDanhMuc.Text = "Xoá";
            this.buttonXoaDanhMuc.UseVisualStyleBackColor = false;
            this.buttonXoaDanhMuc.Click += new System.EventHandler(this.buttonXoaDanhMuc_Click);
            // 
            // dgvGiaoDich
            // 
            this.dgvGiaoDich.BackgroundColor = System.Drawing.Color.White;
            this.dgvGiaoDich.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGiaoDich.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaGiaoDich,
            this.MaVi,
            this.MaDanhMuc,
            this.SoTien,
            this.TinhTrang,
            this.NgayTao});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGiaoDich.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvGiaoDich.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvGiaoDich.Location = new System.Drawing.Point(12, 165);
            this.dgvGiaoDich.Name = "dgvGiaoDich";
            this.dgvGiaoDich.ReadOnly = true;
            this.dgvGiaoDich.RowHeadersWidth = 51;
            this.dgvGiaoDich.RowTemplate.Height = 24;
            this.dgvGiaoDich.Size = new System.Drawing.Size(906, 383);
            this.dgvGiaoDich.TabIndex = 26;
            this.dgvGiaoDich.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGiaoDich_CellDoubleClick);
            // 
            // gbLoaiDanhMuc
            // 
            this.gbLoaiDanhMuc.Controls.Add(this.rbChuaThanhToan);
            this.gbLoaiDanhMuc.Controls.Add(this.rbThanhToan);
            this.gbLoaiDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLoaiDanhMuc.Location = new System.Drawing.Point(408, 99);
            this.gbLoaiDanhMuc.Name = "gbLoaiDanhMuc";
            this.gbLoaiDanhMuc.Size = new System.Drawing.Size(369, 56);
            this.gbLoaiDanhMuc.TabIndex = 27;
            this.gbLoaiDanhMuc.TabStop = false;
            this.gbLoaiDanhMuc.Text = "Tình trạng";
            // 
            // rbChuaThanhToan
            // 
            this.rbChuaThanhToan.AutoSize = true;
            this.rbChuaThanhToan.Location = new System.Drawing.Point(207, 26);
            this.rbChuaThanhToan.Name = "rbChuaThanhToan";
            this.rbChuaThanhToan.Size = new System.Drawing.Size(156, 24);
            this.rbChuaThanhToan.TabIndex = 26;
            this.rbChuaThanhToan.TabStop = true;
            this.rbChuaThanhToan.Text = "Chưa hoàn thành";
            this.rbChuaThanhToan.UseVisualStyleBackColor = true;
            // 
            // rbThanhToan
            // 
            this.rbThanhToan.AutoSize = true;
            this.rbThanhToan.Location = new System.Drawing.Point(6, 26);
            this.rbThanhToan.Name = "rbThanhToan";
            this.rbThanhToan.Size = new System.Drawing.Size(116, 24);
            this.rbThanhToan.TabIndex = 26;
            this.rbThanhToan.TabStop = true;
            this.rbThanhToan.Text = "Hoàn thành";
            this.rbThanhToan.UseVisualStyleBackColor = true;
            this.rbThanhToan.CheckedChanged += new System.EventHandler(this.rbThanhToan_CheckedChanged);
            // 
            // MaGiaoDich
            // 
            this.MaGiaoDich.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaGiaoDich.DataPropertyName = "MaGiaoDich";
            this.MaGiaoDich.HeaderText = "Mã giao dịch";
            this.MaGiaoDich.MinimumWidth = 6;
            this.MaGiaoDich.Name = "MaGiaoDich";
            this.MaGiaoDich.ReadOnly = true;
            // 
            // MaVi
            // 
            this.MaVi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaVi.DataPropertyName = "TenVi";
            this.MaVi.HeaderText = "Tên ví";
            this.MaVi.MinimumWidth = 6;
            this.MaVi.Name = "MaVi";
            this.MaVi.ReadOnly = true;
            // 
            // MaDanhMuc
            // 
            this.MaDanhMuc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaDanhMuc.DataPropertyName = "DanhMuc";
            this.MaDanhMuc.HeaderText = "Danh mục";
            this.MaDanhMuc.MinimumWidth = 6;
            this.MaDanhMuc.Name = "MaDanhMuc";
            this.MaDanhMuc.ReadOnly = true;
            // 
            // SoTien
            // 
            this.SoTien.DataPropertyName = "SoTien";
            this.SoTien.HeaderText = "Số tiền";
            this.SoTien.MinimumWidth = 6;
            this.SoTien.Name = "SoTien";
            this.SoTien.ReadOnly = true;
            this.SoTien.Width = 125;
            // 
            // TinhTrang
            // 
            this.TinhTrang.DataPropertyName = "TinhTrang";
            this.TinhTrang.HeaderText = "Tình trạng";
            this.TinhTrang.MinimumWidth = 6;
            this.TinhTrang.Name = "TinhTrang";
            this.TinhTrang.ReadOnly = true;
            this.TinhTrang.Width = 125;
            // 
            // NgayTao
            // 
            this.NgayTao.DataPropertyName = "NgayGiaoDich";
            this.NgayTao.HeaderText = "Ngày tạo";
            this.NgayTao.MinimumWidth = 6;
            this.NgayTao.Name = "NgayTao";
            this.NgayTao.ReadOnly = true;
            this.NgayTao.Width = 125;
            // 
            // FormThemGiaoDich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 560);
            this.Controls.Add(this.gbLoaiDanhMuc);
            this.Controls.Add(this.dgvGiaoDich);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupLoaiDanhMuc);
            this.Controls.Add(this.buttonXoaDanhMuc);
            this.Controls.Add(this.buttonSuaGiaoDich);
            this.Controls.Add(this.buttonAddGiaoDich);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormThemGiaoDich";
            this.Text = "FormThemGiaoDich";
            this.Load += new System.EventHandler(this.FormThemGiaoDich_Load);
            this.groupLoaiDanhMuc.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaoDich)).EndInit();
            this.gbLoaiDanhMuc.ResumeLayout(false);
            this.gbLoaiDanhMuc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxChonVi;
        private System.Windows.Forms.Button buttonAddGiaoDich;
        private System.Windows.Forms.GroupBox groupLoaiDanhMuc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxChonDanhMuc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbSoTien;
        private System.Windows.Forms.Button buttonSuaGiaoDich;
        private System.Windows.Forms.Button buttonXoaDanhMuc;
        private System.Windows.Forms.DataGridView dgvGiaoDich;
        private System.Windows.Forms.GroupBox gbLoaiDanhMuc;
        private System.Windows.Forms.RadioButton rbChuaThanhToan;
        private System.Windows.Forms.RadioButton rbThanhToan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGiaoDich;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaVi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDanhMuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTao;
    }
}