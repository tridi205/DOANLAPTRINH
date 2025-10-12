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
    public partial class frm_ChiTietDonDatHang : Form
    {
        DonDatHang dh=new DonDatHang();
        NhanVienBLL nv=new NhanVienBLL();
        DonDatHangBLL DonDatHangBLL = new DonDatHangBLL();
        SanPhamBLL SanPhamBLL = new SanPhamBLL();
        public frm_ChiTietDonDatHang(DonDatHang dh)
        {
            InitializeComponent();
            this.dh = dh;
            lbl_MaDatHang.Text=dh.mahd.ToString();
            lblNgayDat.Text=dh.ngaydat.ToString();
            lblNguoiDat.Text = nv.layTenCuaNhanVien(dh.manv);
            lblTongTien.Text = dh.tongtien.ToString("C", new System.Globalization.CultureInfo("vi-VN"));
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
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
        private void frm_ChiTietDonDatHang_Load(object sender, EventArgs e)
        {
            Image img = Image.FromFile("D:\\c#\\icon\\button.png");
            btnThoat.Image = new Bitmap(img, new Size(40, 40));
            img = Image.FromFile("D:\\c#\\icon\\keyboard.png");
            btn_TimKiem.Image = new Bitmap(img, new Size(25, 25));
            SetPlaceholder(txt_TimKiem, "Nhập mã sản phẩm");
            loadData();
        }
        int toado = 0;
        public void loadData()
        {
            if (dh.trangthai == 2)
            {
                pan_DonDatHang.Enabled = false;
                btn_NhapKho.Enabled = false;
                chk_NhanDuTatCa.Enabled = false;
                DataTable dt = DonDatHangBLL.layDanhSachSPTrongDonDatHang(this.dh.mahd);
                foreach (DataRow dr in dt.Rows)
                {
                    SanPham sp = new SanPham();
                    sp.maSP = Convert.ToInt32(dr["masanpham"]);
                    sp.tenSP = dr["sanpham"].ToString();
                    sp.soLuong = Convert.ToInt32(dr["soluong"]);
                    sp.thanhtien = Convert.ToDouble(dr["thanhtien"]);
                    sp.donGia = Convert.ToDouble(dr["gianhap"]);
                    if (toado % 2 == 0)
                    {
                        frm_ChiTietSanPhamDat frm = new frm_ChiTietSanPhamDat(dh, sp);
                        frm.Location = new Point(10, toado);
                        frm.TopLevel = false;
                        frm.BackColor = Color.LightGray;
                        pan_DonDatHang.Controls.Add(frm);
                        frm.Show();
                        toado += 69;
                    }
                    else
                    {
                        frm_ChiTietSanPhamDat frm = new frm_ChiTietSanPhamDat(dh, sp);
                        frm.Location = new Point(10, toado);
                        frm.TopLevel = false;
                        frm.BackColor = Color.DarkGray;
                        pan_DonDatHang.Controls.Add(frm);
                        frm.Show();
                        toado += 69;
                    }

                }

            }
            else
            {
                DataTable dt = DonDatHangBLL.layDanhSachSPTrongDonDatHang(this.dh.mahd);
                foreach (DataRow dr in dt.Rows)
                {
                    SanPham sp = new SanPham();
                    sp.maSP = Convert.ToInt32(dr["masanpham"]);
                    sp.tenSP = dr["sanpham"].ToString();
                    sp.soLuong = Convert.ToInt32(dr["soluong"]);
                    sp.thanhtien = Convert.ToDouble(dr["thanhtien"]);
                    sp.donGia = Convert.ToDouble(dr["gianhap"]);
                    if (toado % 2 == 0)
                    {
                        frm_ChiTietSanPhamDat frm = new frm_ChiTietSanPhamDat(dh, sp);
                        frm.Location = new Point(10, toado);
                        frm.TopLevel = false;
                        frm.BackColor = Color.LightGray;
                        pan_DonDatHang.Controls.Add(frm);
                        frm.Show();
                        toado += 69;
                    }
                    else
                    {
                        frm_ChiTietSanPhamDat frm = new frm_ChiTietSanPhamDat(dh, sp);
                        frm.Location = new Point(10, toado);
                        frm.TopLevel = false;
                        frm.BackColor = Color.DarkGray;
                        pan_DonDatHang.Controls.Add(frm);
                        frm.Show();
                        toado += 69;
                    }

                }

            }
            
        }

        private void chk_NhanDuTatCa_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_NhanDuTatCa.Checked) {
                foreach (Control ctl in pan_DonDatHang.Controls) {
                    if(ctl is frm_ChiTietSanPhamDat)
                    {
                        frm_ChiTietSanPhamDat frm=(frm_ChiTietSanPhamDat)(ctl);
                        frm.setSLSP();
                    }
                }
            }
            else
            {
                foreach (Control ctl in pan_DonDatHang.Controls)
                {
                    if (ctl is frm_ChiTietSanPhamDat)
                    {
                        frm_ChiTietSanPhamDat frm = (frm_ChiTietSanPhamDat)(ctl);
                        frm.setSLSPVe0();
                    }
                }
            }
        }

        private void btn_NhapKho_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn đã kiểm tra số lượng trước khi nhập chưa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                foreach (Control ctl in pan_DonDatHang.Controls)
                {
                    if (ctl is frm_ChiTietSanPhamDat)
                    {
                        frm_ChiTietSanPhamDat frm = (frm_ChiTietSanPhamDat)ctl;
                        SanPham sp = frm.getSP();
                        SanPhamBLL.nhapSanPhamVaoKho(sp.maSP, sp.soLuong);
                    }
                }
                DonDatHangBLL.setTrangThaiDonDatHang(dh, 2);
                this.Close();
            }
            else
            {
                return;
            }
               
        }
    }
}
