using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using WFACrudQ;

namespace WindowsFormsNewProject
{
    public partial class ManageUser: UserControl
    {
        public DataAccess Da { get; set; }
        public ManageUser()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
            this.AutoIdGenerate();
        }

        private void PopulateGridView(string sql = "SELECT * FROM UserTable;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvUser.AutoGenerateColumns = false;
            this.dgvUser.DataSource = ds.Tables[0];
        }

        private void btnShowUserDetails_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM UserTable;";
            this.PopulateGridView(sql);
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql = "select * from UserTable where UserId='" + this.txtSearch.Text + "';";
            this.PopulateGridView(sql);
        }

        private void btnUserAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToSave())
                {
                    MessageBox.Show("Please fill all the empty fields");
                    return;
                }

                var query = "select * from UserTable where UserId = '" + this.txtUserId.Text + "';";
                var ds = this.Da.ExecuteQuery(query);

                if (ds.Tables[0].Rows.Count == 1)
                {
                    var sql = @"UPDATE UserTable
                             SET UserName = '" + this.txtUserName.Text + @"',
                             Password = '" + this.txtPassword.Text + @"',
                             UserType = '" + this.cmbUserType.Text + @"'
                             WHERE UserId = '" + this.txtUserId.Text + "';";

                    var count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data has been updated in the list");
                    else
                        MessageBox.Show("Data hasn't been updated in the list");
                }
                else
                {
                    var sql = "insert into UserTable values('" + this.txtUserId.Text + "','" + this.txtUserName.Text + "','" + this.txtPassword.Text + "','" + this.cmbUserType.Text + "');";

                    var count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data has been Added");
                    else
                        MessageBox.Show("Data has not Added");

                }

                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("There is an error occur, Please try again.\n" + exc.Message);
            }

        }

        private bool IsValidToSave()
        {
            if (string.IsNullOrEmpty(this.txtUserId.Text) || string.IsNullOrEmpty(this.txtUserName.Text) ||
                string.IsNullOrEmpty(this.txtPassword.Text) || string.IsNullOrEmpty(this.cmbUserType.Text))

                return false;
            else
                return true;
        }

        private void btnUserClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }

        private void ClearAll()
        {
            this.txtUserId.Clear();
            this.txtUserName.Clear();
            this.txtPassword.Clear();
            this.cmbUserType.SelectedIndex = -1;
            this.txtSearch.Text = "";

            this.dgvUser.ClearSelection();
            this.AutoIdGenerate();
        }



        private void btnUserDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvUser.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to delete.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                var id = this.dgvUser.CurrentRow.Cells["UserId"].Value.ToString();
                var name = this.dgvUser.CurrentRow.Cells["UserName"].Value.ToString();
                

                var result = MessageBox.Show("Are you sure to delete data?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.No)
                    return;

                var sql = "delete from UserTable where UserId = '" + id + "';";
                var count = this.Da.ExecuteDMLQuery(sql);
                if (count == 1)
                    MessageBox.Show(name.ToUpper() + " has been removed from the list");
                else
                    MessageBox.Show("Data hasn't been deleted from the list");

                this.PopulateGridView();
                this.ClearAll();

            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occurred in the system, please try again.\n" + exc.Message);
            }     

        }

        private void ManageUser_Load(object sender, EventArgs e)
        {
            this.dgvUser.ClearSelection();
            this.AutoIdGenerate();
        }

        private void dgvUser_DoubleClick(object sender, EventArgs e)
        {

            this.txtUserId.Text = this.dgvUser.CurrentRow.Cells[0].Value.ToString();
            this.txtUserName.Text = this.dgvUser.CurrentRow.Cells[1].Value.ToString();
            this.txtPassword.Text = this.dgvUser.CurrentRow.Cells[2].Value.ToString();
            this.cmbUserType.Text = this.dgvUser.CurrentRow.Cells[3].Value.ToString();

        }


        private void AutoIdGenerate()
        {
            var sql = "select max(UserId) from UserTable;";
            DataTable dt = this.Da.ExecuteQueryTable(sql);
            var oldId = dt.Rows[0][0].ToString();
            var temp = oldId.Split('-');
            var num = Convert.ToInt32(temp[1]);
            var currentId = "u-" + (++num).ToString("d3"); 
            this.txtUserId.Text = currentId;
        }
    }
} 
