using BLL;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYCUAHANG
{
    public partial class frm_QuanLyNhanVien : Form
    {
        NhanVienBLL nhanVienBLL=new NhanVienBLL();
        public frm_QuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void frm_QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            pic_Anh.ImageLocation = "D:\\c#\\icon\\profile.png";
            Image image = Image.FromFile("D:\\c#\\icon\\edit.png");
            btn_ChinhSua.Image=new Bitmap(image,new Size(25,25));
            image = Image.FromFile("D:\\c#\\icon\\diskette.png");
            btn_Luu.Image = new Bitmap(image, new Size(25, 25));
            image = Image.FromFile("D:\\c#\\icon\\add-user.png");
            btn_Them.Image = new Bitmap(image, new Size(30, 30)); 
            image = Image.FromFile("D:\\c#\\icon\\image.png");
            btn_DoiAnh.Image = new Bitmap(image, new Size(35,35));
            image = Image.FromFile("D:\\c#\\icon\\button.png"); 
            btn_HuyChinhSua.Image = new Bitmap(image, new Size(25, 25));
            image = Image.FromFile("D:\\c#\\icon\\circle.png");
            btn_Xoa.Image = new Bitmap(image, new Size(35, 35));
            image = Image.FromFile("D:\\c#\\icon\\search.png");
            btn_TimKiemNV.Image = new Bitmap(image, new Size(25, 25));
            SetPlaceholder(txt_TimKiem, "Nhập mã hoặc tên nhân viên");
            loadata();
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
        public void loadata()
        {
            dgv_DanhSachNV.DataSource = nhanVienBLL.layDanhSachNV();
            dgv_DanhSachNV.Columns["manv"].HeaderText = "Mã nhân viên";
            dgv_DanhSachNV.Columns["tennv"].HeaderText = "Tên nhân viên";
            dgv_DanhSachNV.Columns["gioitinh"].HeaderText = "Giới tính";
            dgv_DanhSachNV.Columns["ngaysinh"].HeaderText = "Ngày sinh";
            dgv_DanhSachNV.Columns["diachi"].HeaderText = "Địa chỉ";
            dgv_DanhSachNV.Columns["chucvu"].HeaderText = "Chức vụ";
            dgv_DanhSachNV.Columns["cccd"].HeaderText = "CCCD";
            dgv_DanhSachNV.Columns["email"].HeaderText = "Email";
            dgv_DanhSachNV.Columns["matkhau"].HeaderText = "Mật khẩu";
            dgv_DanhSachNV.Columns["email"].Visible = false;
            dgv_DanhSachNV.Columns["matkhau"].Visible = false;
            dgv_DanhSachNV.Columns["anh"].Visible = false;
        }
        public void loadata(DataTable dt)
        {
            dgv_DanhSachNV.DataSource = dt;
            dgv_DanhSachNV.Columns["manv"].HeaderText = "Mã nhân viên";
            dgv_DanhSachNV.Columns["tennv"].HeaderText = "Tên nhân viên";
            dgv_DanhSachNV.Columns["gioitinh"].HeaderText = "Giới tính";
            dgv_DanhSachNV.Columns["ngaysinh"].HeaderText = "Ngày sinh";
            dgv_DanhSachNV.Columns["diachi"].HeaderText = "Địa chỉ";
            dgv_DanhSachNV.Columns["chucvu"].HeaderText = "Chức vụ";
            dgv_DanhSachNV.Columns["cccd"].HeaderText = "CCCD";
            dgv_DanhSachNV.Columns["email"].HeaderText = "Email";
            dgv_DanhSachNV.Columns["matkhau"].HeaderText = "Mật khẩu";
            dgv_DanhSachNV.Columns["email"].Visible = false;
            dgv_DanhSachNV.Columns["matkhau"].Visible = false;
            dgv_DanhSachNV.Columns["anh"].Visible = false;
        }

        private void dgv_DanhSachNV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btn_ChinhSua.Enabled = true;
                DataGridViewRow row = dgv_DanhSachNV.Rows[e.RowIndex];
                NhanVien nv = new NhanVien()
                {
                    manv = Convert.ToInt32(row.Cells["manv"].Value),
                    tennv = row.Cells["tennv"].Value.ToString(),
                    gioitinh = row.Cells["gioitinh"].Value.ToString(),
                    cccd = row.Cells["cccd"].Value.ToString(),
                    sdt = row.Cells["sdt"].Value.ToString(),
                    diachi = row.Cells["diachi"].Value.ToString(),
                    email = row.Cells["email"].Value.ToString(),
                    ngaysinh = Convert.ToDateTime(row.Cells["ngaysinh"].Value),
                    chucvu = row.Cells["chucvu"].Value.ToString(),
                    mk = row.Cells["matkhau"].Value.ToString(),
                    anh = row.Cells["anh"].Value.ToString()
                    
                };
                
                txt_MaNV.Text = nv.manv.ToString();
                txt_HoTen.Text = nv.tennv;
                if (nv.gioitinh.Equals("Nam"))
                {
                    rdb_Nam.Checked = true;
                }
                else
                {
                    rdb_Nu.Checked = true;
                }
                txt_CCCD.Text = nv.cccd.ToString();
                txt_SDT.Text = nv.sdt.ToString();
                txt_DiaChi.Text=nv.diachi.ToString();
                txt_Email.Text=nv.email.ToString();
                txt_ChucVu.Text=nv.chucvu.ToString();
                txt_MatKhau.Text=nv.mk.ToString();
                dtp_NgaySinh.Value = nv.ngaysinh;
                pic_Anh.ImageLocation = nv.anh;
                btn_Xoa.Visible = true;
                if (!btn_ChinhSua.Visible)
                {
                    btn_HuyChinhSua.Visible = false;
                    btn_ChinhSua.Visible=true;
                }
                setControl(false);
            }
        }

        private void btn_DoiAnh_MouseHover(object sender, EventArgs e)
        {
            btn_DoiAnh.BackColor = Color.Gray;
        }

        private void btn_DoiAnh_MouseLeave(object sender, EventArgs e)
        {
            btn_DoiAnh.BackColor = SystemColors.ControlDarkDark;
        }

        public void setControl(bool tt)
        {
            txt_HoTen.Enabled = tt;
            rdb_Nam.Enabled = tt;
            rdb_Nu.Enabled = tt;
            txt_CCCD.Enabled = tt;
            txt_SDT.Enabled = tt;
            txt_DiaChi.Enabled = tt;
            txt_Email.Enabled = tt;
            dtp_NgaySinh.Enabled = tt;
            txt_MatKhau.Enabled = tt;
            btn_DoiAnh.Enabled = tt;
            btn_Luu.Enabled = tt;
        }
        private void btn_ChinhSua_Click(object sender, EventArgs e)
        {
            btn_HuyChinhSua.Visible = true;
            btn_ChinhSua.Visible = false;
            btn_Xoa.Visible = false;
            setControl(true);
        }
       
        private void btn_HuyChinhSua_Click(object sender, EventArgs e)
        {
            btn_ChinhSua.Visible=true;
            btn_HuyChinhSua.Visible = false ;
            setControl(false);
            NhanVien nv = nhanVienBLL.layThongTinNhanVien(Convert.ToInt32(txt_MaNV.Text));
           
            txt_HoTen.Text = nv.tennv;
            if (nv.gioitinh.Equals("Nam"))
            {
                rdb_Nam.Checked = true;
            }
            else
            {
                rdb_Nu.Checked = true;
            }
            txt_CCCD.Text = nv.cccd.ToString();
            txt_SDT.Text = nv.sdt.ToString();
            txt_DiaChi.Text = nv.diachi.ToString();
            txt_Email.Text = nv.email.ToString();
            txt_ChucVu.Text = nv.chucvu.ToString();
            txt_MatKhau.Text = nv.mk.ToString();
            dtp_NgaySinh.Value = nv.ngaysinh;
            pic_Anh.ImageLocation = nv.anh;
            btn_Xoa.Visible = true;
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
        private void btn_Luu_Click(object sender, EventArgs e)
        {
            string error = "";
            NhanVien nv = new NhanVien(); 
            if (DateTime.Now.Date.AddYears(-18) >= dtp_NgaySinh.Value)
            {
                nv.ngaysinh = dtp_NgaySinh.Value;
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
            if (!IsValidEmail(txt_Email.Text))
            {
                error += "Email không hợp lệ!\n";
            }
            if (string.IsNullOrEmpty(txt_MatKhau.Text))
            {
                error += "Mật khẩu không hợp lệ!\n";
            }
            if (string.IsNullOrEmpty(txt_DiaChi.Text))
            {
                error += "Địa chỉ không được để trống!\n";
            }
            if ( txt_SDT.Text.Length < 10)
            {
                error += "Số điện thoại không hợp lệ!\n";
            }
            nv.manv = Convert.ToInt32(txt_MaNV.Text);
            nv.tennv = txt_HoTen.Text;
            nv.cccd = txt_CCCD.Text;
            nv.sdt = txt_SDT.Text;
            nv.diachi = txt_DiaChi.Text;
            nv.email = txt_Email.Text;
            nv.ngaysinh = dtp_NgaySinh.Value;
            nv.chucvu = txt_ChucVu.Text;
            nv.mk = txt_MatKhau.Text;
            if (rdb_Nam.Checked)
            {
                nv.gioitinh=rdb_Nam.Text;
            }
            else
            {
                nv.gioitinh = rdb_Nu.Text;
            }
            nv.anh=pic_Anh.ImageLocation;
            if (error == "")
            {
                if (nhanVienBLL.thayDoiThongTinNV(nv))
                {
                    MessageBox.Show("Thông tin đã được cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    loadata();
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    return;
                }
                else
                {
                    return;
                }
            }
            
            setControl(false);
            btn_HuyChinhSua.Visible = false;
            btn_ChinhSua.Visible = true;
            btn_Xoa.Visible = true;
        }

        private void btn_DoiAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog open = new OpenFileDialog()) {
                if (open.ShowDialog() == DialogResult.OK) {
                    pic_Anh.ImageLocation = open.FileName;
                }
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Information)==DialogResult.Yes)
            {
                if (nhanVienBLL.xoaNhanVien(Convert.ToInt32(txt_MaNV.Text)))
                {
                    MessageBox.Show("Xóa thành công!", "Thông báo");
                    btn_Xoa.Visible = false;
                    loadata();
                    foreach(Control ctl in gbb_ThongTinNV.Controls)
                    {
                        if(ctl is TextBox)
                        {
                            TextBox txt= (TextBox)ctl;
                            txt.Text = "";
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Xóa không thành công!!", "Thông báo");
                }
                
            }
            else
            {
                return;
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            frm_ThemNhanVien frm_ThemNhanVien=new frm_ThemNhanVien();
            frm_ThemNhanVien.FormClosed += Frm_ThemNhanVien_FormClosed;
            frm_ThemNhanVien.ShowDialog();
        }

        private void Frm_ThemNhanVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm_QuanLyNhanVien_Load(sender, e);
        }

        private void btn_TimKiemNV_Click(object sender, EventArgs e)
        {
            if(txt_TimKiem.Text.Equals("Nhập mã hoặc tên nhân viên")||string.IsNullOrEmpty(txt_TimKiem.Text))
            {
                loadata();
                return;
            }
            else
            {
                
                if (int.TryParse(txt_TimKiem.Text, out int n))
                {
                    string dk = string.Format(" where manv={0} and chucvu<>N'Cửa hàng trưởng'", txt_TimKiem.Text);
                    loadata(nhanVienBLL.timKiemNhanVien(dk));
                }
                else
                {
                    string dk = string.Format(" where tennv like N'%{0}%' and chucvu<>N'Cửa hàng trưởng'", txt_TimKiem.Text);
                    loadata(nhanVienBLL.timKiemNhanVien(dk));
                }
                SetPlaceholder(txt_TimKiem, "Nhập mã hoặc tên nhân viên");
            }
        }
    }
}
