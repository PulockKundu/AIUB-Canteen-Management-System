using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFACrudQ;
using WindowsFormsNewProject;

namespace PracticeGridview
{
    public partial class FormSale: Form
    {
        private FormDashboard dsh;
        private FormAdmin admin;
        private double cartTotal;
        private string userId;



        public DataAccess Da { get; set; }
        public FormSale()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
            this.PopulateCartGridView();
            this.dgvCart.ClearSelection();
            this.dgvProduct.ClearSelection();
        }
        public FormSale(string id,FormDashboard da) : this()
        {
            this.userId = id;
            this.dsh = da;

        }
        public FormSale(string id, FormAdmin admin) : this()
        {
            this.userId = id;
            this.admin = admin;
           
        }

       


        private void PopulateGridView(string sql = "select * from ProductTable;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvProduct.AutoGenerateColumns = false;
            this.dgvProduct.DataSource = ds.Tables[0];

        }
        private void PopulateCartGridView(string sql = "select * from CartTable;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvCart.AutoGenerateColumns = false;
            this.dgvCart.DataSource = ds.Tables[0];
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            try
            {

            
          
            string id = this.dgvProduct.CurrentRow.Cells["ProductId"].Value.ToString();
            string name = this.dgvProduct.CurrentRow.Cells["ProductName"].Value.ToString();
            double unitPrice = Convert.ToDouble(this.dgvProduct.CurrentRow.Cells["UnitPrice"].Value);
            int selectedQty = Convert.ToInt32(this.nudQuantity.Value);
            int stockQty = Convert.ToInt32(this.dgvProduct.CurrentRow.Cells["Quantity"].Value);

            
            if (selectedQty <= 0)
            {
                MessageBox.Show("Please select a quantity.");
                return;
            }
            if (selectedQty > stockQty)
            {
                MessageBox.Show("Not enough stock available.");
                return;
            }

          
            string checkSql = $"SELECT CartQuantity FROM carttable WHERE CartProductId = '{id}'";
            DataSet ds = this.Da.ExecuteQuery(checkSql);

            if (ds.Tables[0].Rows.Count > 0)
            {
               
                int existingQty = Convert.ToInt32(ds.Tables[0].Rows[0]["CartQuantity"]);
                int newQty = existingQty + selectedQty;
                double newTotal = newQty * unitPrice;

                string updateCartSql = $"UPDATE carttable SET CartQuantity = {newQty}, CartTotal = {newTotal} WHERE CartProductId = '{id}'";
                this.Da.ExecuteDMLQuery(updateCartSql);
            }
            else
            {
               
                double total = selectedQty * unitPrice;
                string insertSql = $"INSERT INTO carttable (CartProductId, CartProductName, CartQuantity, CartTotal) " +
                                   $"VALUES ('{id}', '{name}', {selectedQty}, {total})";
                this.Da.ExecuteDMLQuery(insertSql);
            }

            
            int newStockQty = stockQty - selectedQty;
            string updateStockSql = $"UPDATE ProductTable SET Quantity = {newStockQty} WHERE ProductId = '{id}'";
            this.Da.ExecuteDMLQuery(updateStockSql);

            
            this.PopulateGridView();
            this.PopulateCartGridView();
            this.CalculateCarttotal();

            MessageBox.Show("Item added to cart successfully.");

            
            this.nudQuantity.Value = 0;
            this.txtSearch.Text = "";
            this.dgvCart.ClearSelection();
            this.dgvProduct.ClearSelection();


            }
            catch (Exception exc)
            {
                MessageBox.Show("There is an error occur, Please try again.\n" + exc.Message);
            }

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {

          
            string searchText = this.txtSearch.Text.Trim();
            string sql = $"SELECT * FROM ProductTable WHERE ProductName LIKE '%{searchText}%'";

            var ds = this.Da.ExecuteQuery(sql);

            if (ds.Tables[0].Rows.Count > 0)
            {
               
                this.dgvProduct.DataSource = ds.Tables[0];
            }
            else
            {
                this.dgvProduct.DataSource = null; 
                MessageBox.Show("No products found with the given name.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            }
            catch (Exception exc)
            {
                MessageBox.Show("There is an error occur, Please try again.\n" + exc.Message);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
         try
          {

            
            if (dgvCart.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to remove.");
                return;
            }

            var warn1 = MessageBox.Show("Are you sure to Remove Item ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (warn1 == DialogResult.No)
                return;

            string cartProductId = dgvCart.CurrentRow.Cells["CartProductId"].Value.ToString();
            int cartQuantity = Convert.ToInt32(dgvCart.CurrentRow.Cells["CartQuantity"].Value);
            //addme
            double currentCartTotal= Convert.ToDouble(dgvCart.CurrentRow.Cells["CartTotal"].Value);

            string deleteSql = $"DELETE FROM carttable WHERE CartProductId = '{cartProductId}'";
            int result = Da.ExecuteDMLQuery(deleteSql);

            if (result == 1)
            {
                
                string updateStockSql = $"UPDATE ProductTable SET Quantity = Quantity + {cartQuantity} WHERE ProductId = '{cartProductId}'";
                Da.ExecuteDMLQuery(updateStockSql);
                MessageBox.Show("Item removed from cart and re-stocked.");
                
                PopulateCartGridView();
                PopulateGridView();
                this.CalculateCarttotal();
            }
            else
            {
                MessageBox.Show("Failed to remove item.");
            }
            this.dgvCart.ClearSelection();
            this.dgvProduct.ClearSelection();
            }
            catch (Exception exc)
            {
                MessageBox.Show("There is an error occur, Please try again.\n" + exc.Message);
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            try
            {

            
            if (dgvCart.Rows.Count == 0)
            {
                MessageBox.Show("Cart is already empty.");
                return;
            }
            var warn2 = MessageBox.Show("Are you sure to Clear All Item ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (warn2 == DialogResult.No)
                return;

            foreach (DataGridViewRow row in dgvCart.Rows)
            {
                if (row.IsNewRow) continue; 

                string productId = row.Cells["CartProductId"].Value.ToString();
                int cartQuantity = Convert.ToInt32(row.Cells["CartQuantity"].Value);

                
                string updateStockSql = $"UPDATE ProductTable SET Quantity = Quantity + {cartQuantity} WHERE ProductId = '{productId}'";
                Da.ExecuteDMLQuery(updateStockSql);
            }

            
            string deleteAllSql = "DELETE FROM carttable";
            int result = Da.ExecuteDMLQuery(deleteAllSql);

            if (result >= 1)
            {
                MessageBox.Show("All items removed from cart and stock updated.");
                PopulateCartGridView();
                PopulateGridView();
                this.cartTotal = 0.0;
                this.txtCartTotal.Text = "";
            }
            else
            {
                MessageBox.Show("Failed to clear the cart.");
            }
            this.dgvCart.ClearSelection();
            this.dgvProduct.ClearSelection();
          }
            catch (Exception exc)
            {
                MessageBox.Show("There is an error occur, Please try again.\n" + exc.Message);
            }
        }

        private void CalculateCarttotal()
        {
            try 
            { 
            
             this.cartTotal = 0.0;
            foreach (DataGridViewRow row in dgvCart.Rows)
            {
                if (row.IsNewRow) continue; 

                string productId = row.Cells["CartProductId"].Value.ToString();
                this.cartTotal += Convert.ToDouble(row.Cells["CartTotal"].Value);

                
            }
            
            this.txtCartTotal.Text = cartTotal.ToString();
            }
            catch (Exception exc)
            {
                MessageBox.Show("There is an error occur, Please try again.\n" + exc.Message);
            }
        }

     
        

        private void txtPay_Leave(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.txtCartTotal.Text) || this.txtCartTotal.Text == "0")
                {
                    MessageBox.Show("Please Add to Cart First.");
                    return; 
                }

                if (!double.TryParse(this.txtPay.Text.Trim(), out double pay))
                {
                    MessageBox.Show("Please enter a valid number for Pay.");
                    return;
                }
               
                if (this.cartTotal <= pay)
                    this.txtChange.Text = $"{pay - this.cartTotal}";
                else
                {
                    string changes = (this.cartTotal - pay).ToString("0.000");
                    MessageBox.Show($"Insuffucuent Pay amount ,More Needed Amount: "+changes);
                    this.txtChange.Text = "";
                }

                }

            catch (Exception exc)
            {
                if (string.IsNullOrWhiteSpace(this.txtPay.Text))
                {
                    MessageBox.Show("Please enter the pay amount.");
                    return;
                }
                else
                    MessageBox.Show("An error has occurred in the system, please try again.\n" + exc.Message);
            }
        }

        private string GenerateInvoiceId()
        {
            try
            {

            
            string sql = "SELECT MAX(InvoiceNo) FROM ConfirmTable;";
            DataTable dt = this.Da.ExecuteQueryTable(sql);

            string oldId = dt.Rows[0][0].ToString();
            if (string.IsNullOrEmpty(oldId))
            {
                return "inv-001"; // first invoice
            }

            string[] parts = oldId.Split('-');
            int number = Convert.ToInt32(parts[1]);
            string newId = "inv-" + (++number).ToString("D3");

            return newId;
            }
            catch (Exception exc)
            {
                MessageBox.Show("There is an error occur, Please try again.\n" + exc.Message);
                return "";
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
         try
            {

            if (string.IsNullOrEmpty(this.txtCartTotal.Text) || this.txtCartTotal.Text=="0")
            {
                MessageBox.Show("Can't confirme Please add To Cart First.");
                return ; 
            }
            double totalSale = Convert.ToDouble(this.txtCartTotal.Text);
            if (string.IsNullOrWhiteSpace(this.txtPay.Text))
            {
                MessageBox.Show("Please enter a payment amount.");
                return;
            }

            double totalPay;
            if (!double.TryParse(this.txtPay.Text, out totalPay))
            {
                MessageBox.Show("Invalid number format.");
                return;
            }
             totalPay = Convert.ToDouble(this.txtPay.Text);

            if(totalPay < totalSale) 
            {
                MessageBox.Show("Please Enter the Minimum Total Amount");
                return;
            }
            
            string invoiceNo = GenerateInvoiceId(); 
            string userId = this.userId;      
            double changes = totalPay- totalSale ;


            
            string saleDate = DateTime.Now.ToString("yyyy-MM-dd"); // e.g., "2025-06-13"
            string saleTime = DateTime.Now.ToString("HH:mm:ss");   // e.g., "22:15:42"

            
            string insertSql = $"INSERT INTO ConfirmTable (InvoiceNo, UserId, TotalSale, SaleDate, SaleTime,Pay,Changes) " +
                               $"VALUES ('{invoiceNo}', '{userId}', {totalSale}, '{saleDate}', '{saleTime}','{totalPay}','{changes}')";

            int result = this.Da.ExecuteDMLQuery(insertSql);

            if (result == 1)
            {
                MessageBox.Show("Sale confirmed and saved successfully.");
                string deleteAllSql = "DELETE FROM carttable";
                
                Da.ExecuteDMLQuery(deleteAllSql);
                PopulateCartGridView();
            }
            else
            {
                MessageBox.Show("Failed to confirm sale.");
            }

            this.txtCartTotal.Text = "";
            this.txtPay.Text = "";
            this.txtChange.Text = "";
            }
            catch (Exception exc)
            {
                MessageBox.Show("There is an error occur, Please try again.\n" + exc.Message);
            }
        }

       

        private void btnCartUpdateQuantity_Click(object sender, EventArgs e)
        {
          try
           {

            if (dgvCart.CurrentRow == null)
            {
                MessageBox.Show("Please select a cart item to update.");
                return;
            }

            string productId = dgvCart.CurrentRow.Cells["CartProductId"].Value.ToString();
            int oldCartQty = Convert.ToInt32(dgvCart.CurrentRow.Cells["CartQuantity"].Value);
            double unitPrice = Convert.ToDouble(dgvCart.CurrentRow.Cells["CartTotal"].Value) / oldCartQty;
            int newQty = Convert.ToInt32(nudUpdateCartItem.Value);

            if (newQty <= 0)
            {
                MessageBox.Show("Quantity must be greater than zero.");
                return;
            }

            int quantityDifference = newQty - oldCartQty;

            
            string stockSql = $"SELECT Quantity FROM ProductTable WHERE ProductId = '{productId}'";
            DataTable dt = Da.ExecuteQueryTable(stockSql);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Product not found in stock.");
                return;
            }

            int stockQty = Convert.ToInt32(dt.Rows[0]["Quantity"]);

            if (quantityDifference > 0 && quantityDifference > stockQty)
            {
                MessageBox.Show("Not enough stock available.");
                return;
            }

        
            double newTotal = newQty * unitPrice;
            string updateCartSql = $"UPDATE CartTable SET CartQuantity = {newQty}, CartTotal = {newTotal} WHERE CartProductId = '{productId}'";
            Da.ExecuteDMLQuery(updateCartSql);

            
            int updatedStock = stockQty - quantityDifference;  
            string updateStockSql = $"UPDATE ProductTable SET Quantity = {updatedStock} WHERE ProductId = '{productId}'";
            Da.ExecuteDMLQuery(updateStockSql);

            
            PopulateCartGridView();
            PopulateGridView(); 
            CalculateCarttotal();   

            this.dgvCart.ClearSelection();
            this.dgvProduct.ClearSelection(); 

               

          }
            catch (Exception exc)
            {
                MessageBox.Show("There is an error occur, Please try again.\n" + exc.Message);
            }
        }

        private void dgvCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          try 
           { 
            int oldCartQty = Convert.ToInt32(dgvCart.CurrentRow.Cells["CartQuantity"].Value);
            nudUpdateCartItem.Value = oldCartQty;
           }
            catch (Exception exc)
            {
                MessageBox.Show("There is an error occur, Please try again.\n" + exc.Message);
            }
        }

        private void btnViewRecipt_Click(object sender, EventArgs e)
        {
            FormInvoice fi=new FormInvoice();
            fi.Show();
        }

        private void FormSale_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                this.admin.Show();
            }
            catch (Exception exc)
            {
                MessageBox.Show("There is an error occur, Please try again.\n" + exc.Message);
            }
        }

        private void FormSale_Load_1(object sender, EventArgs e)
        {
            this.dgvCart.ClearSelection();
            this.dgvProduct.ClearSelection();
        }
    }
}
