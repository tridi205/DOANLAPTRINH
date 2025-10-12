namespace QUANLYCUAHANG
{
    partial class frm_ThongKe
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pan_ThongKeDoanhThu = new System.Windows.Forms.Panel();
            this.lbl_ThongKeDoanhThu = new System.Windows.Forms.Label();
            this.chart_DT = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbl_BieuDoDoanhThu = new System.Windows.Forms.Label();
            this.lbl_PhieuDoanhThuThangNay = new System.Windows.Forms.Label();
            this.btn_ChiTietDTTN = new System.Windows.Forms.Button();
            this.pan_DoanhThuThangNay = new System.Windows.Forms.Panel();
            this.pic_NhanVien = new System.Windows.Forms.PictureBox();
            this.lbl_SanPhamBanChay = new System.Windows.Forms.Label();
            this.btn_ChiTiet = new System.Windows.Forms.Button();
            this.pan_HoaDon = new System.Windows.Forms.Panel();
            this.pic_HoaDon = new System.Windows.Forms.PictureBox();
            this.cbb_Nam = new System.Windows.Forms.ComboBox();
            this.lbl_Nam = new System.Windows.Forms.Label();
            this.lbl_thang = new System.Windows.Forms.Label();
            this.cbb_Thang = new System.Windows.Forms.ComboBox();
            this.btn_ThongKe = new System.Windows.Forms.Button();
            this.pan_ThongKeDoanhThu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_DT)).BeginInit();
            this.pan_DoanhThuThangNay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_NhanVien)).BeginInit();
            this.pan_HoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_HoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // pan_ThongKeDoanhThu
            // 
            this.pan_ThongKeDoanhThu.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pan_ThongKeDoanhThu.Controls.Add(this.lbl_ThongKeDoanhThu);
            this.pan_ThongKeDoanhThu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan_ThongKeDoanhThu.Location = new System.Drawing.Point(0, 0);
            this.pan_ThongKeDoanhThu.Name = "pan_ThongKeDoanhThu";
            this.pan_ThongKeDoanhThu.Size = new System.Drawing.Size(1098, 44);
            this.pan_ThongKeDoanhThu.TabIndex = 4;
            // 
            // lbl_ThongKeDoanhThu
            // 
            this.lbl_ThongKeDoanhThu.AutoSize = true;
            this.lbl_ThongKeDoanhThu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ThongKeDoanhThu.Location = new System.Drawing.Point(12, 13);
            this.lbl_ThongKeDoanhThu.Name = "lbl_ThongKeDoanhThu";
            this.lbl_ThongKeDoanhThu.Size = new System.Drawing.Size(205, 23);
            this.lbl_ThongKeDoanhThu.TabIndex = 0;
            this.lbl_ThongKeDoanhThu.Text = "THỐNG KÊ DOANH THU";
            // 
            // chart_DT
            // 
            this.chart_DT.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart_DT.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_DT.Legends.Add(legend1);
            this.chart_DT.Location = new System.Drawing.Point(-22, 298);
            this.chart_DT.Name = "chart_DT";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart_DT.Series.Add(series1);
            this.chart_DT.Size = new System.Drawing.Size(1120, 326);
            this.chart_DT.TabIndex = 12;
            this.chart_DT.Text = "chart1";
            // 
            // lbl_BieuDoDoanhThu
            // 
            this.lbl_BieuDoDoanhThu.AutoSize = true;
            this.lbl_BieuDoDoanhThu.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BieuDoDoanhThu.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbl_BieuDoDoanhThu.Location = new System.Drawing.Point(330, 257);
            this.lbl_BieuDoDoanhThu.Name = "lbl_BieuDoDoanhThu";
            this.lbl_BieuDoDoanhThu.Size = new System.Drawing.Size(402, 38);
            this.lbl_BieuDoDoanhThu.TabIndex = 13;
            this.lbl_BieuDoDoanhThu.Text = "Biểu đồ doanh thu tháng này";
            // 
            // lbl_PhieuDoanhThuThangNay
            // 
            this.lbl_PhieuDoanhThuThangNay.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PhieuDoanhThuThangNay.ForeColor = System.Drawing.Color.White;
            this.lbl_PhieuDoanhThuThangNay.Location = new System.Drawing.Point(3, 12);
            this.lbl_PhieuDoanhThuThangNay.Name = "lbl_PhieuDoanhThuThangNay";
            this.lbl_PhieuDoanhThuThangNay.Size = new System.Drawing.Size(172, 35);
            this.lbl_PhieuDoanhThuThangNay.TabIndex = 0;
            this.lbl_PhieuDoanhThuThangNay.Text = "PHIẾU DOANH THU";
            // 
            // btn_ChiTietDTTN
            // 
            this.btn_ChiTietDTTN.AutoSize = true;
            this.btn_ChiTietDTTN.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_ChiTietDTTN.FlatAppearance.BorderSize = 0;
            this.btn_ChiTietDTTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ChiTietDTTN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChiTietDTTN.ForeColor = System.Drawing.Color.White;
            this.btn_ChiTietDTTN.Location = new System.Drawing.Point(134, 71);
            this.btn_ChiTietDTTN.Name = "btn_ChiTietDTTN";
            this.btn_ChiTietDTTN.Size = new System.Drawing.Size(115, 32);
            this.btn_ChiTietDTTN.TabIndex = 3;
            this.btn_ChiTietDTTN.Text = "Chi tiết";
            this.btn_ChiTietDTTN.UseVisualStyleBackColor = false;
            this.btn_ChiTietDTTN.Click += new System.EventHandler(this.btn_ChiTietDTTN_Click);
            // 
            // pan_DoanhThuThangNay
            // 
            this.pan_DoanhThuThangNay.BackColor = System.Drawing.Color.SteelBlue;
            this.pan_DoanhThuThangNay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pan_DoanhThuThangNay.Controls.Add(this.btn_ChiTietDTTN);
            this.pan_DoanhThuThangNay.Controls.Add(this.pic_NhanVien);
            this.pan_DoanhThuThangNay.Controls.Add(this.lbl_PhieuDoanhThuThangNay);
            this.pan_DoanhThuThangNay.Location = new System.Drawing.Point(16, 75);
            this.pan_DoanhThuThangNay.Name = "pan_DoanhThuThangNay";
            this.pan_DoanhThuThangNay.Size = new System.Drawing.Size(262, 116);
            this.pan_DoanhThuThangNay.TabIndex = 14;
            // 
            // pic_NhanVien
            // 
            this.pic_NhanVien.Image = global::QUANLYCUAHANG.Properties.Resources.receipt;
            this.pic_NhanVien.Location = new System.Drawing.Point(213, 3);
            this.pic_NhanVien.Name = "pic_NhanVien";
            this.pic_NhanVien.Size = new System.Drawing.Size(46, 50);
            this.pic_NhanVien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_NhanVien.TabIndex = 1;
            this.pic_NhanVien.TabStop = false;
            // 
            // lbl_SanPhamBanChay
            // 
            this.lbl_SanPhamBanChay.AutoSize = true;
            this.lbl_SanPhamBanChay.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SanPhamBanChay.ForeColor = System.Drawing.Color.White;
            this.lbl_SanPhamBanChay.Location = new System.Drawing.Point(3, 12);
            this.lbl_SanPhamBanChay.Name = "lbl_SanPhamBanChay";
            this.lbl_SanPhamBanChay.Size = new System.Drawing.Size(193, 23);
            this.lbl_SanPhamBanChay.TabIndex = 0;
            this.lbl_SanPhamBanChay.Text = "SẢN PHẨM BÁN CHẠY";
            // 
            // btn_ChiTiet
            // 
            this.btn_ChiTiet.AutoSize = true;
            this.btn_ChiTiet.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_ChiTiet.FlatAppearance.BorderSize = 0;
            this.btn_ChiTiet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ChiTiet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChiTiet.ForeColor = System.Drawing.Color.White;
            this.btn_ChiTiet.Location = new System.Drawing.Point(135, 71);
            this.btn_ChiTiet.Name = "btn_ChiTiet";
            this.btn_ChiTiet.Size = new System.Drawing.Size(115, 32);
            this.btn_ChiTiet.TabIndex = 3;
            this.btn_ChiTiet.Text = "Chi tiết";
            this.btn_ChiTiet.UseVisualStyleBackColor = false;
            this.btn_ChiTiet.Click += new System.EventHandler(this.btn_ChiTiet_Click);
            // 
            // pan_HoaDon
            // 
            this.pan_HoaDon.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.pan_HoaDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pan_HoaDon.Controls.Add(this.btn_ChiTiet);
            this.pan_HoaDon.Controls.Add(this.pic_HoaDon);
            this.pan_HoaDon.Controls.Add(this.lbl_SanPhamBanChay);
            this.pan_HoaDon.Location = new System.Drawing.Point(349, 75);
            this.pan_HoaDon.Name = "pan_HoaDon";
            this.pan_HoaDon.Size = new System.Drawing.Size(262, 116);
            this.pan_HoaDon.TabIndex = 15;
            // 
            // pic_HoaDon
            // 
            this.pic_HoaDon.Image = global::QUANLYCUAHANG.Properties.Resources.bill;
            this.pic_HoaDon.Location = new System.Drawing.Point(213, 3);
            this.pic_HoaDon.Name = "pic_HoaDon";
            this.pic_HoaDon.Size = new System.Drawing.Size(46, 50);
            this.pic_HoaDon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_HoaDon.TabIndex = 1;
            this.pic_HoaDon.TabStop = false;
            // 
            // cbb_Nam
            // 
            this.cbb_Nam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Nam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_Nam.FormattingEnabled = true;
            this.cbb_Nam.Location = new System.Drawing.Point(953, 116);
            this.cbb_Nam.Name = "cbb_Nam";
            this.cbb_Nam.Size = new System.Drawing.Size(121, 28);
            this.cbb_Nam.TabIndex = 16;
            // 
            // lbl_Nam
            // 
            this.lbl_Nam.AutoSize = true;
            this.lbl_Nam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nam.Location = new System.Drawing.Point(894, 119);
            this.lbl_Nam.Name = "lbl_Nam";
            this.lbl_Nam.Size = new System.Drawing.Size(53, 20);
            this.lbl_Nam.TabIndex = 17;
            this.lbl_Nam.Text = "Năm:";
            // 
            // lbl_thang
            // 
            this.lbl_thang.AutoSize = true;
            this.lbl_thang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_thang.Location = new System.Drawing.Point(651, 119);
            this.lbl_thang.Name = "lbl_thang";
            this.lbl_thang.Size = new System.Drawing.Size(66, 20);
            this.lbl_thang.TabIndex = 18;
            this.lbl_thang.Text = "Tháng:";
            // 
            // cbb_Thang
            // 
            this.cbb_Thang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Thang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_Thang.FormattingEnabled = true;
            this.cbb_Thang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbb_Thang.Location = new System.Drawing.Point(723, 116);
            this.cbb_Thang.Name = "cbb_Thang";
            this.cbb_Thang.Size = new System.Drawing.Size(121, 28);
            this.cbb_Thang.TabIndex = 19;
            // 
            // btn_ThongKe
            // 
            this.btn_ThongKe.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThongKe.Location = new System.Drawing.Point(833, 192);
            this.btn_ThongKe.Name = "btn_ThongKe";
            this.btn_ThongKe.Size = new System.Drawing.Size(114, 35);
            this.btn_ThongKe.TabIndex = 20;
            this.btn_ThongKe.Text = "Thống kế";
            this.btn_ThongKe.UseVisualStyleBackColor = true;
            this.btn_ThongKe.Click += new System.EventHandler(this.btn_ThongKe_Click);
            // 
            // frm_ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 664);
            this.Controls.Add(this.btn_ThongKe);
            this.Controls.Add(this.cbb_Thang);
            this.Controls.Add(this.lbl_thang);
            this.Controls.Add(this.lbl_Nam);
            this.Controls.Add(this.cbb_Nam);
            this.Controls.Add(this.pan_HoaDon);
            this.Controls.Add(this.pan_DoanhThuThangNay);
            this.Controls.Add(this.lbl_BieuDoDoanhThu);
            this.Controls.Add(this.chart_DT);
            this.Controls.Add(this.pan_ThongKeDoanhThu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_ThongKe";
            this.Text = "frm_ThongKe";
            this.Load += new System.EventHandler(this.frm_ThongKe_Load);
            this.pan_ThongKeDoanhThu.ResumeLayout(false);
            this.pan_ThongKeDoanhThu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_DT)).EndInit();
            this.pan_DoanhThuThangNay.ResumeLayout(false);
            this.pan_DoanhThuThangNay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_NhanVien)).EndInit();
            this.pan_HoaDon.ResumeLayout(false);
            this.pan_HoaDon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_HoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pan_ThongKeDoanhThu;
        private System.Windows.Forms.Label lbl_ThongKeDoanhThu;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_DT;
        private System.Windows.Forms.Label lbl_BieuDoDoanhThu;
        private System.Windows.Forms.Label lbl_PhieuDoanhThuThangNay;
        private System.Windows.Forms.PictureBox pic_NhanVien;
        private System.Windows.Forms.Button btn_ChiTietDTTN;
        private System.Windows.Forms.Panel pan_DoanhThuThangNay;
        private System.Windows.Forms.Label lbl_SanPhamBanChay;
        private System.Windows.Forms.PictureBox pic_HoaDon;
        private System.Windows.Forms.Button btn_ChiTiet;
        private System.Windows.Forms.Panel pan_HoaDon;
        private System.Windows.Forms.ComboBox cbb_Nam;
        private System.Windows.Forms.Label lbl_Nam;
        private System.Windows.Forms.Label lbl_thang;
        private System.Windows.Forms.ComboBox cbb_Thang;
        private System.Windows.Forms.Button btn_ThongKe;
    }
}