using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            Image img = Image.FromFile("D:\\c#\\icon\\home-agreement.png");
            btn_TrangChu.Image = new Bitmap(img, new Size(25, 25));
            img = Image.FromFile("D:\\c#\\icon\\management.png");
            btn_DanhSachHoaDon.Image = new Bitmap(img, new Size(25, 25));
            img = Image.FromFile("D:\\c#\\icon\\warehouse.png");
            btn_DanhSachSanPham.Image = new Bitmap(img, new Size(25, 25));
            img = Image.FromFile("D:\\c#\\icon\\folder-management.png");
            btn_DatHang.Image = new Bitmap(img, new Size(25, 25));
            img = Image.FromFile("D:\\c#\\icon\\system.png");
            btn_CaiDatHeThong.Image = new Bitmap(img, new Size(25, 25));
            img = Image.FromFile("D:\\c#\\icon\\profile.png");
            btn_CaiDatTaiKhoan.Image = new Bitmap(img, new Size(25, 25));
            img = Image.FromFile("D:\\c#\\icon\\logout.png");
            btn_DangXuat.Image = new Bitmap(img, new Size(25, 25));
            img = Image.FromFile("D:\\c#\\icon\\market.png");
            btn_ThongKeDoanhThu.Image = new Bitmap(img, new Size(25, 25));
            img = Image.FromFile("D:\\c#\\icon\\button.png");
            btn_Thoat.Image = new Bitmap(img, new Size(40, 40));
        }
    }
}
