namespace LoginRegistrationForm.Forms
{
    partial class FormTaoViTien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button_TaoVi = new System.Windows.Forms.Button();
            this.groupBoxTenVi = new System.Windows.Forms.GroupBox();
            this.tbTenVi = new System.Windows.Forms.TextBox();
            this.groupBoxSoDu = new System.Windows.Forms.GroupBox();
            this.tbSoDu = new System.Windows.Forms.TextBox();
            this.dgvViTien = new System.Windows.Forms.DataGridView();
            this.MaVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxTenVi.SuspendLayout();
            this.groupBoxSoDu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViTien)).BeginInit();
            this.SuspendLayout();
            // 
            // button_TaoVi
            // 
            this.button_TaoVi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_TaoVi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_TaoVi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_TaoVi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_TaoVi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_TaoVi.ForeColor = System.Drawing.Color.Black;
            this.button_TaoVi.Location = new System.Drawing.Point(778, 19);
            this.button_TaoVi.Margin = new System.Windows.Forms.Padding(4);
            this.button_TaoVi.Name = "button_TaoVi";
            this.button_TaoVi.Size = new System.Drawing.Size(142, 54);
            this.button_TaoVi.TabIndex = 16;
            this.button_TaoVi.Text = "Tạo";
            this.button_TaoVi.UseVisualStyleBackColor = false;
            this.button_TaoVi.Click += new System.EventHandler(this.button_TaoVi_Click);
            // 
            // groupBoxTenVi
            // 
            this.groupBoxTenVi.Controls.Add(this.tbTenVi);
            this.groupBoxTenVi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTenVi.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTenVi.Name = "groupBoxTenVi";
            this.groupBoxTenVi.Size = new System.Drawing.Size(370, 68);
            this.groupBoxTenVi.TabIndex = 17;
            this.groupBoxTenVi.TabStop = false;
            this.groupBoxTenVi.Text = "Tên ví";
            // 
            // tbTenVi
            // 
            this.tbTenVi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTenVi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenVi.Location = new System.Drawing.Point(3, 23);
            this.tbTenVi.Margin = new System.Windows.Forms.Padding(4);
            this.tbTenVi.Multiline = true;
            this.tbTenVi.Name = "tbTenVi";
            this.tbTenVi.Size = new System.Drawing.Size(364, 42);
            this.tbTenVi.TabIndex = 5;
            // 
            // groupBoxSoDu
            // 
            this.groupBoxSoDu.Controls.Add(this.tbSoDu);
            this.groupBoxSoDu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSoDu.Location = new System.Drawing.Point(401, 12);
            this.groupBoxSoDu.Name = "groupBoxSoDu";
            this.groupBoxSoDu.Size = new System.Drawing.Size(370, 68);
            this.groupBoxSoDu.TabIndex = 18;
            this.groupBoxSoDu.TabStop = false;
            this.groupBoxSoDu.Text = "Số dư";
            // 
            // tbSoDu
            // 
            this.tbSoDu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSoDu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSoDu.Location = new System.Drawing.Point(3, 23);
            this.tbSoDu.Margin = new System.Windows.Forms.Padding(4);
            this.tbSoDu.Multiline = true;
            this.tbSoDu.Name = "tbSoDu";
            this.tbSoDu.Size = new System.Drawing.Size(364, 42);
            this.tbSoDu.TabIndex = 5;
            // 
            // dgvViTien
            // 
            this.dgvViTien.BackgroundColor = System.Drawing.Color.White;
            this.dgvViTien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViTien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaVi,
            this.TenVi,
            this.SoDu});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvViTien.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvViTien.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvViTien.Location = new System.Drawing.Point(12, 87);
            this.dgvViTien.Name = "dgvViTien";
            this.dgvViTien.ReadOnly = true;
            this.dgvViTien.RowHeadersWidth = 51;
            this.dgvViTien.RowTemplate.Height = 24;
            this.dgvViTien.Size = new System.Drawing.Size(906, 461);
            this.dgvViTien.TabIndex = 27;
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
            // FormTaoViTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 560);
            this.Controls.Add(this.dgvViTien);
            this.Controls.Add(this.groupBoxSoDu);
            this.Controls.Add(this.groupBoxTenVi);
            this.Controls.Add(this.button_TaoVi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTaoViTien";
            this.Text = "FormTaoViTien";
            this.Load += new System.EventHandler(this.FormTaoViTien_Load);
            this.groupBoxTenVi.ResumeLayout(false);
            this.groupBoxTenVi.PerformLayout();
            this.groupBoxSoDu.ResumeLayout(false);
            this.groupBoxSoDu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViTien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_TaoVi;
        private System.Windows.Forms.GroupBox groupBoxTenVi;
        private System.Windows.Forms.TextBox tbTenVi;
        private System.Windows.Forms.GroupBox groupBoxSoDu;
        private System.Windows.Forms.TextBox tbSoDu;
        private System.Windows.Forms.DataGridView dgvViTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaVi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenVi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDu;
    }
}