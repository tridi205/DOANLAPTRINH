using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QUANLYCUAHANG
{
    public partial class frm_TrangChu : Form
    {
        HoaDonBLL hoaDonBLL = new HoaDonBLL();
        NhanVienBLL nhanVienBLL=new NhanVienBLL();
        public frm_TrangChu()
        {
            InitializeComponent();
        }

        private void frm_TrangChu_Load(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
            lbl_ThoiGian.Text ="Hôm nay là "+ DateTime.Now.ToString("dddd, dd/MM/yyyy", new CultureInfo("vi-VN"));
            lbl_DongHo.Text="Bây giờ là "+DateTime.Now.ToString("HH:mm:ss");
            Image img = Image.FromFile("D:\\c#\\icon\\user.png");
            btn_TaiKhoan.Image = new Bitmap(img, new Size(40, 40));
            img = Image.FromFile("D:\\c#\\icon\\bell.png");
            btn_ThongBao.Image = new Bitmap(img, new Size(40, 40));
            lbl_SoLuongNV.Text = (nhanVienBLL.laySoLuongNV()-1).ToString();
            lbl_ChaoMung.Text += frm_Main.nv.tennv;
            loadChart();
        }

        private void loadChart()
        {
            DataTable dt = hoaDonBLL.doanhThuNgayHomNay();
            DataTable dt2 = hoaDonBLL.doanhThuNgayHomQua();
            chart_DTHomQuaVaHomNay.Series.Clear();
            chart_DTHomQuaVaHomNay.ChartAreas.Clear();

            // Thêm ChartArea mới
            ChartArea chartArea = new ChartArea("ChartArea1");
            chartArea.AxisX.Title = "Thời gian(h)";
            chartArea.AxisY.Title = "Doanh thu(Vnđ)";

            chart_DTHomQuaVaHomNay.ChartAreas.Add(chartArea);
            chart_DTHomQuaVaHomNay.ChartAreas[0].AxisX.ScrollBar.Enabled = true;
            chart_DTHomQuaVaHomNay.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true; // Thanh cuộn bên trong biểu đồ
            chart_DTHomQuaVaHomNay.ChartAreas[0].AxisX.ScrollBar.Size = 10; // Độ dày của thanh cuộn
            chart_DTHomQuaVaHomNay.ChartAreas[0].AxisX.ScrollBar.ButtonStyle = System.Windows.Forms.DataVisualization.Charting.ScrollBarButtonStyles.All;
            chart_DTHomQuaVaHomNay.ChartAreas[0].AxisX.Minimum = 0;   // Giá trị nhỏ nhất
            chart_DTHomQuaVaHomNay.ChartAreas[0].AxisX.Maximum = 23;  // Giá trị lớn nhất
            chart_DTHomQuaVaHomNay.ChartAreas[0].AxisX.Interval = 1;
            // Thêm Series mới
            Series series1 = new Series("Doanh Thu Hôm nay");
            series1.ChartType = SeriesChartType.Column;
            series1.ChartArea = "ChartArea1"; // Đảm bảo ChartArea này tồn tại
            series1["PointWidth"] = "0.5";

            Series series2 = new Series("Doanh Thu Hôm qua");
            series2.ChartType = SeriesChartType.Column;
            series2.ChartArea = "ChartArea1"; // Đảm bảo ChartArea này tồn tại
            series2["PointWidth"] = "0.5";
            for (int i = 0; i < 24; i++)
            {
                int kt = 0;
                foreach (DataRow dr in dt.Rows)
                {
                    if (Convert.ToInt32(dr["GioHienTai"]) == i)
                    {
                        kt = 1;
                        double vnd = Convert.ToDouble(dr["Doanhthu"]);
                        vnd.ToString("C", new System.Globalization.CultureInfo("vi-VN"));
                        series1.Points.AddXY(dr["GioHienTai"] + "H", vnd);
                        break;
                    }
                }
                if (kt == 0)
                {
                    double vnd = 0;
                    vnd.ToString("C", new System.Globalization.CultureInfo("vi-VN"));
                    series1.Points.AddXY(i+"H", vnd);
                }
                kt = 0;
                foreach (DataRow dr in dt2.Rows)
                {
                    if (Convert.ToInt32(dr["GioHienTai"]) == i)
                    {
                        kt = 1;
                        double vnd = Convert.ToDouble(dr["Doanhthuhomqua"]);
                        vnd.ToString("C", new System.Globalization.CultureInfo("vi-VN"));
                        series2.Points.AddXY(dr["GioHienTai"] + "H", vnd);
                        break;
                    }
                }
                if (kt == 0)
                {
                    double vnd = 0;
                    vnd.ToString("C", new System.Globalization.CultureInfo("vi-VN"));
                    series2.Points.AddXY(i + "H", vnd);
                }
            }
            // Thêm Series vào chart
            chart_DTHomQuaVaHomNay.Series.Add(series2);
            chart_DTHomQuaVaHomNay.Series.Add(series1);
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            lbl_DongHo.Text = "Bây giờ là " + DateTime.Now.ToString("HH:mm:ss");
            lbl_ThoiGian.Text = "Hôm nay là " + DateTime.Now.ToString("dddd, dd/MM/yyyy", new CultureInfo("vi-VN"));
        }

        private void btn_CaiDat_Click(object sender, EventArgs e)
        {

        }

        private void btn_NhanVien_Click(object sender, EventArgs e)
        {
            this.Text=btn_NhanVien.Text;
            this.Close();
        }

        private void btn_HoaDon_Click(object sender, EventArgs e)
        {
            this.Text = btn_HoaDon.Text;
            this.Close();
        }

        private void btn_SanPham_Click(object sender, EventArgs e)
        {
            this.Text = btn_SanPham.Text;
            this.Close();
        }

        private void btn_DatHang_Click(object sender, EventArgs e)
        {
            this.Text = btn_DatHang.Text;
            this.Close();
        }
    }
}
