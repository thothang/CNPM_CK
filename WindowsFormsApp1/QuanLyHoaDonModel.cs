using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class QuanLyHoaDonModel
    {
        public string MaHD { get; set; }
        public string NgayXuat { get; set; }
        public int GiamGia { get; set; }
        public int VAT { get; set; }
        public int TongTien { get; set; }
        public string MaKM { get; set; }
        public string MaNV { get; set; }
        public QuanLyHoaDonModel() { }
        public QuanLyHoaDonModel(string maHD, string ngayXuat, int giamGia, int vAT, int tongTien, string maKM, string maNV)
        {
            MaHD = maHD;
            NgayXuat = ngayXuat;
            GiamGia = giamGia;
            VAT = vAT;
            TongTien = tongTien;
            MaKM = maKM;
            MaNV = maNV;
        }
        public List<Dictionary<string, string>> FatchAllReader()
        {
            List<Dictionary<string, string>> rows = new List<Dictionary<string, string>>();
            Dictionary<string, string> column;
            string sqlQuery = "SELECT * FROM HoaDon";
            SqlCommand command = new SqlCommand(sqlQuery, ConnectionSingleton.GetConnection());
            try
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    column = new Dictionary<string, string>();
                    column["MaHD"] = reader["MaHD"].ToString();
                    column["NgayXuat"] = reader["NgayXuat"].ToString();
                    column["GiamGia"] = reader["GiamGia"].ToString();
                    column["VAT"] = reader["VAT"].ToString();
                    column["TongTien"] = reader["TongTien"].ToString();
                    column["MaKM"] = reader["MaKM"].ToString();
                    column["MaNV"] = reader["MaNV"].ToString();
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

        public void InsertHoaDon(SqlConnection connection)
        {
            string query = "INSERT INTO HoaDon (MaHD, NgayXuat, GiamGia, VAT, TongTien, MaKM, MaNV) " +
                           "VALUES (@MaHD, @NgayXuat, @GiamGia, @VAT, @TongTien, @MaKM, @MaNV)";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@NgayXuat", NgayXuat);
                command.Parameters.AddWithValue("@GiamGia", GiamGia);
                command.Parameters.AddWithValue("@VAT", VAT);
                command.Parameters.AddWithValue("@TongTien", TongTien);
                command.Parameters.AddWithValue("@MaKM", MaKM);
                command.Parameters.AddWithValue("@MaNV", MaNV);
                command.ExecuteNonQuery();
            }
        }
        public bool CheckIfHoaDonExists(SqlConnection connection)
        {
            string query = "SELECT COUNT(*) FROM HoaDon WHERE @MaHD = MaHD";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MaHD", MaHD);
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }
        public void DeleteKhuyenMai(SqlConnection connection)
        {
            string query = "DELETE FROM HoaDon WHERE @MaHD = MaHD";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MaHD", MaHD);
                command.ExecuteScalar();
            }
        }




    }
}

