using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class QuanLyBanHangModel
    {
        public string MaHH { get; set; }
        public string TenHH { get; set; }
        public float Gia { get; set; }
        public string TTKHac { get; set; }
        public string MaDM { get; set; }
        public string MaNSX { get; set; }

        public QuanLyBanHangModel() { }

        public QuanLyBanHangModel(string mahh, string tenhh, float gia, string ttkhac, string madm, string mansx)
        {
            MaHH = mahh;
            TenHH = tenhh;
            Gia = gia;
            TTKHac = ttkhac;
            MaDM = madm;
            MaNSX = mansx;
        }

        public List<Dictionary<string, string>> FatchAllReader()
        {
            List<Dictionary<string, string>> rows = new List<Dictionary<string, string>>();
            Dictionary<string, string> column;
            string sqlQuery = "SELECT MaHH , TenHH , Gia , TTKhac, MaDM , MaNSX FROM HangHoa";
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
                    column["TTKhac"] = reader["TTKhac"].ToString();
                    column["MaDM"] = reader["MaDM"].ToString();
                    column["MaNSX"] = reader["MaNSX"].ToString();
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
