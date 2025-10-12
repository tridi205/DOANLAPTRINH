using BLL;
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
    public partial class frm_ChiTietSanPhamDat : Form
    {
        DonDatHang dh=new DonDatHang();
        SanPham sp=new SanPham();
        public frm_ChiTietSanPhamDat(DonDatHang dh,SanPham sp)
        {
            InitializeComponent();
            this.sp = sp;
            this.dh = dh;
            lbl_MaDH.Text=dh.mahd.ToString();
            lbl_SanPham.Text=sp.maSP.ToString()+"\n"+sp.tenSP.ToString();
            lbl_SoLuong.Text=sp.soLuong.ToString(); 
            lbl_GiaNhap.Text=sp.donGia.ToString("C", new System.Globalization.CultureInfo("vi-VN"));
            lbl_ThanhTien.Text=sp.thanhtien.ToString("C", new System.Globalization.CultureInfo("vi-VN"));
        }

        private void frm_ChiTietSanPhamDat_Load(object sender, EventArgs e)
        {

        }
        public SanPham getSP()
        {
            return sp;
        }
      
        public void setchk_SoLuongDu(bool chk)
        {
            chk_NhanDU.Checked = chk;
        }
        public void setSLSP()
        {
            txt_SoLuong.Text = sp.soLuong.ToString();
        }
        public void setSLSPVe0()
        {
            txt_SoLuong.Text = 0.ToString();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_NhanDU.Checked)
            {
                txt_SoLuong.Text = sp.soLuong.ToString();
            }
            
        }

        private void txt_SoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Không cho nhập
            }
        }

        private void txt_SoLuong_TextChanged(object sender, EventArgs e)
        {
            if (txt_SoLuong.Text == "")
            {
                txt_SoLuong.Text = "0";
                return;
            }
            if (Convert.ToInt32( txt_SoLuong.Text) >= sp.soLuong)
            {
                chk_NhanDU.Checked=true;
            }
            else
            {
                chk_NhanDU.Checked=false;
            }
        }
    }
}
