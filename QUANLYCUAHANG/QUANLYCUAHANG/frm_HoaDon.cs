using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYCUAHANG
{
    public partial class frm_HoaDon : Form
    {
        HoaDon hd=new HoaDon();
        public frm_HoaDon(HoaDon hd)
        {
            InitializeComponent();
            this.hd = hd;
            lbl_MAHD.Text= hd.mahd.ToString();
            lbl_NgayLap.Text=hd.ngaylap.ToString();
            lbl_TongTien.Text=hd.tongtien.ToString("C", new System.Globalization.CultureInfo("vi-VN"));
            if (this.hd.trangthai == 1)
            {
                btn_TrangThai.Text = "Đã thanh toán";
                btn_TrangThai.BackColor = Color.Blue;
            }
        }

        private void frm_HoaDon_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(lbl_TongTien.Text);
        }

        private void btn_ChiTiet_Click(object sender, EventArgs e)
        {
            frm_ChiTietHoaDon frm_ChiTietHoaDon =new frm_ChiTietHoaDon(hd);
            frm_ChiTietHoaDon.FormClosed += Frm_ChiTietHoaDon_FormClosed;
            frm_ChiTietHoaDon.ShowDialog();
        }

        private void Frm_ChiTietHoaDon_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form frm=sender as Form;
            if (frm.Text.Equals("yes"))
            {
                this.Close();
            }
        }
    }
}
