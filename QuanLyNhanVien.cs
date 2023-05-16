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

        private void cssButton2_Click(object sender, EventArgs e)
        {

        }

        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {

        }

         public void LoadData()
        {
            QuanLyNhanVienModel qlnvmodel = new QuanLyNhanVienModel();
            List<Dictionary<string, string>> rows = qlnvmodel.FatchAllReader();
            foreach (Dictionary<string, string> row in rows)
            {
                int index = dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells[0].Value = row["MaNV"];
                dataGridView1.Rows[index].Cells[1].Value = row["TenNV"];
                dataGridView1.Rows[index].Cells[2].Value = row["GT"];
                dataGridView1.Rows[index].Cells[3].Value = row["SDT"];
                dataGridView1.Rows[index].Cells[4].Value = row["Users"];
                dataGridView1.Rows[index].Cells[5].Value = row["Passwords"];
            }
        }


    }
}
