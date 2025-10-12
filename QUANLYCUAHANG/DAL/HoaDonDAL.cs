using Entity;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HoaDonDAL: ConnectionDB
    {
        public DataTable layDachSachHoaDon()
        {
            return executeQuery("select * from hoadon");
        }
        public int soLuongHoaDonNgayHomNay()
        {
            return Convert.ToInt32(executeScalar("select count(*) from HoaDon where month(ngaylap)=month(GETDATE()) and DAY(ngaylap)=day(getdate()) and year(ngaylap)=year(getdate())"));
        }
        public DataTable layDachSachHoaDonCuaNgayHomNay()
        {
            return executeQuery("select * from hoadon where CAST(ngaylap AS DATE) = CAST(GETDATE() AS DATE)");
        }
        public DataTable layDanhSachHoaDon(string dieukien="")
        {
            return executeQuery(string.Format("select * from hoadon where {0}", dieukien));
        }
        public string tenNhanVienLapHD(int mahd)
        {
            return executeScalar(string.Format("select nv.tennv\r\nfrom hoadon hd,NhanVien nv\r\nwhere  nv.manv=hd.MANV and  hd.mahd={0}",mahd)).ToString();
        }
        public DataTable layChiTietHosDon(int mahd)
        {
            return executeQuery(string.Format("select sp.tensp as tensp,cthd.masp as masp, cthd.soluong as soluong,cthd.thanhtien as thanhtien, cthd.dongia as dongia\r\nfrom chitiethoadon cthd, sanpham sp\r\nwhere cthd.masp=sp.masp and cthd.mahd={0}", mahd));
        }
        public DataTable doanhThuNgayHomNay()
        {
            return executeQuery("exec DoanhThuNgayHomNay");
        }
        public DataTable doanhThuNgayHomQua()
        {
            return executeQuery("exec doanhthungayhomqua");
        }
        public int themHoaDon(HoaDon hd)
        {
            openConnection();
            string query = @"insert into hoaDon(mahd,tongtien,trangthai,manv) values (@mahd,@tongtien,@trangthai,@manv)";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@mahd", hd.mahd);
                cmd.Parameters.AddWithValue("@tongtien",hd.tongtien);
                cmd.Parameters.AddWithValue("@trangthai", hd.trangthai);
                cmd.Parameters.AddWithValue("@manv", hd.manv);
                int rowsAffected = cmd.ExecuteNonQuery();
                closeConnection();
                return rowsAffected;
            }
        }
        public int themChiTietVaoHD(HoaDon hd,SanPham sp)
        {
            openConnection();
            string query = @"insert into chitiethoadon(mahd,masp,soluong,thanhtien,dongia)values(@mahd,@masp,@sl,@thanhtien,@dongia)";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@mahd", hd.mahd);
                cmd.Parameters.AddWithValue("@masp", sp.maSP);
                cmd.Parameters.AddWithValue("@sl", sp.soLuong);
                cmd.Parameters.AddWithValue("@thanhtien", sp.thanhtien);
                cmd.Parameters.AddWithValue("@dongia", sp.donGia);
                int rowsAffected = cmd.ExecuteNonQuery();
                closeConnection();
                return rowsAffected;
            }
        }
        public int layMaHDMoi()
        {
            return Convert.ToInt32(executeScalar("select dbo.newMaHD()"));
        }
        public DataTable thongKeDoanhThuThangNay()
        {
            return executeQuery("  exec thongkedoanhthuthangnay");
        }
        public int layTongHoaDonThangNay()
        {
            return Convert.ToInt32(executeScalar("select dbo.tonghoadonthangnay()"));
        }
        public int layTongHoaDonBiHuyThangNay()
        {
            return Convert.ToInt32(executeScalar("select dbo.tonghoadonbihuythangnay()"));
        }
        public double layTongDoanhthuThangNay()
        {
            return Convert.ToDouble(executeScalar("select dbo.tongdoanhthuthangnay()"));
        }
        public List<string> layCacNamLapHoaDon()
        {
            List<string> Nam = new List<string>();
            DataTable dt = new DataTable();
            openConnection();
            dt = executeQuery("select distinct year(ngaylap) as nam\r\nfrom hoadon ");
            foreach (DataRow dr in dt.Rows)
            {
                Nam.Add(dr["nam"].ToString());
            }
            closeConnection();
            return Nam;
        }
        public DataTable layDoanhThuTheoThangNam(int thang,int nam)
        {
            return executeQuery(string.Format("  exec thongkedoanhthutheothangnam {0},{1}",thang,nam));
        }
        public double tongDoanhThuTheoThangNam(int thang, int nam)
        {
            return Convert.ToDouble(executeScalar(string.Format("select dbo.tongdoanhthutheothangnam({0},{1})", nam, thang)));
        }
        public int tongSoHoaDonTheoThangNam(int thang,int nam)
        {
            return Convert.ToInt32(executeScalar( string.Format("select dbo.tonghoadontheothangnam({0},{1})", thang,nam)));
        }
        public int tongSoHoaDonBiHuyTheoThangNam( int thang,int nam)
        {
            return Convert.ToInt32(executeScalar(string.Format("select dbo.tonsohoadonbihuytheothangnam({0},{1})", thang, nam)));
        }
        public int HuyHoaDon(int mahd)
        {
            return executeNonQuery(string.Format("update hoadon set trangthai=0 where mahd={0}",mahd));
        }
    }
}
