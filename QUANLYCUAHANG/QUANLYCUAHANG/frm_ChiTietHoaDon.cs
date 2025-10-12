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
    public partial class frm_ChiTietHoaDon : Form
    {
        HoaDon hd=new HoaDon();
        HoaDonBLL HoaDonBLL = new HoaDonBLL();
        public frm_ChiTietHoaDon(HoaDon hd)
        {
            InitializeComponent();
            this.hd = hd;
            lbl_mahd.Text=hd.mahd.ToString();
            lbl_ngaylap.Text=hd.ngaylap.ToString();
            lbl_tongtien.Text=hd.tongtien.ToString("C", new System.Globalization.CultureInfo("vi-VN"));
            lbl_TenNV.Text = HoaDonBLL.layTenNhanVienLapHoaDon(hd.mahd);
            DataTable dt = HoaDonBLL.layChiTietHoaDOn(hd.mahd);
            if (dt != null)
            {
                int toado = 10;
                foreach (DataRow dr in dt.Rows)
                {
                    SanPham sp = new SanPham();
                    sp.maSP = Convert.ToInt32(dr["masp"]);
                    sp.tenSP = dr["tensp"].ToString();
                    sp.soLuong = Convert.ToInt32(dr["soluong"]);
                    sp.donGia = Convert.ToDouble(dr["dongia"]);
                    sp.thanhtien = Convert.ToDouble(dr["thanhtien"]);
                    if (toado % 2 == 0)
                    {
                        frm_SanPhamTrongHoaDon sphd = new frm_SanPhamTrongHoaDon(sp);
                        sphd.TopLevel = false;
                        sphd.Location = new Point(0, toado);
                        sphd.BackColor = Color.DarkGray;
                        pan_thongtinsanpham.Controls.Add(sphd);
                        sphd.Show();
                        toado += 53;
                    }
                    else
                    {
                        frm_SanPhamTrongHoaDon sphd = new frm_SanPhamTrongHoaDon(sp);
                        sphd.TopLevel = false;
                        sphd.Location = new Point(0, toado);
                        sphd.BackColor=Color.LightGray;
                        pan_thongtinsanpham.Controls.Add(sphd);
                        sphd.Show();
                        toado += 53;
                    }
                }
            }
            
        }
        bool IsFormOpen(string formName)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name == formName)
                    return true;
            }
            return false;
        }
        private void frm_ChiTietHoaDon_Load(object sender, EventArgs e)
        {
            Image img = Image.FromFile("D:\\c#\\icon\\button.png");
            btn_Thoat.Image = new Bitmap(img, new Size(45, 45));
            if (IsFormOpen("frm_Main"))
            {
                if (hd.trangthai == 1)
                {
                    img = Image.FromFile("D:\\c#\\icon\\circle.png");
                    btn_SetTrangThaiHoaDon.Image = new Bitmap(img, new Size(45, 45));
                }
                else
                {
                    btn_SetTrangThaiHoaDon.Visible = false;
                }
            }
            else
            {
                btn_SetTrangThaiHoaDon.Visible=false;
            }
            
            
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool dragging = false;
        private Point startPoint;
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }
        
        private void btn_SetTrangThaiHoaDon_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn hủy hóa đơn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (HoaDonBLL.HuyHoaDon(hd.mahd))
                {
                    MessageBox.Show("Hóa đơn đã hủy thành công", "Thông báo");
                    this.Text = "yes";
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Hóa đơn hủy không thành công", "Thông báo");
                }
            }
            else
            {
                return;
            }
        }
    }
}
