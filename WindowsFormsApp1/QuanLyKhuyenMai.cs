using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class QuanLyKhuyenMai : Form
    {
        public QuanLyKhuyenMai()
        {
            InitializeComponent();
        }

        private void QuanLyKhuyenMai_Load(object sender, EventArgs e)
        {
            LoadKhuyenMai();

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {


            KhuyenMaiModel kmmodel = new KhuyenMaiModel(textbox1.Texts, textbox2.Texts);
            if (textbox1.Texts == "")
            {
                MessageBox.Show("Không Đủ Thông Tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textbox2.Texts == "")
            {
                MessageBox.Show("Không Đủ Thông Tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!kmmodel.CheckIfKhuyenMaiExists(ConnectionSingleton.GetConnection()))
            {
                kmmodel.InsertKhuyenMai(ConnectionSingleton.GetConnection());
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void LoadKhuyenMai()
        {
            KhuyenMaiModel kmmodel = new KhuyenMaiModel();
            List<Dictionary<string, string>> rows = kmmodel.FatchAllReader();
            foreach (Dictionary<string, string> row in rows)
            {
                int index = DGV_KhuyenMai.Rows.Add();
                DGV_KhuyenMai.Rows[index].Cells[0].Value = row["MaKM"];
                DGV_KhuyenMai.Rows[index].Cells[1].Value = row["TiLe"];
            }
        }

        public void ResetData()
        {
            DGV_KhuyenMai.Rows.Clear();
            DGV_KhuyenMai.Refresh();
            LoadKhuyenMai();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            KhuyenMaiModel kmmodel = new KhuyenMaiModel(DGV_KhuyenMai.Rows[0].Cells[0].Value.ToString(), "");
            kmmodel.DeleteKhuyenMai(ConnectionSingleton.GetConnection());
            ResetData();
        }

        private void QuanLyKhuyenMai_Activated(object sender, EventArgs e)
        {

        }

        private void QuanLyKhuyenMai_MouseEnter(object sender, EventArgs e)
        {

        }

        private void DGV_KhuyenMai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                if (e.RowIndex >= 0 && e.RowIndex < DGV_KhuyenMai.Rows.Count)
                {
                    DataGridViewRow row = DGV_KhuyenMai.Rows[e.RowIndex];
                    textbox1.Texts = row.Cells[0].Value.ToString();
                    textbox2.Texts = row.Cells[1].Value.ToString();
                }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            KhuyenMaiModel kmmodel = new KhuyenMaiModel(textbox1.Texts, textbox2.Texts);
            if (kmmodel.CheckIfKhuyenMaiExists(ConnectionSingleton.GetConnection()))
            {
                kmmodel.UpdateKhuyenMai(ConnectionSingleton.GetConnection());
            }
            else
            {
                MessageBox.Show("Mã Khuyến Mãi Không Tồn Tại");
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
