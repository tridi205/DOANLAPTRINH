namespace QUANLYCUAHANG
{
    partial class frm_TichDiem
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
            this.pan_TichDiem = new System.Windows.Forms.Panel();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.lbl_DatHang = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.pan_TichDiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // pan_TichDiem
            // 
            this.pan_TichDiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(158)))), ((int)(((byte)(132)))));
            this.pan_TichDiem.Controls.Add(this.btnThoat);
            this.pan_TichDiem.Controls.Add(this.btn_Thoat);
            this.pan_TichDiem.Controls.Add(this.lbl_DatHang);
            this.pan_TichDiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan_TichDiem.Location = new System.Drawing.Point(0, 0);
            this.pan_TichDiem.Name = "pan_TichDiem";
            this.pan_TichDiem.Size = new System.Drawing.Size(800, 49);
            this.pan_TichDiem.TabIndex = 4;
            this.pan_TichDiem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pan_TichDiem_MouseDown);
            this.pan_TichDiem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pan_TichDiem_MouseMove);
            this.pan_TichDiem.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pan_TichDiem_MouseUp);
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
            // 
            // lbl_DatHang
            // 
            this.lbl_DatHang.AutoSize = true;
            this.lbl_DatHang.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DatHang.Location = new System.Drawing.Point(343, 9);
            this.lbl_DatHang.Name = "lbl_DatHang";
            this.lbl_DatHang.Size = new System.Drawing.Size(105, 25);
            this.lbl_DatHang.TabIndex = 0;
            this.lbl_DatHang.Text = "TÍCH ĐIỂM";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(158)))), ((int)(((byte)(132)))));
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Location = new System.Drawing.Point(756, 3);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(41, 39);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_TichDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pan_TichDiem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_TichDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_TichDiem";
            this.Load += new System.EventHandler(this.frm_TichDiem_Load);
            this.pan_TichDiem.ResumeLayout(false);
            this.pan_TichDiem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pan_TichDiem;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Label lbl_DatHang;
        private System.Windows.Forms.Button btnThoat;
    }
}