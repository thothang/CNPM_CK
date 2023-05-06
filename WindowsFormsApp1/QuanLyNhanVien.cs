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

        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            QuanLyNhanVienModal qlnvmodel = new QuanLyNhanVienModal();
            List<Dictionary<string, string>> rows = qlnvmodel.FatchAllReader();
            foreach (Dictionary<string, string> row in rows)
            {
                int index = dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells[0].Value = row["MaNV"];
                dataGridView1.Rows[index].Cells[1].Value = row["Ten"];
                dataGridView1.Rows[index].Cells[2].Value = row["GT"];
                dataGridView1.Rows[index].Cells[3].Value = row["SDT"];
                dataGridView1.Rows[index].Cells[4].Value = row["Passwords"];

            }
        }

        public void ResetData()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {   string su = SecurityUtils.saltHash(textbox5.Texts);
            QuanLyNhanVienModal qlnvmodel = new QuanLyNhanVienModal(textbox1.Texts, textbox2.Texts, textbox4.Texts, textbox3.Texts);
            QuanLyNhanVienModal qlnvmodel1 = new QuanLyNhanVienModal(textbox1.Texts  , su);
            if (textbox1.Texts == "" || textbox2.Texts == "" || textbox3.Texts == "" || textbox4.Texts == "" || textbox5.Texts == "")
            {
                MessageBox.Show("Không Đủ Thông Tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!qlnvmodel.CheckIfNhanVienExists(ConnectionSingleton.GetConnection()))
            {
                
                qlnvmodel.InsertNhanVien(ConnectionSingleton.GetConnection());
                qlnvmodel1.InsertPass(ConnectionSingleton.GetConnection());
                textbox1.Texts = null;
                textbox2.Texts = null;
                textbox3.Texts = null;
                textbox4.Texts = null;
                textbox5.Texts = null;
                MessageBox.Show("Thêm Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Đã Tồn Tại Tài Khoản", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textbox1.Texts = null;
                textbox2.Texts = null;
                textbox3.Texts = null;
                textbox4.Texts = null;
                textbox5.Texts = null;
            }
            this.ResetData();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            QuanLyNhanVienModal qlnvmodel = new QuanLyNhanVienModal(textbox1.Texts, textbox2.Texts, textbox4.Texts, textbox3.Texts);
            qlnvmodel.DeleteNhanVien(ConnectionSingleton.GetConnection());
            ResetData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textbox1.Texts = row.Cells[0].Value.ToString();
                textbox2.Texts = row.Cells[1].Value.ToString();
                textbox4.Texts = row.Cells[2].Value.ToString();
                textbox3.Texts = row.Cells[3].Value.ToString();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string su = SecurityUtils.saltHash(textbox5.Texts);
            QuanLyNhanVienModal qlnvmodel = new QuanLyNhanVienModal(textbox1.Texts, textbox2.Texts, textbox4.Texts, textbox3.Texts, su);
            if (qlnvmodel.CheckIfNhanVienExists(ConnectionSingleton.GetConnection()))
            {
                qlnvmodel.UpdateNhanVien(ConnectionSingleton.GetConnection());
            }
            else
            {
                MessageBox.Show("Mã Khuyến Mãi Không Tồn Tại");
                textbox1.Texts = null;
                textbox2.Texts = null;
                textbox3.Texts = null;
                textbox4.Texts = null;
                textbox5.Texts = null;
            }
            ResetData();
        }
    }
}
