namespace QUANLYCUAHANG
{
    partial class frm_ThemSanPham
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
            this.pan_ThemSanPhamMoi = new System.Windows.Forms.Panel();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pic_AnhSP = new System.Windows.Forms.PictureBox();
            this.txt_DonGia = new System.Windows.Forms.TextBox();
            this.txt_Loai = new System.Windows.Forms.TextBox();
            this.txt_TenSanPham = new System.Windows.Forms.TextBox();
            this.txt_MaSanPham = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_DonGia = new System.Windows.Forms.Label();
            this.lbl_TenSanPham = new System.Windows.Forms.Label();
            this.lbl_MaSanPham = new System.Windows.Forms.Label();
            this.btn_DoiAnh = new System.Windows.Forms.Button();
            this.txt_MaSP = new System.Windows.Forms.TextBox();
            this.txt_TenSP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.cbb_Ncc = new System.Windows.Forms.ComboBox();
            this.lbl_SoLuong = new System.Windows.Forms.Label();
            this.nud_SoLuong = new System.Windows.Forms.NumericUpDown();
            this.pan_ThemSanPhamMoi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_AnhSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_SoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // pan_ThemSanPhamMoi
            // 
            this.pan_ThemSanPhamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(158)))), ((int)(((byte)(132)))));
            this.pan_ThemSanPhamMoi.Controls.Add(this.btn_Thoat);
            this.pan_ThemSanPhamMoi.Controls.Add(this.label1);
            this.pan_ThemSanPhamMoi.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan_ThemSanPhamMoi.Location = new System.Drawing.Point(0, 0);
            this.pan_ThemSanPhamMoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pan_ThemSanPhamMoi.Name = "pan_ThemSanPhamMoi";
            this.pan_ThemSanPhamMoi.Size = new System.Drawing.Size(872, 49);
            this.pan_ThemSanPhamMoi.TabIndex = 3;
            this.pan_ThemSanPhamMoi.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pan_ThemSanPhamMoi_MouseDown);
            this.pan_ThemSanPhamMoi.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pan_ThemSanPhamMoi_MouseMove);
            this.pan_ThemSanPhamMoi.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pan_ThemSanPhamMoi_MouseUp);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.FlatAppearance.BorderSize = 0;
            this.btn_Thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Thoat.Location = new System.Drawing.Point(834, 3);
            this.btn_Thoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(35, 35);
            this.btn_Thoat.TabIndex = 2;
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÊM SẢN PHẨM MỚI";
            // 
            // pic_AnhSP
            // 
            this.pic_AnhSP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic_AnhSP.Location = new System.Drawing.Point(12, 53);
            this.pic_AnhSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic_AnhSP.Name = "pic_AnhSP";
            this.pic_AnhSP.Size = new System.Drawing.Size(151, 152);
            this.pic_AnhSP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_AnhSP.TabIndex = 4;
            this.pic_AnhSP.TabStop = false;
            // 
            // txt_DonGia
            // 
            this.txt_DonGia.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DonGia.Location = new System.Drawing.Point(618, 72);
            this.txt_DonGia.Name = "txt_DonGia";
            this.txt_DonGia.Size = new System.Drawing.Size(219, 25);
            this.txt_DonGia.TabIndex = 32;
            this.txt_DonGia.Text = "0";
            this.txt_DonGia.TextChanged += new System.EventHandler(this.txt_DonGia_TextChanged);
            this.txt_DonGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_DonGia_KeyPress);
            // 
            // txt_Loai
            // 
            this.txt_Loai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Loai.Location = new System.Drawing.Point(619, 112);
            this.txt_Loai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Loai.Name = "txt_Loai";
            this.txt_Loai.Size = new System.Drawing.Size(218, 27);
            this.txt_Loai.TabIndex = 30;
            // 
            // txt_TenSanPham
            // 
            this.txt_TenSanPham.Enabled = false;
            this.txt_TenSanPham.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenSanPham.Location = new System.Drawing.Point(308, 112);
            this.txt_TenSanPham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TenSanPham.Name = "txt_TenSanPham";
            this.txt_TenSanPham.Size = new System.Drawing.Size(212, 27);
            this.txt_TenSanPham.TabIndex = 28;
            // 
            // txt_MaSanPham
            // 
            this.txt_MaSanPham.Enabled = false;
            this.txt_MaSanPham.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaSanPham.Location = new System.Drawing.Point(308, 70);
            this.txt_MaSanPham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_MaSanPham.Name = "txt_MaSanPham";
            this.txt_MaSanPham.Size = new System.Drawing.Size(212, 27);
            this.txt_MaSanPham.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(564, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "Loại:";
            // 
            // lbl_DonGia
            // 
            this.lbl_DonGia.AutoSize = true;
            this.lbl_DonGia.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DonGia.Location = new System.Drawing.Point(541, 79);
            this.lbl_DonGia.Name = "lbl_DonGia";
            this.lbl_DonGia.Size = new System.Drawing.Size(61, 17);
            this.lbl_DonGia.TabIndex = 24;
            this.lbl_DonGia.Text = "Đơn giá:";
            // 
            // lbl_TenSanPham
            // 
            this.lbl_TenSanPham.AutoSize = true;
            this.lbl_TenSanPham.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenSanPham.Location = new System.Drawing.Point(193, 122);
            this.lbl_TenSanPham.Name = "lbl_TenSanPham";
            this.lbl_TenSanPham.Size = new System.Drawing.Size(98, 17);
            this.lbl_TenSanPham.TabIndex = 22;
            this.lbl_TenSanPham.Text = "Tên sản phẩm:";
            // 
            // lbl_MaSanPham
            // 
            this.lbl_MaSanPham.AutoSize = true;
            this.lbl_MaSanPham.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaSanPham.Location = new System.Drawing.Point(193, 77);
            this.lbl_MaSanPham.Name = "lbl_MaSanPham";
            this.lbl_MaSanPham.Size = new System.Drawing.Size(95, 17);
            this.lbl_MaSanPham.TabIndex = 21;
            this.lbl_MaSanPham.Text = "Mã sản phẩm:";
            // 
            // btn_DoiAnh
            // 
            this.btn_DoiAnh.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_DoiAnh.FlatAppearance.BorderSize = 0;
            this.btn_DoiAnh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DoiAnh.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DoiAnh.ForeColor = System.Drawing.Color.Black;
            this.btn_DoiAnh.Location = new System.Drawing.Point(40, 219);
            this.btn_DoiAnh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_DoiAnh.Name = "btn_DoiAnh";
            this.btn_DoiAnh.Size = new System.Drawing.Size(93, 43);
            this.btn_DoiAnh.TabIndex = 33;
            this.btn_DoiAnh.Text = "Thêm ảnh:";
            this.btn_DoiAnh.UseVisualStyleBackColor = false;
            this.btn_DoiAnh.Click += new System.EventHandler(this.btn_DoiAnh_Click);
            // 
            // txt_MaSP
            // 
            this.txt_MaSP.Enabled = false;
            this.txt_MaSP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaSP.Location = new System.Drawing.Point(308, 74);
            this.txt_MaSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_MaSP.Name = "txt_MaSP";
            this.txt_MaSP.Size = new System.Drawing.Size(212, 27);
            this.txt_MaSP.TabIndex = 27;
            // 
            // txt_TenSP
            // 
            this.txt_TenSP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenSP.Location = new System.Drawing.Point(308, 116);
            this.txt_TenSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TenSP.Name = "txt_TenSP";
            this.txt_TenSP.Size = new System.Drawing.Size(212, 27);
            this.txt_TenSP.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(193, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 34;
            this.label2.Text = "Nhà cung cấp:";
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Them.FlatAppearance.BorderSize = 0;
            this.btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Them.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.Color.White;
            this.btn_Them.Location = new System.Drawing.Point(342, 275);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(104, 40);
            this.btn_Them.TabIndex = 36;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_Reset.FlatAppearance.BorderSize = 0;
            this.btn_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reset.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.ForeColor = System.Drawing.Color.Black;
            this.btn_Reset.Location = new System.Drawing.Point(544, 275);
            this.btn_Reset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(104, 40);
            this.btn_Reset.TabIndex = 37;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // cbb_Ncc
            // 
            this.cbb_Ncc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Ncc.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_Ncc.FormattingEnabled = true;
            this.cbb_Ncc.Location = new System.Drawing.Point(308, 162);
            this.cbb_Ncc.Name = "cbb_Ncc";
            this.cbb_Ncc.Size = new System.Drawing.Size(212, 25);
            this.cbb_Ncc.TabIndex = 38;
            // 
            // lbl_SoLuong
            // 
            this.lbl_SoLuong.AutoSize = true;
            this.lbl_SoLuong.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SoLuong.Location = new System.Drawing.Point(534, 170);
            this.lbl_SoLuong.Name = "lbl_SoLuong";
            this.lbl_SoLuong.Size = new System.Drawing.Size(68, 17);
            this.lbl_SoLuong.TabIndex = 23;
            this.lbl_SoLuong.Text = "Số lượng:";
            // 
            // nud_SoLuong
            // 
            this.nud_SoLuong.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_SoLuong.Location = new System.Drawing.Point(619, 167);
            this.nud_SoLuong.Name = "nud_SoLuong";
            this.nud_SoLuong.Size = new System.Drawing.Size(218, 25);
            this.nud_SoLuong.TabIndex = 39;
            // 
            // frm_ThemSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 385);
            this.Controls.Add(this.nud_SoLuong);
            this.Controls.Add(this.cbb_Ncc);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_DoiAnh);
            this.Controls.Add(this.txt_DonGia);
            this.Controls.Add(this.txt_Loai);
            this.Controls.Add(this.txt_TenSP);
            this.Controls.Add(this.txt_TenSanPham);
            this.Controls.Add(this.txt_MaSP);
            this.Controls.Add(this.txt_MaSanPham);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_DonGia);
            this.Controls.Add(this.lbl_SoLuong);
            this.Controls.Add(this.lbl_TenSanPham);
            this.Controls.Add(this.lbl_MaSanPham);
            this.Controls.Add(this.pic_AnhSP);
            this.Controls.Add(this.pan_ThemSanPhamMoi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_ThemSanPham";
            this.Text = "frm_ThemSanPham";
            this.Load += new System.EventHandler(this.frm_ThemSanPham_Load);
            this.pan_ThemSanPhamMoi.ResumeLayout(false);
            this.pan_ThemSanPhamMoi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_AnhSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_SoLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pan_ThemSanPhamMoi;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pic_AnhSP;
        private System.Windows.Forms.TextBox txt_DonGia;
        private System.Windows.Forms.TextBox txt_Loai;
        private System.Windows.Forms.TextBox txt_TenSanPham;
        private System.Windows.Forms.TextBox txt_MaSanPham;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_DonGia;
        private System.Windows.Forms.Label lbl_TenSanPham;
        private System.Windows.Forms.Label lbl_MaSanPham;
        private System.Windows.Forms.Button btn_DoiAnh;
        private System.Windows.Forms.TextBox txt_MaSP;
        private System.Windows.Forms.TextBox txt_TenSP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.ComboBox cbb_Ncc;
        private System.Windows.Forms.Label lbl_SoLuong;
        private System.Windows.Forms.NumericUpDown nud_SoLuong;
    }
}