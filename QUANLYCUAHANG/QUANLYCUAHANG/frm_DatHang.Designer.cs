namespace QUANLYCUAHANG
{
    partial class frm_DatHang
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
            this.lbl_DatHang = new System.Windows.Forms.Label();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.lbl_DonDatHang = new System.Windows.Forms.Label();
            this.btn_HuyDon = new System.Windows.Forms.Button();
            this.btn_DatHang = new System.Windows.Forms.Button();
            this.lbl_TongTien = new System.Windows.Forms.Label();
            this.txt_TongTien = new System.Windows.Forms.TextBox();
            this.lbl_TongSoLuong = new System.Windows.Forms.Label();
            this.txt_SoLuong = new System.Windows.Forms.TextBox();
            this.pan_DonDatHang = new System.Windows.Forms.Panel();
            this.lbl_ThanhTien = new System.Windows.Forms.Label();
            this.lbl_SoLuong = new System.Windows.Forms.Label();
            this.lbl_DonGia = new System.Windows.Forms.Label();
            this.lbl_SanPham = new System.Windows.Forms.Label();
            this.dgv_DanhSachSanPham = new System.Windows.Forms.DataGridView();
            this.lbl_SanPhamNhaCungCap = new System.Windows.Forms.Label();
            this.lbl_BoLoc = new System.Windows.Forms.Label();
            this.btn_BoLoc = new System.Windows.Forms.Button();
            this.pan_BoLoc = new System.Windows.Forms.Panel();
            this.pan_NhaCungCap = new System.Windows.Forms.Panel();
            this.lbl_NhaCungCap = new System.Windows.Forms.Label();
            this.pan_KhoangGia = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_Den = new System.Windows.Forms.Label();
            this.txt_Tu = new System.Windows.Forms.TextBox();
            this.lbl_Tu = new System.Windows.Forms.Label();
            this.txt_Den = new System.Windows.Forms.TextBox();
            this.pan_Loai = new System.Windows.Forms.Panel();
            this.lbl_Loai = new System.Windows.Forms.Label();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_LichSuDatHang = new System.Windows.Forms.Button();
            this.pan_DatHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachSanPham)).BeginInit();
            this.pan_BoLoc.SuspendLayout();
            this.pan_NhaCungCap.SuspendLayout();
            this.pan_KhoangGia.SuspendLayout();
            this.pan_Loai.SuspendLayout();
            this.SuspendLayout();
            // 
            // pan_DatHang
            // 
            this.pan_DatHang.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pan_DatHang.Controls.Add(this.lbl_DatHang);
            this.pan_DatHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan_DatHang.Location = new System.Drawing.Point(0, 0);
            this.pan_DatHang.Name = "pan_DatHang";
            this.pan_DatHang.Size = new System.Drawing.Size(1098, 49);
            this.pan_DatHang.TabIndex = 2;
            // 
            // lbl_DatHang
            // 
            this.lbl_DatHang.AutoSize = true;
            this.lbl_DatHang.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DatHang.Location = new System.Drawing.Point(12, 13);
            this.lbl_DatHang.Name = "lbl_DatHang";
            this.lbl_DatHang.Size = new System.Drawing.Size(100, 23);
            this.lbl_DatHang.TabIndex = 0;
            this.lbl_DatHang.Text = "ĐẶT HÀNG";
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Location = new System.Drawing.Point(582, 55);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(40, 33);
            this.btn_TimKiem.TabIndex = 3;
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Location = new System.Drawing.Point(356, 60);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(220, 22);
            this.txt_TimKiem.TabIndex = 4;
            // 
            // lbl_DonDatHang
            // 
            this.lbl_DonDatHang.AutoSize = true;
            this.lbl_DonDatHang.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DonDatHang.Location = new System.Drawing.Point(796, 60);
            this.lbl_DonDatHang.Name = "lbl_DonDatHang";
            this.lbl_DonDatHang.Size = new System.Drawing.Size(154, 25);
            this.lbl_DonDatHang.TabIndex = 5;
            this.lbl_DonDatHang.Text = "ĐƠN ĐẶT HÀNG";
            // 
            // btn_HuyDon
            // 
            this.btn_HuyDon.BackColor = System.Drawing.Color.IndianRed;
            this.btn_HuyDon.Enabled = false;
            this.btn_HuyDon.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HuyDon.ForeColor = System.Drawing.Color.White;
            this.btn_HuyDon.Location = new System.Drawing.Point(801, 534);
            this.btn_HuyDon.Name = "btn_HuyDon";
            this.btn_HuyDon.Size = new System.Drawing.Size(109, 47);
            this.btn_HuyDon.TabIndex = 8;
            this.btn_HuyDon.Text = "Hủy đơn";
            this.btn_HuyDon.UseVisualStyleBackColor = false;
            this.btn_HuyDon.Click += new System.EventHandler(this.btn_HuyDon_Click);
            // 
            // btn_DatHang
            // 
            this.btn_DatHang.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_DatHang.Enabled = false;
            this.btn_DatHang.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DatHang.ForeColor = System.Drawing.Color.White;
            this.btn_DatHang.Location = new System.Drawing.Point(938, 534);
            this.btn_DatHang.Name = "btn_DatHang";
            this.btn_DatHang.Size = new System.Drawing.Size(109, 47);
            this.btn_DatHang.TabIndex = 9;
            this.btn_DatHang.Text = "Đặt hàng";
            this.btn_DatHang.UseVisualStyleBackColor = false;
            this.btn_DatHang.Click += new System.EventHandler(this.btn_DatHang_Click);
            // 
            // lbl_TongTien
            // 
            this.lbl_TongTien.AutoSize = true;
            this.lbl_TongTien.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TongTien.Location = new System.Drawing.Point(751, 455);
            this.lbl_TongTien.Name = "lbl_TongTien";
            this.lbl_TongTien.Size = new System.Drawing.Size(92, 23);
            this.lbl_TongTien.TabIndex = 12;
            this.lbl_TongTien.Text = "Tổng tiền:";
            // 
            // txt_TongTien
            // 
            this.txt_TongTien.Enabled = false;
            this.txt_TongTien.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TongTien.Location = new System.Drawing.Point(849, 452);
            this.txt_TongTien.Name = "txt_TongTien";
            this.txt_TongTien.Size = new System.Drawing.Size(198, 30);
            this.txt_TongTien.TabIndex = 14;
            this.txt_TongTien.Text = "0";
            // 
            // lbl_TongSoLuong
            // 
            this.lbl_TongSoLuong.AutoSize = true;
            this.lbl_TongSoLuong.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TongSoLuong.Location = new System.Drawing.Point(755, 491);
            this.lbl_TongSoLuong.Name = "lbl_TongSoLuong";
            this.lbl_TongSoLuong.Size = new System.Drawing.Size(88, 23);
            this.lbl_TongSoLuong.TabIndex = 15;
            this.lbl_TongSoLuong.Text = "Số lượng:";
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.Enabled = false;
            this.txt_SoLuong.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SoLuong.Location = new System.Drawing.Point(849, 488);
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.Size = new System.Drawing.Size(198, 30);
            this.txt_SoLuong.TabIndex = 16;
            this.txt_SoLuong.Text = "0";
            this.txt_SoLuong.TextChanged += new System.EventHandler(this.txt_SoLuong_TextChanged);
            // 
            // pan_DonDatHang
            // 
            this.pan_DonDatHang.AutoScroll = true;
            this.pan_DonDatHang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan_DonDatHang.Enabled = false;
            this.pan_DonDatHang.Location = new System.Drawing.Point(629, 120);
            this.pan_DonDatHang.Name = "pan_DonDatHang";
            this.pan_DonDatHang.Size = new System.Drawing.Size(457, 319);
            this.pan_DonDatHang.TabIndex = 17;
            this.pan_DonDatHang.Paint += new System.Windows.Forms.PaintEventHandler(this.pan_DonDatHang_Paint);
            this.pan_DonDatHang.MouseLeave += new System.EventHandler(this.pan_DonDatHang_MouseLeave);
            // 
            // lbl_ThanhTien
            // 
            this.lbl_ThanhTien.AutoSize = true;
            this.lbl_ThanhTien.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ThanhTien.Location = new System.Drawing.Point(983, 100);
            this.lbl_ThanhTien.Name = "lbl_ThanhTien";
            this.lbl_ThanhTien.Size = new System.Drawing.Size(75, 17);
            this.lbl_ThanhTien.TabIndex = 16;
            this.lbl_ThanhTien.Text = "Thành tiền";
            // 
            // lbl_SoLuong
            // 
            this.lbl_SoLuong.AutoSize = true;
            this.lbl_SoLuong.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SoLuong.Location = new System.Drawing.Point(779, 100);
            this.lbl_SoLuong.Name = "lbl_SoLuong";
            this.lbl_SoLuong.Size = new System.Drawing.Size(64, 17);
            this.lbl_SoLuong.TabIndex = 15;
            this.lbl_SoLuong.Text = "Số lượng";
            // 
            // lbl_DonGia
            // 
            this.lbl_DonGia.AutoSize = true;
            this.lbl_DonGia.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DonGia.Location = new System.Drawing.Point(893, 100);
            this.lbl_DonGia.Name = "lbl_DonGia";
            this.lbl_DonGia.Size = new System.Drawing.Size(57, 17);
            this.lbl_DonGia.TabIndex = 14;
            this.lbl_DonGia.Text = "Đơn giá";
            // 
            // lbl_SanPham
            // 
            this.lbl_SanPham.AutoSize = true;
            this.lbl_SanPham.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SanPham.Location = new System.Drawing.Point(632, 100);
            this.lbl_SanPham.Name = "lbl_SanPham";
            this.lbl_SanPham.Size = new System.Drawing.Size(69, 17);
            this.lbl_SanPham.TabIndex = 13;
            this.lbl_SanPham.Text = "Sản phẩm";
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
            this.dgv_DanhSachSanPham.Location = new System.Drawing.Point(12, 94);
            this.dgv_DanhSachSanPham.Name = "dgv_DanhSachSanPham";
            this.dgv_DanhSachSanPham.ReadOnly = true;
            this.dgv_DanhSachSanPham.RowHeadersWidth = 51;
            this.dgv_DanhSachSanPham.RowTemplate.Height = 24;
            this.dgv_DanhSachSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DanhSachSanPham.Size = new System.Drawing.Size(342, 487);
            this.dgv_DanhSachSanPham.TabIndex = 19;
            this.dgv_DanhSachSanPham.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhSachSanPham_CellDoubleClick);
            // 
            // lbl_SanPhamNhaCungCap
            // 
            this.lbl_SanPhamNhaCungCap.AutoSize = true;
            this.lbl_SanPhamNhaCungCap.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SanPhamNhaCungCap.Location = new System.Drawing.Point(12, 62);
            this.lbl_SanPhamNhaCungCap.Name = "lbl_SanPhamNhaCungCap";
            this.lbl_SanPhamNhaCungCap.Size = new System.Drawing.Size(293, 25);
            this.lbl_SanPhamNhaCungCap.TabIndex = 20;
            this.lbl_SanPhamNhaCungCap.Text = "SẢN PHẨM CỦA NHÀ CUNG CẤP";
            // 
            // lbl_BoLoc
            // 
            this.lbl_BoLoc.AutoSize = true;
            this.lbl_BoLoc.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BoLoc.Location = new System.Drawing.Point(49, 10);
            this.lbl_BoLoc.Name = "lbl_BoLoc";
            this.lbl_BoLoc.Size = new System.Drawing.Size(144, 25);
            this.lbl_BoLoc.TabIndex = 0;
            this.lbl_BoLoc.Text = "Bộ lọc tìm kiếm";
            // 
            // btn_BoLoc
            // 
            this.btn_BoLoc.BackColor = System.Drawing.Color.White;
            this.btn_BoLoc.Location = new System.Drawing.Point(226, 9);
            this.btn_BoLoc.Name = "btn_BoLoc";
            this.btn_BoLoc.Size = new System.Drawing.Size(40, 33);
            this.btn_BoLoc.TabIndex = 4;
            this.btn_BoLoc.UseVisualStyleBackColor = false;
            this.btn_BoLoc.Click += new System.EventHandler(this.btn_BoLoc_Click);
            // 
            // pan_BoLoc
            // 
            this.pan_BoLoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan_BoLoc.Controls.Add(this.pan_NhaCungCap);
            this.pan_BoLoc.Controls.Add(this.pan_KhoangGia);
            this.pan_BoLoc.Controls.Add(this.pan_Loai);
            this.pan_BoLoc.Controls.Add(this.btn_BoLoc);
            this.pan_BoLoc.Controls.Add(this.lbl_BoLoc);
            this.pan_BoLoc.Location = new System.Drawing.Point(356, 94);
            this.pan_BoLoc.Name = "pan_BoLoc";
            this.pan_BoLoc.Size = new System.Drawing.Size(270, 487);
            this.pan_BoLoc.TabIndex = 18;
            // 
            // pan_NhaCungCap
            // 
            this.pan_NhaCungCap.AutoScroll = true;
            this.pan_NhaCungCap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan_NhaCungCap.Controls.Add(this.lbl_NhaCungCap);
            this.pan_NhaCungCap.Location = new System.Drawing.Point(3, 276);
            this.pan_NhaCungCap.Name = "pan_NhaCungCap";
            this.pan_NhaCungCap.Size = new System.Drawing.Size(262, 206);
            this.pan_NhaCungCap.TabIndex = 14;
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
            this.pan_KhoangGia.Controls.Add(this.label9);
            this.pan_KhoangGia.Controls.Add(this.lbl_Den);
            this.pan_KhoangGia.Controls.Add(this.txt_Tu);
            this.pan_KhoangGia.Controls.Add(this.lbl_Tu);
            this.pan_KhoangGia.Controls.Add(this.txt_Den);
            this.pan_KhoangGia.Location = new System.Drawing.Point(3, 170);
            this.pan_KhoangGia.Name = "pan_KhoangGia";
            this.pan_KhoangGia.Size = new System.Drawing.Size(263, 100);
            this.pan_KhoangGia.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(4, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Khoảng giá:";
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
            this.txt_Tu.Location = new System.Drawing.Point(55, 29);
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
            this.txt_Den.Location = new System.Drawing.Point(55, 57);
            this.txt_Den.Name = "txt_Den";
            this.txt_Den.Size = new System.Drawing.Size(165, 25);
            this.txt_Den.TabIndex = 11;
            this.txt_Den.Text = "0";
            this.txt_Den.TextChanged += new System.EventHandler(this.txt_Den_TextChanged);
            this.txt_Den.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Den_KeyPress);
            // 
            // pan_Loai
            // 
            this.pan_Loai.AutoScroll = true;
            this.pan_Loai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan_Loai.Controls.Add(this.lbl_Loai);
            this.pan_Loai.Location = new System.Drawing.Point(3, 48);
            this.pan_Loai.Name = "pan_Loai";
            this.pan_Loai.Size = new System.Drawing.Size(263, 116);
            this.pan_Loai.TabIndex = 9;
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
            // btn_Luu
            // 
            this.btn_Luu.BackColor = System.Drawing.Color.Yellow;
            this.btn_Luu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luu.ForeColor = System.Drawing.Color.Silver;
            this.btn_Luu.Location = new System.Drawing.Point(663, 534);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(109, 47);
            this.btn_Luu.TabIndex = 21;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = false;
            this.btn_Luu.Visible = false;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_LichSuDatHang
            // 
            this.btn_LichSuDatHang.BackColor = System.Drawing.SystemColors.Control;
            this.btn_LichSuDatHang.FlatAppearance.BorderSize = 0;
            this.btn_LichSuDatHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LichSuDatHang.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LichSuDatHang.ForeColor = System.Drawing.Color.Black;
            this.btn_LichSuDatHang.Location = new System.Drawing.Point(1050, 49);
            this.btn_LichSuDatHang.Name = "btn_LichSuDatHang";
            this.btn_LichSuDatHang.Size = new System.Drawing.Size(48, 41);
            this.btn_LichSuDatHang.TabIndex = 22;
            this.btn_LichSuDatHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_LichSuDatHang.UseVisualStyleBackColor = false;
            this.btn_LichSuDatHang.Click += new System.EventHandler(this.btn_LichSuDatHang_Click);
            // 
            // frm_DatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 701);
            this.Controls.Add(this.btn_LichSuDatHang);
            this.Controls.Add(this.lbl_ThanhTien);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.lbl_DonGia);
            this.Controls.Add(this.lbl_SoLuong);
            this.Controls.Add(this.lbl_SanPhamNhaCungCap);
            this.Controls.Add(this.dgv_DanhSachSanPham);
            this.Controls.Add(this.lbl_SanPham);
            this.Controls.Add(this.pan_BoLoc);
            this.Controls.Add(this.pan_DonDatHang);
            this.Controls.Add(this.txt_SoLuong);
            this.Controls.Add(this.lbl_TongSoLuong);
            this.Controls.Add(this.txt_TongTien);
            this.Controls.Add(this.lbl_TongTien);
            this.Controls.Add(this.btn_DatHang);
            this.Controls.Add(this.btn_HuyDon);
            this.Controls.Add(this.lbl_DonDatHang);
            this.Controls.Add(this.btn_TimKiem);
            this.Controls.Add(this.pan_DatHang);
            this.Controls.Add(this.txt_TimKiem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_DatHang";
            this.Text = "frm_DatHang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_DatHang_Load);
            this.MouseLeave += new System.EventHandler(this.frm_DatHang_MouseLeave);
            this.pan_DatHang.ResumeLayout(false);
            this.pan_DatHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachSanPham)).EndInit();
            this.pan_BoLoc.ResumeLayout(false);
            this.pan_BoLoc.PerformLayout();
            this.pan_NhaCungCap.ResumeLayout(false);
            this.pan_NhaCungCap.PerformLayout();
            this.pan_KhoangGia.ResumeLayout(false);
            this.pan_KhoangGia.PerformLayout();
            this.pan_Loai.ResumeLayout(false);
            this.pan_Loai.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pan_DatHang;
        private System.Windows.Forms.Label lbl_DatHang;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.Label lbl_DonDatHang;
        private System.Windows.Forms.Button btn_HuyDon;
        private System.Windows.Forms.Button btn_DatHang;
        private System.Windows.Forms.Label lbl_TongTien;
        private System.Windows.Forms.TextBox txt_TongTien;
        private System.Windows.Forms.Label lbl_TongSoLuong;
        private System.Windows.Forms.TextBox txt_SoLuong;
        private System.Windows.Forms.Panel pan_DonDatHang;
        private System.Windows.Forms.Label lbl_SoLuong;
        private System.Windows.Forms.Label lbl_DonGia;
        private System.Windows.Forms.Label lbl_SanPham;
        private System.Windows.Forms.Label lbl_ThanhTien;
        private System.Windows.Forms.DataGridView dgv_DanhSachSanPham;
        private System.Windows.Forms.Label lbl_SanPhamNhaCungCap;
        private System.Windows.Forms.Label lbl_BoLoc;
        private System.Windows.Forms.Button btn_BoLoc;
        private System.Windows.Forms.Panel pan_BoLoc;
        private System.Windows.Forms.Panel pan_Loai;
        private System.Windows.Forms.Label lbl_Loai;
        private System.Windows.Forms.Panel pan_KhoangGia;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_Den;
        private System.Windows.Forms.TextBox txt_Tu;
        private System.Windows.Forms.Label lbl_Tu;
        private System.Windows.Forms.TextBox txt_Den;
        private System.Windows.Forms.Panel pan_NhaCungCap;
        private System.Windows.Forms.Label lbl_NhaCungCap;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_LichSuDatHang;
    }
}