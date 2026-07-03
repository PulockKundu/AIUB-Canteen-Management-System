using PracticeGridview;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFACrudQ;

namespace WindowsFormsNewProject
{
    public partial class FormLogin: Form
    {
        private string userId;
        private FormDashboard dsh;
        
        public DataAccess Da { get; set; }
        public FormLogin()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
            this.Da = new DataAccess();
            
         
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(this.txtUserId.Text) || string.IsNullOrWhiteSpace(this.txtPassword.Text))
                {
                    MessageBox.Show("Please fill all the empty fields");
                    return;
                }

                string sql = "select * from UserTable where UserId = '" + this.txtUserId.Text + "' and Password = '" + this.txtPassword.Text + "';";

                DataTable dt = this.Da.ExecuteQueryTable(sql);

                if (dt.Rows.Count== 1)
                {
                    
                    var userId = dt.Rows[0]["UserId"].ToString();
                    this.userId = userId;
                    MessageBox.Show("Login Successfully");
                    this.Visible = false;

                    if (dt.Rows[0][3].ToString().Equals("Admin"))
                    {
                        new FormAdmin(userId, this).Visible = true;
                        this.ClearAll();
                    }
                    else if (dt.Rows[0][3].ToString().Equals("Salesman"))
                    {

                        new FormDashboard(userId,this).Visible=true;
                        this.ClearAll();
                       
                    }
                }
                else
                {
                MessageBox.Show("Invalid User,Login Failed");
                }

                
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occurred in the system, please try again.\n" + exc.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }

        private void ClearAll()
        {
            this.txtUserId.Clear();
            this.txtPassword.Clear();
        }

        private void ckbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chbShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
