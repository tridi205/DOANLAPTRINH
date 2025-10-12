namespace QUANLYCUAHANG
{
    partial class frm_ThemNhanVien
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
            this.pan_ThemSanPham = new System.Windows.Forms.Panel();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.lbl_NhanVien = new System.Windows.Forms.Label();
            this.btn_HuyChinhSua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.rdb_Nu = new System.Windows.Forms.RadioButton();
            this.rdb_Nam = new System.Windows.Forms.RadioButton();
            this.dtp_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lbl_MatKhau = new System.Windows.Forms.Label();
            this.lbl_SDT = new System.Windows.Forms.Label();
            this.txt_MatKhau = new System.Windows.Forms.TextBox();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.txt_ChucVu = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.lbl_ChucVu = new System.Windows.Forms.Label();
            this.lbl_NgaySinh = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_DiaChi = new System.Windows.Forms.Label();
            this.pic_Anh = new System.Windows.Forms.PictureBox();
            this.txt_CCCD = new System.Windows.Forms.TextBox();
            this.btn_DoiAnh = new System.Windows.Forms.Button();
            this.lbl_MaNV = new System.Windows.Forms.Label();
            this.lbl_CCCD = new System.Windows.Forms.Label();
            this.txt_MaNV = new System.Windows.Forms.TextBox();
            this.lbl_GioiTinh = new System.Windows.Forms.Label();
            this.lbl_HoTen = new System.Windows.Forms.Label();
            this.txt_HoTen = new System.Windows.Forms.TextBox();
            this.pan_ThemSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Anh)).BeginInit();
            this.SuspendLayout();
            // 
            // pan_ThemSanPham
            // 
            this.pan_ThemSanPham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(158)))), ((int)(((byte)(132)))));
            this.pan_ThemSanPham.Controls.Add(this.btn_Exit);
            this.pan_ThemSanPham.Controls.Add(this.lbl_NhanVien);
            this.pan_ThemSanPham.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan_ThemSanPham.Location = new System.Drawing.Point(0, 0);
            this.pan_ThemSanPham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pan_ThemSanPham.Name = "pan_ThemSanPham";
            this.pan_ThemSanPham.Size = new System.Drawing.Size(979, 49);
            this.pan_ThemSanPham.TabIndex = 3;
            this.pan_ThemSanPham.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pan_ThemSanPham_MouseDown);
            this.pan_ThemSanPham.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pan_ThemSanPham_MouseMove);
            this.pan_ThemSanPham.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pan_ThemSanPham_MouseUp);
            // 
            // btn_Exit
            // 
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Location = new System.Drawing.Point(941, 3);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(35, 35);
            this.btn_Exit.TabIndex = 4;
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // lbl_NhanVien
            // 
            this.lbl_NhanVien.AutoSize = true;
            this.lbl_NhanVien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NhanVien.Location = new System.Drawing.Point(13, 10);
            this.lbl_NhanVien.Name = "lbl_NhanVien";
            this.lbl_NhanVien.Size = new System.Drawing.Size(188, 28);
            this.lbl_NhanVien.TabIndex = 0;
            this.lbl_NhanVien.Text = "THÊM NHÂN VIÊN";
            // 
            // btn_HuyChinhSua
            // 
            this.btn_HuyChinhSua.BackColor = System.Drawing.Color.Red;
            this.btn_HuyChinhSua.FlatAppearance.BorderSize = 0;
            this.btn_HuyChinhSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_HuyChinhSua.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HuyChinhSua.ForeColor = System.Drawing.Color.White;
            this.btn_HuyChinhSua.Location = new System.Drawing.Point(674, 269);
            this.btn_HuyChinhSua.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_HuyChinhSua.Name = "btn_HuyChinhSua";
            this.btn_HuyChinhSua.Size = new System.Drawing.Size(109, 57);
            this.btn_HuyChinhSua.TabIndex = 89;
            this.btn_HuyChinhSua.Text = "   Hủy";
            this.btn_HuyChinhSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_HuyChinhSua.UseVisualStyleBackColor = false;
            this.btn_HuyChinhSua.Click += new System.EventHandler(this.btn_HuyChinhSua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_Them.FlatAppearance.BorderSize = 0;
            this.btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Them.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.Color.White;
            this.btn_Them.Location = new System.Drawing.Point(800, 269);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(111, 57);
            this.btn_Them.TabIndex = 88;
            this.btn_Them.Text = "   Thêm";
            this.btn_Them.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // rdb_Nu
            // 
            this.rdb_Nu.AutoSize = true;
            this.rdb_Nu.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_Nu.Location = new System.Drawing.Point(462, 155);
            this.rdb_Nu.Name = "rdb_Nu";
            this.rdb_Nu.Size = new System.Drawing.Size(51, 24);
            this.rdb_Nu.TabIndex = 85;
            this.rdb_Nu.TabStop = true;
            this.rdb_Nu.Text = "Nữ";
            this.rdb_Nu.UseVisualStyleBackColor = true;
            // 
            // rdb_Nam
            // 
            this.rdb_Nam.AutoSize = true;
            this.rdb_Nam.Checked = true;
            this.rdb_Nam.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_Nam.Location = new System.Drawing.Point(357, 155);
            this.rdb_Nam.Name = "rdb_Nam";
            this.rdb_Nam.Size = new System.Drawing.Size(63, 24);
            this.rdb_Nam.TabIndex = 84;
            this.rdb_Nam.TabStop = true;
            this.rdb_Nam.Text = "Nam";
            this.rdb_Nam.UseVisualStyleBackColor = true;
            // 
            // dtp_NgaySinh
            // 
            this.dtp_NgaySinh.CalendarFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_NgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtp_NgaySinh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgaySinh.Location = new System.Drawing.Point(674, 151);
            this.dtp_NgaySinh.MaxDate = new System.DateTime(2025, 3, 28, 0, 0, 0, 0);
            this.dtp_NgaySinh.Name = "dtp_NgaySinh";
            this.dtp_NgaySinh.Size = new System.Drawing.Size(237, 27);
            this.dtp_NgaySinh.TabIndex = 83;
            this.dtp_NgaySinh.Value = new System.DateTime(2025, 3, 28, 0, 0, 0, 0);
            // 
            // lbl_MatKhau
            // 
            this.lbl_MatKhau.AutoSize = true;
            this.lbl_MatKhau.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MatKhau.Location = new System.Drawing.Point(596, 222);
            this.lbl_MatKhau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MatKhau.Name = "lbl_MatKhau";
            this.lbl_MatKhau.Size = new System.Drawing.Size(70, 17);
            this.lbl_MatKhau.TabIndex = 82;
            this.lbl_MatKhau.Text = "Mật khẩu:";
            // 
            // lbl_SDT
            // 
            this.lbl_SDT.AutoSize = true;
            this.lbl_SDT.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SDT.Location = new System.Drawing.Point(238, 222);
            this.lbl_SDT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_SDT.Name = "lbl_SDT";
            this.lbl_SDT.Size = new System.Drawing.Size(94, 17);
            this.lbl_SDT.TabIndex = 81;
            this.lbl_SDT.Text = "Số điện thoại:";
            // 
            // txt_MatKhau
            // 
            this.txt_MatKhau.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MatKhau.Location = new System.Drawing.Point(674, 217);
            this.txt_MatKhau.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.Size = new System.Drawing.Size(237, 27);
            this.txt_MatKhau.TabIndex = 80;
            this.txt_MatKhau.Text = "123";
            // 
            // txt_SDT
            // 
            this.txt_SDT.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SDT.Location = new System.Drawing.Point(347, 217);
            this.txt_SDT.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(237, 27);
            this.txt_SDT.TabIndex = 79;
            this.txt_SDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SDT_KeyPress);
            // 
            // txt_ChucVu
            // 
            this.txt_ChucVu.Enabled = false;
            this.txt_ChucVu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ChucVu.Location = new System.Drawing.Point(674, 185);
            this.txt_ChucVu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_ChucVu.Name = "txt_ChucVu";
            this.txt_ChucVu.Size = new System.Drawing.Size(237, 27);
            this.txt_ChucVu.TabIndex = 78;
            this.txt_ChucVu.Text = "Nhân viên";
            // 
            // txt_Email
            // 
            this.txt_Email.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Email.Location = new System.Drawing.Point(674, 116);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(237, 27);
            this.txt_Email.TabIndex = 77;
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DiaChi.Location = new System.Drawing.Point(674, 83);
            this.txt_DiaChi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(237, 27);
            this.txt_DiaChi.TabIndex = 76;
            // 
            // lbl_ChucVu
            // 
            this.lbl_ChucVu.AutoSize = true;
            this.lbl_ChucVu.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ChucVu.Location = new System.Drawing.Point(604, 190);
            this.lbl_ChucVu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ChucVu.Name = "lbl_ChucVu";
            this.lbl_ChucVu.Size = new System.Drawing.Size(62, 17);
            this.lbl_ChucVu.TabIndex = 75;
            this.lbl_ChucVu.Text = "Chức vụ:";
            // 
            // lbl_NgaySinh
            // 
            this.lbl_NgaySinh.AutoSize = true;
            this.lbl_NgaySinh.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NgaySinh.Location = new System.Drawing.Point(592, 155);
            this.lbl_NgaySinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_NgaySinh.Name = "lbl_NgaySinh";
            this.lbl_NgaySinh.Size = new System.Drawing.Size(74, 17);
            this.lbl_NgaySinh.TabIndex = 74;
            this.lbl_NgaySinh.Text = "Ngày sinh:";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.Location = new System.Drawing.Point(620, 121);
            this.lbl_Email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(46, 17);
            this.lbl_Email.TabIndex = 73;
            this.lbl_Email.Text = "Email:";
            // 
            // lbl_DiaChi
            // 
            this.lbl_DiaChi.AutoSize = true;
            this.lbl_DiaChi.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DiaChi.Location = new System.Drawing.Point(611, 88);
            this.lbl_DiaChi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_DiaChi.Name = "lbl_DiaChi";
            this.lbl_DiaChi.Size = new System.Drawing.Size(55, 17);
            this.lbl_DiaChi.TabIndex = 72;
            this.lbl_DiaChi.Text = "Địa chỉ:";
            // 
            // pic_Anh
            // 
            this.pic_Anh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic_Anh.Image = global::QUANLYCUAHANG.Properties.Resources.profile;
            this.pic_Anh.Location = new System.Drawing.Point(39, 76);
            this.pic_Anh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pic_Anh.Name = "pic_Anh";
            this.pic_Anh.Size = new System.Drawing.Size(161, 162);
            this.pic_Anh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Anh.TabIndex = 63;
            this.pic_Anh.TabStop = false;
            // 
            // txt_CCCD
            // 
            this.txt_CCCD.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CCCD.Location = new System.Drawing.Point(347, 185);
            this.txt_CCCD.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_CCCD.Name = "txt_CCCD";
            this.txt_CCCD.Size = new System.Drawing.Size(237, 27);
            this.txt_CCCD.TabIndex = 71;
            this.txt_CCCD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CCCD_KeyPress);
            // 
            // btn_DoiAnh
            // 
            this.btn_DoiAnh.AutoSize = true;
            this.btn_DoiAnh.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_DoiAnh.FlatAppearance.BorderSize = 0;
            this.btn_DoiAnh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DoiAnh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DoiAnh.ForeColor = System.Drawing.Color.White;
            this.btn_DoiAnh.Location = new System.Drawing.Point(39, 246);
            this.btn_DoiAnh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_DoiAnh.Name = "btn_DoiAnh";
            this.btn_DoiAnh.Size = new System.Drawing.Size(161, 45);
            this.btn_DoiAnh.TabIndex = 64;
            this.btn_DoiAnh.Text = "   Thêm ảnh";
            this.btn_DoiAnh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_DoiAnh.UseVisualStyleBackColor = false;
            this.btn_DoiAnh.Click += new System.EventHandler(this.btn_DoiAnh_Click);
            // 
            // lbl_MaNV
            // 
            this.lbl_MaNV.AutoSize = true;
            this.lbl_MaNV.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaNV.Location = new System.Drawing.Point(236, 87);
            this.lbl_MaNV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MaNV.Name = "lbl_MaNV";
            this.lbl_MaNV.Size = new System.Drawing.Size(96, 17);
            this.lbl_MaNV.TabIndex = 65;
            this.lbl_MaNV.Text = "Mã nhân viên:";
            // 
            // lbl_CCCD
            // 
            this.lbl_CCCD.AutoSize = true;
            this.lbl_CCCD.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CCCD.Location = new System.Drawing.Point(240, 190);
            this.lbl_CCCD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_CCCD.Name = "lbl_CCCD";
            this.lbl_CCCD.Size = new System.Drawing.Size(92, 17);
            this.lbl_CCCD.TabIndex = 70;
            this.lbl_CCCD.Text = "CCCD/CMND:";
            // 
            // txt_MaNV
            // 
            this.txt_MaNV.Enabled = false;
            this.txt_MaNV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaNV.Location = new System.Drawing.Point(347, 82);
            this.txt_MaNV.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_MaNV.Name = "txt_MaNV";
            this.txt_MaNV.Size = new System.Drawing.Size(237, 27);
            this.txt_MaNV.TabIndex = 66;
            // 
            // lbl_GioiTinh
            // 
            this.lbl_GioiTinh.AutoSize = true;
            this.lbl_GioiTinh.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GioiTinh.Location = new System.Drawing.Point(263, 158);
            this.lbl_GioiTinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_GioiTinh.Name = "lbl_GioiTinh";
            this.lbl_GioiTinh.Size = new System.Drawing.Size(66, 17);
            this.lbl_GioiTinh.TabIndex = 69;
            this.lbl_GioiTinh.Text = "Giới tính:";
            // 
            // lbl_HoTen
            // 
            this.lbl_HoTen.AutoSize = true;
            this.lbl_HoTen.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HoTen.Location = new System.Drawing.Point(258, 124);
            this.lbl_HoTen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_HoTen.Name = "lbl_HoTen";
            this.lbl_HoTen.Size = new System.Drawing.Size(72, 17);
            this.lbl_HoTen.TabIndex = 67;
            this.lbl_HoTen.Text = "Họ và tên:";
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HoTen.Location = new System.Drawing.Point(347, 116);
            this.txt_HoTen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Size = new System.Drawing.Size(237, 27);
            this.txt_HoTen.TabIndex = 68;
            // 
            // frm_ThemNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 395);
            this.Controls.Add(this.btn_HuyChinhSua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.rdb_Nu);
            this.Controls.Add(this.rdb_Nam);
            this.Controls.Add(this.dtp_NgaySinh);
            this.Controls.Add(this.lbl_MatKhau);
            this.Controls.Add(this.lbl_SDT);
            this.Controls.Add(this.txt_MatKhau);
            this.Controls.Add(this.txt_SDT);
            this.Controls.Add(this.txt_ChucVu);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.txt_DiaChi);
            this.Controls.Add(this.lbl_ChucVu);
            this.Controls.Add(this.lbl_NgaySinh);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.lbl_DiaChi);
            this.Controls.Add(this.pic_Anh);
            this.Controls.Add(this.txt_CCCD);
            this.Controls.Add(this.btn_DoiAnh);
            this.Controls.Add(this.lbl_MaNV);
            this.Controls.Add(this.lbl_CCCD);
            this.Controls.Add(this.txt_MaNV);
            this.Controls.Add(this.lbl_GioiTinh);
            this.Controls.Add(this.lbl_HoTen);
            this.Controls.Add(this.txt_HoTen);
            this.Controls.Add(this.pan_ThemSanPham);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_ThemNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_ThemNhanVien";
            this.Load += new System.EventHandler(this.frm_ThemNhanVien_Load);
            this.pan_ThemSanPham.ResumeLayout(false);
            this.pan_ThemSanPham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Anh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pan_ThemSanPham;
        private System.Windows.Forms.Label lbl_NhanVien;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_HuyChinhSua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.RadioButton rdb_Nu;
        private System.Windows.Forms.RadioButton rdb_Nam;
        private System.Windows.Forms.DateTimePicker dtp_NgaySinh;
        private System.Windows.Forms.Label lbl_MatKhau;
        private System.Windows.Forms.Label lbl_SDT;
        private System.Windows.Forms.TextBox txt_MatKhau;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.TextBox txt_ChucVu;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.Label lbl_ChucVu;
        private System.Windows.Forms.Label lbl_NgaySinh;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_DiaChi;
        private System.Windows.Forms.PictureBox pic_Anh;
        private System.Windows.Forms.TextBox txt_CCCD;
        private System.Windows.Forms.Button btn_DoiAnh;
        private System.Windows.Forms.Label lbl_MaNV;
        private System.Windows.Forms.Label lbl_CCCD;
        private System.Windows.Forms.TextBox txt_MaNV;
        private System.Windows.Forms.Label lbl_GioiTinh;
        private System.Windows.Forms.Label lbl_HoTen;
        private System.Windows.Forms.TextBox txt_HoTen;
    }
}