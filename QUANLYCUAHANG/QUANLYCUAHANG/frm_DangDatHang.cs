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
    public partial class frm_DangDatHang : Form
    {
        SanPhamBLL sp = new SanPhamBLL();
        DonDatHangBLL dh = new DonDatHangBLL();
        DonDatHang Dondh = new DonDatHang(); 
        int toado = 0;
        public frm_DangDatHang()
        {
            InitializeComponent();
        }
        public frm_DangDatHang(List<frm_SanPhamDat> dssp)
        {
            InitializeComponent();
            Dondh.mahd = dh.layMadhDangDat();
            if (dssp.Count == 0)
            {
                toado = 0;
            }
            else
            {
                foreach (frm_SanPhamDat spd in dssp)
                {
                    spd.TopLevel = false;
                    spd.Location = new Point(0, toado);
                    this.pan_DonDatHang.Controls.Add(spd);
                    spd.Size = new Size(262, 25);
                    spd.Show();
                    toado += 27;        
                    setSoLuongVaTongTien(spd.getSoLuong(), spd.getTongTien());
                }
                toado += 35;
            }
        }
        private void frm_DangDatHang_Load(object sender, EventArgs e)
        {
            Image img = Image.FromFile("D:\\c#\\icon\\tool.png");
            img = Image.FromFile("D:\\c#\\icon\\search.png");
            btn_TimKiem.Image = new Bitmap(img, new Size(25, 25));
            img = Image.FromFile("D:\\c#\\icon\\tool.png");
            btn_BoLoc.Image = new Bitmap(img, new Size(25, 25));
            img = Image.FromFile("D:\\c#\\icon\\history.png");
            btn_LichSuDatHang.Image = new Bitmap(img, new Size(50, 50));
            loadData();
            add_checkBoxLoaiSP();
            add_checkBoxNCCSP();
            SetPlaceholder(txt_TimKiem, "Nhập mã hoặc tên sản phẩm");
            btn_Luu.Visible = false;
        }
        private void loadData()
        {
            dgv_DanhSachSanPham.DataSource = sp.danhSachSanPhamNcc();
            dgv_DanhSachSanPham.Columns["MaSP"].HeaderText = "Mã Sản Phẩm";
            dgv_DanhSachSanPham.Columns["TenSP"].HeaderText = "Tên Sản Phẩm";
            dgv_DanhSachSanPham.Columns["gianhap"].HeaderText = "Giá nhập";
            dgv_DanhSachSanPham.Columns["Loai"].HeaderText = "Loại";
            dgv_DanhSachSanPham.Columns["tenncc"].HeaderText = "Nhà Cung Cấp";
            dgv_DanhSachSanPham.Columns["image"].HeaderText = "Hình ảnh";

            dgv_DanhSachSanPham.Columns["image"].Visible = false;
            dgv_DanhSachSanPham.Columns["masp"].Visible = false;
            dgv_DanhSachSanPham.Columns["ncc"].Visible = false;
            dgv_DanhSachSanPham.Columns["mancc"].Visible = false;
            dgv_DanhSachSanPham.Columns["diachi"].Visible = false;
            dgv_DanhSachSanPham.Columns["sdt"].Visible = false;
            dgv_DanhSachSanPham.Columns["email"].Visible = false;

        }
        private void loadData(DataTable dt)
        {
            dgv_DanhSachSanPham.DataSource = dt;
            dgv_DanhSachSanPham.Columns["MaSP"].HeaderText = "Mã Sản Phẩm";
            dgv_DanhSachSanPham.Columns["TenSP"].HeaderText = "Tên Sản Phẩm";
            dgv_DanhSachSanPham.Columns["gianhap"].HeaderText = "Giá nhập";
            dgv_DanhSachSanPham.Columns["Loai"].HeaderText = "Loại";
            dgv_DanhSachSanPham.Columns["tenncc"].HeaderText = "Nhà Cung Cấp";
            dgv_DanhSachSanPham.Columns["image"].HeaderText = "Hình ảnh";

            dgv_DanhSachSanPham.Columns["image"].Visible = false;
            dgv_DanhSachSanPham.Columns["masp"].Visible = false;
            dgv_DanhSachSanPham.Columns["ncc"].Visible = false;
            dgv_DanhSachSanPham.Columns["mancc"].Visible = false;
            dgv_DanhSachSanPham.Columns["diachi"].Visible = false;
            dgv_DanhSachSanPham.Columns["sdt"].Visible = false;
            dgv_DanhSachSanPham.Columns["email"].Visible = false;

        }
        private void add_checkBoxLoaiSP()
        {
            List<string> dsLoai = sp.danhSachLoaiSanPhamCuaNcc();
            int j = 0;
            for (int i = 0; i < dsLoai.Count; i++)
            {
                if (i > dsLoai.Count / 2)
                {
                    CheckBox chk = new CheckBox();
                    chk.Text = dsLoai[i];
                    chk.Location = new Point(140, 25 + (j * 25));
                    pan_Loai.Controls.Add(chk);
                    j++;
                }
                else
                {
                    CheckBox chk = new CheckBox();
                    chk.Text = dsLoai[i];
                    chk.Location = new Point(20, 25 + (i * 25));
                    pan_Loai.Controls.Add(chk);
                }
            }
        }
        private void add_checkBoxNCCSP()
        {
            List<string> dsNcc = sp.danhSachNCC();
            int j = 20;
            for (int i = 0; i < dsNcc.Count; i++)
            {
                CheckBox chk = new CheckBox();
                chk.Text = dsNcc[i];
                chk.AutoSize = true;
                chk.Location = new Point(20, j);
                pan_NhaCungCap.Controls.Add(chk);
                j += 20;
            }
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

        private void txt_Tu_TextChanged(object sender, EventArgs e)
        {
            if (txt_Tu.Text.Length > 0 && (txt_Tu.Text.StartsWith(".") || txt_Tu.Text.StartsWith(",")))
            {
                txt_Tu.Text = txt_Tu.Text.Substring(1); // Xóa ký tự đầu tiên
                txt_Tu.SelectionStart = 0; // Đưa con trỏ về đầu
            }
            if (string.IsNullOrEmpty(txt_Tu.Text))
            {
                txt_Tu.Text = "0";
            }
        }

        private void txt_Tu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true; // Không cho nhập
            }

            // Đảm bảo chỉ có một dấu thập phân (.,)
            if ((e.KeyChar == '.' || e.KeyChar == ',') && (txt_Tu.Text.Contains(".") || txt_Tu.Text.Contains(",")))
            {
                e.Handled = true;
            }
        }

        private void txt_Den_TextChanged(object sender, EventArgs e)
        {
            if (txt_Den.Text.Length > 0 && (txt_Den.Text.StartsWith(".") || txt_Den.Text.StartsWith(",")))
            {
                txt_Den.Text = txt_Den.Text.Substring(1); // Xóa ký tự đầu tiên
                txt_Den.SelectionStart = 0; // Đưa con trỏ về đầu
            }
            if (string.IsNullOrEmpty(txt_Den.Text))
            {
                txt_Den.Text = "0";
            }
        }

        private void txt_Den_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true; // Không cho nhập
            }

            // Đảm bảo chỉ có một dấu thập phân (.,)
            if ((e.KeyChar == '.' || e.KeyChar == ',') && (txt_Den.Text.Contains(".") || txt_Den.Text.Contains(",")))
            {
                e.Handled = true;
            }
        }

        private void btn_BoLoc_Click(object sender, EventArgs e)
        {
            string dieukienloc = " ";
            //loc theo gia
            float tu = float.Parse(txt_Tu.Text);
            float den = float.Parse(txt_Den.Text);
            if (den == 0 && tu == 0)
            {
                dieukienloc = " ";
            }
            else
            {
                if (den < tu)
                {
                    if (MessageBox.Show("Khoảng giá bạn chọn không hợp lý!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        return;
                    }
                }
                else
                {
                    dieukienloc += string.Format("gianhap>={0} and gianhap<={1}", tu, den);

                }
            }
            //loc theo nha cung cap
            int i = 0;
            foreach (Control con in pan_NhaCungCap.Controls)
            {
                if (con is CheckBox chk)
                {
                    CheckBox check = (CheckBox)chk;
                    if (i == 0)
                    {
                        if (check.Checked)
                        {
                            i++;
                            if (dieukienloc == " ")
                            {
                                dieukienloc += string.Format(" (tenncc=N'{0}'", check.Text);
                            }
                            else
                            {
                                dieukienloc += string.Format(" and (tenncc=N'{0}'", check.Text);
                            }

                        }

                    }
                    else
                    {
                        if (check.Checked)
                        {
                            dieukienloc += string.Format(" or tenncc=N'{0}'", check.Text);
                        }
                    }
                }
            }
            if (i != 0)
            {
                dieukienloc += ")";
            }
            //loc theo loai
            int j = 0;
            foreach (Control con in pan_Loai.Controls)
            {
                if (con is CheckBox chk)
                {
                    CheckBox check = (CheckBox)chk;
                    if (j == 0)
                    {
                        if (i != 0 || dieukienloc != " ")
                        {
                            if (check.Checked)
                            {
                                j++;
                                dieukienloc += string.Format(" and (loai=N'{0}'", check.Text);
                            }
                        }
                        else
                        {
                            if (check.Checked)
                            {
                                j++;
                                dieukienloc += string.Format(" (loai=N'{0}'", check.Text);
                            }

                        }

                    }
                    else
                    {
                        if (check.Checked)
                        {
                            dieukienloc += string.Format(" or loai=N'{0}'", check.Text);
                        }
                    }
                }
            }
            if (j != 0)
            {
                dieukienloc += ")";
            }
            if (dieukienloc == " ")
            {
                loadData();
            }
            else
            {
                loadData(sp.locSanPhamCuaNcc(dieukienloc));
            }
        }
        public int getCountDonDatHang()
        {
            return pan_DonDatHang.Controls.Count;
        }
        public bool getLuu()
        {
            return btn_Luu.Visible;
        }
        public void LuuDonDatHang()
        {
            foreach (Control ctl in pan_DonDatHang.Controls)
            {
                if (ctl is frm_SanPhamDat)
                {
                    frm_SanPhamDat spd = (frm_SanPhamDat)ctl;
                    if (spd.getSoLuong() != 0)
                    {
                        dh.createPhieuDatHang(spd.getsp(), this.Dondh);
                    }
                    else
                    {
                        dh.xoaSPTrongPhieu(spd.getsp(), this.Dondh);
                    }
                }
            }
            MessageBox.Show("Lưu thành công");

        }
        public void SetTrangThaiDonDatHang()
        {
            foreach (Control ctl in pan_DonDatHang.Controls)
            {
                if (ctl is frm_SanPhamDat)
                {
                    frm_SanPhamDat spd = (frm_SanPhamDat)ctl;
                    //dh.xoaSPTrongPhieu();
                    dh.createPhieuDatHang(spd.getsp(), this.Dondh);
                }
            }
            Dondh.tongtien = tt;
            Dondh.soluong = soluong;
            dh.setTrangThaiHD(-1, Dondh);
        }
        private void btn_DatHang_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận đặt hàng?", "Xác nhận", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                foreach (Control ctl in pan_DonDatHang.Controls)
                {
                    if (ctl is frm_SanPhamDat)
                    {
                        frm_SanPhamDat spd = (frm_SanPhamDat)ctl;
                        if (spd.getSoLuong() != 0)
                        {
                            dh.createPhieuDatHang(spd.getsp(), this.Dondh);
                        }
                    }
                }
                Dondh.tongtien = tt;
                Dondh.soluong = soluong;
                dh.setTrangThaiHD(1, Dondh);
                MessageBox.Show("Đơn hàng đã được đặt thành công");
                setControlSauKhiDatVaHuy();
                this.Close();
            }
            else
            {
                return;
            }
        }
        private bool duyetDonHang(int masp)
        {
            foreach (Control ctl in pan_DonDatHang.Controls)
            {
                if (ctl is frm_SanPhamDat sp)
                {
                    frm_SanPhamDat temp = sp;
                    if (masp == temp.get_masp())
                    {
                        temp.set_SoLuongSp();
                        return true;
                    }
                }
            }
            return false;
        }
        int soluong = 0;
        double tt = 0;
        public void setSoLuongVaTongTien(int sl, double tongtien)
        {
            soluong += sl;
            tt += tongtien;
            txt_SoLuong.Text = soluong.ToString();
            txt_TongTien.Text = tt.ToString("C", new System.Globalization.CultureInfo("vi-VN"));
        }
        public void setControlSauKhiDatVaHuy()
        {
            pan_DonDatHang.Controls.Clear();
            toado = 0;
            btn_DatHang.Enabled = false;
            btn_HuyDon.Enabled = false;
            btn_Luu.Visible = false;
            pan_DonDatHang.Enabled = false;
            soluong = 0;
            tt = 0;
            setSoLuongVaTongTien(soluong, tt);
        }
        private void dgv_DanhSachSanPham_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btn_Luu.Visible = true;
                DataGridViewRow row = dgv_DanhSachSanPham.Rows[e.RowIndex];
                setSoLuongVaTongTien(1, Convert.ToInt32(row.Cells["gianhap"].Value));
                pan_DonDatHang.Enabled = true;
                if (duyetDonHang(Convert.ToInt32(row.Cells["masp"].Value)))
                {
                    return;
                }
                else
                {             
                        frm_SanPhamDat SanPhamDat = new frm_SanPhamDat(row);
                        SanPhamDat.TopLevel = false;
                        SanPhamDat.Size= new Size(349, 35);
                        SanPhamDat.Location = new Point(0, toado);
                        this.pan_DonDatHang.Controls.Add(SanPhamDat);
                        SanPhamDat.Show();
                        toado += 37;
                }
            }
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            string dk = "";
            if (txt_TimKiem.Text == "Nhập mã hoặc tên sản phẩm" || string.IsNullOrEmpty(txt_TimKiem.Text))
            {
                SetPlaceholder(txt_TimKiem, "Nhập mã hoặc tên sản phẩm");
                loadData();
                return;
            }
            if (int.TryParse(txt_TimKiem.Text, out int n))
            {
                dk += string.Format(" masp={0}", txt_TimKiem.Text);
                loadData(sp.locSanPhamCuaNcc(dk));
            }
            else
            {
                dk += string.Format(" tensp like N'%{0}%'", txt_TimKiem.Text);
                loadData(sp.locSanPhamCuaNcc(dk));
            }
            SetPlaceholder(txt_TimKiem, "Nhập mã hoặc tên sản phẩm");
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            foreach (Control ctl in pan_DonDatHang.Controls)
            {
                if (ctl is frm_SanPhamDat)
                {
                    frm_SanPhamDat spd = (frm_SanPhamDat)ctl;
                    if (spd.getSoLuong() != 0)
                    {
                        dh.createPhieuDatHang(spd.getsp(), this.Dondh);
                    }
                    else
                    {
                        dh.xoaSPTrongPhieu(spd.getsp(), this.Dondh);
                    }
                }
            }
            Dondh.tongtien = tt;
            Dondh.soluong = soluong;
            dh.setTrangThaiHD(0, Dondh);
            MessageBox.Show("Lưu thành công");
            btn_Luu.Visible = false;
        }

        private void btn_HuyDon_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn hủy đơn đặt hàng không?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                foreach (Control ctl in pan_DonDatHang.Controls)
                {
                    if (ctl is frm_SanPhamDat)
                    {
                        frm_SanPhamDat spd = (frm_SanPhamDat)ctl;
                        if (spd.getSoLuong() != 0)
                        {
                            dh.createPhieuDatHang(spd.getsp(), this.Dondh);
                        }
                    }
                }
                Dondh.tongtien = tt;
                Dondh.soluong = soluong;
                dh.setTrangThaiHD(-1, Dondh);
                setControlSauKhiDatVaHuy();
                this.Close();
            }
            else
            {
                return;
            }
        }
        int slt = 0;
        private void pan_DonDatHang_MouseLeave(object sender, EventArgs e)
        {
            slt = soluong;
            tt = 0;
            soluong = 0;
            foreach (Control ctl in pan_DonDatHang.Controls)
            {
                if (ctl is frm_SanPhamDat)
                {
                    frm_SanPhamDat spd = (frm_SanPhamDat)ctl;
                    if (spd.getSoLuong() != 0)
                    {
                        setSoLuongVaTongTien(spd.getSoLuong(), spd.getTongTien());
                    }
                }
            }
            if (soluong == 0)
            {
                setSoLuongVaTongTien(0, 0);
            }
        }

        private void frm_DangDatHang_MouseLeave(object sender, EventArgs e)
        {
            slt = soluong;
            tt = 0;
            soluong = 0;
            foreach (Control ctl in pan_DonDatHang.Controls)
            {
                if (ctl is frm_SanPhamDat)
                {
                    frm_SanPhamDat spd = (frm_SanPhamDat)ctl;
                    if (spd.getSoLuong() != 0)
                    {
                        setSoLuongVaTongTien(spd.getSoLuong(), spd.getTongTien());
                    }
                }
            }
            if (soluong == 0)
            {
                setSoLuongVaTongTien(0, 0);
            }
        }
        public int laysl()
        {
            int s = 0;
            foreach (Control ctl in pan_DonDatHang.Controls)
            {
                if (ctl is frm_SanPhamDat)
                {
                    frm_SanPhamDat spd = (frm_SanPhamDat)ctl;
                    if (spd.getSoLuong() != 0)
                    {
                        s += spd.getSoLuong();
                    }
                }
            }
            return s;
        }

        private void txt_TongTien_TextChanged(object sender, EventArgs e)
        {
            if (slt != laysl())
            {
                btn_Luu.Visible = true;
            }
        }

        private void btn_LichSuDatHang_Click(object sender, EventArgs e)
        {
            frm_NhanDonDatHang frm = new frm_NhanDonDatHang();
            frm.ShowDialog();
        }
    }
}
