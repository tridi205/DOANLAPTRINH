using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entity;
namespace QUANLYCUAHANG
{
    public partial class frm_DanhSachSanPham : Form
    {
        SanPhamBLL sp=new SanPhamBLL();
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
        public frm_DanhSachSanPham()
        {
            InitializeComponent();

        }

        private void frm_SanPham_Load(object sender, EventArgs e)
        {
            this.AutoSize = true;
            Image img = Image.FromFile("D:\\c#\\icon\\button.png");
            img = Image.FromFile("D:\\c#\\icon\\search.png");
            btn_TimKiem.Image = new Bitmap(img, new Size(25, 25));
            img = Image.FromFile("D:\\c#\\icon\\tool.png");
            btn_BoLoc.Image = new Bitmap(img, new Size(25, 25));
            img = Image.FromFile("D:\\c#\\icon\\add.png");
            btn_Them.Image = new Bitmap(img, new Size(25, 25));
            SetPlaceholder(txt_TimKiem, "Nhập mã hoặc tên sản phẩm");
            txt_TimKiem.Size = new Size(173, 40); 
            loadData();
            add_checkBoxLoaiSP();
            add_checkBoxNCCSP();
        }
        private void add_checkBoxLoaiSP()
        {
            List<string> dsLoai = sp.loaiSP();
            int j = 0;
            for(int i = 0; i < dsLoai.Count; i++)
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
            dgv_DanhSachSanPham.Columns["trangthai"].HeaderText = "Trạng thái";

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
        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            string dk = "";
            if (txt_TimKiem.Text == "Nhập mã hoặc tên sản phẩm"||string.IsNullOrEmpty(txt_TimKiem.Text))
            {
                SetPlaceholder(txt_TimKiem, "Nhập mã hoặc tên sản phẩm");
                loadData();
                return;
            }
            if(int.TryParse(txt_TimKiem.Text,out int n))
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
        private void dgv_DanhSachSanPham_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_DanhSachSanPham.Rows[e.RowIndex];
                frm_SanPham frm_SP = new frm_SanPham(row);
                frm_SP.StartPosition = FormStartPosition.CenterScreen;
                frm_SP.ShowDialog();
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
                if(con is CheckBox chk )
                {
                    CheckBox check=(CheckBox)chk;
                    if (i==0)
                    {
                        if (check.Checked)
                        {
                            i++;
                            if(dieukienloc==" ")
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
                    if (j==0 )
                    {
                        if(i != 0 || dieukienloc != " ")
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

        private void btn_Them_Click(object sender, EventArgs e)
        {
            frm_ThemSanPham themSP=new frm_ThemSanPham();
            themSP.ShowDialog();
        }

        private void pan_BoLoc_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
