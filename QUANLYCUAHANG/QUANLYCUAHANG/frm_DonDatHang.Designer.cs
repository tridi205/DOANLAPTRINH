namespace QUANLYCUAHANG
{
    partial class frm_DonDatHang
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
            this.lbl_MaDH = new System.Windows.Forms.Label();
            this.lbl_NgayDat = new System.Windows.Forms.Label();
            this.lbl_TongTien = new System.Windows.Forms.Label();
            this.lbl_SoLuong = new System.Windows.Forms.Label();
            this.btn_TrangThai = new System.Windows.Forms.Button();
            this.btn_ChiTiet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_MaDH
            // 
            this.lbl_MaDH.AutoSize = true;
            this.lbl_MaDH.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaDH.Location = new System.Drawing.Point(12, 24);
            this.lbl_MaDH.Name = "lbl_MaDH";
            this.lbl_MaDH.Size = new System.Drawing.Size(117, 23);
            this.lbl_MaDH.TabIndex = 10;
            this.lbl_MaDH.Text = "Mã đơn hàng";
            // 
            // lbl_NgayDat
            // 
            this.lbl_NgayDat.AutoSize = true;
            this.lbl_NgayDat.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NgayDat.Location = new System.Drawing.Point(123, 24);
            this.lbl_NgayDat.Name = "lbl_NgayDat";
            this.lbl_NgayDat.Size = new System.Drawing.Size(84, 23);
            this.lbl_NgayDat.TabIndex = 11;
            this.lbl_NgayDat.Text = "Ngày đặt";
            // 
            // lbl_TongTien
            // 
            this.lbl_TongTien.AutoSize = true;
            this.lbl_TongTien.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TongTien.Location = new System.Drawing.Point(386, 24);
            this.lbl_TongTien.Name = "lbl_TongTien";
            this.lbl_TongTien.Size = new System.Drawing.Size(84, 23);
            this.lbl_TongTien.TabIndex = 12;
            this.lbl_TongTien.Text = "Ngày đặt";
            // 
            // lbl_SoLuong
            // 
            this.lbl_SoLuong.AutoSize = true;
            this.lbl_SoLuong.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SoLuong.Location = new System.Drawing.Point(564, 24);
            this.lbl_SoLuong.Name = "lbl_SoLuong";
            this.lbl_SoLuong.Size = new System.Drawing.Size(84, 23);
            this.lbl_SoLuong.TabIndex = 14;
            this.lbl_SoLuong.Text = "Ngày đặt";
            // 
            // btn_TrangThai
            // 
            this.btn_TrangThai.BackColor = System.Drawing.Color.Red;
            this.btn_TrangThai.Enabled = false;
            this.btn_TrangThai.FlatAppearance.BorderSize = 0;
            this.btn_TrangThai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TrangThai.ForeColor = System.Drawing.Color.White;
            this.btn_TrangThai.Location = new System.Drawing.Point(681, 15);
            this.btn_TrangThai.Name = "btn_TrangThai";
            this.btn_TrangThai.Size = new System.Drawing.Size(112, 43);
            this.btn_TrangThai.TabIndex = 15;
            this.btn_TrangThai.Text = "Chưa nhận";
            this.btn_TrangThai.UseVisualStyleBackColor = false;
            // 
            // btn_ChiTiet
            // 
            this.btn_ChiTiet.BackColor = System.Drawing.Color.White;
            this.btn_ChiTiet.FlatAppearance.BorderSize = 0;
            this.btn_ChiTiet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChiTiet.ForeColor = System.Drawing.Color.Black;
            this.btn_ChiTiet.Location = new System.Drawing.Point(820, 15);
            this.btn_ChiTiet.Name = "btn_ChiTiet";
            this.btn_ChiTiet.Size = new System.Drawing.Size(112, 43);
            this.btn_ChiTiet.TabIndex = 16;
            this.btn_ChiTiet.Text = "Chi tiết";
            this.btn_ChiTiet.UseVisualStyleBackColor = false;
            this.btn_ChiTiet.Click += new System.EventHandler(this.btn_ChiTiet_Click);
            // 
            // frm_DonDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(966, 68);
            this.Controls.Add(this.btn_ChiTiet);
            this.Controls.Add(this.btn_TrangThai);
            this.Controls.Add(this.lbl_SoLuong);
            this.Controls.Add(this.lbl_TongTien);
            this.Controls.Add(this.lbl_NgayDat);
            this.Controls.Add(this.lbl_MaDH);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_DonDatHang";
            this.Text = "frm_DonDatHang";
            this.Load += new System.EventHandler(this.frm_DonDatHang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_MaDH;
        private System.Windows.Forms.Label lbl_NgayDat;
        private System.Windows.Forms.Label lbl_TongTien;
        private System.Windows.Forms.Label lbl_SoLuong;
        private System.Windows.Forms.Button btn_TrangThai;
        private System.Windows.Forms.Button btn_ChiTiet;
    }
}