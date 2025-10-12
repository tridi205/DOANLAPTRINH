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
    public partial class frm_DanhSachSanPhamBan : Form
    {
        SanPhamBLL sp = new SanPhamBLL();
        public frm_DanhSachSanPhamBan()
        {
            InitializeComponent();
        }

        private void frm_DanhSachSanPhamBan_Load(object sender, EventArgs e)
        {
            Image img = Image.FromFile("D:\\c#\\icon\\button.png");
            img = Image.FromFile("D:\\c#\\icon\\search.png");
            btn_TimKiem.Image = new Bitmap(img, new Size(25, 25));
            img = Image.FromFile("D:\\c#\\icon\\tool.png");
            img = Image.FromFile("D:\\c#\\icon\\tool.png");
            btn_BoLoc.Image = new Bitmap(img, new Size(25, 25));
            img = Image.FromFile("D:\\c#\\icon\\button.png");
            btn_Thoat.Image = new Bitmap(img, new Size(40, 40));
            SetPlaceholder(txt_TimKiem, "Nhập mã hoặc tên sản phẩm");
            add_checkBoxLoaiSP();
            add_checkBoxNCCSP();
            loadData();
        }
        private void loadData()
        {
            dgv_DanhSachSanPham.DataSource = sp.layDanhSachSanPhamBangDataTable();
            dgv_DanhSachSanPham.Columns["MaSP"].HeaderText = "Mã Sản Phẩm";
            dgv_DanhSachSanPham.Columns["TenSP"].HeaderText = "Tên Sản Phẩm";
            dgv_DanhSachSanPham.Columns["DonGia"].HeaderText = "Đơn Giá";
            dgv_DanhSachSanPham.Columns["Loai"].HeaderText = "Loại";
            dgv_DanhSachSanPham.Columns["tenncc"].HeaderText = "Nhà Cung Cấp";
            dgv_DanhSachSanPham.Columns["SoLuong"].HeaderText = "Số Lượng tồn";
            dgv_DanhSachSanPham.Columns["image"].HeaderText = "Hình ảnh";

            dgv_DanhSachSanPham.Columns["image"].Visible = false;
            dgv_DanhSachSanPham.Columns["mancc"].Visible = false;
            dgv_DanhSachSanPham.Columns["diachi"].Visible = false;
            dgv_DanhSachSanPham.Columns["sdt"].Visible = false;
            dgv_DanhSachSanPham.Columns["email"].Visible = false;
            dgv_DanhSachSanPham.Columns["ncc"].Visible = false;
        }
        private void loadData(DataTable dt)
        {
            dgv_DanhSachSanPham.DataSource = dt;
            dgv_DanhSachSanPham.Columns["MaSP"].HeaderText = "Mã Sản Phẩm";
            dgv_DanhSachSanPham.Columns["TenSP"].HeaderText = "Tên Sản Phẩm";
            dgv_DanhSachSanPham.Columns["DonGia"].HeaderText = "Đơn Giá";
            dgv_DanhSachSanPham.Columns["Loai"].HeaderText = "Loại";
            dgv_DanhSachSanPham.Columns["tenncc"].HeaderText = "Nhà Cung Cấp";
            dgv_DanhSachSanPham.Columns["SoLuong"].HeaderText = "Số Lượng tồn";
            dgv_DanhSachSanPham.Columns["image"].HeaderText = "Hình ảnh";

            dgv_DanhSachSanPham.Columns["image"].Visible = false;
            dgv_DanhSachSanPham.Columns["mancc"].Visible = false;
            dgv_DanhSachSanPham.Columns["diachi"].Visible = false;
            dgv_DanhSachSanPham.Columns["sdt"].Visible = false;
            dgv_DanhSachSanPham.Columns["email"].Visible = false;
            dgv_DanhSachSanPham.Columns["ncc"].Visible = false;

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
        private void add_checkBoxNCCSP()
        {
            List<string> dsNcc = sp.NccSP();
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
        private void add_checkBoxLoaiSP()
        {
            List<string> dsLoai = sp.loaiSP();
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
        private bool dragging = false;
        private Point startPoint;
        private void pan_DatHang_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void pan_DatHang_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void pan_DatHang_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
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
                loadData(sp.locSanPham(dk));
            }
            else
            {
                dk += string.Format(" tensp like N'%{0}%'", txt_TimKiem.Text);
                loadData(sp.locSanPham(dk));
            }
            SetPlaceholder(txt_TimKiem, "Nhập mã hoặc tên sản phẩm");
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
                    dieukienloc += string.Format("dongia>={0} and dongia<={1}", tu, den);

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
                loadData(sp.locSanPham(dieukienloc));
            }
        }
        private bool duyetDonHang(int masp)
        {
            foreach (Control ctl in pan_SanPhamThem.Controls)
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
        int toado = 0;
        int i = 0;
        private void dgv_DanhSachSanPham_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = dgv_DanhSachSanPham.Rows[e.RowIndex];

                if (duyetDonHang(Convert.ToInt32(row.Cells["masp"].Value)))
                {
                    return;
                }
                else
                {
                    if (i == 0)
                    {
                        frm_SanPhamDat SanPhamDat = new frm_SanPhamDat(row,true);
                        SanPhamDat.TopLevel = false;
                        SanPhamDat.Location = new Point(0, toado);
                        this.pan_SanPhamThem.Controls.Add(SanPhamDat);
                        SanPhamDat.Show();
                        toado += 45;
                        i++;
                    }
                    else
                    {
                        frm_SanPhamDat SanPhamDat = new frm_SanPhamDat(row,true);
                        SanPhamDat.TopLevel = false;
                        SanPhamDat.Location = new Point(0, toado);
                        this.pan_SanPhamThem.Controls.Add(SanPhamDat);
                        SanPhamDat.Show();
                        toado += 45;
                    }
                }
            }
        }

       

        private void btn_Them_Click(object sender, EventArgs e)
        {
            foreach(Control ctl in pan_SanPhamThem.Controls)
            {
                ctl.Dispose();
            }
            pan_SanPhamThem.Controls.Clear();
            toado = 0;
        }

        private void btn_ThemSanPham_Click(object sender, EventArgs e)
        {
            if (pan_SanPhamThem.Controls.Count > 0)
            {
                frm_BanHang.dssp = new List<SanPham>();
                foreach (Control ctl in pan_SanPhamThem.Controls)
                {
                   
                    if (ctl is frm_SanPhamDat)
                    {
                        frm_SanPhamDat frm = (frm_SanPhamDat)ctl;
                        if (frm.getSoLuong() != 0)
                        {
                            frm_BanHang.dssp.Add(frm.getsp());
                        }
                        
                    }
                }
            }
            this.Dispose();
            this.Close();
        }
    }
}
