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
    public partial class QuanLyNhanVien : Form
    {
        public QuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cssButton1_Click(object sender, EventArgs e)
        {

        }

        private void Dangxuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Log_in back = new Log_in();
            back.Closed += (s, args) => this.Close();
            back.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
