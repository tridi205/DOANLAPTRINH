namespace QUANLYCUAHANG
{
    partial class frm_SanPhamBan
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
            this.txt_SoLuong = new System.Windows.Forms.TextBox();
            this.lbl_ThanhTien = new System.Windows.Forms.Label();
            this.lbl_GiamGia = new System.Windows.Forms.Label();
            this.btn_Giam = new System.Windows.Forms.Button();
            this.btn_Tang = new System.Windows.Forms.Button();
            this.lbl_SanPham = new System.Windows.Forms.Label();
            this.lbl_DonGia = new System.Windows.Forms.Label();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SoLuong.Location = new System.Drawing.Point(503, 20);
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.Size = new System.Drawing.Size(46, 30);
            this.txt_SoLuong.TabIndex = 16;
            this.txt_SoLuong.Text = "1";
            this.txt_SoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_SoLuong.TextChanged += new System.EventHandler(this.txt_SoLuong_TextChanged);
            this.txt_SoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SoLuong_KeyPress);
            // 
            // lbl_ThanhTien
            // 
            this.lbl_ThanhTien.AutoSize = true;
            this.lbl_ThanhTien.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ThanhTien.Location = new System.Drawing.Point(865, 23);
            this.lbl_ThanhTien.Name = "lbl_ThanhTien";
            this.lbl_ThanhTien.Size = new System.Drawing.Size(95, 23);
            this.lbl_ThanhTien.TabIndex = 13;
            this.lbl_ThanhTien.Text = "Thành tiền";
            // 
            // lbl_GiamGia
            // 
            this.lbl_GiamGia.AutoSize = true;
            this.lbl_GiamGia.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GiamGia.Location = new System.Drawing.Point(703, 23);
            this.lbl_GiamGia.Name = "lbl_GiamGia";
            this.lbl_GiamGia.Size = new System.Drawing.Size(82, 23);
            this.lbl_GiamGia.TabIndex = 12;
            this.lbl_GiamGia.Text = "Giảm giá";
            // 
            // btn_Giam
            // 
            this.btn_Giam.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Giam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Giam.Location = new System.Drawing.Point(449, 15);
            this.btn_Giam.Name = "btn_Giam";
            this.btn_Giam.Size = new System.Drawing.Size(36, 41);
            this.btn_Giam.TabIndex = 11;
            this.btn_Giam.Text = "-";
            this.btn_Giam.UseVisualStyleBackColor = true;
            this.btn_Giam.Click += new System.EventHandler(this.btn_Giam_Click);
            // 
            // btn_Tang
            // 
            this.btn_Tang.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Tang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tang.Location = new System.Drawing.Point(568, 15);
            this.btn_Tang.Name = "btn_Tang";
            this.btn_Tang.Size = new System.Drawing.Size(39, 40);
            this.btn_Tang.TabIndex = 10;
            this.btn_Tang.Text = "+";
            this.btn_Tang.UseVisualStyleBackColor = true;
            this.btn_Tang.Click += new System.EventHandler(this.btn_Tang_Click);
            // 
            // lbl_SanPham
            // 
            this.lbl_SanPham.AutoSize = true;
            this.lbl_SanPham.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SanPham.Location = new System.Drawing.Point(12, 9);
            this.lbl_SanPham.Name = "lbl_SanPham";
            this.lbl_SanPham.Size = new System.Drawing.Size(90, 23);
            this.lbl_SanPham.TabIndex = 9;
            this.lbl_SanPham.Text = "Sản phẩm";
            // 
            // lbl_DonGia
            // 
            this.lbl_DonGia.AutoSize = true;
            this.lbl_DonGia.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DonGia.Location = new System.Drawing.Point(285, 23);
            this.lbl_DonGia.Name = "lbl_DonGia";
            this.lbl_DonGia.Size = new System.Drawing.Size(74, 23);
            this.lbl_DonGia.TabIndex = 17;
            this.lbl_DonGia.Text = "Đơn giá";
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(1037, 9);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(51, 46);
            this.btn_Xoa.TabIndex = 18;
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(1037, 10);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(51, 46);
            this.btn_Them.TabIndex = 19;
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Visible = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click_1);
            // 
            // frm_SanPhamBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 68);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.lbl_DonGia);
            this.Controls.Add(this.txt_SoLuong);
            this.Controls.Add(this.lbl_ThanhTien);
            this.Controls.Add(this.lbl_GiamGia);
            this.Controls.Add(this.btn_Giam);
            this.Controls.Add(this.btn_Tang);
            this.Controls.Add(this.lbl_SanPham);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_SanPhamBan";
            this.Text = "frm_SanPhamBan";
            this.Load += new System.EventHandler(this.frm_SanPhamBan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_SoLuong;
        private System.Windows.Forms.Label lbl_ThanhTien;
        private System.Windows.Forms.Label lbl_GiamGia;
        private System.Windows.Forms.Button btn_Giam;
        private System.Windows.Forms.Button btn_Tang;
        private System.Windows.Forms.Label lbl_SanPham;
        private System.Windows.Forms.Label lbl_DonGia;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Them;
    }
}