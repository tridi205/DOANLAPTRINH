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
    public class SanPhamBLL
    {
        private SanPhamDAL sanPhamDAL = new SanPhamDAL();

        public List<SanPham> LayDanhSachSanPham()
        {
            return sanPhamDAL.GetAllSanPham();
        }

        public DataTable layDanhSachSanPhamBangDataTable()
        {
            return sanPhamDAL.getAllSanPhambyDataTable();
        }
        public int thayDoiSanPham(string query)
        {
            return sanPhamDAL.thayDoiSanPham(query);
        }
        public SanPham chiTietSanPham(string masp)
        {
            return sanPhamDAL.chiTietSanPham(masp);
        }
        public DataTable locSanPham(string DieuKienLoc=null)
        {
            if(DieuKienLoc == null)
            {
                return sanPhamDAL.locSanPham();
            }
            return sanPhamDAL.locSanPham(DieuKienLoc);
        }
        public List<string> loaiSP()
        {
            return sanPhamDAL.layLoaiSanPham();
        }
        public List<string> NccSP()
        {
            return sanPhamDAL.layNCCSanPham();
        }
        public int layMaSPMoi() { 
            return sanPhamDAL.laymasp();
        }
        public bool themSanPhamMoi(SanPham sp)
        {
            if (sanPhamDAL.themSanPhamNcc(sp) > 0)
            {
                return true;
            }
            else
            {
                return false;   
            }
        }
        public bool themSanPhamVaoKho(SanPham sp)
        {
            if (sanPhamDAL.themSanPhamVaoKho(sp) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public DataTable danhSachSanPhamNcc() { 
            return sanPhamDAL.laySanPhamNcc();
        }
        public List<string> danhSachLoaiSanPhamCuaNcc()
        {
            return sanPhamDAL.layLoaiSanPhamCuaNcc();
        }
        public List<string> danhSachNCC()
        {
            return sanPhamDAL.layNCC();
        }
        public DataTable locSanPhamCuaNcc(string DieuKienLoc = null)
        {
            if (DieuKienLoc == null)
            {
                return sanPhamDAL.locSanPhamNcc();
            }
            return sanPhamDAL.locSanPhamNcc(DieuKienLoc);
        }
        public DataTable layThongTinSanPhamCanTim(int masp)
        {
            if (sanPhamDAL.laySanPhamCanTim(masp).Rows.Count > 0)
            {
                return sanPhamDAL.laySanPhamCanTim(masp);
            }
            return null;
        }
        public bool nhapSanPhamVaoKho(int masp,int sl)
        {
            if (sanPhamDAL.nhapSanPhamVaoKho(masp, sl) > 0)
            {
                return true;
            }
            return false;
        }
        public bool xoaSanPham(int masp)
        {
            if (sanPhamDAL.xoaSanPham(masp) > 0)
            {
                return true;
            }
            return false;
        }
        public DataTable soLuongSanPhamBanDuoc()
        {
            return sanPhamDAL.soLuongSanPhamBanDuoc();
        }
        
    }
}
