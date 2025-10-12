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
    public partial class frm_NhanDonDatHang : Form
    {
        DonDatHangBLL DonDatHangBLL=new DonDatHangBLL();
        int toado =10;
        public frm_NhanDonDatHang()
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
        private void frm_NhanDonDatHang_Load(object sender, EventArgs e)
        {
            Image img = Image.FromFile("D:\\c#\\icon\\button.png");
            btnThoat.Image = new Bitmap(img, new Size(40, 40));
            img = Image.FromFile("D:\\c#\\icon\\keyboard.png");
            btn_TimKiem.Image = new Bitmap(img, new Size(25, 25));
            SetPlaceholder(txt_TimKiem, "Nhập mã đơn hàng");
            loadData();
           
        }
        public void loadData()
        {
            pan_DonDatHang.Controls.Clear();
            toado = 10;
            DataTable dt = DonDatHangBLL.layDanhSachDonDatHang();
            foreach (DataRow dr in dt.Rows)
            {
                DonDatHang dh = new DonDatHang();
                dh.mahd = Convert.ToInt32(dr["madh"]);
                dh.ngaydat = dr["ngaydat"].ToString();
                dh.tongtien = Convert.ToDouble(dr["tongtien"]);
                dh.trangthai = Convert.ToInt16(dr["trangthai"]);
                dh.soluong = Convert.ToInt32(dr["soluong"]);
                dh.manv = Convert.ToInt32(dr["manv"]);
                frm_DonDatHang frm_DonDatHang = new frm_DonDatHang(dh);
                frm_DonDatHang.FormClosed += Frm_DonDatHang_FormClosed;
               
                if (toado % 2 == 0)
                {
                    
                    frm_DonDatHang.Location = new Point(10, toado);
                    frm_DonDatHang.TopLevel = false;
                    pan_DonDatHang.Controls.Add(frm_DonDatHang);
                    frm_DonDatHang.Show();
                    toado += 69;
                }
                else
                {
                    frm_DonDatHang.Location = new Point(10, toado);
                    frm_DonDatHang.TopLevel = false;
                    frm_DonDatHang.BackColor=Color.DarkGray;
                    pan_DonDatHang.Controls.Add(frm_DonDatHang);
                    frm_DonDatHang.Show();
                    toado += 69;
                }
                
            }
        }

        private void Frm_DonDatHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            loadData();
        }
        public void loadData(DataTable data)
        {
            DataTable dt = data;
            foreach (DataRow dr in dt.Rows)
            {
                DonDatHang dh = new DonDatHang();
                dh.mahd = Convert.ToInt32(dr["madh"]);
                dh.ngaydat = dr["ngaydat"].ToString();
                dh.tongtien = Convert.ToDouble(dr["tongtien"]);
                dh.trangthai = Convert.ToInt16(dr["trangthai"]);
                dh.soluong = Convert.ToInt32(dr["soluong"]);
                if (toado % 2 == 0)
                {
                    frm_DonDatHang frm_DonDatHang = new frm_DonDatHang(dh);
                    frm_DonDatHang.Location = new Point(10, toado);
                    frm_DonDatHang.TopLevel = false;
                    pan_DonDatHang.Controls.Add(frm_DonDatHang);
                    frm_DonDatHang.Show();
                    toado += 69;
                }
                else
                {
                    frm_DonDatHang frm_DonDatHang = new frm_DonDatHang(dh);
                    frm_DonDatHang.Location = new Point(10, toado);
                    frm_DonDatHang.TopLevel = false;
                    frm_DonDatHang.BackColor = Color.DarkGray;
                    pan_DonDatHang.Controls.Add(frm_DonDatHang);
                    frm_DonDatHang.Show();
                    toado += 69;
                }

            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool dragging = false;
        private Point startPoint;
        private void pan_TichDiem_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void pan_TichDiem_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
        }

        private void pan_TichDiem_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(pan_DonDatHang.Controls.Count.ToString());
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            toado = 0;
            pan_DonDatHang.Controls.Clear();
            if (txt_TimKiem.Text.Equals("Nhập mã đơn hàng"))
            {
                loadData();
                return;
            }
            else
            {
                DataTable dt =DonDatHangBLL.layDanhSachDonDatHang(" and madh="+txt_TimKiem.Text);
                if (dt.Rows.Count > 0)
                {
                    loadData(dt);
                }
                else
                {
                    toado = 0;
                    pan_DonDatHang.Controls.Clear();
                }
                SetPlaceholder(txt_TimKiem, "Nhập mã đơn hàng");
            }
        }

        private void txt_TimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Không cho nhập
            }
        }
    }
}
