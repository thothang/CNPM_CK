using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Log_in : Form
    {
        public Log_in()
        {
            InitializeComponent();
        }

        private void Log_in_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void cssbtn_signup_Click(object sender, EventArgs e)
        {

        }

        private void cssButton1_Click(object sender, EventArgs e)
        {
            string su = SecurityUtils.saltHash(textbox2.Texts);
            UserModel model = new UserModel(txt_username.Texts,textbox2.Texts);
            if (!model.CheckIfUserExists(ConnectionSingleton.GetConnection()))
            {
                MessageBox.Show("Sai ten dang nhap");
            }
            else if (!model.CheckPassword(ConnectionSingleton.GetConnection()))
            {
                MessageBox.Show("Sai Mat Khau");
            }
            else
            {
                if (txt_username.Texts == "Admin")
                {
                    this.Hide();
                    QuanLy ql = new QuanLy();
                    ql.Closed += (s, args) => this.Close();
                    ql.Show();
                }
                else
                {
                    this.Hide();
                    QuanLyBanHang qlbh = new QuanLyBanHang();
                    qlbh.Closed += (s, args) => this.Close();
                    qlbh.Show();
                }
            }  
        }
    }
}
