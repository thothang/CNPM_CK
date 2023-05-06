using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class QuanLyNhanVienModal
    {
        public string MaNV { get; set; }
        public string Ten { get; set; }
        public string GT { get; set; }
        public string SDT { get; set; }
        public string Users { get; set; }

        public string Passwords { get; set; }


        public QuanLyNhanVienModal() { }

        public QuanLyNhanVienModal(string manv, string ten, string gt, string sdt) 
        {
            MaNV = manv;
            Ten = ten;
            GT = gt;
            SDT = sdt;
           
        }

        public QuanLyNhanVienModal(string manv, string passwords)
        {
            MaNV = manv;
            Passwords= passwords;

        }

        public QuanLyNhanVienModal(string manv, string ten, string gt, string sdt, string passwords)
        {
            MaNV = manv;
            Ten = ten;
            GT = gt;
            SDT = sdt;
            Passwords = passwords;
        }


        public List<Dictionary<string, string>> FatchAllReader()
        {
            List<Dictionary<string, string>> rows = new List<Dictionary<string, string>>();
            Dictionary<string, string> column;
            string sqlQuery = "SELECT NhanVien.MaNV, NhanVien.Ten, NhanVien.GT, NhanVien.SDT, TaiKhoan.Passwords FROM NhanVien JOIN TaiKhoan ON NhanVien.MaNV = TaiKhoan.MaNV  ";
            SqlCommand command = new SqlCommand(sqlQuery, ConnectionSingleton.GetConnection());
            try
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    column = new Dictionary<string, string>();

                    column["MaNV"] = reader["MaNV"].ToString();
                    column["Ten"] = reader["Ten"].ToString();
                    column["GT"] = reader["GT"].ToString();
                    column["SDT"] = reader["SDT"].ToString();
                    column["Passwords"] = reader["Passwords"].ToString();
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


        public void InsertNhanVien(SqlConnection connection)
        {
            string query = "INSERT INTO NhanVien (MaNV, Ten, GT, SDT) " + "VALUES (@MaNV, @Ten, @GT, @SDT)";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MaNV", MaNV);
                command.Parameters.AddWithValue("@Ten", Ten);
                command.Parameters.AddWithValue("@GT", GT);
                command.Parameters.AddWithValue("@SDT", SDT);
                command.ExecuteNonQuery();
            }
        }
        public void InsertPass(SqlConnection connection)
        {
            string query = "INSERT INTO TaiKhoan (Users, Passwords, MaNV) " + "VALUES (@MaNV, @Passwords, @MaNV)";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Passwords", Passwords);
                command.Parameters.AddWithValue("@MaNV", MaNV);
                command.ExecuteNonQuery();
            }
        }

        public bool CheckIfNhanVienExists(SqlConnection connection)
        {
            string query = "SELECT COUNT(*) FROM NhanVien WHERE @MaNV = MaNV";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MaNV", MaNV);
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }

        public void DeleteNhanVien(SqlConnection connection)
        {
            string query = "DELETE FROM NhanVien WHERE @MaNV = MaNV";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MaNV", MaNV);
                command.ExecuteScalar();
            }
        }

        public void UpdateNhanVien(SqlConnection connection)
        {
            string queryNhanVien = "UPDATE NhanVien SET Ten = @Ten, GT = @GT, SDT = @SDT WHERE MaNV = @MaNV";
            string queryTaiKhoan = "UPDATE TaiKhoan SET Passwords = @Passwords WHERE MaNV = @MaNV";
            using (SqlCommand commandNhanVien = new SqlCommand(queryNhanVien, connection))
            using (SqlCommand commandTaiKhoan = new SqlCommand(queryTaiKhoan, connection))
            {
                commandNhanVien.Parameters.AddWithValue("@Ten", Ten);
                commandNhanVien.Parameters.AddWithValue("@GT", GT);
                commandNhanVien.Parameters.AddWithValue("@SDT", SDT);
                commandNhanVien.Parameters.AddWithValue("@MaNV", MaNV);
                commandNhanVien.ExecuteNonQuery();

                commandTaiKhoan.Parameters.AddWithValue("@Passwords", Passwords);
                commandTaiKhoan.Parameters.AddWithValue("@MaNV", MaNV);
                commandTaiKhoan.ExecuteNonQuery();
            }
        }


    }
}
