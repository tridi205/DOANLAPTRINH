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
    public partial class frm_DanhSachHoaDonBan : Form
    {
        HoaDonBLL hd = new HoaDonBLL();
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
        public frm_DanhSachHoaDonBan()
        {
            InitializeComponent();
        }

        private void frm_DanhSachHoaDonBan_Load(object sender, EventArgs e)
        {
            Image img = Image.FromFile("D:\\c#\\icon\\search.png");
            btn_TimKiemHD.Image = new Bitmap(img, new Size(25, 25));
            img = Image.FromFile("D:\\c#\\icon\\tool.png");
            btn_BoLoc.Image = new Bitmap(img, new Size(25, 25));
            img = Image.FromFile("D:\\c#\\icon\\button.png");
            btn_Thoat.Image = new Bitmap(img, new Size(40, 40));
            SetPlaceholder(txt_TimKiem, "Nhập mã hóa đơn cần tìm");
            DataTable dt = hd.layDanhSachHoaDonCuaNgayHomNay();
            if (dt.Rows.Count == 0)
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
                lbl.Text = "Chưa có hóa đơn được lập trong ngày hôm nay";
                lbl.Location = new Point(
                    (pan_DanhSachHoaDon.Width - picBox.Width) / 2 - 70,  // Căn giữa ngang
                    (pan_DanhSachHoaDon.Height - picBox.Height) / 2 + 220// Căn giữa dọc
                );
                pan_DanhSachHoaDon.Controls.Add(lbl);
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
            pan_DanhSachHoaDon.Controls.Clear();
            DataTable dt = hd.layDanhSachHoaDonCuaNgayHomNay();
            loadata(dt);
        }

        private bool dragging = false;
        private Point startPoint;
        private void pan_DSHD_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void pan_DSHD_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void pan_DSHD_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
        }

        private void btn_TimKiemHD_Click(object sender, EventArgs e)
        {
            if (txt_TimKiem.Text != "Nhập mã hóa đơn cần tìm")
            {
                string dieukien = "mahd=" + txt_TimKiem.Text+ " and CAST(ngaylap AS DATE) = CAST(GETDATE() AS DATE)";
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

        private void btn_BoLoc_Click(object sender, EventArgs e)
        {
            string dieukien = "";
            DateTime tu = dtp_Tu.Value.Date;
            DateTime den = dtp_Den.Value.Date;
            if (tu > den)
            {
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
            if (txt_Den.Text != "0" || txt_Tu.Text != "0")
            {
                double start = Convert.ToDouble(txt_Tu.Text);
                double end = Convert.ToDouble(txt_Den.Text);
                if (end < start)
                {
                    MessageBox.Show("Khoảng giá không hợp lí!");
                    return;
                }
                else
                {
                    dieukien += string.Format(" and (tongtien>={0} and tongtien <={1}) ", txt_Tu.Text, txt_Den.Text);
                }
            }
            if (chk_TangDan.Checked)
            {
                dieukien += "\n Order By tongtien ";
            }
            if (chk_GiamDan.Checked)
            {
                dieukien += "\n Order By tongtien desc";
            }

            if (dieukien == "")
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

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chk_TangDan_CheckedChanged(object sender, EventArgs e)
        {
            chk_GiamDan.Checked = false;
        }

        private void chk_GiamDan_CheckedChanged(object sender, EventArgs e)
        {
            chk_TangDan.Checked = false;
        }

        private void chk_DaHuy_CheckedChanged(object sender, EventArgs e)
        {
            chk_DaThanhToan.Checked = false;
        }

        private void chk_DaThanhToan_CheckedChanged(object sender, EventArgs e)
        {
            chk_DaHuy.Checked = false;
        }
    }
}
