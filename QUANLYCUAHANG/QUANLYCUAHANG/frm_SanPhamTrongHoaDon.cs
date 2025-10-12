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
    public partial class frm_SanPhamTrongHoaDon : Form
    {
        SanPham sp= new SanPham();
        public frm_SanPhamTrongHoaDon(SanPham sp)
        {
            InitializeComponent();
            this.sp = sp;
            lbl_SanPham.Text = sp.maSP.ToString() +"\n"+ sp.tenSP;
            lbl_SoLuong.Text=sp.soLuong.ToString();
            lbl_DonGia.Text=sp.donGia.ToString("C", new System.Globalization.CultureInfo("vi-VN"));
            lbl_ThanhTien.Text=sp.thanhtien.ToString("C", new System.Globalization.CultureInfo("vi-VN"));
            //ToString("C", new System.Globalization.CultureInfo("vi-VN"));

        }

        private void frm_SanPhamTrongHoaDon_Load(object sender, EventArgs e)
        {

        }
    }
}
