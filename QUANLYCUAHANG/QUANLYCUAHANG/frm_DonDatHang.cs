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
    public partial class frm_DonDatHang : Form
    {
        DonDatHang DonDatHang=new DonDatHang();
        public frm_DonDatHang(DonDatHang dh)
        {
            InitializeComponent();
            this.DonDatHang = dh;
            lbl_MaDH.Text=dh.mahd.ToString();
            lbl_NgayDat.Text=dh.ngaydat.ToString();
            lbl_TongTien.Text=dh.tongtien.ToString("C", new System.Globalization.CultureInfo("vi-VN"));
            lbl_SoLuong.Text=dh.soluong.ToString();
            if (dh.trangthai == 2)
            {
                btn_TrangThai.BackColor = Color.Blue;
                btn_TrangThai.Text = "Đã nhận";
            }
        }

        private void frm_DonDatHang_Load(object sender, EventArgs e)
        {

        }

        private void btn_ChiTiet_Click(object sender, EventArgs e)
        {
            frm_ChiTietDonDatHang frm_ChiTietDonDatHang=new frm_ChiTietDonDatHang(DonDatHang);
            frm_ChiTietDonDatHang.FormClosed += Frm_ChiTietDonDatHang_FormClosed;
            frm_ChiTietDonDatHang.ShowDialog();
        }

        private void Frm_ChiTietDonDatHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
