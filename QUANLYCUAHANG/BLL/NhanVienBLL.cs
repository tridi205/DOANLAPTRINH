using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
namespace BLL
{
    public class NhanVienBLL
    {
        NhanVienDAL nv=new NhanVienDAL();
        public DataTable layDanhSachNV()
        {
            return nv.layDanhSachNV();
        }
        public bool thayDoiThongTinNV(NhanVien nv)
        {
            if (this.nv.thayDoiThongTinNhanVien(nv) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string layTenCuaNhanVien(int manv)
        {
            return nv.layTenCuaNhanVien(manv);
        }
        public NhanVien layThongTinNhanVien(int manv)
        {
            return nv.layThongTinNV(manv);
        }
        public bool xoaNhanVien(int manv)
        {
            if (nv.xoaNhanVien(manv) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int layMaNVMoi()
        {
            return nv.layMaNVMoi();
        }
        public int laySoLuongNV()
        {
            return nv.laySoLuongNV();
        }
        public bool themNhanVienMoi(NhanVien nv)
        {
            if(this.nv.themNhanVienMoi(nv) == 1)
            {
                return true;
            }
            return false;
        }
        public DataTable timKiemNhanVien(string dk)
        {
            return nv.timKiemNhanVien(dk);
        }
        public DataTable DangNhap(int manv,string mk)
        {
            DataTable dt = nv.DangNhap(manv,mk);
            if(dt.Rows.Count == 0)
            {
                return null;
            }
            return dt;
        }
    }
}
