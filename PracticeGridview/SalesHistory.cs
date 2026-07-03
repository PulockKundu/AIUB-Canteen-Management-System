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

namespace PracticeGridview
{
    public partial class SalesHistory: UserControl
    {
       
        
        public DataAccess Da { get; set; }
        public SalesHistory()
        {
            InitializeComponent();
            this.Da = new DataAccess();

            string sql = $"select * from ConfirmTable ;";
            PopulateGridView(sql);
        }
        

        private void PopulateGridView(string sql)
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvSalesManSalesHistory.AutoGenerateColumns = false;
            this.dgvSalesManSalesHistory.DataSource = ds.Tables[0];

        }

        private void btnLast7Day_Click(object sender, EventArgs e)
        {
          try
           {

            string sql = $"SELECT * FROM ConfirmTable WHERE SaleDate >= DATEADD(DAY, -7, GETDATE());";
            PopulateGridView(sql);
           }
            catch (Exception exc)
           {
                MessageBox.Show("There is an error occur, Please try again.\n" + exc.Message);
           }
        }

        private void btnlast30Days_Click(object sender, EventArgs e)
        {
          try
           {

            string sql = $"SELECT * FROM ConfirmTable WHERE SaleDate >= DATEADD(DAY, -30, GETDATE());";
            PopulateGridView(sql);
           }
            catch (Exception exc)
            {
                MessageBox.Show("There is an error occur, Please try again.\n" + exc.Message);
            }
        }

        private void btnEntireSale_Click(object sender, EventArgs e)
        {
          try
           {

            string sql = $"SELECT * FROM ConfirmTable ;";
            PopulateGridView(sql);
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
            string sql = $"SELECT * FROM ConfirmTable WHERE UserId LIKE '%{searchText}%'";

            var ds = this.Da.ExecuteQuery(sql);

            if (ds.Tables[0].Rows.Count > 0)
            {
                this.dgvSalesManSalesHistory.DataSource = ds.Tables[0];
            }
            else
            {
                this.dgvSalesManSalesHistory.DataSource = null;
                MessageBox.Show("No products found with the given name.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
          }
            catch (Exception exc)
            {
                MessageBox.Show("There is an error occur, Please try again.\n" + exc.Message);
            }
        }
    }
}
