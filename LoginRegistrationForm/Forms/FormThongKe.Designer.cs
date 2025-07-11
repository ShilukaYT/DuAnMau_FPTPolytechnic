﻿namespace LoginRegistrationForm.Forms
{
    partial class FormThongKe
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dtpNgayCuoi = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayDau = new System.Windows.Forms.DateTimePicker();
            this.chartBieuDo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelThu = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelChi = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.buttonHienThi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartBieuDo)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpNgayCuoi
            // 
            this.dtpNgayCuoi.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayCuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayCuoi.Location = new System.Drawing.Point(358, 57);
            this.dtpNgayCuoi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpNgayCuoi.Name = "dtpNgayCuoi";
            this.dtpNgayCuoi.Size = new System.Drawing.Size(212, 24);
            this.dtpNgayCuoi.TabIndex = 21;
            // 
            // dtpNgayDau
            // 
            this.dtpNgayDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayDau.Location = new System.Drawing.Point(358, 18);
            this.dtpNgayDau.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpNgayDau.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dtpNgayDau.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtpNgayDau.Name = "dtpNgayDau";
            this.dtpNgayDau.Size = new System.Drawing.Size(212, 24);
            this.dtpNgayDau.TabIndex = 20;
            // 
            // chartBieuDo
            // 
            chartArea4.Name = "ChartArea1";
            this.chartBieuDo.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartBieuDo.Legends.Add(legend4);
            this.chartBieuDo.Location = new System.Drawing.Point(9, 90);
            this.chartBieuDo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chartBieuDo.Name = "chartBieuDo";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartBieuDo.Series.Add(series4);
            this.chartBieuDo.Size = new System.Drawing.Size(682, 355);
            this.chartBieuDo.TabIndex = 19;
            this.chartBieuDo.Text = "chart1";
            this.chartBieuDo.Click += new System.EventHandler(this.chartBieuDo_Click);
            // 
            // labelThu
            // 
            this.labelThu.AutoSize = true;
            this.labelThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelThu.Location = new System.Drawing.Point(119, 15);
            this.labelThu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelThu.Name = "labelThu";
            this.labelThu.Size = new System.Drawing.Size(42, 26);
            this.labelThu.TabIndex = 18;
            this.labelThu.Text = "0 đ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(11, 54);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 26);
            this.label10.TabIndex = 17;
            this.label10.Text = "Tổng chi :";
            // 
            // labelChi
            // 
            this.labelChi.AutoSize = true;
            this.labelChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChi.Location = new System.Drawing.Point(119, 53);
            this.labelChi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelChi.Name = "labelChi";
            this.labelChi.Size = new System.Drawing.Size(42, 26);
            this.labelChi.TabIndex = 16;
            this.labelChi.Text = "0 đ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 15);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 26);
            this.label8.TabIndex = 15;
            this.label8.Text = "Tổng thu :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(241, 54);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 26);
            this.label6.TabIndex = 14;
            this.label6.Text = "Đến ngày :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(241, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 26);
            this.label4.TabIndex = 13;
            this.label4.Text = "Từ ngày :";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(591, 18);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 23);
            this.btnClear.TabIndex = 22;
            this.btnClear.Text = "XÓA HẾT";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // buttonHienThi
            // 
            this.buttonHienThi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonHienThi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonHienThi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHienThi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHienThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHienThi.ForeColor = System.Drawing.Color.Black;
            this.buttonHienThi.Location = new System.Drawing.Point(591, 56);
            this.buttonHienThi.Name = "buttonHienThi";
            this.buttonHienThi.Size = new System.Drawing.Size(100, 23);
            this.buttonHienThi.TabIndex = 22;
            this.buttonHienThi.Text = "HIỂN THỊ";
            this.buttonHienThi.UseVisualStyleBackColor = false;
            this.buttonHienThi.Click += new System.EventHandler(this.buttonHienThi_Click);
            // 
            // FormThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 455);
            this.Controls.Add(this.buttonHienThi);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dtpNgayCuoi);
            this.Controls.Add(this.dtpNgayDau);
            this.Controls.Add(this.chartBieuDo);
            this.Controls.Add(this.labelThu);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.labelChi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormThongKe";
            this.Text = "FormThongKe";
            this.Load += new System.EventHandler(this.FormThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartBieuDo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpNgayCuoi;
        private System.Windows.Forms.DateTimePicker dtpNgayDau;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBieuDo;
        private System.Windows.Forms.Label labelThu;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelChi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button buttonHienThi;
    }
}