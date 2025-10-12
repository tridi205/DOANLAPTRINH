namespace QUANLYCUAHANG
{
    partial class frm_DanhSachSanPhamBan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pan_DatHang = new System.Windows.Forms.Panel();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.lbl_DatHang = new System.Windows.Forms.Label();
            this.lbl_SanPhamTrongKho = new System.Windows.Forms.Label();
            this.dgv_DanhSachSanPham = new System.Windows.Forms.DataGridView();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.pan_Loai = new System.Windows.Forms.Panel();
            this.lbl_Loai = new System.Windows.Forms.Label();
            this.pan_NhaCungCap = new System.Windows.Forms.Panel();
            this.lbl_NhaCungCap = new System.Windows.Forms.Label();
            this.pan_KhoangGia = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_Den = new System.Windows.Forms.Label();
            this.txt_Tu = new System.Windows.Forms.TextBox();
            this.lbl_Tu = new System.Windows.Forms.Label();
            this.txt_Den = new System.Windows.Forms.TextBox();
            this.btn_BoLoc = new System.Windows.Forms.Button();
            this.lbl_BoLoc = new System.Windows.Forms.Label();
            this.lbl_ThanhTien = new System.Windows.Forms.Label();
            this.lbl_DonGia = new System.Windows.Forms.Label();
            this.lbl_SoLuong = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pan_SanPhamThem = new System.Windows.Forms.Panel();
            this.lbl_SanPham = new System.Windows.Forms.Label();
            this.btn_ThemSanPham = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.pan_DatHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachSanPham)).BeginInit();
            this.pan_Loai.SuspendLayout();
            this.pan_NhaCungCap.SuspendLayout();
            this.pan_KhoangGia.SuspendLayout();
            this.SuspendLayout();
            // 
            // pan_DatHang
            // 
            this.pan_DatHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(158)))), ((int)(((byte)(132)))));
            this.pan_DatHang.Controls.Add(this.btn_Thoat);
            this.pan_DatHang.Controls.Add(this.lbl_DatHang);
            this.pan_DatHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan_DatHang.Location = new System.Drawing.Point(0, 0);
            this.pan_DatHang.Name = "pan_DatHang";
            this.pan_DatHang.Size = new System.Drawing.Size(1499, 49);
            this.pan_DatHang.TabIndex = 3;
            this.pan_DatHang.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pan_DatHang_MouseDown);
            this.pan_DatHang.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pan_DatHang_MouseMove);
            this.pan_DatHang.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pan_DatHang_MouseUp);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(158)))), ((int)(((byte)(132)))));
            this.btn_Thoat.FlatAppearance.BorderSize = 0;
            this.btn_Thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Thoat.Location = new System.Drawing.Point(1456, 5);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(41, 39);
            this.btn_Thoat.TabIndex = 3;
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // lbl_DatHang
            // 
            this.lbl_DatHang.AutoSize = true;
            this.lbl_DatHang.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DatHang.Location = new System.Drawing.Point(672, 9);
            this.lbl_DatHang.Name = "lbl_DatHang";
            this.lbl_DatHang.Size = new System.Drawing.Size(221, 25);
            this.lbl_DatHang.TabIndex = 0;
            this.lbl_DatHang.Text = "DANH SÁCH SẢN PHẨM";
            // 
            // lbl_SanPhamTrongKho
            // 
            this.lbl_SanPhamTrongKho.AutoSize = true;
            this.lbl_SanPhamTrongKho.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SanPhamTrongKho.Location = new System.Drawing.Point(12, 71);
            this.lbl_SanPhamTrongKho.Name = "lbl_SanPhamTrongKho";
            this.lbl_SanPhamTrongKho.Size = new System.Drawing.Size(223, 25);
            this.lbl_SanPhamTrongKho.TabIndex = 22;
            this.lbl_SanPhamTrongKho.Text = "SẢN PHẨM TRONG KHO";
            // 
            // dgv_DanhSachSanPham
            // 
            this.dgv_DanhSachSanPham.AllowUserToAddRows = false;
            this.dgv_DanhSachSanPham.AllowUserToDeleteRows = false;
            this.dgv_DanhSachSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DanhSachSanPham.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_DanhSachSanPham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_DanhSachSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachSanPham.Location = new System.Drawing.Point(12, 99);
            this.dgv_DanhSachSanPham.Name = "dgv_DanhSachSanPham";
            this.dgv_DanhSachSanPham.ReadOnly = true;
            this.dgv_DanhSachSanPham.RowHeadersWidth = 51;
            this.dgv_DanhSachSanPham.RowTemplate.Height = 24;
            this.dgv_DanhSachSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DanhSachSanPham.Size = new System.Drawing.Size(687, 597);
            this.dgv_DanhSachSanPham.TabIndex = 21;
            this.dgv_DanhSachSanPham.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhSachSanPham_CellDoubleClick);
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.BackColor = System.Drawing.Color.White;
            this.btn_TimKiem.Location = new System.Drawing.Point(967, 89);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(47, 45);
            this.btn_TimKiem.TabIndex = 23;
            this.btn_TimKiem.UseVisualStyleBackColor = false;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.BackColor = System.Drawing.Color.White;
            this.txt_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TimKiem.Location = new System.Drawing.Point(705, 99);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(256, 27);
            this.txt_TimKiem.TabIndex = 24;
            // 
            // pan_Loai
            // 
            this.pan_Loai.AutoScroll = true;
            this.pan_Loai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan_Loai.Controls.Add(this.lbl_Loai);
            this.pan_Loai.Location = new System.Drawing.Point(705, 191);
            this.pan_Loai.Name = "pan_Loai";
            this.pan_Loai.Size = new System.Drawing.Size(309, 136);
            this.pan_Loai.TabIndex = 27;
            // 
            // lbl_Loai
            // 
            this.lbl_Loai.AutoSize = true;
            this.lbl_Loai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Loai.Location = new System.Drawing.Point(4, 4);
            this.lbl_Loai.Name = "lbl_Loai";
            this.lbl_Loai.Size = new System.Drawing.Size(42, 20);
            this.lbl_Loai.TabIndex = 0;
            this.lbl_Loai.Text = "Loại:";
            // 
            // pan_NhaCungCap
            // 
            this.pan_NhaCungCap.AutoScroll = true;
            this.pan_NhaCungCap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan_NhaCungCap.Controls.Add(this.lbl_NhaCungCap);
            this.pan_NhaCungCap.Location = new System.Drawing.Point(705, 448);
            this.pan_NhaCungCap.Name = "pan_NhaCungCap";
            this.pan_NhaCungCap.Size = new System.Drawing.Size(309, 248);
            this.pan_NhaCungCap.TabIndex = 29;
            // 
            // lbl_NhaCungCap
            // 
            this.lbl_NhaCungCap.AutoSize = true;
            this.lbl_NhaCungCap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NhaCungCap.Location = new System.Drawing.Point(4, 4);
            this.lbl_NhaCungCap.Name = "lbl_NhaCungCap";
            this.lbl_NhaCungCap.Size = new System.Drawing.Size(108, 20);
            this.lbl_NhaCungCap.TabIndex = 0;
            this.lbl_NhaCungCap.Text = "Nhà cung cấp:";
            // 
            // pan_KhoangGia
            // 
            this.pan_KhoangGia.AutoScroll = true;
            this.pan_KhoangGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan_KhoangGia.Controls.Add(this.label4);
            this.pan_KhoangGia.Controls.Add(this.lbl_Den);
            this.pan_KhoangGia.Controls.Add(this.txt_Tu);
            this.pan_KhoangGia.Controls.Add(this.lbl_Tu);
            this.pan_KhoangGia.Controls.Add(this.txt_Den);
            this.pan_KhoangGia.Location = new System.Drawing.Point(705, 342);
            this.pan_KhoangGia.Name = "pan_KhoangGia";
            this.pan_KhoangGia.Size = new System.Drawing.Size(309, 100);
            this.pan_KhoangGia.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Khoảng giá:";
            // 
            // lbl_Den
            // 
            this.lbl_Den.AutoSize = true;
            this.lbl_Den.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Den.Location = new System.Drawing.Point(20, 60);
            this.lbl_Den.Name = "lbl_Den";
            this.lbl_Den.Size = new System.Drawing.Size(37, 17);
            this.lbl_Den.TabIndex = 9;
            this.lbl_Den.Text = "Đến:";
            // 
            // txt_Tu
            // 
            this.txt_Tu.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Tu.Location = new System.Drawing.Point(67, 29);
            this.txt_Tu.Name = "txt_Tu";
            this.txt_Tu.Size = new System.Drawing.Size(165, 25);
            this.txt_Tu.TabIndex = 10;
            this.txt_Tu.Text = "0";
            this.txt_Tu.TextChanged += new System.EventHandler(this.txt_Tu_TextChanged);
            this.txt_Tu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Tu_KeyPress);
            // 
            // lbl_Tu
            // 
            this.lbl_Tu.AutoSize = true;
            this.lbl_Tu.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tu.Location = new System.Drawing.Point(20, 32);
            this.lbl_Tu.Name = "lbl_Tu";
            this.lbl_Tu.Size = new System.Drawing.Size(29, 17);
            this.lbl_Tu.TabIndex = 8;
            this.lbl_Tu.Text = "Từ:";
            // 
            // txt_Den
            // 
            this.txt_Den.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Den.Location = new System.Drawing.Point(67, 57);
            this.txt_Den.Name = "txt_Den";
            this.txt_Den.Size = new System.Drawing.Size(165, 25);
            this.txt_Den.TabIndex = 11;
            this.txt_Den.Text = "0";
            this.txt_Den.TextChanged += new System.EventHandler(this.txt_Den_TextChanged);
            this.txt_Den.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Den_KeyPress);
            // 
            // btn_BoLoc
            // 
            this.btn_BoLoc.BackColor = System.Drawing.Color.White;
            this.btn_BoLoc.Location = new System.Drawing.Point(967, 140);
            this.btn_BoLoc.Name = "btn_BoLoc";
            this.btn_BoLoc.Size = new System.Drawing.Size(47, 45);
            this.btn_BoLoc.TabIndex = 26;
            this.btn_BoLoc.UseVisualStyleBackColor = false;
            this.btn_BoLoc.Click += new System.EventHandler(this.btn_BoLoc_Click);
            // 
            // lbl_BoLoc
            // 
            this.lbl_BoLoc.AutoSize = true;
            this.lbl_BoLoc.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BoLoc.Location = new System.Drawing.Point(782, 147);
            this.lbl_BoLoc.Name = "lbl_BoLoc";
            this.lbl_BoLoc.Size = new System.Drawing.Size(144, 25);
            this.lbl_BoLoc.TabIndex = 25;
            this.lbl_BoLoc.Text = "Bộ lọc tìm kiếm";
            // 
            // lbl_ThanhTien
            // 
            this.lbl_ThanhTien.AutoSize = true;
            this.lbl_ThanhTien.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ThanhTien.Location = new System.Drawing.Point(1360, 140);
            this.lbl_ThanhTien.Name = "lbl_ThanhTien";
            this.lbl_ThanhTien.Size = new System.Drawing.Size(75, 17);
            this.lbl_ThanhTien.TabIndex = 39;
            this.lbl_ThanhTien.Text = "Thành tiền";
            // 
            // lbl_DonGia
            // 
            this.lbl_DonGia.AutoSize = true;
            this.lbl_DonGia.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DonGia.Location = new System.Drawing.Point(1268, 140);
            this.lbl_DonGia.Name = "lbl_DonGia";
            this.lbl_DonGia.Size = new System.Drawing.Size(57, 17);
            this.lbl_DonGia.TabIndex = 35;
            this.lbl_DonGia.Text = "Đơn giá";
            // 
            // lbl_SoLuong
            // 
            this.lbl_SoLuong.AutoSize = true;
            this.lbl_SoLuong.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SoLuong.Location = new System.Drawing.Point(1153, 140);
            this.lbl_SoLuong.Name = "lbl_SoLuong";
            this.lbl_SoLuong.Size = new System.Drawing.Size(64, 17);
            this.lbl_SoLuong.TabIndex = 37;
            this.lbl_SoLuong.Text = "Số lượng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1039, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "Sản phẩm";
            // 
            // pan_SanPhamThem
            // 
            this.pan_SanPhamThem.AutoScroll = true;
            this.pan_SanPhamThem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan_SanPhamThem.Location = new System.Drawing.Point(1020, 160);
            this.pan_SanPhamThem.Name = "pan_SanPhamThem";
            this.pan_SanPhamThem.Size = new System.Drawing.Size(464, 445);
            this.pan_SanPhamThem.TabIndex = 41;
            // 
            // lbl_SanPham
            // 
            this.lbl_SanPham.AutoSize = true;
            this.lbl_SanPham.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SanPham.Location = new System.Drawing.Point(1173, 96);
            this.lbl_SanPham.Name = "lbl_SanPham";
            this.lbl_SanPham.Size = new System.Drawing.Size(166, 25);
            this.lbl_SanPham.TabIndex = 30;
            this.lbl_SanPham.Text = "SẢN PHẨM THÊM";
            // 
            // btn_ThemSanPham
            // 
            this.btn_ThemSanPham.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_ThemSanPham.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemSanPham.ForeColor = System.Drawing.Color.White;
            this.btn_ThemSanPham.Location = new System.Drawing.Point(1285, 634);
            this.btn_ThemSanPham.Name = "btn_ThemSanPham";
            this.btn_ThemSanPham.Size = new System.Drawing.Size(186, 57);
            this.btn_ThemSanPham.TabIndex = 42;
            this.btn_ThemSanPham.Text = "Thêm vào hóa đơn";
            this.btn_ThemSanPham.UseVisualStyleBackColor = false;
            this.btn_ThemSanPham.Click += new System.EventHandler(this.btn_ThemSanPham_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Them.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.Color.White;
            this.btn_Them.Location = new System.Drawing.Point(1072, 634);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(186, 57);
            this.btn_Them.TabIndex = 43;
            this.btn_Them.Text = "Xóa tất cả";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // frm_DanhSachSanPhamBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1499, 774);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.btn_ThemSanPham);
            this.Controls.Add(this.lbl_ThanhTien);
            this.Controls.Add(this.lbl_DonGia);
            this.Controls.Add(this.lbl_SoLuong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pan_SanPhamThem);
            this.Controls.Add(this.lbl_SanPham);
            this.Controls.Add(this.pan_Loai);
            this.Controls.Add(this.pan_NhaCungCap);
            this.Controls.Add(this.pan_KhoangGia);
            this.Controls.Add(this.btn_BoLoc);
            this.Controls.Add(this.lbl_BoLoc);
            this.Controls.Add(this.btn_TimKiem);
            this.Controls.Add(this.txt_TimKiem);
            this.Controls.Add(this.lbl_SanPhamTrongKho);
            this.Controls.Add(this.dgv_DanhSachSanPham);
            this.Controls.Add(this.pan_DatHang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_DanhSachSanPhamBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_DanhSachSanPhamBan";
            this.Load += new System.EventHandler(this.frm_DanhSachSanPhamBan_Load);
            this.pan_DatHang.ResumeLayout(false);
            this.pan_DatHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachSanPham)).EndInit();
            this.pan_Loai.ResumeLayout(false);
            this.pan_Loai.PerformLayout();
            this.pan_NhaCungCap.ResumeLayout(false);
            this.pan_NhaCungCap.PerformLayout();
            this.pan_KhoangGia.ResumeLayout(false);
            this.pan_KhoangGia.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pan_DatHang;
        private System.Windows.Forms.Label lbl_DatHang;
        private System.Windows.Forms.Label lbl_SanPhamTrongKho;
        private System.Windows.Forms.DataGridView dgv_DanhSachSanPham;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.Panel pan_Loai;
        private System.Windows.Forms.Label lbl_Loai;
        private System.Windows.Forms.Panel pan_NhaCungCap;
        private System.Windows.Forms.Label lbl_NhaCungCap;
        private System.Windows.Forms.Panel pan_KhoangGia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_Den;
        private System.Windows.Forms.TextBox txt_Tu;
        private System.Windows.Forms.Label lbl_Tu;
        private System.Windows.Forms.TextBox txt_Den;
        private System.Windows.Forms.Button btn_BoLoc;
        private System.Windows.Forms.Label lbl_BoLoc;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Label lbl_ThanhTien;
        private System.Windows.Forms.Label lbl_DonGia;
        private System.Windows.Forms.Label lbl_SoLuong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pan_SanPhamThem;
        private System.Windows.Forms.Label lbl_SanPham;
        private System.Windows.Forms.Button btn_ThemSanPham;
        private System.Windows.Forms.Button btn_Them;
    }
}