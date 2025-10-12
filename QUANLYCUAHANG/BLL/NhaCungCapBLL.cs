using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

using System.Data;
namespace BLL
{
    public class NhaCungCapBLL
    {
        NhaCungCapDAL NCC = new NhaCungCapDAL();
       
        public DataTable insertNhaCungCap()
        {
            return NCC.layDanhSachNhaCungCap();
        }
        public bool themNhaCungCap(NhaCungCap ncc)
        {
           if(NCC.themNhaCungCap(ncc) >0){
                return true;
            }
           else
                { return false; }
        }
        public int getnewMaNCC()
        {
            return NCC.getnewNCC();
        }
        public bool xoaNhaCungCap(int ncc)
        {
            if (NCC.xoaNhaCungCap(ncc) > 0)
            {
                return true;
            }
            else
            { return false; }
        }

        
        public bool updateNCC(NhaCungCap ncc)
        {
            if(NCC.updateNCC(ncc)>0)
            {
                return true;
            }
            else { return false; }
        }

        public DataTable locNCC(string dieukien = null)
        {
            if (dieukien == null)
            {
                return NCC.locNhaCungCap();
 
            }
            return NCC.locNhaCungCap(dieukien);

        }
    }
}
