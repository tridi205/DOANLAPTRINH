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
using System.Net.Mail;
namespace QUANLYCUAHANG
{
    public partial class frm_ThemNhanVien : Form
    {
        NhanVienBLL nhanVienBLL = new NhanVienBLL();
        public frm_ThemNhanVien()
        {
            InitializeComponent();
        }
        private bool dragging = false;
        private Point startPoint;
        private void pan_ThemSanPham_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void pan_ThemSanPham_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
        }

        private void pan_ThemSanPham_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void frm_ThemNhanVien_Load(object sender, EventArgs e)
        {
            pic_Anh.ImageLocation = "D:\\c#\\icon\\profile.png";
            Image img = Image.FromFile("D:\\c#\\icon\\button.png");
            btn_Exit.Image = new Bitmap(img, new Size(40, 40));
            img= Image.FromFile("D:\\c#\\icon\\image.png");
            btn_DoiAnh.Image=new Bitmap(img, new Size(35,35));
            img = Image.FromFile("D:\\c#\\icon\\add-user.png");
            btn_Them.Image = new Bitmap(img, new Size(25, 25));
            img = Image.FromFile("D:\\c#\\icon\\circle.png");
            btn_HuyChinhSua.Image = new Bitmap(img, new Size(25, 25));
            txt_MaNV.Text = nhanVienBLL.layMaNVMoi().ToString();
            dtp_NgaySinh.MaxDate=DateTime.Today;
        }
        public void setControl()
        {
            foreach (Control ctl in this.Controls)
            {
                if(ctl is TextBox)
                {
                    TextBox txt = (TextBox)ctl;
                    txt.Text = "";
                }
            }
            txt_ChucVu.Text = "Nhân viên";
            txt_MatKhau.Text = "123";
            txt_MaNV.Text=nhanVienBLL.layMaNVMoi().ToString();
            pic_Anh.ImageLocation = "D:\\c#\\icon\\profile.png";
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public bool IsValidEmail(string email)
        {
            try
            {
                var mail = new MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            string error = "";
            NhanVien nv=new NhanVien();
            nv.manv = Convert.ToInt32(txt_MaNV.Text);
            if (DateTime.Now.Date.AddYears(-18)>=dtp_NgaySinh.Value )
            {
                nv.ngaysinh=dtp_NgaySinh.Value;
            }
            else
            {
                error += "Ngày sinh không hợp lệ!\n";
            }
            if (string.IsNullOrEmpty(txt_HoTen.Text))
            {
                error += "Họ tên không được để trống!\n";
            }
            if (string.IsNullOrEmpty(txt_CCCD.Text))
            {
                error += "CCCD không được để trống!\n";
            }
            if (string.IsNullOrEmpty(txt_SDT.Text))
            {
                error += "Email không được trống!\n";
            }
            if (!IsValidEmail(txt_Email.Text)) {
                error += "Email không hợp lệ!\n";
            }
            if (string.IsNullOrEmpty(txt_MatKhau.Text)) {
                error += "Mật khẩu không hợp lệ!\n";
            }
            if (string.IsNullOrEmpty(txt_DiaChi.Text))
            { 
                error += "Địa chỉ không được để trống!\n";
            }
            if (string.IsNullOrEmpty(txt_SDT.Text) || (txt_SDT.Text.Length <0 && txt_SDT.Text.Length> 11))
            {
                error += "Số điện thoại không hợp lệ!\n";
            }
            if (error == "")
            {
                nv.tennv = txt_HoTen.Text;
                if (rdb_Nam.Checked)
                {
                    nv.gioitinh = rdb_Nam.Text;
                }
                else
                {
                    nv.gioitinh = rdb_Nu.Text;
                }
                nv.cccd= txt_CCCD.Text;
                nv.sdt=txt_SDT.Text;
                nv.diachi=txt_DiaChi.Text;
                nv.chucvu=txt_ChucVu.Text;
                nv.mk = txt_MatKhau.Text;
                nv.anh = pic_Anh.ImageLocation;
                if (nhanVienBLL.themNhanVienMoi(nv))
                {
                    MessageBox.Show("Thêm thành công!", "Thông báo");
                    setControl();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công!", "Thông báo");
                }
            }
            else
            {
                if(MessageBox.Show(error,"Lỗi",MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    return;
                }
                else
                {
                    return;
                }
            }
        }

        private void txt_CCCD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Không cho nhập
            } 
        }

        private void txt_SDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Không cho nhập
            }
        }

        private void btn_HuyChinhSua_Click(object sender, EventArgs e)
        {
            setControl();
        }

        private void btn_DoiAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog open = new OpenFileDialog()) { 
                if(open.ShowDialog() == DialogResult.OK)
                {
                    pic_Anh.ImageLocation = open.FileName;  
                }
            }
        }
    }
}
