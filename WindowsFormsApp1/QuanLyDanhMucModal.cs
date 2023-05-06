using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class QuanLyDanhMucModal
    {
        public string MaDM { get; set; }
        public string TenDM { get; set; }

        public QuanLyDanhMucModal()
        {

        }

        public QuanLyDanhMucModal(string madm, string tendm)
        {
            MaDM = madm;
            TenDM = tendm;
        }

        public List<Dictionary<string, string>> FatchAllReader()
        {
            List<Dictionary<string, string>> rows = new List<Dictionary<string, string>>();
            Dictionary<string, string> column;
            string sqlQuery = "SELECT MaDM , TenDM FROM DanhMucHH";
            SqlCommand command = new SqlCommand(sqlQuery, ConnectionSingleton.GetConnection());
            try
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    column = new Dictionary<string, string>();

                    column["MaDM"] = reader["MaDM"].ToString();
                    column["TenDM"] = reader["TenDM"].ToString();
                    rows.Add(column);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return rows;
        }

        public void InsertDanhMuc(SqlConnection connection)
        {
            string query = "INSERT INTO DanhMucHH (MaDM, TenDM) " + "VALUES (@MaDM, @TenDM)";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MaDM", MaDM);
                command.Parameters.AddWithValue("@TenDM", TenDM);
                command.ExecuteNonQuery();
            }
        }

        public bool CheckIfDanhMucExists(SqlConnection connection)
        {
            string query = "SELECT COUNT(*) FROM DanhMucHH WHERE @MaDM = MaDM";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MaDM", MaDM);
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }

        public void DeleteDanhMuc(SqlConnection connection)
        {
            string query = "DELETE FROM DanhMucHH WHERE @MaDM = MaDM";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MaDM", MaDM);
                command.ExecuteScalar();
            }
        }

        public void UpdateDanhMuc(SqlConnection connection)
        {
            string query = "UPDATE DanhMucHH SET TenDM = @TenDM WHERE @MaDM =MaDM";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MaDM", MaDM);
                command.Parameters.AddWithValue("@TenDM", TenDM);
                command.ExecuteScalar();

            }
        }
    }
}
