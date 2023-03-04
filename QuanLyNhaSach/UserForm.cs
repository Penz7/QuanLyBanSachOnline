using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using ComponentFactory.Krypton.Toolkit;

namespace QuanLyNhaSach
{
    public partial class UserForm : KryptonForm
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );
       

        public UserForm()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnExplore.Height;
            pnlNav.Top = btnExplore.Width;
            pnlNav.Left = btnExplore.Left;
           
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            string imageUrl = "https://images.unsplash.com/photo-1677393705186-a7ea40f7b7e3?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=387&q=80";
            pictureBox1.ImageLocation = imageUrl;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExplore_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnExplore.Height;
            pnlNav.Top = btnExplore.Width;
            pnlNav.Left = btnExplore.Left;
            btnExplore.ForeColor = Color.FromArgb(35, 61, 127);
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnCategories.Height;
            pnlNav.Top = btnCategories.Width;
            pnlNav.Left = btnCategories.Left;
            btnCategories.ForeColor = Color.FromArgb(35, 61, 127);
        }

        private void btnSaved_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnSaved.Height;
            pnlNav.Top = btnSaved.Width;
            pnlNav.Left = btnSaved.Left;
            btnSaved.ForeColor = Color.FromArgb(35, 61, 127);
        }

        private void btnBookPlan_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnBookPlan.Height;
            pnlNav.Top = btnBookPlan.Width;
            pnlNav.Left = btnBookPlan.Left;
            btnBookPlan.ForeColor = Color.FromArgb(35, 61, 127);
        }

        private void btnPrefer_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnPrefer.Height;
            pnlNav.Top = btnPrefer.Width;
            pnlNav.Left = btnPrefer.Left;
            btnPrefer.ForeColor = Color.FromArgb(35, 61, 127);
        }

        private void btnExplore_Leave(object sender, EventArgs e)
        {
            btnExplore.ForeColor = Color.FromArgb(184, 184, 184);
        }

        private void btnCategories_Leave(object sender, EventArgs e)
        {
            btnCategories.ForeColor = Color.FromArgb(184, 184, 184);
        }

        private void btnSaved_Leave(object sender, EventArgs e)
        {
            btnSaved.ForeColor = Color.FromArgb(184, 184, 184);
        }

        private void btnBookPlan_Leave(object sender, EventArgs e)
        {
            btnBookPlan.ForeColor = Color.FromArgb(184, 184, 184);
        }

        private void btnPrefer_Leave(object sender, EventArgs e)
        {
            btnPrefer.ForeColor = Color.FromArgb(184, 184, 184);
        }
    }
}
