using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Properties;

namespace WindowsFormsApp1
{
    public partial class ThongKe : Form
    {
        public ThongKe()
        {
            InitializeComponent();
        }

        private void btn_TKNgay_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tính năng chưa phát triển");
        }

        private void btn_TKThang_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tính năng chưa phát triển");
        }

        private void btn_TKNam_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tính năng chưa phát triển");

        }

        private void btn_In_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Image image = Resources.logo;
            e.Graphics.DrawImage(image, 180, 0, image.Width, image.Height);
            e.Graphics.DrawString("HOA DON", new Font("Arial", 24, FontStyle.Regular), Brushes.Black, new Point(330, 520));
            e.Graphics.DrawString("Date: " + DateTime.Now.ToShortDateString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 580));
            e.Graphics.DrawString("Date: " + DateTime.Now.ToShortDateString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 610));
            e.Graphics.DrawString("Date: " + DateTime.Now.ToShortDateString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 640));
            e.Graphics.DrawString("Date: " + DateTime.Now.ToShortDateString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 670));

        }
    }
}
