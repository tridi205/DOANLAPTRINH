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

using BLL;
    
namespace QUANLYCUAHANG
{
    public partial class frm_loginUI : Form
    {
        NhanVienBLL nhanVienBLL= new NhanVienBLL();
        NhanVien nv = new NhanVien();
        public frm_loginUI()
        {
            InitializeComponent();
        }

        private void frm_loginUI_Load(object sender, EventArgs e)
        {
            Image img = Image.FromFile("D:\\c#\\icon\\home-agreement.png");
            img = Image.FromFile("D:\\c#\\icon\\button.png");
            btn_Thoat.Image = new Bitmap(img, new Size(42, 42));
            txt_mk.UseSystemPasswordChar = true;  
        }
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            string mess = "";
            if (string.IsNullOrEmpty(txt_tendn.Text))
            {
                mess += "Chưa nhập mã nhân viên!\n";
                
            }

            if (string.IsNullOrEmpty(txt_mk.Text))
            {
                mess += "Chưa nhập mật khẩu!\n";
                
            }
            if (mess == "")
            {
                int manv=Convert.ToInt32(txt_tendn.Text);
                string mk=txt_mk.Text;
                DataTable dt = nhanVienBLL.DangNhap(manv, mk);
                if (dt != null)
                {
                    nv.manv = Convert.ToInt32(dt.Rows[0]["manv"]);
                    nv.tennv= dt.Rows[0]["tennv"].ToString();
                    nv.diachi = dt.Rows[0]["diachi"].ToString();
                    nv.chucvu = dt.Rows[0]["chucvu"].ToString();
                    nv.sdt= dt.Rows[0]["sdt"].ToString() ;
                    nv.mk = dt.Rows[0]["matkhau"].ToString();
                    nv.gioitinh = dt.Rows[0]["gioitinh"].ToString();
                    nv.cccd = dt.Rows[0]["cccd"].ToString();
                    if(nv.chucvu.Equals("Cửa hàng trưởng"))
                    {
                        this.Hide();
                        MessageBox.Show("Đăng nhập thành công vào trang quản lý", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frm_Main frm=new frm_Main();
                        frm.FormClosed += Frm_FormClosed;
                        frm_Main.nv = nv;
                        frm.ShowDialog();
                    }else if(nv.chucvu.Equals("Nhân viên"))
                    {
                        this.Hide();
                        MessageBox.Show("Đăng nhập thành công vào trang bán hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frm_BanHang frm_banhang=new frm_BanHang();
                        frm_banhang.FormClosed += Frm_banhang_FormClosed;
                        frm_BanHang.nv = nv;
                        frm_banhang.ShowDialog();
                    }
                    else
                    {
                        return;
                    }
                   
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void Frm_banhang_FormClosed(object sender, FormClosedEventArgs e)
        {
            txt_mk.Text = "";
            txt_tendn.Text = "";
            this.Show();
        }

        private void Frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            txt_mk.Text = "";
            txt_tendn.Text = "";
            this.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_hienthimatkhau.Checked)
            {
                txt_mk.UseSystemPasswordChar = false;
               
            }
            else
            {
                txt_mk.UseSystemPasswordChar = true;
            }
        }

        private void txt_tendn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Không cho nhập
            }
        }
    }
}