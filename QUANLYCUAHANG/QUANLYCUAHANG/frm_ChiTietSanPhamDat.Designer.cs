namespace QUANLYCUAHANG
{
    partial class frm_ChiTietSanPhamDat
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
            this.lbl_SoLuong = new System.Windows.Forms.Label();
            this.lbl_GiaNhap = new System.Windows.Forms.Label();
            this.lbl_SanPham = new System.Windows.Forms.Label();
            this.lbl_MaDH = new System.Windows.Forms.Label();
            this.lbl_ThanhTien = new System.Windows.Forms.Label();
            this.txt_SoLuong = new System.Windows.Forms.TextBox();
            this.chk_NhanDU = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbl_SoLuong
            // 
            this.lbl_SoLuong.AutoSize = true;
            this.lbl_SoLuong.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SoLuong.Location = new System.Drawing.Point(416, 21);
            this.lbl_SoLuong.Name = "lbl_SoLuong";
            this.lbl_SoLuong.Size = new System.Drawing.Size(19, 23);
            this.lbl_SoLuong.TabIndex = 18;
            this.lbl_SoLuong.Text = "0";
            // 
            // lbl_GiaNhap
            // 
            this.lbl_GiaNhap.AutoSize = true;
            this.lbl_GiaNhap.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GiaNhap.Location = new System.Drawing.Point(527, 21);
            this.lbl_GiaNhap.Name = "lbl_GiaNhap";
            this.lbl_GiaNhap.Size = new System.Drawing.Size(82, 23);
            this.lbl_GiaNhap.TabIndex = 17;
            this.lbl_GiaNhap.Text = "Giá Nhập";
            // 
            // lbl_SanPham
            // 
            this.lbl_SanPham.AutoSize = true;
            this.lbl_SanPham.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SanPham.Location = new System.Drawing.Point(126, 21);
            this.lbl_SanPham.Name = "lbl_SanPham";
            this.lbl_SanPham.Size = new System.Drawing.Size(87, 23);
            this.lbl_SanPham.TabIndex = 16;
            this.lbl_SanPham.Text = "Sản phẩm";
            // 
            // lbl_MaDH
            // 
            this.lbl_MaDH.AutoSize = true;
            this.lbl_MaDH.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaDH.Location = new System.Drawing.Point(6, 21);
            this.lbl_MaDH.Name = "lbl_MaDH";
            this.lbl_MaDH.Size = new System.Drawing.Size(114, 23);
            this.lbl_MaDH.TabIndex = 15;
            this.lbl_MaDH.Text = "Mã đơn hàng";
            // 
            // lbl_ThanhTien
            // 
            this.lbl_ThanhTien.AutoSize = true;
            this.lbl_ThanhTien.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ThanhTien.Location = new System.Drawing.Point(685, 21);
            this.lbl_ThanhTien.Name = "lbl_ThanhTien";
            this.lbl_ThanhTien.Size = new System.Drawing.Size(92, 23);
            this.lbl_ThanhTien.TabIndex = 19;
            this.lbl_ThanhTien.Text = "Thành tiền";
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.txt_SoLuong.Location = new System.Drawing.Point(878, 20);
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.Size = new System.Drawing.Size(80, 27);
            this.txt_SoLuong.TabIndex = 22;
            this.txt_SoLuong.Text = "0";
            this.txt_SoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_SoLuong.TextChanged += new System.EventHandler(this.txt_SoLuong_TextChanged);
            this.txt_SoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SoLuong_KeyPress);
            // 
            // chk_NhanDU
            // 
            this.chk_NhanDU.AutoSize = true;
            this.chk_NhanDU.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.chk_NhanDU.Location = new System.Drawing.Point(1056, 21);
            this.chk_NhanDU.Name = "chk_NhanDU";
            this.chk_NhanDU.Size = new System.Drawing.Size(99, 27);
            this.chk_NhanDU.TabIndex = 23;
            this.chk_NhanDU.Text = "Nhận đủ";
            this.chk_NhanDU.UseVisualStyleBackColor = true;
            this.chk_NhanDU.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // frm_ChiTietSanPhamDat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 68);
            this.Controls.Add(this.chk_NhanDU);
            this.Controls.Add(this.txt_SoLuong);
            this.Controls.Add(this.lbl_ThanhTien);
            this.Controls.Add(this.lbl_SoLuong);
            this.Controls.Add(this.lbl_GiaNhap);
            this.Controls.Add(this.lbl_SanPham);
            this.Controls.Add(this.lbl_MaDH);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_ChiTietSanPhamDat";
            this.Text = "frm_ChiTietSanPhamDat";
            this.Load += new System.EventHandler(this.frm_ChiTietSanPhamDat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_SoLuong;
        private System.Windows.Forms.Label lbl_GiaNhap;
        private System.Windows.Forms.Label lbl_SanPham;
        private System.Windows.Forms.Label lbl_MaDH;
        private System.Windows.Forms.Label lbl_ThanhTien;
        private System.Windows.Forms.TextBox txt_SoLuong;
        private System.Windows.Forms.CheckBox chk_NhanDU;
    }
}