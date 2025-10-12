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
    public partial class frm_SanPhamBan : Form
    {
        SanPham sp=new SanPham();
        public frm_SanPhamBan(SanPham sp)
        {
            InitializeComponent();
            this.sp = sp;
            lbl_SanPham.Text = sp.maSP.ToString() + "\n" + sp.tenSP;
            lbl_DonGia.Text=sp.donGia.ToString("C", new System.Globalization.CultureInfo("vi-VN"));
            txt_SoLuong.Text = sp.soLuong.ToString();
            sp.thanhtien = sp.soLuong * sp.donGia;
            lbl_ThanhTien.Text = sp.thanhtien.ToString("C", new System.Globalization.CultureInfo("vi-VN"));
            lbl_GiamGia.Text=0.ToString("C", new System.Globalization.CultureInfo("vi-VN"));
        }

        private void frm_SanPhamBan_Load(object sender, EventArgs e)
        {
            Image img = Image.FromFile("D:\\c#\\icon\\x.png");
            btn_Xoa.Image = new Bitmap(img, new Size(25, 25));
            img = Image.FromFile("D:\\c#\\icon\\plus.png");
            btn_Them.Image = new Bitmap(img, new Size(25, 25));
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {

        }
        public SanPham getSP()
        {
            return sp;
        }
        private void txt_SoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Không cho nhập
            }
        }
        public void setSoLuongSP()
        {
            sp.soLuong++;
            txt_SoLuong.Text = sp.soLuong.ToString();
            sp.thanhtien = sp.soLuong * sp.donGia;
            lbl_ThanhTien.Text = sp.thanhtien.ToString("C", new System.Globalization.CultureInfo("vi-VN"));
            lbl_GiamGia.Text = 0.ToString("C", new System.Globalization.CultureInfo("vi-VN"));
        }
        public void setSL(int sl)
        {
            sp.soLuong += sl;
            txt_SoLuong.Text = sp.soLuong.ToString();
            sp.thanhtien = sp.soLuong * sp.donGia;
            lbl_ThanhTien.Text = sp.thanhtien.ToString("C", new System.Globalization.CultureInfo("vi-VN"));
            lbl_GiamGia.Text = 0.ToString("C", new System.Globalization.CultureInfo("vi-VN"));
        }
        public int getMaSP()
        {
            return sp.maSP;
        }
        private void btn_Tang_Click(object sender, EventArgs e)
        {
            sp.soLuong++;
            sp.thanhtien = sp.soLuong * sp.donGia;
            txt_SoLuong .Text = sp.soLuong.ToString() ;
            lbl_ThanhTien.Text = sp.thanhtien.ToString("C", new System.Globalization.CultureInfo("vi-VN"));
            lbl_GiamGia.Text = 0.ToString("C", new System.Globalization.CultureInfo("vi-VN"));
        }

        private void btn_Giam_Click(object sender, EventArgs e)
        {
            sp.soLuong--;
            sp.thanhtien = sp.soLuong * sp.donGia;
            txt_SoLuong.Text = sp.soLuong.ToString();
            lbl_ThanhTien.Text = sp.thanhtien.ToString("C", new System.Globalization.CultureInfo("vi-VN"));
            lbl_GiamGia.Text = 0.ToString("C", new System.Globalization.CultureInfo("vi-VN"));
        }

        private void txt_SoLuong_TextChanged(object sender, EventArgs e)
        {
            if (txt_SoLuong.Text == "0"||txt_SoLuong.Text=="")
            {
                this.btn_Xoa_Click(sender, e);
                return;
            }
            sp.soLuong=Convert.ToInt32(txt_SoLuong.Text);
            sp.thanhtien = sp.soLuong * sp.donGia;
            txt_SoLuong.Text = sp.soLuong.ToString();
            lbl_ThanhTien.Text = sp.thanhtien.ToString("C", new System.Globalization.CultureInfo("vi-VN"));
            lbl_GiamGia.Text = 0.ToString("C", new System.Globalization.CultureInfo("vi-VN"));
            if (sp.soLuong > 0)
            {
                btn_Them.Visible = false;
                btn_Xoa.Visible = true;
                this.BackColor = SystemColors.Control;
                setVisibaleControl(true);
                sp.thanhtien = sp.soLuong * sp.donGia;
                txt_SoLuong.Text = sp.soLuong.ToString();
                lbl_ThanhTien.Text = sp.thanhtien.ToString("C", new System.Globalization.CultureInfo("vi-VN"));
                lbl_GiamGia.Text = 0.ToString("C", new System.Globalization.CultureInfo("vi-VN"));
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            btn_Them.Visible = true;
            btn_Xoa.Visible= false;
            this.BackColor = Color.FromArgb(255, 128, 128);
            sp.soLuong = 0;
            setVisibaleControl(false);
        }
        public void setVisibaleControl(bool tt)
        {
            btn_Tang.Visible = tt;
            btn_Giam.Visible = tt;
            lbl_DonGia.Visible = tt;
            lbl_GiamGia.Visible= tt;
            txt_SoLuong .Visible = tt;
            lbl_ThanhTien .Visible = tt;
        }
        private void btn_Them_Click_1(object sender, EventArgs e)
        {
            btn_Them.Visible = false;
            btn_Xoa.Visible = true;
            this.BackColor = SystemColors.Control;
            setVisibaleControl(true);
            sp.soLuong = 1;
            sp.thanhtien = sp.soLuong * sp.donGia;
            txt_SoLuong.Text = sp.soLuong.ToString();
            lbl_ThanhTien.Text = sp.thanhtien.ToString("C", new System.Globalization.CultureInfo("vi-VN"));
            lbl_GiamGia.Text = 0.ToString("C", new System.Globalization.CultureInfo("vi-VN"));
        }
        public int getSL()
        {
            return sp.soLuong;
        }
        public double getDonGia()
        {
            return sp.donGia;
        }
        public double getThanhTien()
        {
            return sp.thanhtien;
        }
    }
}
