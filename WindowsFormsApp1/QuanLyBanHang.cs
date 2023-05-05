using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class QuanLyBanHang : Form
    {
        
        public QuanLyBanHang()
        {
            InitializeComponent();
           
        }


        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                bool dataExists = false;
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == selectedRow.Cells[0].Value.ToString()
                        && row.Cells[1].Value != null && row.Cells[1].Value.ToString() == selectedRow.Cells[1].Value.ToString()
                        && row.Cells[2].Value != null && row.Cells[2].Value.ToString() == selectedRow.Cells[2].Value.ToString())
                    {
                        dataExists = true;
                        int quantity = Convert.ToInt32(row.Cells[3].Value) + 1;
                        row.Cells[3].Value = quantity;
                        row.Cells[4].Value = Convert.ToDouble(row.Cells[2].Value) * quantity;
                        break;
                    }
                }

                if (!dataExists)
                {
                    int index = dataGridView2.Rows.Add();
                    dataGridView2.Rows[index].Cells[0].Value = selectedRow.Cells[0].Value;
                    dataGridView2.Rows[index].Cells[1].Value = selectedRow.Cells[1].Value;
                    dataGridView2.Rows[index].Cells[2].Value = selectedRow.Cells[2].Value;
                    dataGridView2.Rows[index].Cells[3].Value = 1;
                    dataGridView2.Rows[index].Cells[4].Value = Convert.ToDouble(selectedRow.Cells[2].Value);
                }
            }
        }
        

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        

        private void cssButton2_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }


        QuanLyBanHangModel QLBHMD = new QuanLyBanHangModel();
        public void LoadData()
        {
            List<Dictionary<string, string>> rows = QLBHMD.FatchAllReader();
            foreach (Dictionary<string, string> row in rows)
            {
                int index = dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells[0].Value = row["MaHH"];
                dataGridView1.Rows[index].Cells[1].Value = row["TenHH"];
                dataGridView1.Rows[index].Cells[2].Value = row["Gia"];
            }
        }

        private void QuanLyBanHang_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadDataToComboBox();
        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bt_reset_Click(object sender, EventArgs e)
        {
            double sum = 0;

            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                double quantity = Convert.ToDouble(dataGridView2.Rows[i].Cells[2].Value);
                double total = Convert.ToDouble(dataGridView2.Rows[i].Cells[3].Value);
                double newRowValue = quantity * total;
                dataGridView2.Rows[i].Cells[4].Value = newRowValue.ToString();
                sum += newRowValue;
            }
            double selectedItem;
            if (comboBox1.SelectedItem == null)
            {
                selectedItem = 0;
            }
            else 
            {
                selectedItem = Convert.ToDouble(comboBox1.SelectedItem.ToString());
            }
            
            textbox3.Texts = sum.ToString();
            textbox4.Texts = (sum* selectedItem/100).ToString();
            textbox5.Texts = (sum*0.01).ToString();
            textbox6.Texts = (sum+sum*0.01- (sum * selectedItem / 100)).ToString();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView2.SelectedRows)
            {
                dataGridView2.Rows.RemoveAt(row.Index);
            }
        }

        private void LoadDataToComboBox()
        {
            KhuyenMaiModel model = new KhuyenMaiModel();
            List<Dictionary<string, string>> data = model.FatchAllReader();

            foreach (Dictionary<string, string> row in data)
            {
                comboBox1.Items.Add(row["TiLe"]);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i] != null && dataGridView1.Rows[i].Cells[0].Value != null)
                {
                    if (dataGridView1.Rows[i].Cells[0].Value.ToString() != textBox1.Text)
                    {
                        dataGridView1.Rows.RemoveAt(i);
                        i--;
                    }
                }
            }
        }



    }
}
