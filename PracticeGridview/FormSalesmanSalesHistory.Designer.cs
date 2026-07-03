namespace PracticeGridview
{
    partial class FormSalesmanSalesHistory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearchUser = new System.Windows.Forms.Label();
            this.btnEntireSale = new System.Windows.Forms.Button();
            this.btnlast30Days = new System.Windows.Forms.Button();
            this.btnLast7Day = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvSalesManSalesHistory = new System.Windows.Forms.DataGridView();
            this.InvoiceNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsersId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Changes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesManSalesHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.lblSearchUser);
            this.panel1.Controls.Add(this.btnEntireSale);
            this.panel1.Controls.Add(this.btnlast30Days);
            this.panel1.Controls.Add(this.btnLast7Day);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-4, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1239, 754);
            this.panel1.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(367, 478);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(213, 34);
            this.txtSearch.TabIndex = 24;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearchUser
            // 
            this.lblSearchUser.AutoSize = true;
            this.lblSearchUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchUser.Location = new System.Drawing.Point(77, 478);
            this.lblSearchUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchUser.Name = "lblSearchUser";
            this.lblSearchUser.Size = new System.Drawing.Size(262, 29);
            this.lblSearchUser.TabIndex = 23;
            this.lblSearchUser.Text = "Search By InvoiceNo:";
            // 
            // btnEntireSale
            // 
            this.btnEntireSale.BackColor = System.Drawing.Color.DarkOrange;
            this.btnEntireSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntireSale.Location = new System.Drawing.Point(827, 608);
            this.btnEntireSale.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEntireSale.Name = "btnEntireSale";
            this.btnEntireSale.Size = new System.Drawing.Size(363, 81);
            this.btnEntireSale.TabIndex = 19;
            this.btnEntireSale.Text = "Entire Sale";
            this.btnEntireSale.UseVisualStyleBackColor = false;
            this.btnEntireSale.Click += new System.EventHandler(this.btnEntireSale_Click);
            // 
            // btnlast30Days
            // 
            this.btnlast30Days.BackColor = System.Drawing.Color.DarkOrange;
            this.btnlast30Days.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlast30Days.Location = new System.Drawing.Point(437, 608);
            this.btnlast30Days.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnlast30Days.Name = "btnlast30Days";
            this.btnlast30Days.Size = new System.Drawing.Size(329, 81);
            this.btnlast30Days.TabIndex = 18;
            this.btnlast30Days.Text = "Last 30 Days Sale";
            this.btnlast30Days.UseVisualStyleBackColor = false;
            this.btnlast30Days.Click += new System.EventHandler(this.btnlast30Days_Click);
            // 
            // btnLast7Day
            // 
            this.btnLast7Day.BackColor = System.Drawing.Color.DarkOrange;
            this.btnLast7Day.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast7Day.Location = new System.Drawing.Point(48, 608);
            this.btnLast7Day.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLast7Day.Name = "btnLast7Day";
            this.btnLast7Day.Size = new System.Drawing.Size(324, 81);
            this.btnLast7Day.TabIndex = 17;
            this.btnLast7Day.Text = "Last 7 Days Sale";
            this.btnLast7Day.UseVisualStyleBackColor = false;
            this.btnLast7Day.Click += new System.EventHandler(this.btnLast7Day_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvSalesManSalesHistory);
            this.panel2.Location = new System.Drawing.Point(4, 10);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1231, 412);
            this.panel2.TabIndex = 0;
            // 
            // dgvSalesManSalesHistory
            // 
            this.dgvSalesManSalesHistory.AllowUserToAddRows = false;
            this.dgvSalesManSalesHistory.AllowUserToDeleteRows = false;
            this.dgvSalesManSalesHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalesManSalesHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InvoiceNo,
            this.UsersId,
            this.TotalSale,
            this.SaleDate,
            this.SaleTime,
            this.Pay,
            this.Changes});
            this.dgvSalesManSalesHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSalesManSalesHistory.Location = new System.Drawing.Point(0, 0);
            this.dgvSalesManSalesHistory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvSalesManSalesHistory.Name = "dgvSalesManSalesHistory";
            this.dgvSalesManSalesHistory.ReadOnly = true;
            this.dgvSalesManSalesHistory.RowHeadersWidth = 51;
            this.dgvSalesManSalesHistory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvSalesManSalesHistory.Size = new System.Drawing.Size(1231, 412);
            this.dgvSalesManSalesHistory.TabIndex = 1;
            // 
            // InvoiceNo
            // 
            this.InvoiceNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.InvoiceNo.DataPropertyName = "InvoiceNo";
            this.InvoiceNo.HeaderText = "Invoice No";
            this.InvoiceNo.MinimumWidth = 6;
            this.InvoiceNo.Name = "InvoiceNo";
            this.InvoiceNo.ReadOnly = true;
            // 
            // UsersId
            // 
            this.UsersId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UsersId.DataPropertyName = "UserId";
            this.UsersId.HeaderText = "User Id";
            this.UsersId.MinimumWidth = 6;
            this.UsersId.Name = "UsersId";
            this.UsersId.ReadOnly = true;
            // 
            // TotalSale
            // 
            this.TotalSale.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TotalSale.DataPropertyName = "TotalSale";
            this.TotalSale.HeaderText = "Total Sale";
            this.TotalSale.MinimumWidth = 6;
            this.TotalSale.Name = "TotalSale";
            this.TotalSale.ReadOnly = true;
            // 
            // SaleDate
            // 
            this.SaleDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SaleDate.DataPropertyName = "SaleDate";
            this.SaleDate.HeaderText = "Sale Date";
            this.SaleDate.MinimumWidth = 6;
            this.SaleDate.Name = "SaleDate";
            this.SaleDate.ReadOnly = true;
            // 
            // SaleTime
            // 
            this.SaleTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SaleTime.DataPropertyName = "SaleTime";
            this.SaleTime.HeaderText = "Sale Time";
            this.SaleTime.MinimumWidth = 6;
            this.SaleTime.Name = "SaleTime";
            this.SaleTime.ReadOnly = true;
            // 
            // Pay
            // 
            this.Pay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Pay.DataPropertyName = "Pay";
            this.Pay.HeaderText = "Pay";
            this.Pay.MinimumWidth = 6;
            this.Pay.Name = "Pay";
            this.Pay.ReadOnly = true;
            // 
            // Changes
            // 
            this.Changes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Changes.DataPropertyName = "Changes";
            this.Changes.HeaderText = "Changes";
            this.Changes.MinimumWidth = 6;
            this.Changes.Name = "Changes";
            this.Changes.ReadOnly = true;
            // 
            // FormSalesmanSalesHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 757);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FormSalesmanSalesHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalesHistory";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesManSalesHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvSalesManSalesHistory;
        private System.Windows.Forms.Button btnEntireSale;
        private System.Windows.Forms.Button btnlast30Days;
        private System.Windows.Forms.Button btnLast7Day;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsersId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Changes;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearchUser;
    }
}