namespace QUANLYCUAHANG
{
    partial class frm_SanPhamTrongHoaDon
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
            this.lbl_SanPham = new System.Windows.Forms.Label();
            this.lbl_SoLuong = new System.Windows.Forms.Label();
            this.lbl_DonGia = new System.Windows.Forms.Label();
            this.lbl_ThanhTien = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_SanPham
            // 
            this.lbl_SanPham.AutoSize = true;
            this.lbl_SanPham.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SanPham.Location = new System.Drawing.Point(12, 9);
            this.lbl_SanPham.Name = "lbl_SanPham";
            this.lbl_SanPham.Size = new System.Drawing.Size(53, 23);
            this.lbl_SanPham.TabIndex = 0;
            this.lbl_SanPham.Text = "label1";
            // 
            // lbl_SoLuong
            // 
            this.lbl_SoLuong.AutoSize = true;
            this.lbl_SoLuong.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SoLuong.Location = new System.Drawing.Point(263, 9);
            this.lbl_SoLuong.Name = "lbl_SoLuong";
            this.lbl_SoLuong.Size = new System.Drawing.Size(53, 23);
            this.lbl_SoLuong.TabIndex = 1;
            this.lbl_SoLuong.Text = "label1";
            // 
            // lbl_DonGia
            // 
            this.lbl_DonGia.AutoSize = true;
            this.lbl_DonGia.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DonGia.Location = new System.Drawing.Point(420, 9);
            this.lbl_DonGia.Name = "lbl_DonGia";
            this.lbl_DonGia.Size = new System.Drawing.Size(53, 23);
            this.lbl_DonGia.TabIndex = 2;
            this.lbl_DonGia.Text = "label1";
            // 
            // lbl_ThanhTien
            // 
            this.lbl_ThanhTien.AutoSize = true;
            this.lbl_ThanhTien.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ThanhTien.Location = new System.Drawing.Point(634, 9);
            this.lbl_ThanhTien.Name = "lbl_ThanhTien";
            this.lbl_ThanhTien.Size = new System.Drawing.Size(53, 23);
            this.lbl_ThanhTien.TabIndex = 3;
            this.lbl_ThanhTien.Text = "label1";
            // 
            // frm_SanPhamTrongHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(791, 60);
            this.Controls.Add(this.lbl_ThanhTien);
            this.Controls.Add(this.lbl_DonGia);
            this.Controls.Add(this.lbl_SoLuong);
            this.Controls.Add(this.lbl_SanPham);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_SanPhamTrongHoaDon";
            this.Text = "frm_SanPhamTrongHoaDon";
            this.Load += new System.EventHandler(this.frm_SanPhamTrongHoaDon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_SanPham;
        private System.Windows.Forms.Label lbl_SoLuong;
        private System.Windows.Forms.Label lbl_DonGia;
        private System.Windows.Forms.Label lbl_ThanhTien;
    }
}