namespace LoginRegistrationForm.Forms
{
    partial class FormCapNhatViTien
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
            this.groupTenVi = new System.Windows.Forms.GroupBox();
            this.tbTenVi = new System.Windows.Forms.TextBox();
            this.groupSoDu = new System.Windows.Forms.GroupBox();
            this.tbSoDu = new System.Windows.Forms.TextBox();
            this.btnSuaVi = new System.Windows.Forms.Button();
            this.buttonXoaVi = new System.Windows.Forms.Button();
            this.dgvViTien = new System.Windows.Forms.DataGridView();
            this.MaVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupTenVi.SuspendLayout();
            this.groupSoDu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViTien)).BeginInit();
            this.SuspendLayout();
            // 
            // groupTenVi
            // 
            this.groupTenVi.Controls.Add(this.tbTenVi);
            this.groupTenVi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupTenVi.Location = new System.Drawing.Point(12, 12);
            this.groupTenVi.Name = "groupTenVi";
            this.groupTenVi.Size = new System.Drawing.Size(300, 68);
            this.groupTenVi.TabIndex = 11;
            this.groupTenVi.TabStop = false;
            this.groupTenVi.Text = "Tên ví";
            // 
            // tbTenVi
            // 
            this.tbTenVi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTenVi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenVi.Location = new System.Drawing.Point(3, 23);
            this.tbTenVi.Margin = new System.Windows.Forms.Padding(4);
            this.tbTenVi.Multiline = true;
            this.tbTenVi.Name = "tbTenVi";
            this.tbTenVi.Size = new System.Drawing.Size(294, 42);
            this.tbTenVi.TabIndex = 5;
            // 
            // groupSoDu
            // 
            this.groupSoDu.Controls.Add(this.tbSoDu);
            this.groupSoDu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupSoDu.Location = new System.Drawing.Point(318, 12);
            this.groupSoDu.Name = "groupSoDu";
            this.groupSoDu.Size = new System.Drawing.Size(300, 68);
            this.groupSoDu.TabIndex = 12;
            this.groupSoDu.TabStop = false;
            this.groupSoDu.Text = "Số dư";
            // 
            // tbSoDu
            // 
            this.tbSoDu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSoDu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSoDu.Location = new System.Drawing.Point(3, 23);
            this.tbSoDu.Margin = new System.Windows.Forms.Padding(4);
            this.tbSoDu.Multiline = true;
            this.tbSoDu.Name = "tbSoDu";
            this.tbSoDu.Size = new System.Drawing.Size(294, 42);
            this.tbSoDu.TabIndex = 5;
            // 
            // btnSuaVi
            // 
            this.btnSuaVi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSuaVi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSuaVi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuaVi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaVi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaVi.ForeColor = System.Drawing.Color.Black;
            this.btnSuaVi.Location = new System.Drawing.Point(623, 25);
            this.btnSuaVi.Margin = new System.Windows.Forms.Padding(4);
            this.btnSuaVi.Name = "btnSuaVi";
            this.btnSuaVi.Size = new System.Drawing.Size(145, 55);
            this.btnSuaVi.TabIndex = 24;
            this.btnSuaVi.Text = "SỬA";
            this.btnSuaVi.UseVisualStyleBackColor = false;
            this.btnSuaVi.Click += new System.EventHandler(this.btnSuaVi_Click);
            // 
            // buttonXoaVi
            // 
            this.buttonXoaVi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonXoaVi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonXoaVi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonXoaVi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonXoaVi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXoaVi.ForeColor = System.Drawing.Color.Black;
            this.buttonXoaVi.Location = new System.Drawing.Point(776, 25);
            this.buttonXoaVi.Margin = new System.Windows.Forms.Padding(4);
            this.buttonXoaVi.Name = "buttonXoaVi";
            this.buttonXoaVi.Size = new System.Drawing.Size(145, 55);
            this.buttonXoaVi.TabIndex = 24;
            this.buttonXoaVi.Text = "XOÁ";
            this.buttonXoaVi.UseVisualStyleBackColor = false;
            this.buttonXoaVi.Click += new System.EventHandler(this.buttonXoaVi_Click);
            // 
            // dgvViTien
            // 
            this.dgvViTien.BackgroundColor = System.Drawing.Color.White;
            this.dgvViTien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViTien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaVi,
            this.TenVi,
            this.SoDu});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvViTien.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvViTien.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvViTien.Location = new System.Drawing.Point(12, 87);
            this.dgvViTien.Name = "dgvViTien";
            this.dgvViTien.ReadOnly = true;
            this.dgvViTien.RowHeadersWidth = 51;
            this.dgvViTien.RowTemplate.Height = 24;
            this.dgvViTien.Size = new System.Drawing.Size(906, 461);
            this.dgvViTien.TabIndex = 26;
            this.dgvViTien.DoubleClick += new System.EventHandler(this.dgvViTien_DoubleClick);
            // 
            // MaVi
            // 
            this.MaVi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaVi.DataPropertyName = "Ma_Vi";
            this.MaVi.HeaderText = "Mã ví";
            this.MaVi.MinimumWidth = 6;
            this.MaVi.Name = "MaVi";
            this.MaVi.ReadOnly = true;
            // 
            // TenVi
            // 
            this.TenVi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenVi.DataPropertyName = "Ten_Vi";
            this.TenVi.HeaderText = "Tên ví";
            this.TenVi.MinimumWidth = 6;
            this.TenVi.Name = "TenVi";
            this.TenVi.ReadOnly = true;
            // 
            // SoDu
            // 
            this.SoDu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoDu.DataPropertyName = "So_Du";
            this.SoDu.HeaderText = "Số dư";
            this.SoDu.MinimumWidth = 6;
            this.SoDu.Name = "SoDu";
            this.SoDu.ReadOnly = true;
            // 
            // FormCapNhatViTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 560);
            this.Controls.Add(this.dgvViTien);
            this.Controls.Add(this.buttonXoaVi);
            this.Controls.Add(this.btnSuaVi);
            this.Controls.Add(this.groupSoDu);
            this.Controls.Add(this.groupTenVi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCapNhatViTien";
            this.Text = "FormCapNhatViTien";
            this.Load += new System.EventHandler(this.FormCapNhatViTien_Load);
            this.groupTenVi.ResumeLayout(false);
            this.groupTenVi.PerformLayout();
            this.groupSoDu.ResumeLayout(false);
            this.groupSoDu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViTien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupTenVi;
        private System.Windows.Forms.TextBox tbTenVi;
        private System.Windows.Forms.GroupBox groupSoDu;
        private System.Windows.Forms.TextBox tbSoDu;
        private System.Windows.Forms.Button btnSuaVi;
        private System.Windows.Forms.Button buttonXoaVi;
        private System.Windows.Forms.DataGridView dgvViTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaVi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenVi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDu;
    }
}