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
    public class SanPhamDAL:ConnectionDB
    {
       
        public List<SanPham> GetAllSanPham()
        {
            List<SanPham> dsSanPham = new List<SanPham>();
            DataTable dt = new DataTable();
            openConnection();
            dt = executeQuery("select * from sanpham");
            foreach (DataRow dr in dt.Rows)
            {
                dsSanPham.Add(new SanPham
                {
                    maSP = Convert.ToInt32(dr["MaSP"]),
                    tenSP = dr["TenSP"].ToString(),
                    donGia = Convert.ToDouble(dr["DonGia"]),
                    soLuong = Convert.ToInt32(dr["SoLuong"]),  
                    image = dr["image"].ToString(),
                    loai = dr["Loai"].ToString(),
                    ncc = dr["NCC"].ToString()
                });
            }
            closeConnection();
            return dsSanPham;
        }
        public DataTable getAllSanPhambyDataTable()
        {
            return executeQuery("select * from sanpham sp,NhaCungCap ncc where ncc=mancc");
        }
        public int thayDoiSanPham(string query)
        {
            return executeNonQuery(query);
        }
        public SanPham chiTietSanPham(string masp)
        {
            string query = string.Format("SELECT * FROM SanPham where masp={0}", masp);
            openConnection();
            DataTable dt = executeQuery(query);
            DataRow row = dt.Rows[0];
            SanPham sp = new SanPham() {
                maSP = Convert.ToInt32(row["MaSP"]),
                tenSP = row["TenSP"].ToString(),
                donGia = Convert.ToDouble(row["DonGia"]),
                soLuong = Convert.ToInt32(row["SoLuong"]),  
                image = row["image"].ToString(),
                loai = row["Loai"].ToString(),
                ncc = row["NCC"].ToString()
            };
            closeConnection();
            return sp;
        }
        public DataTable locSanPham(string DieuKienLoc)
        {
            string query = string.Format("select * from sanpham sp,NhaCungCap ncc where ncc=mancc and {0}", DieuKienLoc);
            openConnection();
            DataTable dt = executeQuery(query);
            closeConnection();
            return dt;
        }
        public DataTable locSanPham()
        {
            return executeQuery("select * from sanpham");
        }
        public List<string> layLoaiSanPham()
        {
            List<string> dsLoaiSP = new List<string>();
            DataTable dt = new DataTable();
            openConnection();
            dt = executeQuery("select distinct loai from sanpham");
            foreach (DataRow dr in dt.Rows)
            {
                dsLoaiSP.Add(dr["loai"].ToString());
            }
            closeConnection();
            return dsLoaiSP;
        }
        public List<string> layNCCSanPham()
        {
            List<string> dsNCCSP = new List<string>();
            DataTable dt = new DataTable();
            openConnection();
            dt = executeQuery("select distinct tenncc from sanpham sp,NhaCungCap ncc where ncc=mancc");
            foreach (DataRow dr in dt.Rows)
            {
                dsNCCSP.Add(dr["tenncc"].ToString());
            }
            closeConnection();
            return dsNCCSP;
        }
        public List<string> layLoaiSanPhamCuaNcc()
        {
            List<string> dsLoaiSP = new List<string>();
            DataTable dt = new DataTable();
            openConnection();
            dt = executeQuery("select distinct loai from sanphamcuancc");
            foreach (DataRow dr in dt.Rows)
            {
                dsLoaiSP.Add(dr["loai"].ToString());
            }
            closeConnection();
            return dsLoaiSP;
        }
        public List<string> layNCC()
        {
            List<string> dsNCCSP = new List<string>();
            DataTable dt = new DataTable();
            openConnection();
            dt = executeQuery("select distinct tenNCC from nhacungcap");
            foreach (DataRow dr in dt.Rows)
            {
                dsNCCSP.Add(dr["tenncc"].ToString());
            }
            closeConnection();
            return dsNCCSP;
        }
        public int laymasp()
        {   
            return Convert.ToInt32(executeScalar("select dbo.getnewmasp()"));
        }
        public int themSanPhamNcc(SanPham sp)
        {         
            openConnection();

            string query = @"INSERT INTO SanPhamCuaNCC (maSP, tenSP, gianhap, loai, ncc, image)
                         VALUES (@maSP, @tenSP, @donGia, @loai, @ncc, @image)";

           
            using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@maSP", sp.maSP);
                    cmd.Parameters.AddWithValue("@tenSP", sp.tenSP);
                    cmd.Parameters.AddWithValue("@donGia", sp.donGia);
                    cmd.Parameters.AddWithValue("@loai", sp.loai ?? "");
                    cmd.Parameters.AddWithValue("@ncc", sp.ncc ?? "");
                    cmd.Parameters.AddWithValue("@image", sp.image ?? "");
                    int rowsAffected = cmd.ExecuteNonQuery();
                closeConnection();
                    return rowsAffected;
                }
        }
        public int themSanPhamVaoKho(SanPham sp)
        {
            openConnection();

            string query = @"INSERT INTO SanPham (maSP, tenSP, dongia, loai, ncc,soluong, image)
                         VALUES (@maSP, @tenSP, @donGia, @loai, @ncc,@soluong, @image)";


            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@maSP", sp.maSP);
                cmd.Parameters.AddWithValue("@tenSP", sp.tenSP);
                cmd.Parameters.AddWithValue("@donGia", sp.donGia);
                cmd.Parameters.AddWithValue("@loai", sp.loai ?? "");
                cmd.Parameters.AddWithValue("@ncc", sp.ncc ?? "");
                cmd.Parameters.AddWithValue("@image", sp.image ?? "");
                cmd.Parameters.AddWithValue("@soluong", sp.soLuong.ToString() ?? "");
                int rowsAffected = cmd.ExecuteNonQuery();
                closeConnection();
                return rowsAffected;
            }
        }
        public DataTable laySanPhamNcc()
        {
            return executeQuery("  select * from SanPhamCuaNCC spncc,NhaCungCap ncc where mancc = ncc");
        }
        public DataTable locSanPhamNcc(string DieuKienLoc)
        {
            string query = string.Format("select * from SanPhamCuaNCC spncc,NhaCungCap ncc where (mancc = ncc) and {0}", DieuKienLoc);
            openConnection();
            DataTable dt = executeQuery(query);
            closeConnection();
            return dt;
        }
        public DataTable locSanPhamNcc()
        {
            return executeQuery("select * from sanphamcuancc");
        }
        public DataTable laySanPhamCanTim(int masp)
        {
            return executeQuery(string.Format("select * from sanpham where masp={0}", masp));
        }
        public int nhapSanPhamVaoKho(int masp,int sl)
        {
            return executeNonQuery(string.Format("exec nhapkho @masp={0},@sl={1}", masp, sl));
        }
        public int xoaSanPham(int masp) { 
            return executeNonQuery(string.Format("delete from sanpham where masp={0}",masp));
        }
        public DataTable soLuongSanPhamBanDuoc()
        {
            return executeQuery("select cthd.masp as masp,sp.tensp as tensp,sum(cthd.soluong) as soluong\r\nfrom chitiethoadon cthd,sanpham sp\r\nwhere cthd.masp=sp.masp\r\ngroup by cthd.masp,sp.tensp\r\norder by count(cthd.soluong) desc");
        }
    }
}
