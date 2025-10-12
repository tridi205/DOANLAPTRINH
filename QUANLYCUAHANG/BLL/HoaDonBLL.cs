using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;
namespace BLL
{
    public class HoaDonBLL
    {
        HoaDonDAL hd=new HoaDonDAL();
        public DataTable layDanhSachHoaDon(string dieukien=null)
        {
            if (dieukien == null)
            {
                return hd.layDachSachHoaDon();
            }
            return hd.layDanhSachHoaDon(dieukien);
        }
        public int laySoLuongHoaDonNgayHomNay()
        {
            return hd.soLuongHoaDonNgayHomNay();
        }
        public DataTable layDanhSachHoaDonCuaNgayHomNay()
        {
            return hd.layDachSachHoaDonCuaNgayHomNay();
        }
        public string layTenNhanVienLapHoaDon(int mahd)
        {
            return hd.tenNhanVienLapHD(mahd);
        }
        public DataTable layChiTietHoaDOn(int mahd)
        {
            if (hd.layChiTietHosDon(mahd).Rows.Count==0)
            {
                return null;
            }
            return hd.layChiTietHosDon(mahd);
        }
        public DataTable doanhThuNgayHomNay()
        {
            return hd.doanhThuNgayHomNay();
        }
        public DataTable doanhThuNgayHomQua()
        {
            return hd.doanhThuNgayHomQua();
        }
        public bool themHoaDon(HoaDon hd)
        {
            if (this.hd.themHoaDon(hd) > 0)
            {
                return true;
            }
            return false;
        }
        public int layMaHDMoi()
        {
            return hd.layMaHDMoi();
        }
        public bool themChiTietHD(HoaDon hd,SanPham sp)
        {
            if(this.hd.themChiTietVaoHD(hd,sp) > 0)
            {
                return true;
            }
            return false;
        }
        public DataTable thongKeDoanhThuThangNay()
        {
            return hd.thongKeDoanhThuThangNay();
        }
       public int layTongHoaDonThangNay()
        {
            return hd.layTongHoaDonThangNay();
        }
        public int layTongHoaDonBiHuyThangNay()
        {
            return hd.layTongHoaDonBiHuyThangNay();
        }
        public double layTongDoanhthuThangNay()
        {
            return hd.layTongDoanhthuThangNay();
        }
        public List<string> layCacNamLapHoaDon()
        {
            return hd.layCacNamLapHoaDon();
        }
        public DataTable layDoanhThuTheoThangNam(int thang, int nam)
        {
            return hd.layDoanhThuTheoThangNam(thang,nam);
        }
        public double tongDoanhThuTheoThangNam(int thang, int nam)
        {
            return hd.tongDoanhThuTheoThangNam(thang, nam);
        }
        public int tongSoHoaDonTheoThangNam(int thang, int nam)
        {
            return hd.tongSoHoaDonTheoThangNam(thang, nam);
        }
        public int tongSoHoaDonBiHuyTheoThangNam(int thang, int nam)
        {
            return hd.tongSoHoaDonBiHuyTheoThangNam(thang, nam);
        }
        public bool HuyHoaDon(int mahd)
        {
            if (hd.HuyHoaDon(mahd)>0)
            {
                return true;
            }
            return false;
        }
    }
}
