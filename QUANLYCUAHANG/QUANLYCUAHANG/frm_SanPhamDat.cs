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
    public partial class frm_SanPhamDat : Form
    {
        SanPham sp=new SanPham();
        public frm_SanPhamDat(DataGridViewRow row)
        {
            InitializeComponent();
            //row.Cells["image"].Value.ToString();
            sp.maSP=Convert.ToInt32(row.Cells["masp"].Value);
            sp.tenSP= row.Cells["tensp"].Value.ToString();
            sp.loai= row.Cells["loai"].Value.ToString();    
            sp.donGia = Convert.ToDouble(row.Cells["gianhap"].Value.ToString());    
            sp.soLuong += 1;
        }
        public frm_SanPhamDat(DataGridViewRow row,bool loai)
        {
            InitializeComponent();
            //row.Cells["image"].Value.ToString();
            sp.maSP = Convert.ToInt32(row.Cells["masp"].Value);
            sp.tenSP = row.Cells["tensp"].Value.ToString();
            sp.loai = row.Cells["loai"].Value.ToString();
            sp.donGia = Convert.ToDouble(row.Cells["dongia"].Value.ToString());
            sp.soLuong += 1;
           
        }
        public frm_SanPhamDat(SanPham sp)
        {
            InitializeComponent();
            this.sp.maSP = sp.maSP;
            this.sp.tenSP = sp.tenSP;
            this.sp.loai = sp.loai;
            this.sp.donGia = sp.donGia;
            this.sp.soLuong=sp.soLuong;
        }
        public SanPham getsp()
        {
            return sp;
        }

        private void frm_SanPhamDat_Load(object sender, EventArgs e)
        {
            Image img = Image.FromFile("D:\\c#\\icon\\delete.png");
            btn_Xoa.Image = new Bitmap(img, new Size(25, 25));
            img = Image.FromFile("D:\\c#\\icon\\add.png");
            btn_Them.Image = new Bitmap(img, new Size(25, 25));
            loadata();
        }
        public void loadata()
        {
            lbl_SanPham.Text = sp.maSP.ToString() + "\n" + sp.tenSP;
            lbl_GiaNhap.Text = sp.donGia.ToString();
            txt_SoLuong.Text = sp.soLuong.ToString();
            double gia = Convert.ToDouble(lbl_GiaNhap.Text);
            int sl = Convert.ToInt32(txt_SoLuong.Text);
            lbl_ThanhTien.Text = (sl * gia).ToString();
        }
        public double getTongTien()
        {
            return sp.soLuong * sp.donGia;
        }
        private void btn_Tang_Click(object sender, EventArgs e)
        {
            sp.soLuong += 1;
            txt_SoLuong.Text = sp.soLuong.ToString();
        }

        private void btn_Giam_Click(object sender, EventArgs e)
        {
            sp.soLuong -= 1;
            txt_SoLuong.Text = sp.soLuong.ToString();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            btn_Them.Visible = true;
            sp.soLuong = 0;
            txt_SoLuong.Text = "0";
            set_control(false);

        }
        public void set_SoLuongSp()
        {
            sp.soLuong++;
            txt_SoLuong.Text=sp.soLuong.ToString();
        }
        public int getSoLuong()
        {
            return sp.soLuong;  
        }
        public int get_masp()
        {
            return sp.maSP;
        }
        public void set_control(bool b)
        {
            lbl_GiaNhap.Visible = b;
            lbl_ThanhTien.Visible = b;
            btn_Giam.Visible = b;
            btn_Tang.Visible = b;
            txt_SoLuong.Visible = b;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            btn_Them.Visible = false;
            btn_Xoa.Visible = true;
            sp.soLuong = 1;
            txt_SoLuong.Text = "1";
            set_control(true);
        }

        private void txt_SoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) { 
                e.Handled = true; // Không cho nhập
            }           
        }


        private void txt_SoLuong_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_SoLuong.Text)|| Convert.ToInt32(txt_SoLuong.Text) <= 0)
            {
                sp.soLuong = 0;
                txt_SoLuong.Text = "0";
                set_control(false);
                btn_Xoa.Visible = false;
                btn_Them.Visible = true;
                this.BackColor =Color.IndianRed;
            }
            else
            {
                sp.soLuong = Convert.ToInt16(txt_SoLuong.Text);
                lbl_ThanhTien.Text = (sp.soLuong*sp.donGia).ToString();
                this.BackColor =SystemColors.ScrollBar;
                set_control(true);
            }
            
        }

        
    }
}
