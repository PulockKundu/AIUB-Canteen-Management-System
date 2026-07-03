using PracticeGridview;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsNewProject
{
    public partial class FormAdmin: Form
    {
        private string userId;
        public FormLogin Fl { get; set; }
        private Manage_Product manageProduct;
        private ManageUser manageUser;
        private ViewProfile viewProfile;
        private SalesHistory salesHistory;

        public FormAdmin()
        {
            InitializeComponent();

         
        }

        public FormAdmin(string userId, FormLogin fl) : this()
        {
            this.userId = userId;
            this.lblInfo.Text += userId.ToUpper();
            this.Fl = fl;

            viewProfile = new ViewProfile(this.userId,this);
            manageProduct = new Manage_Product();
            manageUser = new ManageUser();
            salesHistory = new SalesHistory();

            viewProfile.Dock = DockStyle.Fill;
            manageProduct.Dock = DockStyle.Fill;
            manageUser.Dock = DockStyle.Fill;
            salesHistory.Dock = DockStyle.Fill;


            panel2.Controls.Add(viewProfile);
            panel2.Controls.Add(manageProduct);
            panel2.Controls.Add(manageUser);
            panel2.Controls.Add(salesHistory);

            viewProfile.Visible = false;
            manageUser.Visible = false;
            salesHistory.Visible = false;

        }


        private void btnViewProfile_Click(object sender, EventArgs e)
        {
            viewProfile.Visible = true;
            manageProduct.Visible = false;
            manageUser.Visible = false;
            salesHistory.Visible = false;

        }

        private void btnMProduct_Click(object sender, EventArgs e)
        {
            viewProfile.Visible = false;
            manageProduct.Visible = true;
            manageUser.Visible = false;
            salesHistory.Visible = false;
        }

        private void btnMUser_Click(object sender, EventArgs e)
        {
            viewProfile.Visible = false;
            manageProduct.Visible = false;
            manageUser.Visible = true;
            salesHistory.Visible = false;
        }

        private void btnSHistory_Click(object sender, EventArgs e)
        {
            viewProfile.Visible = false;
            manageProduct.Visible = false;
            manageUser.Visible = false;
            salesHistory.Visible = true;
        }

        private void btnViewProfile_MouseHover(object sender, EventArgs e)
        {
            this.btnViewProfile.BackColor = Color.DarkTurquoise;
        }

        private void btnViewProfile_MouseLeave(object sender, EventArgs e)
        {
            this.btnViewProfile.BackColor = Color.PaleTurquoise;
        }

        private void btnMProduct_MouseHover(object sender, EventArgs e)
        {
            this.btnMProduct.BackColor = Color.DarkTurquoise;
        }

        private void btnMProduct_MouseLeave(object sender, EventArgs e)
        {
            this.btnMProduct.BackColor = Color.PaleTurquoise;
        }

        private void btnMUser_MouseHover(object sender, EventArgs e)
        {
            this.btnMUser.BackColor = Color.DarkTurquoise;
        }

        private void btnMUser_MouseLeave(object sender, EventArgs e)
        {
            this.btnMUser.BackColor = Color.PaleTurquoise;
        }

        private void btnSHistory_MouseHover(object sender, EventArgs e)
        {
            this.btnSHistory.BackColor = Color.DarkTurquoise;
        }

        private void btnSHistory_MouseLeave(object sender, EventArgs e)
        {
            this.btnSHistory.BackColor = Color.PaleTurquoise;
        }

        private void btnSale_MouseHover(object sender, EventArgs e)
        {
            this.btnSalesCorner.BackColor = Color.DarkTurquoise;
        }

        private void btnSale_MouseLeave(object sender, EventArgs e)
        {
            this.btnSalesCorner.BackColor = Color.PaleTurquoise;
        }

        private void btnLogOut_MouseHover(object sender, EventArgs e)
        {
            this.btnLogOut.BackColor = Color.DarkTurquoise;
        }

        private void btnLogOut_MouseLeave(object sender, EventArgs e)
        {
            this.btnLogOut.BackColor = Color.PaleTurquoise;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure to Logged out from system?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.No)
                return;

            this.Hide();
            this.Fl.Show();
        }

        private void FormAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("System Closing properly!");
            Application.Exit();
        }

        private void btnSalesCorner_Click(object sender, EventArgs e)
        {
            this.Hide();

            new FormSale(userId, this).Visible=true;
        }
    }
}
