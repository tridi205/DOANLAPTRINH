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
    public partial class frm_DoanhSoSanPhamBanDuoc : Form
    {
        SanPhamBLL SanPhamBLL=new SanPhamBLL();
        public frm_DoanhSoSanPhamBanDuoc()
        {
            InitializeComponent();
        }

        private void frm_DoanhSoSanPhamBanDuoc_Load(object sender, EventArgs e)
        {
            chart_SoLuongSPBan.Series.Clear();

            // Tạo series mới
            Series barSeries = new Series
            {
                Name = "Số lượng sản phẩm bán",
                ChartType = SeriesChartType.Bar
            };
            DataTable dt = SanPhamBLL.soLuongSanPhamBanDuoc();
            foreach (DataRow dr in dt.Rows)
            {
                barSeries.Points.AddXY(dr["tensp"], dr["soluong"]);
            }
            chart_SoLuongSPBan.Series.Add(barSeries);
            chart_SoLuongSPBan.ChartAreas[0].AxisY.LabelStyle.Enabled = false;

            // Hiển thị tên sản phẩm trên thanh
            foreach (var point in barSeries.Points)
            {
                point.Label = $"{point.AxisLabel} ({point.YValues[0]})";
            }
            barSeries["BarLabelStyle"] = "Center";
            barSeries.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            chart_SoLuongSPBan.ChartAreas[0].AxisX.Title = "Số lượng bán";
            chart_SoLuongSPBan.ChartAreas[0].AxisY.Title = "Sản phẩm";
            chart_SoLuongSPBan.ChartAreas[0].AxisY.Interval = 1;
            chart_SoLuongSPBan.ChartAreas[0].AxisY.LabelStyle.Angle = 0;
            chart_SoLuongSPBan.ChartAreas[0].AxisY.MajorGrid.Enabled = false;

            // Cuộn nếu có nhiều sản phẩm
            chart_SoLuongSPBan.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
            chart_SoLuongSPBan.ChartAreas[0].AxisY.ScrollBar.Enabled = true;// Hiển thị chú thích
        }
    }
}
