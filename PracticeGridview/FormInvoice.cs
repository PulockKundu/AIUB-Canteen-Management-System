using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFACrudQ;

namespace PracticeGridview
{
    public partial class FormInvoice: Form
    {
        private FormSale sa;
        public DataAccess Da { get; set; }


        public FormInvoice()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.ShowInvoice();
        }
        public FormInvoice(FormSale sa) :this()
        {
            this.sa = sa;
        }


        private void ShowInvoice()
        {
          try
            { 

            string sqlInvoice = "SELECT MAX(InvoiceNo) FROM ConfirmTable;";
            DataTable dtInvoice = this.Da.ExecuteQueryTable(sqlInvoice);
            string invoiceNo = dtInvoice.Rows[0][0].ToString();
            this.lblInvoiceNo.Text = invoiceNo;

            string sqlDetails = $@"
                  SELECT UserId, TotalSale, SaleDate, SaleTime, Pay, Changes
                  FROM ConfirmTable
                  WHERE InvoiceNo = '{invoiceNo}'";
                  DataTable dtDetails = this.Da.ExecuteQueryTable(sqlDetails);

            if (dtDetails.Rows.Count > 0)
            {
                DataRow row = dtDetails.Rows[0];

                this.LblUserId.Text = row["UserId"].ToString();
                this.lblTotalSale.Text = row["TotalSale"].ToString();
                this.lblSaleDate.Text = Convert.ToDateTime(row["SaleDate"]).ToString("yyyy-MM-dd");
                this.lblSaleTime.Text = row["SaleTime"].ToString();
                this.lblPay.Text = row["Pay"].ToString();
                this.lblChanges.Text = row["Changes"].ToString();
            }
            else
            {
                MessageBox.Show("No invoice data found.");
            }
            }
            catch (Exception exc)
            {
                MessageBox.Show("There is an error occur, Please try again.\n" + exc.Message);
            }

        }

    }
}
