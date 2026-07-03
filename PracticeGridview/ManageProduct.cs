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

namespace WindowsFormsNewProject
{
    public partial class Manage_Product: UserControl
    {
        public DataAccess Da { get; set; }
        public Manage_Product()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
            this.AutoIdGenerate();
        }

        private void PopulateGridView(string sql = "select * from ProductTable;")
        {
            var ds = this.Da.ExecuteQuery(sql);
            this.dgvProduct.AutoGenerateColumns = false;
            this.dgvProduct.DataSource = ds.Tables[0];
        }

        private void btnShowProductDetails_Click(object sender, EventArgs e)
        {
            string sql = "select * from ProductTable;";
            this.PopulateGridView(sql);
        }

        private void btnProductSearch_Click(object sender, EventArgs e)
        {
            string sql = "select * from ProductTable where ProductName ='" + this.txtProductSearch.Text + "';";
            this.PopulateGridView(sql);
        }

        private void btnProductAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToSave())
                {
                    MessageBox.Show("Please fill all the empty fields");
                    return;
                }

                //Quantity and Price Validation
                if (!int.TryParse(this.txtQuantity.Text.Trim(), out int quantity))
                {
                    MessageBox.Show("Please enter a valid number for Quantity.");
                    return;
                }

                if (!double.TryParse(this.txtPrice.Text.Trim(), out double price))
                {
                    MessageBox.Show("Please enter a valid number for Price.");
                    return;
                }

                var query = "select * from ProductTable where ProductId = '" + this.txtProductId.Text + "';";
                var ds = this.Da.ExecuteQuery(query);

                if (ds.Tables[0].Rows.Count == 1)
                {
                    var sql = @"UPDATE ProductTable
                             SET ProductName = '" + this.txtProductName.Text + @"',
                             Quantity = " + this.txtQuantity.Text + @",
                             UnitPrice = " + this.txtPrice.Text + @"
                             WHERE ProductId = '" + this.txtProductId.Text + "';";

                    var count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data has been updated in the list");
                    else
                        MessageBox.Show("Data hasn't been updated in the list");

                }
                else
                {
                    var sql = "insert into ProductTable values('" + this.txtProductId.Text + "','" + this.txtProductName.Text + "'," + this.txtQuantity.Text + "," + this.txtPrice.Text + ");";
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
            if (string.IsNullOrEmpty(this.txtProductId.Text) || string.IsNullOrEmpty(this.txtProductName.Text) ||
                string.IsNullOrEmpty(this.txtQuantity.Text) || string.IsNullOrEmpty(this.txtPrice.Text))

                return false;
            else
                return true;
        }

        private void btnProductClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }

        private void ClearAll()
        {
            this.txtProductId.Clear();
            this.txtProductName.Clear();
            this.txtQuantity.Clear();
            this.txtPrice.Clear();
            this.txtProductSearch.Text = "";

            this.dgvProduct.ClearSelection();
            this.AutoIdGenerate();
        }

        private void btnProductDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvProduct.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to delete.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                var id = this.dgvProduct.CurrentRow.Cells["ProductId"].Value.ToString();
                var name = this.dgvProduct.CurrentRow.Cells["ProductName"].Value.ToString();
             
                var result = MessageBox.Show("Are you sure to delete data?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.No)
                    return;

                var sql = "delete from ProductTable where ProductId = '" + id + "';";
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

        private void ManageProduct_Load(object sender, EventArgs e)
        {
            this.dgvProduct.ClearSelection();
            this.AutoIdGenerate();
        }

        private void dgvProduct_DoubleClick(object sender, EventArgs e)
        {
            this.txtProductId.Text = this.dgvProduct.CurrentRow.Cells[0].Value.ToString();
            this.txtProductName.Text = this.dgvProduct.CurrentRow.Cells[1].Value.ToString();
            this.txtQuantity.Text = this.dgvProduct.CurrentRow.Cells[2].Value.ToString();
            this.txtPrice.Text = this.dgvProduct.CurrentRow.Cells[3].Value.ToString();

        }

        private void AutoIdGenerate()
        {
            var sql = "select max(ProductId) from ProductTable;";
            DataTable dt = this.Da.ExecuteQueryTable(sql);
            var oldId = dt.Rows[0][0].ToString();

            int num = 0;
            if (!string.IsNullOrEmpty(oldId))
            {
                // Assuming the format is "U001"
                num = Convert.ToInt32(oldId.Substring(1));
            }

            var currentId = "P" + (++num).ToString("D3"); //zeros to 3 digits
            this.txtProductId.Text = currentId;
        }

    }
}
