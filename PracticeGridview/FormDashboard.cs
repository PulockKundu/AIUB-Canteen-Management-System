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
using WindowsFormsNewProject;

namespace PracticeGridview
{
    public partial class FormDashboard: Form
    {
        private FormLogin log;
        private FormSale salesCornerForm;
        private FormEditProfile formEditProfile;
        private FormSalesmanSalesHistory formSalHistory;
        private string userId;
       

        public FormDashboard()
        {
            InitializeComponent();
            

        }

        public FormDashboard(string userId, FormLogin log) :this()
        {

            this.userId = userId;
            this.lblSearchById.Text = this.userId;
            
            salesCornerForm = new FormSale(this.userId, this);
            formEditProfile = new FormEditProfile(this.userId, this);
            formSalHistory = new FormSalesmanSalesHistory(this.userId, this);


            EmbedFormInPanel(salesCornerForm);
            EmbedFormInPanel(formEditProfile);
            EmbedFormInPanel(formSalHistory);


            panel2.Controls.Add(salesCornerForm);
            panel2.Controls.Add(formEditProfile);
            panel2.Controls.Add(formSalHistory);
          

            salesCornerForm.Show();
            formEditProfile.Hide();
            formSalHistory.Hide();
            this.log = log;

        }

        private void EmbedFormInPanel(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
        }

        private void btnSalesCorner_Click(object sender, EventArgs e)
        {
            
            salesCornerForm.Show();
            salesCornerForm.BringToFront();

        }


        private void FormDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.log.Show();
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            formEditProfile.Show();
            formEditProfile.BringToFront();
        }

        private void btnSalesHistory_Click(object sender, EventArgs e)
        {
            formSalHistory.Show();
            formSalHistory.BringToFront();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure to Logged out from system?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.No)
                return;

            this.Hide();
            this.log.Show();
        }
    }
}
