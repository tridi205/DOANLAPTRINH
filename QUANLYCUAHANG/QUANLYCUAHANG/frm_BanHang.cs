using BLL;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYCUAHANG
{
    public partial class frm_BanHang : Form
    {
        SanPhamBLL sanPhamBLL = new SanPhamBLL();
        public static List<SanPham> dssp = null;
        public static NhanVien nv=new NhanVien();
        HoaDonBLL HoaDonBLL = new HoaDonBLL();
       
        public frm_BanHang()
        {
            InitializeComponent();
        }
        private bool dragging = false;
        private Point startPoint;
        private void pan_BanHang_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void pan_BanHang_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
        }

        private void pan_BanHang_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }
        private void SetPlaceholder(TextBox textBox, string placeholder)
        {
            textBox.Text = placeholder;
            textBox.ForeColor = Color.Gray;

            textBox.Enter += (s, e) =>
            {
                if (textBox.Text == placeholder)
                {
                    textBox.Text = "";
                    textBox.ForeColor = Color.Black;
                }
            };

            textBox.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholder;
                    textBox.ForeColor = Color.Gray;
                }
            };
        }
       

        private void frm_BanHang_Load(object sender, EventArgs e)
        {
            lbl_HoTenNV.Text += nv.tennv;
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
            lbl_ThoiGian.Text = DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy");
            Image img = Image.FromFile("D:\\c#\\icon\\keyboard.png");
            btn_TimKiem.Image = new Bitmap(img, new Size(25, 25));
            img = Image.FromFile("D:\\c#\\icon\\reward.png");
            btn_TichDiem.Image = new Bitmap(img, new Size(35, 35));
            img = Image.FromFile("D:\\c#\\icon\\delete1.png");
            btn_HuyHoaDon.Image = new Bitmap(img, new Size(35, 35));
            img = Image.FromFile("D:\\c#\\icon\\agreement.png");
            btn_TimHoaDon.Image = new Bitmap(img, new Size(35, 35));
            img = Image.FromFile("D:\\c#\\icon\\search1.png");
            btn_TimKiemSanPham.Image = new Bitmap(img, new Size(35, 35));
            img = Image.FromFile("D:\\c#\\icon\\points.png");
            btn_DoiDiem.Image = new Bitmap(img, new Size(35, 35));
            img = Image.FromFile("D:\\c#\\icon\\clean.png");
            btn_Clear.Image = new Bitmap(img, new Size(35, 35));
            img = Image.FromFile("D:\\c#\\icon\\button.png");
            btn_Thoat.Image = new Bitmap(img, new Size(40, 40));
            img = Image.FromFile("D:\\c#\\icon\\history.png");
            btn_ThongBao.Image = new Bitmap(img, new Size(45, 45));
            SetPlaceholder(txt_TimKiem, "Nhập mã sản phẩm");
        
            tongSLVaTongTien();
            txt_TienKhachTra.Text= tienphaitra.ToString("C", new System.Globalization.CultureInfo("vi-VN"));
            txt_TienTraLaiKhach.Text= tientrakhach.ToString("C", new System.Globalization.CultureInfo("vi-VN"));
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            lbl_ThoiGian.Text = DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy");
        }

        private void btn_TimHoaDon_Click(object sender, EventArgs e)
        {
            frm_DanhSachHoaDonBan frm = new frm_DanhSachHoaDonBan();
            frm.ShowDialog();
        }

        private void Frm_ThanhToan_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btn_TichDiem_Click(object sender, EventArgs e)
        {
            frm_TichDiem frm_TichDiem = new frm_TichDiem();
            frm_TichDiem.ShowDialog();
        }

        private void pan_ThongtinSP_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        public bool duyetSPTrongHD(int masp, int sl = 1)
        {
            foreach (Control ctl in pan_SPTrongHoaDon.Controls)
            {
                if (ctl is frm_SanPhamBan)
                {
                    frm_SanPhamBan frm_SanPhamBan = (frm_SanPhamBan)ctl;
                    if (masp == frm_SanPhamBan.getMaSP())
                    {
                        frm_SanPhamBan.setSL(sl);
                        return true;
                    }
                }
            }
            return false;
        }




        int toado = 0;
        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            if (txt_TimKiem.Text.Equals("Nhập mã sản phẩm"))
            {
                return;
            }
            else
            {
                int masp = Convert.ToInt32(txt_TimKiem.Text);
                DataTable dt = sanPhamBLL.layThongTinSanPhamCanTim(masp);
                if (dt != null)
                {
                    SetPlaceholder(txt_TimKiem, "Nhập mã sản phẩm");
                    dssp = new List<SanPham>();
                    DataRow dr = dt.Rows[0];
                    SanPham sp = new SanPham();
                    sp.maSP = Convert.ToInt32(dr["masp"]);
                    sp.tenSP = dr["tensp"].ToString();
                    sp.donGia = Convert.ToDouble(dr["dongia"]);
                    sp.soLuong = 1;
                    if (duyetSPTrongHD(sp.maSP))
                    {
                        return;
                    }
                    frm_SanPhamBan frm_SanPhamBan = new frm_SanPhamBan(sp);
                    frm_SanPhamBan.Location = new Point(0, toado);
                    frm_SanPhamBan.TopLevel = false;
                    pan_SPTrongHoaDon.Controls.Add(frm_SanPhamBan);
                    frm_SanPhamBan.Show();
                    toado += 60;
                }
                else
                {
                    MessageBox.Show(string.Format("Không tìm thấy sản phẩm:{0}", txt_TimKiem.Text), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void txt_TimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Không cho nhập
            }
        }

        private void txt_TimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_TimKiem_Click(sender, e);
                btn_TimKiem.Focus();
            }
        }

        private void btn_TimKiemSanPham_Click(object sender, EventArgs e)
        {
            frm_DanhSachSanPhamBan frm = new frm_DanhSachSanPhamBan();
            frm.FormClosed += Frm_FormClosed;
            frm.ShowDialog();
        }

        private void Frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (frm_BanHang.dssp!=null && frm_BanHang.dssp.Count >0)
            {
                foreach (SanPham sp in dssp)
                {
                    if (duyetSPTrongHD(sp.maSP, sp.soLuong))
                    {
                        return;
                    }
                    frm_SanPhamBan frm_SanPhamBan = new frm_SanPhamBan(sp);
                    frm_SanPhamBan.Location = new Point(0, toado);
                    frm_SanPhamBan.TopLevel = false;
                    pan_SPTrongHoaDon.Controls.Add(frm_SanPhamBan);
                    frm_SanPhamBan.Show();
                    toado += 60;
                }  
            }
            setTongTien();
            frm_BanHang.dssp = null;
        }

        private void pan_SPTrongHoaDon_ControlAdded(object sender, ControlEventArgs e)
        {
            if (pan_SPTrongHoaDon.Controls.Count > 0)
            {
                btn_HuyHoaDon.BackColor = Color.FromArgb(255, 128, 128);
                btn_HuyHoaDon.Enabled = true;
                
                pan_ThanhToan.Enabled = true;
                setTongTien();
            }
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            if (tienphaitra < tongcong)
            {
                MessageBox.Show("Số tiền bạn nhập không hợp lệ!","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                HoaDon hd = new HoaDon();
                hd.mahd = HoaDonBLL.layMaHDMoi();
                hd.trangthai = 1;
                foreach(Control ctl in pan_SPTrongHoaDon.Controls)
                {
                    if(ctl is frm_SanPhamBan)
                    {
                        frm_SanPhamBan frm_SanPhamBan = (frm_SanPhamBan)ctl;
                        if (frm_SanPhamBan.getSL() != 0)
                        {
                            hd.tongtien += frm_SanPhamBan.getThanhTien();
                        } 
                    }
                }
                //hd.tongtien = tongcong;
                hd.manv = nv.manv;
                if (HoaDonBLL.themHoaDon(hd))
                {
                    foreach (Control ctl in pan_SPTrongHoaDon.Controls)
                    {
                        if (ctl is frm_SanPhamBan)
                        {
                            frm_SanPhamBan frm = (frm_SanPhamBan)ctl;
                            if (frm.getSL() != 0)
                            {
                                SanPham sp=frm.getSP();
                                HoaDonBLL.themChiTietHD(hd, sp);
                            }
                        }
                    }
                    MessageBox.Show("Thanh toán thành công");
                    setControlSauKhiThanhToan();
                }
                else
                {
                    MessageBox.Show("Thanh toán thất bại");
                }
            }
                
        }
        public void setControlSauKhiThanhToan()
        {
            pan_SPTrongHoaDon.Controls.Clear();
            setTongTien();
            pan_ThanhToan.Enabled = false;
            btn_HuyHoaDon.Enabled = false;
            btn_HuyHoaDon.BackColor = Color.Gray;
            tienphaitra = 0;
            tientrakhach = 0;
            txt_TienKhachTra.Text = tienphaitra.ToString("C", new System.Globalization.CultureInfo("vi-VN"));
            txt_TienTraLaiKhach.Text = tientrakhach.ToString("C", new System.Globalization.CultureInfo("vi-VN"));
            toado = 0;
        }
        double tienphaitra = 0;
        double tientrakhach = 0;
        int sosp = 0;
        int sl = 0;
        double tongthanhtien = 0;
        double tongcong = 0;
        double giamgia = 0;
        public void tongSLVaTongTien(int sosp = 0, int tongsl = 0, double tongthanhtien = 0, double tongcong = 0)
        {
            lbl_SoSP.Text = sosp.ToString();
            lbl_SL.Text = tongsl.ToString();
            lbl_GG.Text = 0.ToString("C", new System.Globalization.CultureInfo("vi-VN"));
            lbl_TT.Text = tongthanhtien.ToString("C", new System.Globalization.CultureInfo("vi-VN"));
            lbl_TC.Text = tongcong.ToString("C", new System.Globalization.CultureInfo("vi-VN"));
            txt_TienPhaiTra.Text= tongcong.ToString("C", new System.Globalization.CultureInfo("vi-VN"));
        }

        private void pan_SPTrongHoaDon_MouseLeave(object sender, EventArgs e)
        {
            setTongTien();
        }
        public void setTongTien()
        {
            sosp = 0;
            sl = 0;
            tongthanhtien = 0;
            tongcong = 0;
            giamgia = 0;
            foreach (Control ctl in pan_SPTrongHoaDon.Controls)
            {
                if (ctl is frm_SanPhamBan)
                {
                    frm_SanPhamBan spb = (frm_SanPhamBan)ctl;
                    if (spb.getSL() != 0)
                    {
                        sosp++;
                        sl += spb.getSL();
                        tongthanhtien += spb.getThanhTien();
                        tongcong += spb.getThanhTien() + giamgia;
                    }
                }
            }
            tongSLVaTongTien(sosp, sl, tongthanhtien, tongcong);
        }

        private void pan_SPTrongHoaDon_MouseHover(object sender, EventArgs e)
        {
            setTongTien();
        }

        private void btn_NhanDu_Click(object sender, EventArgs e)
        {
            tienphaitra = tongcong;
            txt_TienKhachTra.Text= tongcong.ToString("C", new System.Globalization.CultureInfo("vi-VN"));
        }

        private void txt_TienKhachTra_TextChanged(object sender, EventArgs e)
        {
            if (tienphaitra > tongcong)
            {
                tientrakhach=tienphaitra-tongcong;
                txt_TienTraLaiKhach.Text= tientrakhach.ToString("C", new System.Globalization.CultureInfo("vi-VN"));
            }
            if (tienphaitra == tongcong)
            {
                tientrakhach = tienphaitra - tongcong;
                txt_TienTraLaiKhach.Text =tientrakhach.ToString("C", new System.Globalization.CultureInfo("vi-VN"));

            }
        }

        private void btn_NamTramNghin_Click(object sender, EventArgs e)
        {
            tienphaitra += 500000;
            txt_TienKhachTra.Text= tienphaitra.ToString("C", new System.Globalization.CultureInfo("vi-VN"));
        }

        private void btn_MotTramNghin_Click(object sender, EventArgs e)
        {
            tienphaitra += 100000;
            txt_TienKhachTra.Text = tienphaitra.ToString("C", new System.Globalization.CultureInfo("vi-VN"));
        }

        private void btn_HaiMuoiNghin_Click(object sender, EventArgs e)
        {
            tienphaitra += 20000;
            txt_TienKhachTra.Text = tienphaitra.ToString("C", new System.Globalization.CultureInfo("vi-VN"));
        }

        private void btn_NamNghin_Click(object sender, EventArgs e)
        {
            tienphaitra += 5000;
            txt_TienKhachTra.Text = tienphaitra.ToString("C", new System.Globalization.CultureInfo("vi-VN"));
        }

        private void btn_MotNghin_Click(object sender, EventArgs e)
        {
            tienphaitra += 1000;
            txt_TienKhachTra.Text = tienphaitra.ToString("C", new System.Globalization.CultureInfo("vi-VN"));
        }

        private void btn_HaiTramNghin_Click(object sender, EventArgs e)
        {
            tienphaitra += 200000;
            txt_TienKhachTra.Text = tienphaitra.ToString("C", new System.Globalization.CultureInfo("vi-VN"));
        }

        private void btn_NamMuoiNghin_Click(object sender, EventArgs e)
        {
            tienphaitra += 50000;
            txt_TienKhachTra.Text = tienphaitra.ToString("C", new System.Globalization.CultureInfo("vi-VN"));
        }

        private void btn_MuoiNghin_Click(object sender, EventArgs e)
        {
            tienphaitra += 10000;
            txt_TienKhachTra.Text = tienphaitra.ToString("C", new System.Globalization.CultureInfo("vi-VN"));
        }

        private void btn_HaiNghin_Click(object sender, EventArgs e)
        {
            tienphaitra += 2000;
            txt_TienKhachTra.Text = tienphaitra.ToString("C", new System.Globalization.CultureInfo("vi-VN"));
        }

        private void btn_NamTram_Click(object sender, EventArgs e)
        {
            tienphaitra += 500;
            txt_TienKhachTra.Text = tienphaitra.ToString("C", new System.Globalization.CultureInfo("vi-VN"));
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            tienphaitra = 0;
            tientrakhach = 0;
            txt_TienKhachTra.Text = tienphaitra.ToString("C", new System.Globalization.CultureInfo("vi-VN"));
            txt_TienTraLaiKhach.Text = tientrakhach.ToString("C", new System.Globalization.CultureInfo("vi-VN"));
        }

        private void btn_HuyHoaDon_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn hủy hóa đơn này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                HoaDon hd = new HoaDon();
                hd.mahd = HoaDonBLL.layMaHDMoi();
                hd.trangthai = 0;
                hd.tongtien = tongcong;
                hd.manv = nv.manv;
                if (HoaDonBLL.themHoaDon(hd))
                {
                    foreach (Control ctl in pan_SPTrongHoaDon.Controls)
                    {
                        if (ctl is frm_SanPhamBan)
                        {
                            frm_SanPhamBan frm = (frm_SanPhamBan)ctl;
                            if (frm.getSL() != 0)
                            {
                                SanPham sp = frm.getSP();
                                HoaDonBLL.themChiTietHD(hd, sp);
                            }
                        }
                    }
                    setControlSauKhiThanhToan();
                }
            }
            else
            {
                return;
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void btn_ThongBao_Click(object sender, EventArgs e)
        {
            frm_NhanDonDatHang frm_NhanDonDatHang=new frm_NhanDonDatHang();
            frm_NhanDonDatHang.ShowDialog();
        }

        private void pan_BanHang_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
