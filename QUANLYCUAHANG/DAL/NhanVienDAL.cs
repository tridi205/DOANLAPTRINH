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
    public class NhanVienDAL: ConnectionDB
    {
        public DataTable layDanhSachNV()
        {
            return executeQuery("SELECT [manv]\r\n      ,[tennv]\r\n\t  ,[gioitinh]\r\n      ,[ngaysinh]\r\n      ,[diachi]\r\n      ,[email]\r\n      ,[chucvu]\r\n      ,[sdt]\r\n      ,[matkhau]\r\n      ,[cccd] \r\n    ,[anh] \r\n  FROM [QUANLYCUAHANG].[dbo].[NhanVien] where chucvu not like N'Cửa hàng trưởng'");
        }
        public string layTenCuaNhanVien(int manv)
        {
            return executeScalar(string.Format("select tennv from nhanvien where manv={0}",manv)).ToString();
        }
        public int thayDoiThongTinNhanVien(NhanVien nv)
        {
            openConnection();

            string query = @"UPDATE [dbo].[NhanVien]
                                SET 
                                tennv = @tennv,
                                ngaysinh = @ngaysinh,
                                diachi = @diachi,
                                email = @email,
                                chucvu = @chucvu,
                                sdt = @sdt,
                                matkhau = @mk,
                                cccd = @cccd,
                                gioitinh =@gioitinh,
                                anh=@anh
                                WHERE manv = @manv;
                                ";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@tennv", nv.tennv);
                cmd.Parameters.AddWithValue("@ngaysinh",nv.ngaysinh);
                cmd.Parameters.AddWithValue("@diachi", nv.diachi);
                cmd.Parameters.AddWithValue("@email", nv.email ?? "");
                cmd.Parameters.AddWithValue("@chucvu", nv.chucvu?? "");
                cmd.Parameters.AddWithValue("@sdt", nv.sdt ?? "");
                cmd.Parameters.AddWithValue("@mk", nv.mk ?? "");
                cmd.Parameters.AddWithValue("@cccd", nv.cccd ?? "");
                cmd.Parameters.AddWithValue("@gioitinh", nv.gioitinh ?? "");
                cmd.Parameters.AddWithValue("@manv", nv.manv);
                cmd.Parameters.AddWithValue("@anh", nv.anh);
                int rowsAffected = cmd.ExecuteNonQuery();
                closeConnection();
                return rowsAffected;
            }
        }
        public NhanVien layThongTinNV(int manv)
        {
            DataTable dt = executeQuery(string.Format("select * from nhanvien where manv={0}", manv));
            DataRow dr=dt.Rows[0];
            NhanVien nv=new NhanVien();
            nv.tennv = dr["tennv"].ToString();
            nv.gioitinh = dr["gioitinh"].ToString();
            nv.cccd = dr["cccd"].ToString();
            nv.sdt = dr["sdt"].ToString();
            nv.diachi = dr["diachi"].ToString();
            nv.email = dr["email"].ToString();
            nv.ngaysinh =Convert.ToDateTime( dr["ngaysinh"]);
            nv.chucvu = dr["chucvu"].ToString();
            nv.mk = dr["matkhau"].ToString() ;
            nv.anh = dr["anh"].ToString();
            return nv;
        }
        public int xoaNhanVien(int manv)
        {
            return executeNonQuery(string.Format("delete from nhanvien where manv={0}",manv));
        }
        public int layMaNVMoi()
        {
            return Convert.ToInt32( executeScalar("select dbo.getnewmanv()"));
        }
        public int laySoLuongNV()
        {
            return Convert.ToInt32(executeScalar("select count(*) from nhanvien"));
        }
        public int themNhanVienMoi(NhanVien nv)
        {
            openConnection();
            string query = @"INSERT INTO [dbo].[NhanVien] (manv, tennv, ngaysinh, diachi, email, chucvu, sdt, matkhau, cccd, gioitinh,anh)
            VALUES (@manv, @tennv, @ngaysinh, @diachi, @email, @chucvu,@sdt, @mk, @cccd, @gioitinh,@anh);";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@tennv", nv.tennv);
                cmd.Parameters.AddWithValue("@ngaysinh", nv.ngaysinh);
                cmd.Parameters.AddWithValue("@diachi", nv.diachi);
                cmd.Parameters.AddWithValue("@email", nv.email ?? "");
                cmd.Parameters.AddWithValue("@chucvu", nv.chucvu ?? "");
                cmd.Parameters.AddWithValue("@sdt", nv.sdt ?? "");
                cmd.Parameters.AddWithValue("@mk", nv.mk ?? "");
                cmd.Parameters.AddWithValue("@cccd", nv.cccd ?? "");
                cmd.Parameters.AddWithValue("@gioitinh", nv.gioitinh ?? "");
                cmd.Parameters.AddWithValue("@manv", nv.manv);
                cmd.Parameters.AddWithValue("@anh", nv.anh);
                int rowsAffected = cmd.ExecuteNonQuery();
                closeConnection();
                return rowsAffected;
            }
        }
        public DataTable timKiemNhanVien(string dk)
        {
            return executeQuery(string.Format("select * from nhanvien {0}",dk));
        }
       public DataTable DangNhap(int manv,string mk)
        {
            return executeQuery(string.Format("SELECT *\r\nFROM [QUANLYCUAHANG].[dbo].[NhanVien]\r\nwhere manv={0} and matkhau={1}",manv,mk));
        }
    }
}
