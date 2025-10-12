using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class NhaCungCapDAL : ConnectionDB
    {
        public DataTable layDanhSachNhaCungCap()
        {
            return executeQuery("SELECT  [mancc]\r\n      ,[tenncc]\r\n      ,[diachi]\r\n      ,[sdt]\r\n      ,[email]\r\n  FROM [QUANLYCUAHANG].[dbo].[NhaCungCap]");
        }
        public int themNhaCungCap(NhaCungCap NCC)
        {
            openConnection();
            //tao chuoi chua cau lenh
            string query = @"insert into NhaCungCap(mancc,tenncc,sdt,diachi,email) values (@mancc,@tenncc,@sdt,@diachi,@email)";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@mancc", NCC.mancc);
                cmd.Parameters.AddWithValue("@tenncc", NCC.tenncc);
                cmd.Parameters.AddWithValue("@sdt", NCC.sdt);
                cmd.Parameters.AddWithValue("@diachi", NCC.diachi);
                cmd.Parameters.AddWithValue("email", NCC.email);
                int rowAffect = cmd.ExecuteNonQuery();
                closeConnection();
                return rowAffect;
            }
        }
        //public int capnhatNCC(NhaCungCap NCC)
        //{
        //    openConnection();
        //    string caulenh = @"update NhaCungCap set tenncc=N'{0}',diachi=N'{1}',sdt='{2}',email=N'{3}' where MaSP={4}";
        //    using (SqlCommand cmd = new SqlCommand(caulenh,conn))
        //    {
        //        cmd.Parameters.AddWithValue("@mancc")
        //    }
        //        return executeNonQuery(caulenh);
        //}
        public int updateNCC(NhaCungCap NCC)
        {
            openConnection();
            string caulenh = @"update NhaCungCap set tenncc=@tenncc,sdt=@sdt,diachi=@diachi,email=@email where mancc=@mancc";
            using (SqlCommand cmd= new SqlCommand(caulenh, conn))
            {
              
                cmd.Parameters.AddWithValue("@tenncc", NCC.tenncc);
                cmd.Parameters.AddWithValue("@sdt", NCC.sdt);
                cmd.Parameters.AddWithValue("@diachi", NCC.diachi);
                cmd.Parameters.AddWithValue("email", NCC.email);
                
                cmd.Parameters.AddWithValue("@mancc", NCC.mancc);
                int rowAffect = cmd.ExecuteNonQuery();
                closeConnection();
                return rowAffect ;
            }
        }
        public int getnewNCC()
        {
            return Convert.ToInt32(executeScalar("select dbo.getnewmaNCC()"));
        }
       public int xoaNhaCungCap(int ncc)
        {
            
            return executeNonQuery(string.Format("delete from nhacungcap where mancc={0}", ncc));
        }
        public DataTable locNhaCungCap()
        {
            return executeQuery("select * from nhacungcap");
        }
        public DataTable locNhaCungCap(string dieukien)
        {
            string caulenh = string.Format("select * from nhacungcap where {0}", dieukien);
            openConnection();
            DataTable dt = executeQuery(caulenh);
            closeConnection();
            return dt;
        }
    }
}
