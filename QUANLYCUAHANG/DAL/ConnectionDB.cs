using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Entity;
namespace DAL
{
    public class ConnectionDB
    {
        protected string connectString;
        protected SqlConnection conn;
        public ConnectionDB(string connectString)
        {
            this.connectString = connectString;
            conn = new SqlConnection(connectString);
        }
        public ConnectionDB()
        {
            conn = new SqlConnection("Data Source=.;Initial Catalog=QUANLYCUAHANG;Integrated Security=True");
        }
        public void openConnection()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        public void closeConnection()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
        public DataTable executeQuery(string query)
        {
            DataTable dataTable = new DataTable();
            try
            {
                openConnection();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(dataTable);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                closeConnection();
            }
            return dataTable;
        }
        public int executeNonQuery(string query)
        {
            int rowsAffected = 0;
            try
            {
                openConnection();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    rowsAffected = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
               Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                closeConnection();
            }
            return rowsAffected;
        }
        public object executeScalar(string query)
        {
            openConnection();
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                object result = cmd.ExecuteScalar();
                closeConnection();
                if (result != null)
                {
                    return result;
                }
                return null;
            }
        }
    }
}
