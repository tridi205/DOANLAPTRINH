namespace QUANLYCUAHANG
{
    partial class frm_HoaDon
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
            this.lbl_MAHD = new System.Windows.Forms.Label();
            this.lbl_TongTien = new System.Windows.Forms.Label();
            this.lbl_NgayLap = new System.Windows.Forms.Label();
            this.btn_TrangThai = new System.Windows.Forms.Button();
            this.btn_ChiTiet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_MAHD
            // 
            this.lbl_MAHD.AutoSize = true;
            this.lbl_MAHD.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MAHD.Location = new System.Drawing.Point(12, 16);
            this.lbl_MAHD.Name = "lbl_MAHD";
            this.lbl_MAHD.Size = new System.Drawing.Size(51, 20);
            this.lbl_MAHD.TabIndex = 0;
            this.lbl_MAHD.Text = "label1";
            // 
            // lbl_TongTien
            // 
            this.lbl_TongTien.AutoSize = true;
            this.lbl_TongTien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TongTien.Location = new System.Drawing.Point(143, 16);
            this.lbl_TongTien.Name = "lbl_TongTien";
            this.lbl_TongTien.Size = new System.Drawing.Size(51, 20);
            this.lbl_TongTien.TabIndex = 1;
            this.lbl_TongTien.Text = "label1";
            // 
            // lbl_NgayLap
            // 
            this.lbl_NgayLap.AutoSize = true;
            this.lbl_NgayLap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NgayLap.Location = new System.Drawing.Point(280, 16);
            this.lbl_NgayLap.Name = "lbl_NgayLap";
            this.lbl_NgayLap.Size = new System.Drawing.Size(51, 20);
            this.lbl_NgayLap.TabIndex = 2;
            this.lbl_NgayLap.Text = "label1";
            // 
            // btn_TrangThai
            // 
            this.btn_TrangThai.BackColor = System.Drawing.Color.Red;
            this.btn_TrangThai.Enabled = false;
            this.btn_TrangThai.FlatAppearance.BorderSize = 0;
            this.btn_TrangThai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TrangThai.ForeColor = System.Drawing.Color.White;
            this.btn_TrangThai.Location = new System.Drawing.Point(466, 6);
            this.btn_TrangThai.Name = "btn_TrangThai";
            this.btn_TrangThai.Size = new System.Drawing.Size(94, 34);
            this.btn_TrangThai.TabIndex = 3;
            this.btn_TrangThai.Text = "Đã hủy";
            this.btn_TrangThai.UseVisualStyleBackColor = false;
            this.btn_TrangThai.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_ChiTiet
            // 
            this.btn_ChiTiet.FlatAppearance.BorderSize = 0;
            this.btn_ChiTiet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChiTiet.Location = new System.Drawing.Point(591, 6);
            this.btn_ChiTiet.Name = "btn_ChiTiet";
            this.btn_ChiTiet.Size = new System.Drawing.Size(91, 34);
            this.btn_ChiTiet.TabIndex = 4;
            this.btn_ChiTiet.Text = "Chi tiết";
            this.btn_ChiTiet.UseVisualStyleBackColor = true;
            this.btn_ChiTiet.Click += new System.EventHandler(this.btn_ChiTiet_Click);
            // 
            // frm_HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(694, 58);
            this.Controls.Add(this.btn_ChiTiet);
            this.Controls.Add(this.btn_TrangThai);
            this.Controls.Add(this.lbl_NgayLap);
            this.Controls.Add(this.lbl_TongTien);
            this.Controls.Add(this.lbl_MAHD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_HoaDon";
            this.Text = "frm_HoaDon";
            this.Load += new System.EventHandler(this.frm_HoaDon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_MAHD;
        private System.Windows.Forms.Label lbl_TongTien;
        private System.Windows.Forms.Label lbl_NgayLap;
        private System.Windows.Forms.Button btn_TrangThai;
        private System.Windows.Forms.Button btn_ChiTiet;
    }
}