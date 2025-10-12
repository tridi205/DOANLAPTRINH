namespace QUANLYCUAHANG
{
    partial class frm_DanhSachSanPham
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.pan_DanhSachSanPham = new System.Windows.Forms.Panel();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.dgv_DanhSachSanPham = new System.Windows.Forms.DataGridView();
            this.lbl_BoLoc = new System.Windows.Forms.Label();
            this.btn_BoLoc = new System.Windows.Forms.Button();
            this.txt_Den = new System.Windows.Forms.TextBox();
            this.txt_Tu = new System.Windows.Forms.TextBox();
            this.lbl_Den = new System.Windows.Forms.Label();
            this.lbl_Tu = new System.Windows.Forms.Label();
            this.pan_BoLoc = new System.Windows.Forms.Panel();
            this.pan_NhaCungCap = new System.Windows.Forms.Panel();
            this.lbl_NhaCungCap = new System.Windows.Forms.Label();
            this.pan_KhoangGia = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pan_Loai = new System.Windows.Forms.Panel();
            this.lbl_Loai = new System.Windows.Forms.Label();
            this.pan_DanhSachSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachSanPham)).BeginInit();
            this.pan_BoLoc.SuspendLayout();
            this.pan_NhaCungCap.SuspendLayout();
            this.pan_KhoangGia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.pan_Loai.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH SẢN PHẨM";
            // 
            // pan_DanhSachSanPham
            // 
            this.pan_DanhSachSanPham.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pan_DanhSachSanPham.Controls.Add(this.btn_Them);
            this.pan_DanhSachSanPham.Controls.Add(this.btn_TimKiem);
            this.pan_DanhSachSanPham.Controls.Add(this.txt_TimKiem);
            this.pan_DanhSachSanPham.Controls.Add(this.label1);
            this.pan_DanhSachSanPham.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan_DanhSachSanPham.Location = new System.Drawing.Point(0, 0);
            this.pan_DanhSachSanPham.Name = "pan_DanhSachSanPham";
            this.pan_DanhSachSanPham.Size = new System.Drawing.Size(1098, 44);
            this.pan_DanhSachSanPham.TabIndex = 1;
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.White;
            this.btn_Them.Location = new System.Drawing.Point(1055, 3);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(40, 33);
            this.btn_Them.TabIndex = 5;
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.BackColor = System.Drawing.Color.White;
            this.btn_TimKiem.Location = new System.Drawing.Point(1009, 3);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(40, 33);
            this.btn_TimKiem.TabIndex = 3;
            this.btn_TimKiem.UseVisualStyleBackColor = false;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.BackColor = System.Drawing.Color.White;
            this.txt_TimKiem.Location = new System.Drawing.Point(808, 8);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(199, 22);
            this.txt_TimKiem.TabIndex = 4;
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
            this.dgv_DanhSachSanPham.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgv_DanhSachSanPham.Location = new System.Drawing.Point(0, 44);
            this.dgv_DanhSachSanPham.Name = "dgv_DanhSachSanPham";
            this.dgv_DanhSachSanPham.ReadOnly = true;
            this.dgv_DanhSachSanPham.RowHeadersWidth = 51;
            this.dgv_DanhSachSanPham.RowTemplate.Height = 24;
            this.dgv_DanhSachSanPham.Size = new System.Drawing.Size(805, 657);
            this.dgv_DanhSachSanPham.TabIndex = 2;
            this.dgv_DanhSachSanPham.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhSachSanPham_CellDoubleClick);
            // 
            // lbl_BoLoc
            // 
            this.lbl_BoLoc.AutoSize = true;
            this.lbl_BoLoc.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BoLoc.Location = new System.Drawing.Point(80, 17);
            this.lbl_BoLoc.Name = "lbl_BoLoc";
            this.lbl_BoLoc.Size = new System.Drawing.Size(144, 25);
            this.lbl_BoLoc.TabIndex = 0;
            this.lbl_BoLoc.Text = "Bộ lọc tìm kiếm";
            // 
            // btn_BoLoc
            // 
            this.btn_BoLoc.BackColor = System.Drawing.Color.White;
            this.btn_BoLoc.Location = new System.Drawing.Point(247, 10);
            this.btn_BoLoc.Name = "btn_BoLoc";
            this.btn_BoLoc.Size = new System.Drawing.Size(40, 33);
            this.btn_BoLoc.TabIndex = 4;
            this.btn_BoLoc.UseVisualStyleBackColor = false;
            this.btn_BoLoc.Click += new System.EventHandler(this.btn_BoLoc_Click);
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
            // pan_BoLoc
            // 
            this.pan_BoLoc.Controls.Add(this.pan_NhaCungCap);
            this.pan_BoLoc.Controls.Add(this.pan_KhoangGia);
            this.pan_BoLoc.Controls.Add(this.btn_BoLoc);
            this.pan_BoLoc.Controls.Add(this.lbl_BoLoc);
            this.pan_BoLoc.Dock = System.Windows.Forms.DockStyle.Right;
            this.pan_BoLoc.Location = new System.Drawing.Point(808, 44);
            this.pan_BoLoc.Name = "pan_BoLoc";
            this.pan_BoLoc.Size = new System.Drawing.Size(290, 657);
            this.pan_BoLoc.TabIndex = 3;
            this.pan_BoLoc.Paint += new System.Windows.Forms.PaintEventHandler(this.pan_BoLoc_Paint);
            // 
            // pan_NhaCungCap
            // 
            this.pan_NhaCungCap.AutoScroll = true;
            this.pan_NhaCungCap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan_NhaCungCap.Controls.Add(this.lbl_NhaCungCap);
            this.pan_NhaCungCap.Location = new System.Drawing.Point(3, 303);
            this.pan_NhaCungCap.Name = "pan_NhaCungCap";
            this.pan_NhaCungCap.Size = new System.Drawing.Size(284, 260);
            this.pan_NhaCungCap.TabIndex = 13;
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
            this.pan_KhoangGia.Location = new System.Drawing.Point(3, 197);
            this.pan_KhoangGia.Name = "pan_KhoangGia";
            this.pan_KhoangGia.Size = new System.Drawing.Size(284, 100);
            this.pan_KhoangGia.TabIndex = 12;
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
            // pan_Loai
            // 
            this.pan_Loai.AutoScroll = true;
            this.pan_Loai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan_Loai.Controls.Add(this.lbl_Loai);
            this.pan_Loai.Location = new System.Drawing.Point(811, 99);
            this.pan_Loai.Name = "pan_Loai";
            this.pan_Loai.Size = new System.Drawing.Size(284, 136);
            this.pan_Loai.TabIndex = 8;
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
            // frm_DanhSachSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 701);
            this.Controls.Add(this.pan_Loai);
            this.Controls.Add(this.pan_BoLoc);
            this.Controls.Add(this.dgv_DanhSachSanPham);
            this.Controls.Add(this.pan_DanhSachSanPham);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_DanhSachSanPham";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_SanPham_Load);
            this.pan_DanhSachSanPham.ResumeLayout(false);
            this.pan_DanhSachSanPham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachSanPham)).EndInit();
            this.pan_BoLoc.ResumeLayout(false);
            this.pan_BoLoc.PerformLayout();
            this.pan_NhaCungCap.ResumeLayout(false);
            this.pan_NhaCungCap.PerformLayout();
            this.pan_KhoangGia.ResumeLayout(false);
            this.pan_KhoangGia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.pan_Loai.ResumeLayout(false);
            this.pan_Loai.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pan_DanhSachSanPham;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.DataGridView dgv_DanhSachSanPham;
        private System.Windows.Forms.Label lbl_BoLoc;
        private System.Windows.Forms.Button btn_BoLoc;
        private System.Windows.Forms.Label lbl_Den;
        private System.Windows.Forms.Label lbl_Tu;
        private System.Windows.Forms.Panel pan_BoLoc;
        private System.Windows.Forms.TextBox txt_Den;
        private System.Windows.Forms.TextBox txt_Tu;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Panel pan_Loai;
        private System.Windows.Forms.Label lbl_Loai;
        private System.Windows.Forms.Panel pan_KhoangGia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pan_NhaCungCap;
        private System.Windows.Forms.Label lbl_NhaCungCap;
        private System.Windows.Forms.Button btn_Them;
    }
}