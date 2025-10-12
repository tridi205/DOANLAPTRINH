
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
using Entity;
namespace QUANLYCUAHANG
{
    public partial class frm_themNhaCungCap : Form
    {
        NhaCungCapBLL Ncc = new NhaCungCapBLL();
        public frm_themNhaCungCap()
        {
            InitializeComponent();
        }

        private void frm_themNhaCungCap_Load(object sender, EventArgs e)
        {
            txt_mancc.Text=Ncc.getnewMaNCC().ToString(); 
            txt_mancc.Enabled=false ;
            Image img = Image.FromFile("D:\\c#\\icon\\home-agreement.png");
            
            img = Image.FromFile("D:\\c#\\icon\\button.png");
            btn_out.Image = new Bitmap(img, new Size(40, 40));

            img = Image.FromFile("D:\\c#\\icon\\icons8-plus-69.png");
            btn_Them.Image = new Bitmap(img, new Size(35, 35));

            img = Image.FromFile("D:\\c#\\icon\\icons8-reset-69.png");
            btn_Reset.Image = new Bitmap(img, new Size(35, 35));
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {

        }
        private void load()
        {
            txt_mancc.Text = "";
            txt_Tenncc.Text = "";
            txt_diachi.Text = "";
            txt_email.Text = "";
            txt_sdt.Text = "";
        }
        private void btn_Them_Click_1(object sender, EventArgs e)
        {
            string mess = "";
            if (string.IsNullOrEmpty(txt_Tenncc.Text))
            {
                mess += "Chưa nhập tên nhà cung cấp!\n";
            }
      
            if (string.IsNullOrEmpty(txt_sdt.Text))
            {
                mess += "Chưa nhập số điện thoại nhà cung cấp!\n";
            }
            if(txt_sdt.Text.Length!=10)
            {
                mess += " Định dạng số điện thoại sai";
            }
            
            if (string.IsNullOrEmpty(txt_diachi.Text))
            {
                mess += "Chưa nhập địa chỉ nhà cung cấp!\n";
            }
            if (string.IsNullOrEmpty(txt_email.Text))
            {
                mess += "Chưa nhập email nhà cung cấp!\n";
            }
            if (mess == "")
            {
                NhaCungCap ncc = new NhaCungCap();
                ncc.mancc = Convert.ToInt32(txt_mancc.Text);    
                ncc.tenncc=txt_Tenncc.Text;
                ncc.sdt = txt_sdt.Text;
                ncc.diachi = txt_diachi.Text; 
                ncc.email = txt_email.Text;
                if (this.Ncc.themNhaCungCap(ncc))
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
            this.Close();   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txt_diachi.Text=string.Empty;
            txt_Tenncc.Text=string.Empty;
            
            txt_sdt.Text=string.Empty;
            txt_email.Text=string.Empty;
        }

        private void txt_sdt_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_sdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true; // Không cho nhập
            }
        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
