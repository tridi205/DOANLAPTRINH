using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QUANLYCUAHANG
{
    public partial class frm_ThongKe : Form
    {
        HoaDonBLL hoaDonBLL=new HoaDonBLL();
        public frm_ThongKe()
        {
            InitializeComponent();
        }

        private void frm_ThongKe_Load(object sender, EventArgs e)
        {
            List<string> list = hoaDonBLL.layCacNamLapHoaDon();
            foreach(string s in list)
            {
                cbb_Nam.Items.Add(s);
            }
            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;
            cbb_Thang.Text = month.ToString();
            cbb_Nam.Text = year.ToString();
            lbl_BieuDoDoanhThu.Text = "Biểu đồ doanh thu tháng " + month + "/" + year;
            loadChart();
        }
        public void loadChart(DataTable doanhThu)
        {
            //DataTable dt = hoaDonBLL.doanhThuNgayHomNay();
            //DataTable dt2 = hoaDonBLL.doanhThuNgayHomQua();
            DataTable dt = doanhThu;
            chart_DT.Series.Clear();
            chart_DT.ChartAreas.Clear();
            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;

            int daysInMonth = DateTime.DaysInMonth(year, month);
            // Thêm ChartArea mới
            ChartArea chartArea = new ChartArea("ChartArea1");
            chartArea.AxisX.Title = "Ngày";
            chartArea.AxisY.Title = "Doanh thu(Vnđ)";

            chart_DT.ChartAreas.Add(chartArea);
            chart_DT.ChartAreas[0].AxisX.ScrollBar.Enabled = true;
            chart_DT.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true; // Thanh cuộn bên trong biểu đồ
            chart_DT.ChartAreas[0].AxisX.ScrollBar.Size = 10; // Độ dày của thanh cuộn
            chart_DT.ChartAreas[0].AxisX.ScrollBar.ButtonStyle = System.Windows.Forms.DataVisualization.Charting.ScrollBarButtonStyles.All;
            chart_DT.ChartAreas[0].AxisX.Minimum = 1;   // Giá trị nhỏ nhất
            chart_DT.ChartAreas[0].AxisX.Maximum = daysInMonth;  // Giá trị lớn nhất
            chart_DT.ChartAreas[0].AxisX.Interval = 1;
            // Thêm Series mới
            Series series1 = new Series("Doanh Thu theo ngày");
            series1.ChartType = SeriesChartType.Column;
            series1.ChartArea = "ChartArea1"; // Đảm bảo ChartArea này tồn tại
            series1["PointWidth"] = "0.5";

            Series series2 = new Series("Doanh Thu Hôm qua");
            series2.ChartType = SeriesChartType.Column;
            series2.ChartArea = "ChartArea1"; // Đảm bảo ChartArea này tồn tại
            series2["PointWidth"] = "0.5";

            for (int i = 0; i <= daysInMonth; i++)
            {
                int kt = 0;
                foreach (DataRow dr in dt.Rows)
                {
                    if (Convert.ToInt32(dr["ngay"]) == i)
                    {
                        kt = 1;
                        double vnd = Convert.ToDouble(dr["tongtien"]);
                        vnd.ToString("C", new System.Globalization.CultureInfo("vi-VN"));
                        series1.Points.AddXY(dr["ngay"], vnd);
                        break;
                    }
                }
                if (kt == 0)
                {
                    double vnd = 0;
                    vnd.ToString("C", new System.Globalization.CultureInfo("vi-VN"));
                    series1.Points.AddXY(i, vnd);
                }

            }
            // Thêm Series vào chart
            // chart_DT.Series.Add(series2);
            chart_DT.Series.Add(series1);
        }
        public void loadChart()
        {
            //DataTable dt = hoaDonBLL.doanhThuNgayHomNay();
            //DataTable dt2 = hoaDonBLL.doanhThuNgayHomQua();
            DataTable dt = hoaDonBLL.thongKeDoanhThuThangNay();
            chart_DT.Series.Clear();
            chart_DT.ChartAreas.Clear();
            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;

            int daysInMonth = DateTime.DaysInMonth(year, month);
            // Thêm ChartArea mới
            ChartArea chartArea = new ChartArea("ChartArea1");
            chartArea.AxisX.Title = "Ngày";
            chartArea.AxisY.Title = "Doanh thu(Vnđ)";

            chart_DT.ChartAreas.Add(chartArea);
            chart_DT.ChartAreas[0].AxisX.ScrollBar.Enabled = true;
            chart_DT.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true; // Thanh cuộn bên trong biểu đồ
            chart_DT.ChartAreas[0].AxisX.ScrollBar.Size = 10; // Độ dày của thanh cuộn
            chart_DT.ChartAreas[0].AxisX.ScrollBar.ButtonStyle = System.Windows.Forms.DataVisualization.Charting.ScrollBarButtonStyles.All;
            chart_DT.ChartAreas[0].AxisX.Minimum = 1;   // Giá trị nhỏ nhất
            chart_DT.ChartAreas[0].AxisX.Maximum = daysInMonth;  // Giá trị lớn nhất
            chart_DT.ChartAreas[0].AxisX.Interval = 1;
            // Thêm Series mới
            Series series1 = new Series("Doanh Thu theo ngày");
            series1.ChartType = SeriesChartType.Column;
            series1.ChartArea = "ChartArea1"; // Đảm bảo ChartArea này tồn tại
            series1["PointWidth"] = "0.5";

            //Series series2 = new Series("Doanh Thu Hôm qua");
            //series2.ChartType = SeriesChartType.Column;
            //series2.ChartArea = "ChartArea1"; // Đảm bảo ChartArea này tồn tại
            //series2["PointWidth"] = "0.5";

            for (int i = 0; i <= daysInMonth; i++)
            {
                int kt = 0;
                foreach (DataRow dr in dt.Rows)
                {
                    if (Convert.ToInt32(dr["ngay"]) == i)
                    {
                        kt = 1;
                        double vnd = Convert.ToDouble(dr["tongtien"]);
                        vnd.ToString("C", new System.Globalization.CultureInfo("vi-VN"));
                        series1.Points.AddXY(dr["ngay"], vnd);
                        break;
                    }
                }
                if (kt == 0)
                {
                    double vnd = 0;
                    vnd.ToString("C", new System.Globalization.CultureInfo("vi-VN"));
                    series1.Points.AddXY(i, vnd);
                }

            }
            // Thêm Series vào chart
            // chart_DT.Series.Add(series2);
            chart_DT.Series.Add(series1);
        }
        private void btn_ChiTietDTTN_Click(object sender, EventArgs e)
        {
            int month=Convert.ToInt32(cbb_Thang.Text);
            int year=Convert.ToInt32(cbb_Nam.Text);
            frm_PhieuDoanhThu frm=new frm_PhieuDoanhThu(month,year);
            frm.ShowDialog();
        }

        private void btn_ChiTiet_Click(object sender, EventArgs e)
        {
            frm_DoanhSoSanPhamBanDuoc frm =new frm_DoanhSoSanPhamBanDuoc();
            frm.ShowDialog();
        }

        private void btn_ThongKe_Click(object sender, EventArgs e)
        {
            
            int thang=Convert.ToInt32(cbb_Thang.Text);
            int nam=Convert.ToInt32(cbb_Nam.Text);
            lbl_BieuDoDoanhThu.Text = "Biểu đồ doanh thu tháng " + thang + "/" + nam;
            DataTable dt = hoaDonBLL.layDoanhThuTheoThangNam(thang,nam);
            loadChart(dt);
        }
    }
}
