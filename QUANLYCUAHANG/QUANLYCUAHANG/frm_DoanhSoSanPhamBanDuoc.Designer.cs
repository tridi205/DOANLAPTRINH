namespace QUANLYCUAHANG
{
    partial class frm_DoanhSoSanPhamBanDuoc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart_SoLuongSPBan = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart_SoLuongSPBan)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_SoLuongSPBan
            // 
            chartArea2.Name = "ChartArea1";
            this.chart_SoLuongSPBan.ChartAreas.Add(chartArea2);
            this.chart_SoLuongSPBan.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chart_SoLuongSPBan.Legends.Add(legend2);
            this.chart_SoLuongSPBan.Location = new System.Drawing.Point(0, 0);
            this.chart_SoLuongSPBan.Name = "chart_SoLuongSPBan";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart_SoLuongSPBan.Series.Add(series2);
            this.chart_SoLuongSPBan.Size = new System.Drawing.Size(1223, 757);
            this.chart_SoLuongSPBan.TabIndex = 0;
            this.chart_SoLuongSPBan.Text = "chart1";
            // 
            // frm_DoanhSoSanPhamBanDuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 757);
            this.Controls.Add(this.chart_SoLuongSPBan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_DoanhSoSanPhamBanDuoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doanh số bán sản phẩm";
            this.Load += new System.EventHandler(this.frm_DoanhSoSanPhamBanDuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_SoLuongSPBan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_SoLuongSPBan;
    }
}