using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class QuanLySanPhamModel
    {
        public string MaHH { get; set; }
        public string TenHH { get; set; }
        public float Gia { get; set; }

        public QuanLySanPhamModel() { }
        public QuanLySanPhamModel(string mahh,string tenhh,float gia) 
        { 
            MaHH= mahh;
            TenHH= tenhh;   
            Gia= gia;
        }

        public List<Dictionary<string, string>> FatchAllReader()
        {
            List<Dictionary<string, string>> rows = new List<Dictionary<string, string>>();
            Dictionary<string, string> column;
            string sqlQuery = "SELECT MaHH, TenHH, Gia FROM HangHoa";
            SqlCommand command = new SqlCommand(sqlQuery, ConnectionSingleton.GetConnection());
            try
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    column = new Dictionary<string, string>();

                    column["MaHH"] = reader["MaHH"].ToString();
                    column["TenHH"] = reader["TenHH"].ToString();
                    column["Gia"] = reader["Gia"].ToString();
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

        public void InsertHangHoa(SqlConnection connection)
        {
            string query = "INSERT INTO HangHoa (MaHH, TenHH, Gia) " + "VALUES (@MaHH, @TenHH, @Gia)";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MaHH", MaHH);
                command.Parameters.AddWithValue("@TenHH", TenHH);
                command.Parameters.AddWithValue("@Gia", Gia);
                command.ExecuteNonQuery();
            }
        }

        public bool CheckIfHangHoaExists(SqlConnection connection)
        {
            string query = "SELECT COUNT(*) FROM HangHoa WHERE @MaHH = MaHH";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MaHH", MaHH);
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }

         public void DeleteHangHoa(SqlConnection connection)
         {
             string query = "DELETE FROM HangHoa WHERE @MaHH = MaHH";
             using (SqlCommand command = new SqlCommand(query, connection))
             {
                 command.Parameters.AddWithValue("@MaHH", MaHH);
                 command.ExecuteScalar();
             }
         }

         public void UpdateHangHoa(SqlConnection connection)
         {
             string query = "UPDATE HangHoa SET MaHH =@MaHH, TenHH= @TenHH , Gia =@Gia Where @MaHH = MaHH";
             using (SqlCommand command = new SqlCommand(query, connection))
             {
                command.Parameters.AddWithValue("@MaHH", MaHH);
                command.Parameters.AddWithValue("@TenHH", TenHH);
                command.Parameters.AddWithValue("@Gia", Gia);
                command.ExecuteScalar();

             }
         }
    }
}
