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
    public partial class frm_ThemSanPham : Form
    {
        SanPhamBLL sp=new SanPhamBLL();
        public frm_ThemSanPham()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            add_Ncc(sp.NccSP());
            int masp = sp.layMaSPMoi();
            txt_MaSP.Text=masp.ToString();
        }
        private void add_Ncc(List<string> dsNcc)
        {
            cbb_Ncc.Items.Clear();
            foreach (string s in dsNcc) { 
                cbb_Ncc.Items.Add(s);
            }
        }
        private void frm_ThemSanPham_Load(object sender, EventArgs e)
        {
            
            Image img = Image.FromFile("D:\\c#\\icon\\button.png");
            btn_Thoat.Image = new Bitmap(img, new Size(35, 35));
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool dragging = false;
        private Point startPoint;
        private void pan_ThemSanPhamMoi_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
        }

        private void pan_ThemSanPhamMoi_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void pan_ThemSanPhamMoi_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string mess = "";
            if (string.IsNullOrEmpty(cbb_Ncc.Text))
            {
                mess += "Chưa chọn nhà cung cấp!\n";
            }
            if (string.IsNullOrEmpty(txt_TenSP.Text))
            {
                mess += "Chưa nhập tên sản phẩm!\n";
            }
            if (string.IsNullOrEmpty(txt_Loai.Text))
            {
                mess += "Chưa nhập loại sản phẩm!\n";
            }
            if (nud_SoLuong.Value == 0)
            {
                mess += "Số lượng phải lớn hơn 0!\n";
            }
            if (mess == "")
            {
                SanPham sp = new SanPham();
                txt_DonGia.Text = txt_DonGia.Text.Replace(',', '.');
                sp.maSP = Convert.ToInt32(txt_MaSP.Text);
                sp.tenSP = txt_TenSP.Text;
                sp.ncc = cbb_Ncc.Text;
                sp.donGia = Convert.ToDouble(txt_DonGia.Text);
                sp.loai = txt_Loai.Text;
                sp.soLuong=Convert.ToInt32(nud_SoLuong.Value);
                if (string.IsNullOrEmpty(pic_AnhSP.ImageLocation))
                {
                    sp.image = "";
                }
                else
                {
                    sp.image = pic_AnhSP.ImageLocation.ToString();
                }

                if (this.sp.themSanPhamMoi(sp)&&this.sp.themSanPhamVaoKho(sp))
                {
                    MessageBox.Show("Bạn đã thêm thành công", "Thông báo");
                    load();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công!!", "Thông báo");
                }
            }
            else
            {
                if (MessageBox.Show(mess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    return;
                }
                else
                {
                    return;
                }
                
            }
        }

        private void txt_DonGia_TextChanged(object sender, EventArgs e)
        {
            if (txt_DonGia.Text.Length > 0 && (txt_DonGia.Text.StartsWith(".") || txt_DonGia.Text.StartsWith(",")))
            {
                txt_DonGia.Text = txt_DonGia.Text.Substring(1); // Xóa ký tự đầu tiên
                txt_DonGia.SelectionStart = 0; // Đưa con trỏ về đầu
            }
            if (string.IsNullOrEmpty(txt_DonGia.Text))
            {
                txt_DonGia.Text = "0";
            }
        }

        private void txt_DonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true; // Không cho nhập
            }

            // Đảm bảo chỉ có một dấu thập phân (.,)
            if ((e.KeyChar == '.' || e.KeyChar == ',') && (txt_DonGia.Text.Contains(".") || txt_DonGia.Text.Contains(",")))
            {
                e.Handled = true;
            }
        }

        private void btn_DoiAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog open = new OpenFileDialog()) { 
                if(open.ShowDialog() == DialogResult.OK)
                {
                    pic_AnhSP.ImageLocation=open.FileName;
                    MessageBox.Show(open.FileName);
                }
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            load();
            
        }

        private void load()
        {
            txt_TenSP.Text = "";
            txt_DonGia.Text = "";
            cbb_Ncc.Text = "";
            txt_Loai.Text = "";
            pic_AnhSP.ImageLocation = "";
            nud_SoLuong.Value = 0;
        }
    }
}
