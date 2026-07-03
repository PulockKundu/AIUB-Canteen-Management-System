using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFACrudQ;
using WindowsFormsNewProject;

namespace PracticeGridview
{
    public partial class ViewProfile: UserControl
    {

        private FormAdmin admin;
        private string userId;
        private string originalName;
        private string originalPassword;

        public DataAccess Da { get; set; }

        public ViewProfile()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            
        }
        public ViewProfile(string userId, FormAdmin admin) : this()
        {
            this.userId = userId;
            this.admin = admin;
            this.LoadInfo();
        }
        private void LoadInfo()
        {
            try
            {
                string sql = $"SELECT * FROM UserTable WHERE UserId= '{this.userId}'";
                DataTable dt = this.Da.ExecuteQueryTable(sql);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    txtUserId.Text = row["UserId"].ToString();
                    originalName = row["UserName"].ToString();
                    txtUserName.Text = originalName;
                    originalPassword = row["Password"].ToString();
                    txtPassword.Text = originalPassword;
                    txtUserType.Text = row["UserType"].ToString();


                }

            }
            catch (Exception exc)
            {
                MessageBox.Show("There is an error occur, Please try again.\n" + exc.Message);
            }

        }
        private bool IsValidToSave()
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
                return false;
            else
                return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string userId = txtUserId.Text;
                string newName = txtUserName.Text;
                string newPassword = txtPassword.Text;


                if (!this.IsValidToSave())
                {
                    MessageBox.Show("Name and Password cannot be empty.");
                    return;
                }

                if (originalName == newName && originalPassword == newPassword)
                {
                    MessageBox.Show("Privious And Updated Values are Same Nothing To Change.");
                    return;
                }


                string sql = @"update UserTable
               set UserName = '" + this.txtUserName.Text + @"',
                   Password = '" + this.txtPassword.Text + @"'
                   where UserId = '" + this.userId + "';";






                int count = this.Da.ExecuteDMLQuery(sql);

                if (count > 0)
                {
                    MessageBox.Show("Profile updated successfully!");
                    this.LoadInfo();
                }
                else
                {
                    MessageBox.Show("Profile Update failed, Please try again.");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("There is an error occur, Please try again.\n" + exc.Message);
            }
        }
    }
}
