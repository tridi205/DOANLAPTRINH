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
    public class DonDatHangBLL
    {
        DonDatHangDAL dh = new DonDatHangDAL();
        public int insertDonDatHang(int manv)
        {
            return dh.createDonDatHang(manv);
        }
        public int layMaSPMoiNhat()
        {
            return dh.getMaDHMoi();
        }
        public bool createPhieuDatHang(SanPham sp,DonDatHang dondh) {
            if(dh.insertPhieuDatHang(sp,dondh)>0)
                return true;
            return false;
        }
        public bool xoaSPTrongPhieu(SanPham sp,DonDatHang dondh)
        {
            if (dh.xoaSanPhamTrongPhieuDatHang(sp, dondh) > 0)
                return true;
            return false;
        }
        public bool setTrangThaiHD(int tt,DonDatHang dondh)
        {
            if (dh.setDonDatHang(tt, dondh) > 0)
                return true;
            return false;
        }
        public bool getDonDangDat()
        {
            if (dh.kiemTraCoDonDangDaHayKhong() == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public DataTable DanhSachSanPhamDangDat()
        {
            return dh.layDanhSachSanPhamDangDat();
        }
        public int layMadhDangDat()
        {
            return dh.layMaDhDangDat();
        }
        public DataTable layDanhSachDonDatHang(string dieukien="")
        {
            return dh.layDanhSachDonDatHang(dieukien);
        }
        public DataTable layDanhSachSPTrongDonDatHang(int madh)
        {
            return dh.layDanhSachSPTrongDonDatHang(madh);
        }
        public bool setTrangThaiDonDatHang(DonDatHang dh,int tt)
        {
            if (this.dh.setTrangThaiDonDatHang(dh,tt)>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int tongSoDonDatHangThangNay()
        {
            return dh.tongSoDonDatHangThangNay();
        }
        public double tongTienDatHangThangNay()
        {
            return dh.tongTienDatHangThangNay();
        }
        public double tongTienDatHangTheoThangNam(int thang, int nam)
        {
            return dh.tongTienDatHangTheoThangNam(thang,nam);
        }
        public int tongSoDonDatHangTheoThangNam(int thang, int nam)
        {
            return dh.tongSoDonDatHangTheoThangNam(thang,nam);
        }
    }
}
