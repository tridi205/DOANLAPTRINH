using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DonDatHangDAL:ConnectionDB
    {
        public int createDonDatHang(int manv)
        {
            return executeNonQuery(string.Format("insert into dondathang(madh,trangthai,manv)values(dbo.getnewmadh(),0,{0})",manv));
        }
        public int getMaDHMoi()
        {
            return Convert.ToInt32(executeScalar("select dbo.getmaxmadh()"));
        }
        public int insertPhieuDatHang(SanPham sp,DonDatHang dondh)
        {
            openConnection();
            string query = @"exec themSanPhamVaoPhieu @madh,@masp,@sl,@gianhap";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@madh", dondh.mahd);
                cmd.Parameters.AddWithValue("@maSP", sp.maSP);
                cmd.Parameters.AddWithValue("@gianhap", sp.donGia);             
                cmd.Parameters.AddWithValue("@sl", sp.soLuong.ToString() ?? "");
                int rowsAffected = cmd.ExecuteNonQuery();
                closeConnection();
                return rowsAffected;
            }
        }
        public int xoaSanPhamTrongPhieuDatHang(SanPham sp,DonDatHang dondh)
        {
            openConnection();
            string query = @"delete from PhieuDatHang where madh=@madh and masp=@masp";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@madh", dondh.mahd);
                cmd.Parameters.AddWithValue("@maSP", sp.maSP);
                int rowsAffected = cmd.ExecuteNonQuery();
                closeConnection();
                return rowsAffected;
            }
        }
        public int setDonDatHang(int tt,DonDatHang dondh)
        {
            openConnection();
            string query = @"update dondathang set tongtien=@tongtien,soluong=@sl, trangthai = @tt where madh=@madh";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@madh", dondh.mahd);
                cmd.Parameters.AddWithValue("@tt", tt);
                cmd.Parameters.AddWithValue("@tongtien", dondh.tongtien);
                cmd.Parameters.AddWithValue("@sl",dondh.soluong);
                int rowsAffected = cmd.ExecuteNonQuery();
                closeConnection();
                return rowsAffected;
            }
        }
        public int kiemTraCoDonDangDaHayKhong()
        {
            return Convert.ToInt32(executeScalar("select count(*) from dondathang where trangthai=0"));
        }
        public DataTable layDanhSachSanPhamDangDat()
        {
            return executeQuery("select pdh.masp as masp,spncc.tensp as tensp,pdh.soluong as soluong,pdh.gianhap as gianhap,spncc.loai as loai from DonDatHang ddh,PhieuDatHang pdh,SanPhamCuaNCC spncc where ddh.madh=pdh.madh and pdh.masp=spncc.masp and ddh.trangthai=0");
        }
        public int layMaDhDangDat()
        {
            return Convert.ToInt32(executeScalar("select madh from dondathang where trangthai=0"));
        }
        public DataTable layDanhSachDonDatHang(string dieukien="")
        {
            return executeQuery("select * from DonDatHang where (trangthai=1 or trangthai=2) "+dieukien+"\r\norder by ngaydat desc");
        }
        public DataTable layDanhSachSPTrongDonDatHang(int madh)
        {
            return executeQuery("  select * ,sp.tensp as sanpham,sp.masp as masanpham from PhieuDatHang pdh,sanphamcuancc sp where sp.masp=pdh.masp and pdh.madh=" + madh.ToString());
        }
        public int setTrangThaiDonDatHang(DonDatHang dh,int tt)
        {
            return executeNonQuery(string.Format("update dondathang set trangthai={0} where madh={1}", tt,dh.mahd));
        }
        public int tongSoDonDatHangThangNay()
        {
            return Convert.ToInt32(executeScalar("select dbo.tongdondathangthangnay()"));
        }
        public double tongTienDatHangThangNay()
        {
            return Convert.ToDouble(executeScalar("select dbo.tongtiendathangthangnay()"));
        }
        public double tongTienDatHangTheoThangNam(int thang, int nam)
        {
            return Convert.ToDouble(executeScalar(string.Format("select dbo.tongtiendathangtheothangnam({0},{1})", thang, nam)));
        }
        public int tongSoDonDatHangTheoThangNam(int thang,int nam)
        {
            return Convert.ToInt32(executeScalar(string.Format("select dbo.tongsodondathangtheothangnam({0},{1})", thang, nam)));
        }
    }
}
