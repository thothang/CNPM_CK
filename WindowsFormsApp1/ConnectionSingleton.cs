using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public static class ConnectionSingleton
    {
        static SqlConnection conn;
        public static SqlConnection GetConnection()
        {
            if (conn == null)
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder["Data Source"] = "MSI\\SQLEXPRESS";
                builder["integrated Security"] = true;
                builder["Initial Catalog"] = "CNPM_CK";
                builder.UserID = "sa";
                builder.Password = "Thothang28@";
                conn = new SqlConnection(builder.ConnectionString);
                conn.Open();
                return conn;
            }
            else
                return conn;
        }
    }
}
