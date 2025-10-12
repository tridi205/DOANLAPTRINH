using BLL;
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
    public partial class frm_PhieuDoanhThu : Form
    {
        HoaDonBLL HoaDonBLL=new HoaDonBLL();
        DonDatHangBLL DonDatHangBLL = new DonDatHangBLL();
        int thang;
        int nam;
        public frm_PhieuDoanhThu(int month,int year)
        {
            InitializeComponent();
            this.thang = month;
            this.nam = year;
        }

        private void frm_PhieuDoanhThu_Load(object sender, EventArgs e)
        {
            Image img = Image.FromFile("D:\\c#\\icon\\button.png");
            btn_Thoat.Image = new Bitmap(img, new Size(45, 45));
            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;
            double doanhthu = HoaDonBLL.tongDoanhThuTheoThangNam(thang,nam);
            double tongtiendathang = DonDatHangBLL.tongTienDatHangTheoThangNam(thang,nam);
            lbl_DoanhThuThang.Text += " "+thang.ToString()+"/"+nam.ToString();
            txt_HoaDonDuocLap.Text = HoaDonBLL.tongSoHoaDonTheoThangNam(thang,nam).ToString();
            txt_TongHoaDonBiHuy.Text =  HoaDonBLL.tongSoHoaDonBiHuyTheoThangNam(thang,nam).ToString();
            txt_DoanhThu.Text=doanhthu.ToString("C", new System.Globalization.CultureInfo("vi-VN"));
            txt_TongSoDonDatHang.Text=DonDatHangBLL.tongSoDonDatHangTheoThangNam(thang,nam).ToString();
            txt_TongTienDatHang.Text=tongtiendathang.ToString("C", new System.Globalization.CultureInfo("vi-VN"));
            txt_DoanhThuSauKhiTruCacKhoan.Text=(doanhthu-tongtiendathang).ToString("C", new System.Globalization.CultureInfo("vi-VN"));
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
