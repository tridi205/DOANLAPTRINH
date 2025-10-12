namespace QUANLYCUAHANG
{
    partial class frm_SanPhamDat
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
            this.btn_Tang = new System.Windows.Forms.Button();
            this.btn_Giam = new System.Windows.Forms.Button();
            this.lbl_GiaNhap = new System.Windows.Forms.Label();
            this.lbl_ThanhTien = new System.Windows.Forms.Label();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.txt_SoLuong = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_SanPham
            // 
            this.lbl_SanPham.AutoSize = true;
            this.lbl_SanPham.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SanPham.Location = new System.Drawing.Point(12, 9);
            this.lbl_SanPham.Name = "lbl_SanPham";
            this.lbl_SanPham.Size = new System.Drawing.Size(69, 17);
            this.lbl_SanPham.TabIndex = 0;
            this.lbl_SanPham.Text = "Sản phẩm";
            // 
            // btn_Tang
            // 
            this.btn_Tang.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Tang.Location = new System.Drawing.Point(201, 10);
            this.btn_Tang.Name = "btn_Tang";
            this.btn_Tang.Size = new System.Drawing.Size(29, 26);
            this.btn_Tang.TabIndex = 1;
            this.btn_Tang.Text = "+";
            this.btn_Tang.UseVisualStyleBackColor = true;
            this.btn_Tang.Click += new System.EventHandler(this.btn_Tang_Click);
            // 
            // btn_Giam
            // 
            this.btn_Giam.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Giam.Location = new System.Drawing.Point(126, 10);
            this.btn_Giam.Name = "btn_Giam";
            this.btn_Giam.Size = new System.Drawing.Size(29, 26);
            this.btn_Giam.TabIndex = 2;
            this.btn_Giam.Text = "-";
            this.btn_Giam.UseVisualStyleBackColor = true;
            this.btn_Giam.Click += new System.EventHandler(this.btn_Giam_Click);
            // 
            // lbl_GiaNhap
            // 
            this.lbl_GiaNhap.AutoSize = true;
            this.lbl_GiaNhap.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GiaNhap.Location = new System.Drawing.Point(254, 15);
            this.lbl_GiaNhap.Name = "lbl_GiaNhap";
            this.lbl_GiaNhap.Size = new System.Drawing.Size(63, 17);
            this.lbl_GiaNhap.TabIndex = 4;
            this.lbl_GiaNhap.Text = "Giá nhập";
            // 
            // lbl_ThanhTien
            // 
            this.lbl_ThanhTien.AutoSize = true;
            this.lbl_ThanhTien.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ThanhTien.Location = new System.Drawing.Point(346, 15);
            this.lbl_ThanhTien.Name = "lbl_ThanhTien";
            this.lbl_ThanhTien.Size = new System.Drawing.Size(75, 17);
            this.lbl_ThanhTien.TabIndex = 5;
            this.lbl_ThanhTien.Text = "Thành tiền";
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.FlatAppearance.BorderSize = 0;
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Xoa.Location = new System.Drawing.Point(427, 6);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(32, 26);
            this.btn_Xoa.TabIndex = 6;
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.FlatAppearance.BorderSize = 0;
            this.btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Them.Location = new System.Drawing.Point(427, 6);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(32, 29);
            this.btn_Them.TabIndex = 7;
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Visible = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SoLuong.Location = new System.Drawing.Point(161, 10);
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.Size = new System.Drawing.Size(34, 30);
            this.txt_SoLuong.TabIndex = 8;
            this.txt_SoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_SoLuong.TextChanged += new System.EventHandler(this.txt_SoLuong_TextChanged);
            this.txt_SoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SoLuong_KeyPress);
            // 
            // frm_SanPhamDat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(465, 47);
            this.Controls.Add(this.txt_SoLuong);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.lbl_ThanhTien);
            this.Controls.Add(this.lbl_GiaNhap);
            this.Controls.Add(this.btn_Giam);
            this.Controls.Add(this.btn_Tang);
            this.Controls.Add(this.lbl_SanPham);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_SanPhamDat";
            this.Text = "frm_SanPhamDat";
            this.Load += new System.EventHandler(this.frm_SanPhamDat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_SanPham;
        private System.Windows.Forms.Button btn_Tang;
        private System.Windows.Forms.Button btn_Giam;
        private System.Windows.Forms.Label lbl_GiaNhap;
        private System.Windows.Forms.Label lbl_ThanhTien;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.TextBox txt_SoLuong;
    }
}