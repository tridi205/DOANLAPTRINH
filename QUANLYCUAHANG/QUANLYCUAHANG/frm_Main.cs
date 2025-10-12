using BLL;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace QUANLYCUAHANG
{
    public partial class frm_Main : Form
    {
        public static NhanVien nv=new NhanVien();
        DonDatHangBLL dondh=new DonDatHangBLL();
        public frm_Main()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            pic_Anh.ImageLocation = "D:\\c#\\icon\\man.png";
            Image img = Image.FromFile("D:\\c#\\icon\\home-agreement.png");
            btn_TrangChu.Image = new Bitmap(img, new Size(25, 25));
            img = Image.FromFile("D:\\c#\\icon\\management.png");
            btn_DanhSachHoaDon.Image = new Bitmap(img, new Size(25, 25));
            img = Image.FromFile("D:\\c#\\icon\\warehouse.png");
            btn_DanhSachSanPham.Image = new Bitmap(img, new Size(25, 25));
            img = Image.FromFile("D:\\c#\\icon\\folder-management.png");
            btn_DatHang.Image = new Bitmap(img, new Size(25, 25));
            img = Image.FromFile("D:\\c#\\icon\\staff-management.png");
            btn_QuanLyNhanVien.Image = new Bitmap(img, new Size(25, 25));
            img = Image.FromFile("D:\\c#\\icon\\supply-chain.png");
            btn_QuanLyNCC.Image = new Bitmap(img, new Size(25, 25));
            img = Image.FromFile("D:\\c#\\icon\\logout.png");
            btn_DangXuat.Image = new Bitmap(img, new Size(25, 25)); 
            img = Image.FromFile("D:\\c#\\icon\\market.png");
            btn_ThongKeDoanhThu.Image = new Bitmap(img, new Size(25, 25));
            img = Image.FromFile("D:\\c#\\icon\\button.png");
            btn_Thoat.Image = new Bitmap(img, new Size(40, 40));
            frm_TrangChu frm_TrangChu = new frm_TrangChu();
            frm_TrangChu.TopLevel = false;
            frm_TrangChu.FormClosed += Frm_TrangChu_FormClosed;
            pan_HienThi.Controls.Clear();
            pan_HienThi.Controls.Add(frm_TrangChu);
            frm_TrangChu.Show();
        }
        private void kiemTraDonDatHang()
        {
            foreach (Control ctl in pan_HienThi.Controls)
            {
                if (ctl is frm_DatHang)
                {
                    frm_DatHang dh = (frm_DatHang)ctl;
                    if (dh.getCountDonDatHang() > 0 && dh.getLuu())
                    {
                        DialogResult result = MessageBox.Show("Bạn có muốn lưu đơn đặt hàng không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if ( result== DialogResult.Yes)
                        {
                            dh.LuuDonDatHang();
                        }
                        else if(result== DialogResult.No){
                             dh.SetTrangThaiDonDatHang();
                             break;
                        }
                    }
                }
            }
        }
        private void kiemTraDonDangDatHang()
        {
            foreach (Control ctl in pan_HienThi.Controls)
            {
                if (ctl is frm_DangDatHang)
                {
                    frm_DangDatHang dh = (frm_DangDatHang)ctl;
                    if (dh.getCountDonDatHang() > 0 && dh.getLuu())
                    {
                        DialogResult result = MessageBox.Show("Bạn có muốn lưu đơn đặt hàng không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (result == DialogResult.Yes)
                        {
                            dh.LuuDonDatHang();
                        }
                        else if (result == DialogResult.No)
                        {
                            dh.SetTrangThaiDonDatHang();
                            break;
                        }
                    }
                }
            }
        }
        private void btn_ManageProduct_Click(object sender, EventArgs e)
        {
            kiemTraDonDatHang();
            kiemTraDonDangDatHang();
            frm_DanhSachSanPham frm_DSSP = new frm_DanhSachSanPham();
            frm_DSSP.TopLevel = false;
            pan_HienThi.Controls.Clear();
            pan_HienThi.Controls.Add(frm_DSSP);
            frm_DSSP.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private bool dragging = false;
        private Point startPoint;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

      
        private void btn_Thoat_Click_1(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát ứng dụng không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                kiemTraDonDatHang();
                kiemTraDonDangDatHang();
                this.Close();
            }
            else
            {
                return;
            }
            
        }
        private void btn_ManagWarehouse_Click(object sender, EventArgs e)
        {
            kiemTraDonDatHang();
            kiemTraDonDangDatHang();
            if (dondh.getDonDangDat())
            {
                DataTable dt = dondh.DanhSachSanPhamDangDat();
                List<frm_SanPhamDat> dssp = new List<frm_SanPhamDat>();
                foreach (DataRow dr in dt.Rows)
                {
                    SanPham sp = new SanPham();
                    sp.maSP = Convert.ToInt32(dr["masp"]);
                    sp.tenSP = dr["tensp"].ToString();
                    sp.donGia = Convert.ToDouble(dr["gianhap"]);
                    sp.soLuong = Convert.ToInt32(dr["soluong"]);
                    sp.loai = dr["loai"].ToString();
                    dssp.Add(new frm_SanPhamDat(sp));
                }
                frm_DangDatHang frm_DangDatHang = new frm_DangDatHang(dssp);
                frm_DangDatHang.TopLevel = false;
                frm_DangDatHang.FormClosed += Frm_DangDatHang_FormClosed;
                pan_HienThi.Controls.Clear();
                pan_HienThi.Controls.Add(frm_DangDatHang);
                frm_DangDatHang.Show();
            }
            else
            {
                frm_DatHang frm_DatHang = new frm_DatHang();
                frm_DatHang.TopLevel = false;
                pan_HienThi.Controls.Clear();
                pan_HienThi.Controls.Add(frm_DatHang);
                frm_DatHang.Show();
            }
                     
        }

        private void Frm_DangDatHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            btn_ManagWarehouse_Click(sender, e);
        }
        private void btn_ManageSales_Click(object sender, EventArgs e)
        {
            kiemTraDonDatHang();
            kiemTraDonDangDatHang();
            frm_DanhSachHoaDon frm_DSHD = new frm_DanhSachHoaDon();
            frm_DSHD.TopLevel = false;
            pan_HienThi.Controls.Clear();
            pan_HienThi.Controls.Add(frm_DSHD);
            frm_DSHD.Show();
        }

        private void btn_TrangChu_Click(object sender, EventArgs e)
        {
            kiemTraDonDatHang();
            kiemTraDonDangDatHang();
            frm_TrangChu frm_TrangChu = new frm_TrangChu();
            frm_TrangChu.TopLevel = false;
            frm_TrangChu.FormClosed += Frm_TrangChu_FormClosed;
            pan_HienThi.Controls.Clear();
            pan_HienThi.Controls.Add(frm_TrangChu);
            frm_TrangChu.Show();
        }

        private void Frm_TrangChu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form frm = sender as Form;
            if(frm.Text.Equals("Quản lý"))
            {
                btn_QuanLyNhanVien_Click(sender, e);
            }
            else if(frm.Text.Equals("Kiểm tra"))
            {
                btn_ManageSales_Click(sender, e); 
            }
            else if (frm.Text.Equals("Kiểm kê"))
            {
                btn_ManageProduct_Click(sender, e);
            }
            else
            {
                btn_ManagWarehouse_Click(sender, e);
            }
        }

        private void btn_QuanLyNhanVien_Click(object sender, EventArgs e)
        {
            kiemTraDonDatHang();
            kiemTraDonDangDatHang();
            frm_QuanLyNhanVien frm_QuanLyNhanVien=new frm_QuanLyNhanVien();
            frm_QuanLyNhanVien.TopLevel = false;
            pan_HienThi.Controls.Clear();
            pan_HienThi.Controls.Add(frm_QuanLyNhanVien);
            frm_QuanLyNhanVien.Show();
        }
        private void btn_ThongKeDoanhThu_Click(object sender, EventArgs e)
        {
            kiemTraDonDatHang();
            kiemTraDonDangDatHang();
            frm_ThongKe frm_ThongKe=new frm_ThongKe();
            frm_ThongKe.TopLevel = false;
            pan_HienThi.Controls.Clear();
            pan_HienThi.Controls.Add(frm_ThongKe);
            frm_ThongKe.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_QuanLyNCC_Click(object sender, EventArgs e)
        {
            kiemTraDonDatHang();
            kiemTraDonDangDatHang();
            frm_NhaCungCap frmncc = new frm_NhaCungCap();
            frmncc.TopLevel = false;
            pan_HienThi.Controls.Clear();
            pan_HienThi.Controls.Add(frmncc);
            frmncc.Show();
        }

        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
           
            if (MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information)==DialogResult.Yes)
            {
                kiemTraDonDatHang();
                kiemTraDonDangDatHang();
                this.Close();
            }
            else
            {
                return;
            }
            
        }
    }
}
