namespace QUANLYCUAHANG
{
    partial class frm_SanPham
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
            this.pan_SanPham = new System.Windows.Forms.Panel();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pic_AnhSP = new System.Windows.Forms.PictureBox();
            this.lbl_MaSanPham = new System.Windows.Forms.Label();
            this.lbl_TenSanPham = new System.Windows.Forms.Label();
            this.lbl_SoLuongTon = new System.Windows.Forms.Label();
            this.lbl_DonGia = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_MaSanPham = new System.Windows.Forms.TextBox();
            this.txt_TenSanPham = new System.Windows.Forms.TextBox();
            this.txt_SoLuongTon = new System.Windows.Forms.TextBox();
            this.txt_Loai = new System.Windows.Forms.TextBox();
            this.btn_DoiAnh = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_ChinhSua = new System.Windows.Forms.Button();
            this.btn_QuayLai = new System.Windows.Forms.Button();
            this.txt_DonGia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Ncc = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.pan_SanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_AnhSP)).BeginInit();
            this.SuspendLayout();
            // 
            // pan_SanPham
            // 
            this.pan_SanPham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(158)))), ((int)(((byte)(132)))));
            this.pan_SanPham.Controls.Add(this.btn_Thoat);
            this.pan_SanPham.Controls.Add(this.label1);
            this.pan_SanPham.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan_SanPham.Location = new System.Drawing.Point(0, 0);
            this.pan_SanPham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pan_SanPham.Name = "pan_SanPham";
            this.pan_SanPham.Size = new System.Drawing.Size(834, 49);
            this.pan_SanPham.TabIndex = 2;
            this.pan_SanPham.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.pan_SanPham.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.pan_SanPham.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.FlatAppearance.BorderSize = 0;
            this.btn_Thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Thoat.Location = new System.Drawing.Point(791, 2);
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
            this.label1.Size = new System.Drawing.Size(119, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "SẢN PHẨM";
            // 
            // pic_AnhSP
            // 
            this.pic_AnhSP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic_AnhSP.Location = new System.Drawing.Point(13, 64);
            this.pic_AnhSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic_AnhSP.Name = "pic_AnhSP";
            this.pic_AnhSP.Size = new System.Drawing.Size(134, 171);
            this.pic_AnhSP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_AnhSP.TabIndex = 3;
            this.pic_AnhSP.TabStop = false;
            // 
            // lbl_MaSanPham
            // 
            this.lbl_MaSanPham.AutoSize = true;
            this.lbl_MaSanPham.Location = new System.Drawing.Point(152, 78);
            this.lbl_MaSanPham.Name = "lbl_MaSanPham";
            this.lbl_MaSanPham.Size = new System.Drawing.Size(95, 17);
            this.lbl_MaSanPham.TabIndex = 4;
            this.lbl_MaSanPham.Text = "Mã sản phẩm:";
            // 
            // lbl_TenSanPham
            // 
            this.lbl_TenSanPham.AutoSize = true;
            this.lbl_TenSanPham.Location = new System.Drawing.Point(152, 127);
            this.lbl_TenSanPham.Name = "lbl_TenSanPham";
            this.lbl_TenSanPham.Size = new System.Drawing.Size(98, 17);
            this.lbl_TenSanPham.TabIndex = 5;
            this.lbl_TenSanPham.Text = "Tên sản phẩm:";
            // 
            // lbl_SoLuongTon
            // 
            this.lbl_SoLuongTon.AutoSize = true;
            this.lbl_SoLuongTon.Location = new System.Drawing.Point(154, 174);
            this.lbl_SoLuongTon.Name = "lbl_SoLuongTon";
            this.lbl_SoLuongTon.Size = new System.Drawing.Size(93, 17);
            this.lbl_SoLuongTon.TabIndex = 6;
            this.lbl_SoLuongTon.Text = "Số lượng tồn:";
            // 
            // lbl_DonGia
            // 
            this.lbl_DonGia.AutoSize = true;
            this.lbl_DonGia.Location = new System.Drawing.Point(511, 75);
            this.lbl_DonGia.Name = "lbl_DonGia";
            this.lbl_DonGia.Size = new System.Drawing.Size(61, 17);
            this.lbl_DonGia.TabIndex = 7;
            this.lbl_DonGia.Text = "Đơn giá:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(534, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Loại:";
            // 
            // txt_MaSanPham
            // 
            this.txt_MaSanPham.Enabled = false;
            this.txt_MaSanPham.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaSanPham.Location = new System.Drawing.Point(250, 74);
            this.txt_MaSanPham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_MaSanPham.Name = "txt_MaSanPham";
            this.txt_MaSanPham.Size = new System.Drawing.Size(226, 27);
            this.txt_MaSanPham.TabIndex = 10;
            // 
            // txt_TenSanPham
            // 
            this.txt_TenSanPham.Enabled = false;
            this.txt_TenSanPham.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenSanPham.Location = new System.Drawing.Point(250, 124);
            this.txt_TenSanPham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TenSanPham.Name = "txt_TenSanPham";
            this.txt_TenSanPham.Size = new System.Drawing.Size(226, 27);
            this.txt_TenSanPham.TabIndex = 11;
            // 
            // txt_SoLuongTon
            // 
            this.txt_SoLuongTon.Enabled = false;
            this.txt_SoLuongTon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SoLuongTon.Location = new System.Drawing.Point(250, 169);
            this.txt_SoLuongTon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_SoLuongTon.Name = "txt_SoLuongTon";
            this.txt_SoLuongTon.Size = new System.Drawing.Size(226, 27);
            this.txt_SoLuongTon.TabIndex = 12;
            // 
            // txt_Loai
            // 
            this.txt_Loai.Enabled = false;
            this.txt_Loai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Loai.Location = new System.Drawing.Point(581, 117);
            this.txt_Loai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Loai.Name = "txt_Loai";
            this.txt_Loai.Size = new System.Drawing.Size(244, 27);
            this.txt_Loai.TabIndex = 14;
            // 
            // btn_DoiAnh
            // 
            this.btn_DoiAnh.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_DoiAnh.Enabled = false;
            this.btn_DoiAnh.FlatAppearance.BorderSize = 0;
            this.btn_DoiAnh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DoiAnh.ForeColor = System.Drawing.Color.Black;
            this.btn_DoiAnh.Location = new System.Drawing.Point(42, 254);
            this.btn_DoiAnh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_DoiAnh.Name = "btn_DoiAnh";
            this.btn_DoiAnh.Size = new System.Drawing.Size(75, 40);
            this.btn_DoiAnh.TabIndex = 16;
            this.btn_DoiAnh.Text = "Đổi ảnh:";
            this.btn_DoiAnh.UseVisualStyleBackColor = false;
            this.btn_DoiAnh.Click += new System.EventHandler(this.btn_DoiAnh_Click);
            this.btn_DoiAnh.MouseLeave += new System.EventHandler(this.btn_DoiAnh_MouseLeave);
            this.btn_DoiAnh.MouseHover += new System.EventHandler(this.btn_DoiAnh_MouseHover);
            // 
            // btn_Luu
            // 
            this.btn_Luu.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_Luu.Enabled = false;
            this.btn_Luu.FlatAppearance.BorderSize = 0;
            this.btn_Luu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Luu.ForeColor = System.Drawing.Color.Black;
            this.btn_Luu.Location = new System.Drawing.Point(608, 254);
            this.btn_Luu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(104, 40);
            this.btn_Luu.TabIndex = 17;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = false;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            this.btn_Luu.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            this.btn_Luu.MouseHover += new System.EventHandler(this.button2_MouseHover);
            // 
            // btn_ChinhSua
            // 
            this.btn_ChinhSua.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_ChinhSua.FlatAppearance.BorderSize = 0;
            this.btn_ChinhSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ChinhSua.ForeColor = System.Drawing.Color.White;
            this.btn_ChinhSua.Location = new System.Drawing.Point(495, 254);
            this.btn_ChinhSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ChinhSua.Name = "btn_ChinhSua";
            this.btn_ChinhSua.Size = new System.Drawing.Size(104, 40);
            this.btn_ChinhSua.TabIndex = 18;
            this.btn_ChinhSua.Text = "Chỉnh sửa";
            this.btn_ChinhSua.UseVisualStyleBackColor = false;
            this.btn_ChinhSua.Click += new System.EventHandler(this.btn_ChinhSua_Click);
            this.btn_ChinhSua.MouseLeave += new System.EventHandler(this.button3_MouseLeave);
            this.btn_ChinhSua.MouseHover += new System.EventHandler(this.button3_MouseHover);
            // 
            // btn_QuayLai
            // 
            this.btn_QuayLai.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_QuayLai.FlatAppearance.BorderSize = 0;
            this.btn_QuayLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_QuayLai.ForeColor = System.Drawing.Color.Black;
            this.btn_QuayLai.Location = new System.Drawing.Point(718, 254);
            this.btn_QuayLai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_QuayLai.Name = "btn_QuayLai";
            this.btn_QuayLai.Size = new System.Drawing.Size(104, 40);
            this.btn_QuayLai.TabIndex = 19;
            this.btn_QuayLai.Text = "Quay lại";
            this.btn_QuayLai.UseVisualStyleBackColor = false;
            this.btn_QuayLai.Click += new System.EventHandler(this.btn_QuayLai_Click);
            // 
            // txt_DonGia
            // 
            this.txt_DonGia.Enabled = false;
            this.txt_DonGia.Location = new System.Drawing.Point(578, 72);
            this.txt_DonGia.Name = "txt_DonGia";
            this.txt_DonGia.Size = new System.Drawing.Size(244, 25);
            this.txt_DonGia.TabIndex = 20;
            this.txt_DonGia.TextChanged += new System.EventHandler(this.txt_DonGia_TextChanged);
            this.txt_DonGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_DonGia_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(477, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nhà cung Cấp:";
            // 
            // txt_Ncc
            // 
            this.txt_Ncc.Enabled = false;
            this.txt_Ncc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Ncc.Location = new System.Drawing.Point(581, 169);
            this.txt_Ncc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Ncc.Name = "txt_Ncc";
            this.txt_Ncc.Size = new System.Drawing.Size(241, 27);
            this.txt_Ncc.TabIndex = 22;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.Red;
            this.btn_Xoa.FlatAppearance.BorderSize = 0;
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Xoa.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Xoa.Location = new System.Drawing.Point(372, 254);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(104, 40);
            this.btn_Xoa.TabIndex = 23;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // frm_SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 337);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.txt_Ncc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_DonGia);
            this.Controls.Add(this.btn_QuayLai);
            this.Controls.Add(this.btn_ChinhSua);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.btn_DoiAnh);
            this.Controls.Add(this.txt_Loai);
            this.Controls.Add(this.txt_SoLuongTon);
            this.Controls.Add(this.txt_TenSanPham);
            this.Controls.Add(this.txt_MaSanPham);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_DonGia);
            this.Controls.Add(this.lbl_SoLuongTon);
            this.Controls.Add(this.lbl_TenSanPham);
            this.Controls.Add(this.lbl_MaSanPham);
            this.Controls.Add(this.pic_AnhSP);
            this.Controls.Add(this.pan_SanPham);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_SanPham";
            this.Text = "SanPham";
            this.Load += new System.EventHandler(this.SanPham_Load);
            this.pan_SanPham.ResumeLayout(false);
            this.pan_SanPham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_AnhSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pan_SanPham;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pic_AnhSP;
        private System.Windows.Forms.Label lbl_MaSanPham;
        private System.Windows.Forms.Label lbl_TenSanPham;
        private System.Windows.Forms.Label lbl_SoLuongTon;
        private System.Windows.Forms.Label lbl_DonGia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_MaSanPham;
        private System.Windows.Forms.TextBox txt_TenSanPham;
        private System.Windows.Forms.TextBox txt_SoLuongTon;
        private System.Windows.Forms.TextBox txt_Loai;
        private System.Windows.Forms.Button btn_DoiAnh;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_ChinhSua;
        private System.Windows.Forms.Button btn_QuayLai;
        private System.Windows.Forms.TextBox txt_DonGia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Ncc;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btn_Xoa;
    }
}