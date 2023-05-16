using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class QuanLyNhanVienModel
    {
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public string GT { get; set; }
        public string SDT { get; set; }
        public string Users { get; set; }

        public string Passwords { get; set; }






        public QuanLyNhanVienModel() { }

        public QuanLyNhanVienModel(string manv, string tennv, string gt, string sdt, string users, string passwords) 
        { 
            MaNV = manv;
            TenNV = tennv;
            GT = gt;
            SDT = sdt;
            Users = users;
            Passwords = passwords;
        }

        public List<Dictionary<string, string>> FatchAllReader()
        {
            List<Dictionary<string, string>> rows = new List<Dictionary<string, string>>();
            Dictionary<string, string> column;
            string sqlQuery = "SELECT MaNV, TenNV, GT, SDT, Users, Passwords FROM NhanVien,TaiKhoan Where @MaNV = MaNV";
            SqlCommand command = new SqlCommand(sqlQuery, ConnectionSingleton.GetConnection());
            try
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    column = new Dictionary<string, string>();

                    column["MaNV"] = reader["MaNV"].ToString();
                    column["TenNV"] = reader["TenNV"].ToString();
                    column["GT"] = reader["GT"].ToString();
                    column["SDT"] = reader["SDT"].ToString();
                    column["Users"] = reader["Users"].ToString();
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



    }
}
