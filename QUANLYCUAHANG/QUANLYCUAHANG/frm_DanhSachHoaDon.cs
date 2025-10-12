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
    public partial class frm_DanhSachHoaDon : Form
    {
        HoaDonBLL hd=new HoaDonBLL();
        public frm_DanhSachHoaDon()
        {
            InitializeComponent();
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

        private void frm_DanhSachHoaDon_Load(object sender, EventArgs e)
        {
            dtp_Tu.MaxDate = DateTime.Today;
            dtp_Den.MaxDate = DateTime.Today;
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
            lbl_ThoiGianThuc.Text = DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy");
            Image img = Image.FromFile("D:\\c#\\icon\\search.png");
            btn_TimKiemHD.Image = new Bitmap(img, new Size(25, 25));
            img = Image.FromFile("D:\\c#\\icon\\tool.png");
            btn_BoLoc.Image = new Bitmap(img, new Size(25, 25));
            SetPlaceholder(txt_TimKiem, "Nhập mã hóa đơn cần tìm");
            DataTable dt = hd.layDanhSachHoaDonCuaNgayHomNay();
            if (dt.Rows.Count==0)
            {
                PictureBox picBox = new PictureBox();
                picBox.Size = new Size(200, 200);
                picBox.SizeMode = PictureBoxSizeMode.StretchImage;
                picBox.Location = new Point(
                (pan_DanhSachHoaDon.Width - picBox.Width) / 2,  // Căn giữa ngang
                (pan_DanhSachHoaDon.Height - picBox.Height) / 2 // Căn giữa dọc
                );  
                picBox.Image = Image.FromFile(@"D:\c#\icon\no-task.png"); 
                Label lbl=new Label();
                lbl.AutoSize = true;
                lbl.Font=new Font("Arial", 10, FontStyle.Regular);
                lbl.Text = "Chưa có hóa đơn được lập trong ngày hôm nay";
                lbl.Location = new Point(
                    (pan_DanhSachHoaDon.Width - picBox.Width) / 2-70,  // Căn giữa ngang
                    (pan_DanhSachHoaDon.Height - picBox.Height) / 2 +220// Căn giữa dọc
                );
                pan_DanhSachHoaDon.Controls.Add( lbl );
                pan_DanhSachHoaDon.Controls.Add(picBox);
            }
            else
            {
                loadata(dt);
            }           
        }
        public void loadata(DataTable dt)
        {
            int toado = 10;
            foreach (DataRow dr in dt.Rows)
            {
                HoaDon hoaDon = new HoaDon();
                hoaDon.mahd = Convert.ToInt32(dr["mahd"]);
                hoaDon.ngaylap = dr["ngaylap"].ToString();
                hoaDon.tongtien = Convert.ToDouble(dr["tongtien"]);
                hoaDon.trangthai = Convert.ToInt32(dr["trangthai"]);
                frm_HoaDon frm_HoaDon = new frm_HoaDon(hoaDon);
                frm_HoaDon.FormClosed += Frm_HoaDon_FormClosed;
                if (toado % 2 == 0)
                {
                    frm_HoaDon.TopLevel = false;
                    frm_HoaDon.Location = new Point(10, toado);
                    frm_HoaDon.BackColor = Color.LightGray;
                    toado += 59;
                    pan_DanhSachHoaDon.Controls.Add(frm_HoaDon);
                    frm_HoaDon.Show();
                }
                else
                {
                    frm_HoaDon.TopLevel = false;
                    frm_HoaDon.Location = new Point(10, toado);
                    frm_HoaDon.BackColor = Color.DarkGray;
                    toado += 59;
                    pan_DanhSachHoaDon.Controls.Add(frm_HoaDon);
                    frm_HoaDon.Show();
                }
            }
        }

        private void Frm_HoaDon_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach(frm_HoaDon frm in pan_DanhSachHoaDon.Controls)
            {
                frm.Dispose();
            }
            pan_DanhSachHoaDon.Controls.Clear();
            DataTable dt = hd.layDanhSachHoaDonCuaNgayHomNay();
            loadata(dt);

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            lbl_ThoiGianThuc.Text = DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy");
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
        public void setControl()
        {
            PictureBox picBox = new PictureBox();
            picBox.Size = new Size(200, 200);
            picBox.SizeMode = PictureBoxSizeMode.StretchImage;
            picBox.Location = new Point(
            (pan_DanhSachHoaDon.Width - picBox.Width) / 2,  // Căn giữa ngang
            (pan_DanhSachHoaDon.Height - picBox.Height) / 2 // Căn giữa dọc
            );
            picBox.Image = Image.FromFile(@"D:\c#\icon\no-task.png");
            Label lbl = new Label();
            lbl.AutoSize = true;
            lbl.Font = new Font("Arial", 10, FontStyle.Regular);
            lbl.Text = "Không có hóa đơn cần tìm";
            lbl.Location = new Point(
                (pan_DanhSachHoaDon.Width - picBox.Width) / 2 - 14,  // Căn giữa ngang
                (pan_DanhSachHoaDon.Height - picBox.Height) / 2 + 220// Căn giữa dọc
            );
            pan_DanhSachHoaDon.Controls.Add(lbl);
            pan_DanhSachHoaDon.Controls.Add(picBox);
        }
        private void btn_TimKiemHD_Click(object sender, EventArgs e)
        {
            if(txt_TimKiem.Text!= "Nhập mã hóa đơn cần tìm")
            {
                string dieukien = "mahd=" + txt_TimKiem.Text;
                DataTable dt = hd.layDanhSachHoaDon(dieukien);
                pan_DanhSachHoaDon.Controls.Clear();
                if (dt.Rows.Count > 0)
                {
                    loadata(dt);
                }
                else
                {
                    setControl();
                }
                SetPlaceholder(txt_TimKiem, "Nhập mã hóa đơn cần tìm");
            }
            else
            {
                pan_DanhSachHoaDon.Controls.Clear();
                DataTable dt = hd.layDanhSachHoaDonCuaNgayHomNay();
                if (dt.Rows.Count > 0)
                {
                    loadata(dt);
                }
                else
                {
                    setControl();
                }
                SetPlaceholder(txt_TimKiem, "Nhập mã hóa đơn cần tìm");
            }
            
        }

        private void txt_TimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void chk_TangDan_CheckedChanged(object sender, EventArgs e)
        {
            chk_GiamDan.Checked=false;
        }

        private void chk_GiamDan_CheckedChanged(object sender, EventArgs e)
        {
            chk_TangDan.Checked = false;
        }

        private void chk_DaHuy_CheckedChanged(object sender, EventArgs e)
        {
            chk_DaThanhToan.Checked=false;
        }

        private void chk_DaThanhToan_CheckedChanged(object sender, EventArgs e)
        {
            chk_DaHuy.Checked = false;
        }

        private void btn_BoLoc_Click(object sender, EventArgs e)
        {
            string dieukien = "";
            DateTime tu = dtp_Tu.Value.Date;
            DateTime den = dtp_Den.Value.Date;
            if (tu > den) {
                MessageBox.Show("Mốc thời gian không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dtp_Tu.CustomFormat = "yyyy-MM-dd";
            dtp_Den.CustomFormat = "yyyy-MM-dd";
            dieukien += string.Format(" (CONVERT(DATE, ngaylap, 103)>='{0}' and CONVERT(DATE, ngaylap, 103)<='{1}') ", dtp_Tu.Text, dtp_Den.Text);
            dtp_Tu.CustomFormat = "dd/MM/yyyy";
            dtp_Den.CustomFormat = "dd/MM/yyyy";
            if (chk_DaHuy.Checked)
            {
                dieukien += "and trangthai=0";
            }
            if (chk_DaThanhToan.Checked)
            {
                dieukien += "and trangthai=1";
            }
            if (txt_Den.Text != "0" || txt_Tu.Text != "0") {
                double start = Convert.ToDouble(txt_Tu.Text);
                double end = Convert.ToDouble(txt_Den.Text);
                if (end < start)
                {
                    MessageBox.Show("Khoảng giá không hợp lí!");
                    return;
                }
                else
                {
                    dieukien += string.Format(" and (tongtien>={0} and tongtien <={1}) ",txt_Tu.Text,txt_Den.Text);
                }
            }
            if (chk_TangDan.Checked) {
                dieukien += "\n Order By tongtien ";
            }
            if (chk_GiamDan.Checked)
            {
                dieukien += "\n Order By tongtien desc";
            }
            
            if (dieukien== "")
            {
                return;
            }
            else
            {
                DataTable dt = hd.layDanhSachHoaDon(dieukien);
                foreach (Control ctl in pan_DanhSachHoaDon.Controls)
                {
                    ctl.Dispose();
                }
                pan_DanhSachHoaDon.Controls.Clear();
                if (dt.Rows.Count > 0)
                {
                    loadata(dt);
                }
                else
                {
                    setControl();
                }
            }
        }

        private void lbl_ThoiGianThuc_Click(object sender, EventArgs e)
        {

        }
    }
}
