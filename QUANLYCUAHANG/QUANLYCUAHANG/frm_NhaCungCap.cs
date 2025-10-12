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
    public partial class frm_NhaCungCap : Form
    {
        NhaCungCapBLL nccbll = new NhaCungCapBLL();
        string originalTenNhaCungCap, originalDiaChi, originalSoDienThoai, originalEmail;

        public frm_NhaCungCap()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pan_thongtin_Paint(object sender, PaintEventArgs e)
        {

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

        private void frm_NhaCungCap_Load(object sender, EventArgs e)
        {
            dgv_dsNCC.DataSource = nccbll.insertNhaCungCap();
            //dgv_dsNCC.Columns["mancc"].Visible= true;
            SetPlaceholder(txt_timkiem, "Nhập mã hoặc tên nhà cung cấp");

            originalTenNhaCungCap = txt_tenncc.Text;
            originalDiaChi = txt_diachi.Text;
            originalSoDienThoai = txt_sdt.Text;
            originalEmail = txt_email.Text;
            LoadData();
            Image img = Image.FromFile("D:\\c#\\icon\\home-agreement.png");
            img = Image.FromFile("D:\\c#\\icon\\icons8-plus-69.png");
            btn_them.Image = new Bitmap(img, new Size(35, 35));
            img = Image.FromFile("D:\\c#\\icon\\icons8-cancel-69.png");
            
            btn_xoa.Image = new Bitmap(img, new Size(35, 35));
            img = Image.FromFile("D:\\c#\\icon\\icons8-pencil-69.png");
            
            btn_Sua.Image = new Bitmap(img, new Size(35, 35));
            img = Image.FromFile("D:\\c#\\icon\\icons8-document-69.png");
            
            btn_luu.Image = new Bitmap(img, new Size(35, 35));


            img = Image.FromFile("D:\\c#\\icon\\icons8-search-69.png");
            btn_timkiem.Image = new Bitmap(img, new Size(20, 20));


            //


        }
        private void CheckChanges()
        {
            if (originalTenNhaCungCap != txt_tenncc.Text || originalDiaChi != txt_diachi.Text || originalSoDienThoai != txt_sdt.Text|| originalEmail!=txt_email.Text)

            {
                btn_Sua.Enabled = true;
            }
            else
            {
                btn_Sua.Enabled = false;
            }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {

            string mess = "";
            if (string.IsNullOrEmpty(txt_tenncc.Text))
            {
                mess += "Chưa nhập tên nhà cung cấp!\n";
            }

            if (string.IsNullOrEmpty(txt_sdt.Text))
            {
                mess += "Chưa nhập số điện thoại nhà cung cấp!\n";
            }
            

            if (string.IsNullOrEmpty(txt_diachi.Text))
            {
                mess += "Chưa nhập địa chỉ nhà cung cấp!\n";
            }
            if (string.IsNullOrEmpty(txt_email.Text))
            {
                mess += "Chưa nhập email nhà cung cấp!\n";
            }
            
            NhaCungCap ncc = new NhaCungCap();
            if (mess != "")
            {
                if (MessageBox.Show(mess, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    return;
                }
                else
                {
                    return;
                }
            }
            if (MessageBox.Show("Bạn có chắc chắn muốn thay đổi không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
              
                ncc.mancc = Convert.ToInt32(txt_mancc.Text);
                ncc.tenncc = txt_tenncc.Text;
                ncc.sdt = txt_sdt.Text;
                ncc.diachi = txt_diachi.Text;
                ncc.email = txt_email.Text;
                if (this.nccbll.updateNCC(ncc))
                {
                    MessageBox.Show("Bạn Đã cập nhật thành công", "Thông báo");
                    LoadData();
                    txt_diachi.ReadOnly = true;
                    txt_email.ReadOnly = true;
                    txt_mancc.ReadOnly = true;
                    txt_tenncc.ReadOnly = true;
                    txt_sdt.ReadOnly = true;
                    btn_Sua.Enabled = false;
                    btn_luu.Visible = false;
                    btn_xoa.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Bạn Đã cập nhật thất bại!", "Thông báo");
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

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            btn_luu.Visible = true;
            btn_xoa.Enabled = false;

            txt_diachi.ReadOnly = false;
            txt_email.ReadOnly = false;
            txt_mancc.Enabled = false;
            txt_tenncc.ReadOnly = false;
            txt_sdt.ReadOnly = false;

            
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            btn_luu.Visible = false;
            frm_themNhaCungCap frm = new frm_themNhaCungCap();
            frm.FormClosed += Frm_FormClosed;
            frm.ShowDialog();
            btn_xoa.Enabled = false;

        }

        private void Frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadData();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            btn_luu.Visible = false;
            
            if (dgv_dsNCC.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    NhaCungCap ncc = new NhaCungCap();
                    ncc.mancc = Convert.ToInt32(txt_mancc.Text);

                    if (this.nccbll.xoaNhaCungCap(ncc.mancc))
                    {
                        MessageBox.Show("Bạn đã xoá thành công", "Thông báo");
                        LoadData();

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
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // MessageBox.Show(Convert.ToInt32(txt_mancc.Text).GetType().ToString());

            }
            afterDo();

        }

        private void dgv_dsNCC_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                btn_Sua.Enabled = true;
                var mancc = dgv_dsNCC.Rows[e.RowIndex].Cells[0].Value;
                var tenncc = dgv_dsNCC.Rows[e.RowIndex].Cells[1].Value;
                var sdt = dgv_dsNCC.Rows[e.RowIndex].Cells[3].Value;
                var diachi = dgv_dsNCC.Rows[e.RowIndex].Cells[2].Value;
                var email = dgv_dsNCC.Rows[e.RowIndex].Cells[4].Value;
                //MessageBox.Show(dgv_dsNCC.Rows[e.RowIndex].Cells[4].Value.ToString());
                //Hiển thị giá trị vào TextBox
                txt_mancc.Text = mancc.ToString();
                txt_tenncc.Text = tenncc.ToString();
                txt_email.Text = email.ToString();
                txt_sdt.Text = sdt.ToString();
                txt_diachi.Text = diachi.ToString();
            }
            btn_xoa.Enabled = true;

        }

        private void dgv_dsNCC_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        public void LoadData()
        {
            dgv_dsNCC.DataSource = nccbll.insertNhaCungCap();
            
            dgv_dsNCC.Columns["mancc"].HeaderText = "Mã Nhà Cung Cấp";
            dgv_dsNCC.Columns["tenncc"].HeaderText = "Tên Nhà Cung Cấp";
            dgv_dsNCC.Columns["sdt"].HeaderText = "Số Điện Thoại";
            dgv_dsNCC.Columns["diachi"].HeaderText = "Địa Chỉ";
            dgv_dsNCC.Columns["email"].HeaderText = "Email";
            
            btn_luu.Visible = false;
            btn_Sua.Enabled = false;
            btn_xoa.Enabled = false;
            txt_diachi.ReadOnly = true;
            txt_email.ReadOnly = true;
            txt_mancc.ReadOnly = true;
            txt_tenncc.ReadOnly = true;
            txt_sdt.ReadOnly = true;
        }
        public void LoadData(DataTable dt)
        {
            dgv_dsNCC.DataSource = dt;

           // dgv_dsNCC.Columns["mancc"].HeaderText = "Mã Nhà Cung Cấp";
            //dgv_dsNCC.Columns["tenncc"].HeaderText = "Tên Nhà Cung Cấp";
            //dgv_dsNCC.Columns["sdt"].HeaderText = "Số Điện Thoại";
            //dgv_dsNCC.Columns["diachi"].HeaderText = "Địa Chỉ";
            //dgv_dsNCC.Columns["email"].HeaderText = "Email";

            btn_luu.Visible = false;
            btn_Sua.Enabled = false;
            btn_xoa.Enabled = false;
            txt_diachi.ReadOnly = true;
            txt_email.ReadOnly = true;
            txt_mancc.ReadOnly = true;
            txt_tenncc.ReadOnly = true;
            txt_sdt.ReadOnly = true;
        }

        public void afterDo()
        {
            LoadData();
            txt_diachi.Text=string.Empty;
            txt_mancc.Text=string.Empty;
            txt_sdt.Text=string.Empty;
            txt_tenncc.Text=string.Empty;
            txt_timkiem.Text=string.Empty;
            txt_email.Text= string.Empty;
        }




        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            
        }

        private void txt_tennc_TextChanged(object sender, EventArgs e)
        {
            CheckChanges ();
        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {
            CheckChanges();
        }

        private void txt_mancc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_diachi_TextChanged(object sender, EventArgs e)
        {
            CheckChanges();
        }

        private void txt_sdt_TextChanged(object sender, EventArgs e)
        {
            CheckChanges();
        }

        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {
           
            string dk = "";
            if (txt_timkiem.Text == "Nhập mã hoặc tên nhà cung cấp" || string.IsNullOrEmpty(txt_timkiem.Text))
            {
                //SetPlaceholder(txt_timkiem, "Nhập mã hoặc tên nhà cung cấp");
                LoadData();
                return;
            }
            if (int.TryParse(txt_timkiem.Text, out int n))
            {
                dk += string.Format(" mancc={0}", txt_timkiem.Text);
                LoadData(nccbll.locNCC(dk));
            }
            else
            {
                dk += string.Format(" tenncc like N'%{0}%'", txt_timkiem.Text);
                LoadData(nccbll.locNCC(dk));
            }
            
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            string dk = "";
            if (txt_timkiem.Text == "Nhập mã hoặc tên nhà cung cấp" || string.IsNullOrEmpty(txt_timkiem.Text))
            {
                SetPlaceholder(txt_timkiem, "Nhập mã hoặc tên nhà cung cấp");
                LoadData();
                return;
            }
            if (int.TryParse(txt_timkiem.Text, out int n))
            {
                dk += string.Format(" mancc={0}", txt_timkiem.Text);
                LoadData(nccbll.locNCC(dk));
            }
            else
            {
                dk += string.Format(" tenncc like N'%{0}%'", txt_timkiem.Text);
                LoadData(nccbll.locNCC(dk));
            }
            SetPlaceholder(txt_timkiem, "Nhập mã hoặc tên nhà cung cấp");
        }

        private void dgv_dsNCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
