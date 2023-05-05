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

        public UserModel() { }

        public UserModel(string users, string passwords)
        {
            Users = users;
            Passwords = passwords;
        }

        public bool CheckIfUserExists(SqlConnection connection)
        {
            string query = "SELECT COUNT(*) FROM account WHERE @Users = users";
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
            string query = "SELECT COUNT(*) FROM account WHERE passwords = @Passwords";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Passwords", Passwords);
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }


        }
    }
}
