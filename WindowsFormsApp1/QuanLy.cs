using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class QuanLy : Form
    {
        public QuanLy()
        {
            InitializeComponent();
            customizeDesign();
        }
        private void customizeDesign() {
            panelQLSPSubmenu.Visible = false;
            panelQLXHSubmenu.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelQLSPSubmenu.Visible == true) { panelQLSPSubmenu.Visible = false; }
            if (panelQLXHSubmenu.Visible == true) { panelQLXHSubmenu.Visible = false; }
        }
        private void showSubMenu(Panel subMenu) {
            if (subMenu.Visible == false) {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnQLNH_Click(object sender, EventArgs e)
        {
            
        }
        #region QLSP

        private void btnQLSP_Click(object sender, EventArgs e)
        {
            showSubMenu(panelQLSPSubmenu);  
        }
        private void btnQLSP1_Click(object sender, EventArgs e)
        {
            //code
            hideSubMenu();
        }

        private void btnQLDM_Click(object sender, EventArgs e)
        {
            //code
            hideSubMenu();
        }
        #endregion
        #region QLXH
        private void btnQLXH_Click(object sender, EventArgs e)
        {
            showSubMenu(panelQLXHSubmenu);
        }

        private void btn_TPXH_Click(object sender, EventArgs e)
        {
            //code
            hideSubMenu();
        }

        private void btn_TPTH_Click(object sender, EventArgs e)
        {
            //code
            hideSubMenu();
        }
        #endregion

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void QuanLy_Load(object sender, EventArgs e)
        {

        }
        private Form activeForm = null;

        private void openChildForm(Form childForm) { 
            if(activeForm != null) 
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnQLKM_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnQLNV_Click(object sender, EventArgs e)
        {
            openChildForm(new QuanLyNhanVien());
        }
    }
}
