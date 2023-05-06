using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WindowsFormsApp1
{
    internal class KhuyenMaiModel
    {
        public string MaKM { get; set; }
        public string TiLe { get; set; }

        public KhuyenMaiModel() { }

        public KhuyenMaiModel(string makm,string tile)
        {
            MaKM = makm;
            TiLe = tile;
        }

        public List<Dictionary<string, string>> FatchAllReader()
        {
            List<Dictionary<string, string>> rows = new List<Dictionary<string, string>>();
            Dictionary<string, string> column;
            string sqlQuery = "SELECT MaKM, TiLe FROM KhuyenMai";
            SqlCommand command = new SqlCommand(sqlQuery, ConnectionSingleton.GetConnection());
            try
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    column = new Dictionary<string, string>();

                    column["MaKM"] = reader["MaKM"].ToString();
                    column["TiLe"] = reader["TiLe"].ToString();
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

        public void InsertKhuyenMai(SqlConnection connection)
        {
            string query = "INSERT INTO KhuyenMai (MaKM, TiLe) " +
                           "VALUES (@MaKM, @TiLe)";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MaKM", MaKM);
                command.Parameters.AddWithValue("@TiLe", TiLe);
                command.ExecuteNonQuery();
            }
        }

        public bool CheckIfKhuyenMaiExists(SqlConnection connection)
        {
            string query = "SELECT COUNT(*) FROM KhuyenMai WHERE @MaKM = MaKM";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MaKM", MaKM);
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }

        public void DeleteKhuyenMai(SqlConnection connection)
        {
            string query = "DELETE FROM KhuyenMai WHERE @MaKM = MaKM";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MaKM", MaKM);
                command.ExecuteScalar();
            }
        }

        public void UpdateKhuyenMai(SqlConnection connection)
        {
            string query = "UPDATE KhuyenMai SET MaKM =@MaKM, TiLe = @TiLe";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MaKM", MaKM);
                command.Parameters.AddWithValue("@TiLe", TiLe);
                command.ExecuteScalar();

            }
        }


        public double TiLeKhuyenMai(SqlConnection connection)
        {
            string query = "SELECT TiLe FROM KhuyenMai WHERE MaKM = @MaKM";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MaKM", MaKM);
                command.Parameters.AddWithValue("@TiLe", TiLe);
                object result = command.ExecuteScalar();
                if (result != null && double.TryParse(result.ToString(), out double count))
                {
                    return count;
                }
                else
                {
                    return 0;
                }
            }
        }

    }
}



