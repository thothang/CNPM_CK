using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WindowsFormsApp1
{
    internal class UserModel
    {
        public string Users { get; set; }
        public string Passwords { get; set; }
        public string MaNV { get; set; }

        public UserModel() { }

        public UserModel(string users, string passwords, string maNV)
        {
            Users = users;
            Passwords = passwords;
            MaNV = maNV;
        }

        public bool CheckIfUserExists(SqlConnection connection)
        {
            string query = "SELECT COUNT(*) FROM TaiKhoan WHERE @Users = users";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Users", Users);
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }

        public bool CheckPassword(SqlConnection connection)
        {
            string su = SecurityUtils.saltHash(Passwords);
            Passwords = su;
            string query = "SELECT COUNT(*) FROM TaiKhoan WHERE passwords = @Passwords";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Passwords", Passwords);
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }


        }

        public void DeleteUsers(SqlConnection connection)
        {
            string query = "DELETE FROM TaiKhoan WHERE @MaNV = MaNV";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MaNV", MaNV);
                command.ExecuteScalar();
            }
        }

    }
}
