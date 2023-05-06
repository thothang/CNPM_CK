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
    public partial class QuanLySanPham : Form
    {
        public QuanLySanPham()
        {
            InitializeComponent();
        }

        private void textbox4__TextChanged(object sender, EventArgs e)
        {

        }

        private void QuanLySanPham_Load(object sender, EventArgs e)
        {
            LoadHangHoa();
        }

        public void LoadHangHoa()
        {
            QuanLySanPhamModel hhmodel = new QuanLySanPhamModel();
            List<Dictionary<string, string>> rows = hhmodel.FatchAllReader();
            foreach (Dictionary<string, string> row in rows)
            {
                int index = dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells[0].Value = row["MaHH"];
                dataGridView1.Rows[index].Cells[1].Value = row["TenHH"];
                dataGridView1.Rows[index].Cells[2].Value = row["Gia"];
            }
        }

        public void ResetData()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            LoadHangHoa();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            QuanLySanPhamModel qlspmodel = new QuanLySanPhamModel(textbox1.Texts, textbox2.Texts, 0);

            try
            {
                qlspmodel.Gia = float.Parse(textbox3.Texts);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Giá phải là số thực!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(textbox1.Texts) || string.IsNullOrEmpty(textbox2.Texts))
            {
                MessageBox.Show("Không đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!qlspmodel.CheckIfHangHoaExists(ConnectionSingleton.GetConnection()))
            {
                qlspmodel.InsertHangHoa(ConnectionSingleton.GetConnection());
                textbox1.Texts = "";
                textbox2.Texts = "";
                textbox3.Texts = "";
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Đã tồn tại hàng hóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textbox1.Texts = "";
                textbox2.Texts = "";
                textbox3.Texts = "";
            }

            this.ResetData();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            QuanLySanPhamModel qlspmodel = new QuanLySanPhamModel(textbox1.Texts,"",0);
            qlspmodel.DeleteHangHoa(ConnectionSingleton.GetConnection());
            ResetData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textbox1.Texts = row.Cells[0].Value.ToString();
                textbox2.Texts = row.Cells[1].Value.ToString();
                textbox3.Texts = row.Cells[2].Value.ToString();
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            QuanLySanPhamModel qlspmodel = new QuanLySanPhamModel(textbox1.Texts, textbox2.Texts, float.Parse(textbox3.Texts));
            if (qlspmodel.CheckIfHangHoaExists(ConnectionSingleton.GetConnection()))
            {
                qlspmodel.UpdateHangHoa(ConnectionSingleton.GetConnection());
            }
            else
            {
                MessageBox.Show("Mã Khuyến Mãi Không Tồn Tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textbox1.Texts = null;
                textbox2.Texts = null;
            }
            ResetData();
        }

        private void Dangxuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Log_in back = new Log_in();
            back.Closed += (s, args) => this.Close();
            back.Show();
        }
    }
}
