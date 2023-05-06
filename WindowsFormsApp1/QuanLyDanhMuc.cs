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
    public partial class QuanLyDanhMuc : Form
    {
        public QuanLyDanhMuc()
        {
            InitializeComponent();

        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            QuanLyDanhMucModal qldmmodel = new QuanLyDanhMucModal(textbox1.Texts, textbox2.Texts);
            if (qldmmodel.CheckIfDanhMucExists(ConnectionSingleton.GetConnection()))
            {
               qldmmodel.UpdateDanhMuc(ConnectionSingleton.GetConnection());
            }
            else
            {
                MessageBox.Show("Mã Khuyến Mãi Không Tồn Tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textbox1.Texts = null;
                textbox2.Texts = null;
            }
            ResetData();

        }

        public void LoadDanhMuc()
        {
            QuanLyDanhMucModal qldmmodel = new QuanLyDanhMucModal();
            List<Dictionary<string, string>> rows = qldmmodel.FatchAllReader();
            foreach (Dictionary<string, string> row in rows)
            {
                int index = DGV_HangHoa.Rows.Add();
                DGV_HangHoa.Rows[index].Cells[0].Value = row["MaDM"];
                DGV_HangHoa.Rows[index].Cells[1].Value = row["TenDM"];
            }
        }

        public void ResetData()
        {
            DGV_HangHoa.Rows.Clear();
            DGV_HangHoa.Refresh();
            LoadDanhMuc();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            QuanLyDanhMucModal qldmmodel = new QuanLyDanhMucModal(textbox1.Texts,textbox2.Texts);
            if (textbox1.Texts == "" || textbox2.Texts == "")
            {
                MessageBox.Show("Không Đủ Thông Tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!qldmmodel.CheckIfDanhMucExists(ConnectionSingleton.GetConnection())) 
            {
                qldmmodel.InsertDanhMuc(ConnectionSingleton.GetConnection());
                textbox1.Texts = null;
                textbox2.Texts = null;
                MessageBox.Show("Thêm Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Đã Tồn Tại Mã Khuyến Mãi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textbox1.Texts = null;
                textbox2.Texts = null;
            }
            this.ResetData();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textbox1__TextChanged(object sender, EventArgs e)
        {

        }

        private void QuanLyDanhMuc_Load(object sender, EventArgs e)
        {
            LoadDanhMuc();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            QuanLyDanhMucModal qldmmodel = new QuanLyDanhMucModal(textbox1.Texts, textbox2.Texts);
            qldmmodel.DeleteDanhMuc(ConnectionSingleton.GetConnection());
            ResetData();
        }

        private void DGV_HangHoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < DGV_HangHoa.Rows.Count)
            {
                DataGridViewRow row = DGV_HangHoa.Rows[e.RowIndex];
                textbox1.Texts = row.Cells[0].Value.ToString();
                textbox2.Texts = row.Cells[1].Value.ToString();
            }
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
