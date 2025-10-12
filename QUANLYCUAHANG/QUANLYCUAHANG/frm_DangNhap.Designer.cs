namespace QUANLYCUAHANG
{
    partial class frm_loginUI
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
            this.pan_tt = new System.Windows.Forms.Panel();
            this.chk_hienthimatkhau = new System.Windows.Forms.CheckBox();
            this.txt_mk = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tendn = new System.Windows.Forms.TextBox();
            this.btn_dangnhap = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pic_anh = new System.Windows.Forms.PictureBox();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.pan_tt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_anh)).BeginInit();
            this.SuspendLayout();
            // 
            // pan_tt
            // 
            this.pan_tt.BackColor = System.Drawing.Color.DarkKhaki;
            this.pan_tt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pan_tt.Controls.Add(this.chk_hienthimatkhau);
            this.pan_tt.Controls.Add(this.txt_mk);
            this.pan_tt.Controls.Add(this.label4);
            this.pan_tt.Controls.Add(this.label2);
            this.pan_tt.Controls.Add(this.txt_tendn);
            this.pan_tt.Controls.Add(this.btn_dangnhap);
            this.pan_tt.Controls.Add(this.label3);
            this.pan_tt.Controls.Add(this.label1);
            this.pan_tt.Location = new System.Drawing.Point(-3, 246);
            this.pan_tt.Margin = new System.Windows.Forms.Padding(4);
            this.pan_tt.Name = "pan_tt";
            this.pan_tt.Size = new System.Drawing.Size(675, 319);
            this.pan_tt.TabIndex = 1;
            // 
            // chk_hienthimatkhau
            // 
            this.chk_hienthimatkhau.AutoSize = true;
            this.chk_hienthimatkhau.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_hienthimatkhau.ForeColor = System.Drawing.SystemColors.Info;
            this.chk_hienthimatkhau.Location = new System.Drawing.Point(155, 178);
            this.chk_hienthimatkhau.Margin = new System.Windows.Forms.Padding(4);
            this.chk_hienthimatkhau.Name = "chk_hienthimatkhau";
            this.chk_hienthimatkhau.Size = new System.Drawing.Size(148, 24);
            this.chk_hienthimatkhau.TabIndex = 6;
            this.chk_hienthimatkhau.Text = "Hiển thị mật khẩu";
            this.chk_hienthimatkhau.UseVisualStyleBackColor = true;
            this.chk_hienthimatkhau.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txt_mk
            // 
            this.txt_mk.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mk.Location = new System.Drawing.Point(155, 126);
            this.txt_mk.Margin = new System.Windows.Forms.Padding(4);
            this.txt_mk.Name = "txt_mk";
            this.txt_mk.Size = new System.Drawing.Size(367, 39);
            this.txt_mk.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(151, 101);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mật Khẩu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(151, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mật Khẩu";
            // 
            // txt_tendn
            // 
            this.txt_tendn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tendn.Location = new System.Drawing.Point(155, 46);
            this.txt_tendn.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tendn.Name = "txt_tendn";
            this.txt_tendn.Size = new System.Drawing.Size(367, 39);
            this.txt_tendn.TabIndex = 3;
            this.txt_tendn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_tendn_KeyPress);
            // 
            // btn_dangnhap
            // 
            this.btn_dangnhap.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_dangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dangnhap.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_dangnhap.Location = new System.Drawing.Point(155, 207);
            this.btn_dangnhap.Margin = new System.Windows.Forms.Padding(4);
            this.btn_dangnhap.Name = "btn_dangnhap";
            this.btn_dangnhap.Size = new System.Drawing.Size(368, 53);
            this.btn_dangnhap.TabIndex = 2;
            this.btn_dangnhap.Text = "LOGIN";
            this.btn_dangnhap.UseVisualStyleBackColor = false;
            this.btn_dangnhap.Click += new System.EventHandler(this.btn_dangnhap_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(151, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã Nhân Viên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Nhân Viên:";
            // 
            // pic_anh
            // 
            this.pic_anh.Image = global::QUANLYCUAHANG.Properties.Resources._4015161_2899;
            this.pic_anh.Location = new System.Drawing.Point(-3, -6);
            this.pic_anh.Margin = new System.Windows.Forms.Padding(4);
            this.pic_anh.Name = "pic_anh";
            this.pic_anh.Size = new System.Drawing.Size(676, 257);
            this.pic_anh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_anh.TabIndex = 2;
            this.pic_anh.TabStop = false;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackColor = System.Drawing.Color.Transparent;
            this.btn_Thoat.FlatAppearance.BorderSize = 0;
            this.btn_Thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Thoat.Location = new System.Drawing.Point(627, 0);
            this.btn_Thoat.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(47, 43);
            this.btn_Thoat.TabIndex = 6;
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // frm_loginUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(673, 562);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.pic_anh);
            this.Controls.Add(this.pan_tt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_loginUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang đăng nhập";
            this.Load += new System.EventHandler(this.frm_loginUI_Load);
            this.pan_tt.ResumeLayout(false);
            this.pan_tt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_anh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pan_tt;
        private System.Windows.Forms.PictureBox pic_anh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tendn;
        private System.Windows.Forms.Button btn_dangnhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_mk;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chk_hienthimatkhau;
    }
}