using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
namespace QUANLYCUAHANG
{
    public partial class frm_SanPham : Form
    {
        SanPhamBLL sp = new SanPhamBLL();
        SanPham SanPham=new SanPham();
        public frm_SanPham(DataGridViewRow row)
        {
            InitializeComponent();
            SanPham.maSP = Convert.ToInt32(row.Cells["MaSP"].Value);
            SanPham.soLuong = Convert.ToInt32(row.Cells["SoLuong"].Value);
            pic_AnhSP.ImageLocation = row.Cells["image"].Value.ToString();
            txt_MaSanPham.Text = row.Cells["MaSP"].Value.ToString();
            txt_TenSanPham.Text= row.Cells["TenSP"].Value.ToString();
            txt_DonGia.Text= row.Cells["DonGia"].Value.ToString();
            txt_Loai.Text = row.Cells["Loai"].Value.ToString();
            txt_SoLuongTon.Text = row.Cells["SoLuong"].Value.ToString(); 
            txt_Ncc.Text= row.Cells["tenncc"].Value.ToString();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SanPham_Load(object sender, EventArgs e)
        {
            Image img = Image.FromFile("D:\\c#\\icon\\button.png");
            btn_Thoat.Image = new Bitmap(img, new Size(40,40));
            img = Image.FromFile("D:\\c#\\icon\\search.png");
        }
        private bool dragging = false;
        private Point startPoint;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

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

        private void button2_MouseHover(object sender, EventArgs e)
        {
            btn_Luu.BackColor = Color.Gray;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            btn_Luu.BackColor = Color.Gray;
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            btn_ChinhSua.BackColor = Color.Gray;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            btn_ChinhSua.BackColor = Color.Black;
        }

       

        private void btn_DoiAnh_MouseHover(object sender, EventArgs e)
        {
            btn_Luu.BackColor = Color.Gray;
        }

        private void btn_DoiAnh_MouseLeave(object sender, EventArgs e)
        {
            btn_Luu.BackColor = Color.Gray;
        }

        private void btn_ChinhSua_Click(object sender, EventArgs e)
        {
            btn_DoiAnh.Enabled = true;
            btn_Luu.Enabled = true;
            txt_DonGia.Enabled = true;                  
                    
            txt_TenSanPham.Enabled=true;
            btn_QuayLai.Enabled = true;
        }

        private void btn_QuayLai_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn quay lại không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                SanPham ctsp=sp.chiTietSanPham(txt_MaSanPham.Text);
                pic_AnhSP.ImageLocation = ctsp.image.ToString();
                txt_MaSanPham.Text = ctsp.maSP.ToString();
                txt_TenSanPham.Text = ctsp.tenSP.ToString();
                txt_DonGia.Text = ctsp.donGia.ToString();
                txt_Loai.Text = ctsp.loai.ToString();
                txt_SoLuongTon.Text = ctsp.soLuong.ToString();
              
                btn_DoiAnh.Enabled = false;
                btn_Luu.Enabled = false;
                txt_DonGia.Enabled = false;
               
                txt_TenSanPham.Enabled = false;
                btn_QuayLai.Enabled = false;
            }
            else
            {
                return;
            }
        }

        private void btn_DoiAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog open = new OpenFileDialog()) {
                if(open.ShowDialog() == DialogResult.OK)
                {
                    pic_AnhSP.ImageLocation=open.FileName;
                }
            }

        }
        private void btn_Luu_Click(object sender, EventArgs e)
        {
            string error = "";
            txt_DonGia.Text = txt_DonGia.Text.Replace(',','.');
            if (string.IsNullOrEmpty(txt_TenSanPham.Text))
            {
                error += "Tên sản phẩm không hợp lệ!!\n"; 
            }
            if (float.Parse( txt_DonGia.Text) <=0)
            {
                error += "Đơn giá không được bé hơn 0!!\n";
            }
            if(error!= "")
            {
               if(MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error) ==DialogResult.OK)
                {
                    return;
                }
                else
                {
                    return;
                }   
            }
            
            if(MessageBox.Show("Bạn có chắc chắn muốn thay đổi không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes){
                string query = String.Format("update SanPham set TenSP=N'{0}',DonGia={1},image='{2}' where MaSP={3}", txt_TenSanPham.Text, txt_DonGia.Text, pic_AnhSP.ImageLocation, txt_MaSanPham.Text);
                int i = sp.thayDoiSanPham(query);
                if (i > 0)
                {
                    MessageBox.Show("Bạn Đã cập nhật thành công", "Thông báo");
                    btn_DoiAnh.Enabled = false;
                    btn_Luu.Enabled = false;
                    txt_DonGia.Enabled = false;
                    txt_TenSanPham.Enabled = false;
                    btn_QuayLai.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Bạn Đã cập nhật thất bại!", "Thông báo");
                }
            }
            else
            {
                return;
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

        private void txt_DonGia_TextChanged(object sender, EventArgs e)
        {
            if (txt_DonGia.Text.Length > 0 && (txt_DonGia.Text.StartsWith(".") || txt_DonGia.Text.StartsWith(",")))
            {
                txt_DonGia.Text = txt_DonGia.Text.Substring(1); // Xóa ký tự đầu tiên
                txt_DonGia.SelectionStart = 0; // Đưa con trỏ về đầu
            }
            if (string.IsNullOrEmpty(txt_DonGia.Text)) {
                txt_DonGia.Text = "0";
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (SanPham.soLuong > 0)
                {
                    MessageBox.Show("Không thể xóa được do sản phẩm vẫn còn tồn!", "Thông báo");
                }
                else
                {
                    if (this.sp.xoaSanPham(SanPham.maSP))
                    {
                        MessageBox.Show("Xóa thành công", "Thông báo");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công", "Thông báo");
                    }
                }
            }
            else
            {
                return;
            }
        }
    }
}
