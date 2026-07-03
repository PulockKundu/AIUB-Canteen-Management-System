namespace PracticeGridview
{
    partial class FormSale
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.CartProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CartProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CartQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CartTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblChangesPress = new System.Windows.Forms.Label();
            this.btnCartUpdateQuantity = new System.Windows.Forms.Button();
            this.lblCartUpdateQuantity = new System.Windows.Forms.Label();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.lblCartChange = new System.Windows.Forms.Label();
            this.txtPay = new System.Windows.Forms.TextBox();
            this.lblCartPay = new System.Windows.Forms.Label();
            this.txtCartTotal = new System.Windows.Forms.TextBox();
            this.lblCartTotal = new System.Windows.Forms.Label();
            this.lblCartRemove = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.nudUpdateCartItem = new System.Windows.Forms.NumericUpDown();
            this.btnViewRecipt = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUpdateCartItem)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvProduct);
            this.panel2.Location = new System.Drawing.Point(12, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(436, 347);
            this.panel2.TabIndex = 1;
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToAddRows = false;
            this.dgvProduct.AllowUserToDeleteRows = false;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.ProductName,
            this.Quantity,
            this.UnitPrice});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProduct.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProduct.Location = new System.Drawing.Point(0, 0);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            this.dgvProduct.RowHeadersWidth = 51;
            this.dgvProduct.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduct.Size = new System.Drawing.Size(436, 347);
            this.dgvProduct.TabIndex = 0;
            // 
            // ProductID
            // 
            this.ProductID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductID.DataPropertyName = "ProductId";
            this.ProductID.HeaderText = "Product ID";
            this.ProductID.MinimumWidth = 6;
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            // 
            // ProductName
            // 
            this.ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.MinimumWidth = 6;
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // UnitPrice
            // 
            this.UnitPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UnitPrice.DataPropertyName = "UnitPrice";
            this.UnitPrice.HeaderText = "Unit Price";
            this.UnitPrice.MinimumWidth = 6;
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvCart);
            this.panel3.Location = new System.Drawing.Point(470, 37);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(445, 254);
            this.panel3.TabIndex = 2;
            // 
            // dgvCart
            // 
            this.dgvCart.AllowUserToAddRows = false;
            this.dgvCart.AllowUserToDeleteRows = false;
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CartProductId,
            this.CartProductName,
            this.CartQuantity,
            this.CartTotal});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCart.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCart.Location = new System.Drawing.Point(0, 0);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.ReadOnly = true;
            this.dgvCart.RowHeadersWidth = 51;
            this.dgvCart.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCart.Size = new System.Drawing.Size(445, 254);
            this.dgvCart.TabIndex = 2;
            this.dgvCart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCart_CellContentClick);
            // 
            // CartProductId
            // 
            this.CartProductId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CartProductId.DataPropertyName = "CartProductId";
            this.CartProductId.HeaderText = "Product Id";
            this.CartProductId.MinimumWidth = 6;
            this.CartProductId.Name = "CartProductId";
            this.CartProductId.ReadOnly = true;
            // 
            // CartProductName
            // 
            this.CartProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CartProductName.DataPropertyName = "CartProductName";
            this.CartProductName.HeaderText = "Product Name";
            this.CartProductName.MinimumWidth = 6;
            this.CartProductName.Name = "CartProductName";
            this.CartProductName.ReadOnly = true;
            // 
            // CartQuantity
            // 
            this.CartQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CartQuantity.DataPropertyName = "CartQuantity";
            this.CartQuantity.HeaderText = "Quantity";
            this.CartQuantity.MinimumWidth = 6;
            this.CartQuantity.Name = "CartQuantity";
            this.CartQuantity.ReadOnly = true;
            // 
            // CartTotal
            // 
            this.CartTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CartTotal.DataPropertyName = "CartTotal";
            this.CartTotal.HeaderText = "Total";
            this.CartTotal.MinimumWidth = 6;
            this.CartTotal.Name = "CartTotal";
            this.CartTotal.ReadOnly = true;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.txtSearch);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.nudQuantity);
            this.panel4.Controls.Add(this.btnAddToCart);
            this.panel4.Location = new System.Drawing.Point(12, 391);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(436, 216);
            this.panel4.TabIndex = 3;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(118, 15);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(155, 26);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Search ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quantity";
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(118, 78);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.ReadOnly = true;
            this.nudQuantity.Size = new System.Drawing.Size(155, 26);
            this.nudQuantity.TabIndex = 1;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.BackColor = System.Drawing.Color.DarkOrange;
            this.btnAddToCart.Location = new System.Drawing.Point(110, 139);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(191, 47);
            this.btnAddToCart.TabIndex = 0;
            this.btnAddToCart.Text = "ADD To Cart";
            this.btnAddToCart.UseVisualStyleBackColor = false;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.lblChangesPress);
            this.panel5.Controls.Add(this.btnCartUpdateQuantity);
            this.panel5.Controls.Add(this.lblCartUpdateQuantity);
            this.panel5.Controls.Add(this.btnClearAll);
            this.panel5.Controls.Add(this.txtChange);
            this.panel5.Controls.Add(this.lblCartChange);
            this.panel5.Controls.Add(this.txtPay);
            this.panel5.Controls.Add(this.lblCartPay);
            this.panel5.Controls.Add(this.txtCartTotal);
            this.panel5.Controls.Add(this.lblCartTotal);
            this.panel5.Controls.Add(this.lblCartRemove);
            this.panel5.Controls.Add(this.btnRemove);
            this.panel5.Controls.Add(this.nudUpdateCartItem);
            this.panel5.Controls.Add(this.btnViewRecipt);
            this.panel5.Controls.Add(this.btnConfirm);
            this.panel5.Location = new System.Drawing.Point(470, 311);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(444, 294);
            this.panel5.TabIndex = 4;
            // 
            // lblChangesPress
            // 
            this.lblChangesPress.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangesPress.Location = new System.Drawing.Point(304, 140);
            this.lblChangesPress.Name = "lblChangesPress";
            this.lblChangesPress.Size = new System.Drawing.Size(104, 43);
            this.lblChangesPress.TabIndex = 15;
            this.lblChangesPress.Text = "<-- Click There to See Changes";
            // 
            // btnCartUpdateQuantity
            // 
            this.btnCartUpdateQuantity.BackColor = System.Drawing.Color.DarkOrange;
            this.btnCartUpdateQuantity.Location = new System.Drawing.Point(323, 11);
            this.btnCartUpdateQuantity.Name = "btnCartUpdateQuantity";
            this.btnCartUpdateQuantity.Size = new System.Drawing.Size(116, 61);
            this.btnCartUpdateQuantity.TabIndex = 14;
            this.btnCartUpdateQuantity.Text = "Update Quantity";
            this.btnCartUpdateQuantity.UseVisualStyleBackColor = false;
            this.btnCartUpdateQuantity.Click += new System.EventHandler(this.btnCartUpdateQuantity_Click);
            // 
            // lblCartUpdateQuantity
            // 
            this.lblCartUpdateQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCartUpdateQuantity.Location = new System.Drawing.Point(18, 24);
            this.lblCartUpdateQuantity.Name = "lblCartUpdateQuantity";
            this.lblCartUpdateQuantity.Size = new System.Drawing.Size(94, 26);
            this.lblCartUpdateQuantity.TabIndex = 13;
            this.lblCartUpdateQuantity.Text = "Set The Quantity \r\nFirst To Update";
            // 
            // btnClearAll
            // 
            this.btnClearAll.BackColor = System.Drawing.Color.DarkOrange;
            this.btnClearAll.Location = new System.Drawing.Point(261, 202);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(141, 34);
            this.btnClearAll.TabIndex = 5;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = false;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // txtChange
            // 
            this.txtChange.Location = new System.Drawing.Point(118, 141);
            this.txtChange.Name = "txtChange";
            this.txtChange.ReadOnly = true;
            this.txtChange.Size = new System.Drawing.Size(180, 26);
            this.txtChange.TabIndex = 12;
            // 
            // lblCartChange
            // 
            this.lblCartChange.AutoSize = true;
            this.lblCartChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCartChange.Location = new System.Drawing.Point(30, 140);
            this.lblCartChange.Name = "lblCartChange";
            this.lblCartChange.Size = new System.Drawing.Size(65, 18);
            this.lblCartChange.TabIndex = 11;
            this.lblCartChange.Text = "Change";
            // 
            // txtPay
            // 
            this.txtPay.Location = new System.Drawing.Point(118, 101);
            this.txtPay.Name = "txtPay";
            this.txtPay.Size = new System.Drawing.Size(180, 26);
            this.txtPay.TabIndex = 10;
            this.txtPay.Leave += new System.EventHandler(this.txtPay_Leave);
            // 
            // lblCartPay
            // 
            this.lblCartPay.AutoSize = true;
            this.lblCartPay.Location = new System.Drawing.Point(29, 106);
            this.lblCartPay.Name = "lblCartPay";
            this.lblCartPay.Size = new System.Drawing.Size(38, 20);
            this.lblCartPay.TabIndex = 9;
            this.lblCartPay.Text = "Pay";
            // 
            // txtCartTotal
            // 
            this.txtCartTotal.Location = new System.Drawing.Point(118, 62);
            this.txtCartTotal.Name = "txtCartTotal";
            this.txtCartTotal.ReadOnly = true;
            this.txtCartTotal.Size = new System.Drawing.Size(180, 26);
            this.txtCartTotal.TabIndex = 8;
            this.txtCartTotal.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblCartTotal
            // 
            this.lblCartTotal.AutoSize = true;
            this.lblCartTotal.Location = new System.Drawing.Point(29, 65);
            this.lblCartTotal.Name = "lblCartTotal";
            this.lblCartTotal.Size = new System.Drawing.Size(49, 20);
            this.lblCartTotal.TabIndex = 7;
            this.lblCartTotal.Text = "Total";
            // 
            // lblCartRemove
            // 
            this.lblCartRemove.AutoSize = true;
            this.lblCartRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCartRemove.Location = new System.Drawing.Point(55, 182);
            this.lblCartRemove.Name = "lblCartRemove";
            this.lblCartRemove.Size = new System.Drawing.Size(161, 13);
            this.lblCartRemove.TabIndex = 6;
            this.lblCartRemove.Text = "Select Any item First To Remove";
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.DarkOrange;
            this.btnRemove.Location = new System.Drawing.Point(58, 202);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(141, 34);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // nudUpdateCartItem
            // 
            this.nudUpdateCartItem.Location = new System.Drawing.Point(118, 24);
            this.nudUpdateCartItem.Name = "nudUpdateCartItem";
            this.nudUpdateCartItem.ReadOnly = true;
            this.nudUpdateCartItem.Size = new System.Drawing.Size(180, 26);
            this.nudUpdateCartItem.TabIndex = 3;
            // 
            // btnViewRecipt
            // 
            this.btnViewRecipt.BackColor = System.Drawing.Color.DarkOrange;
            this.btnViewRecipt.Location = new System.Drawing.Point(261, 255);
            this.btnViewRecipt.Name = "btnViewRecipt";
            this.btnViewRecipt.Size = new System.Drawing.Size(141, 34);
            this.btnViewRecipt.TabIndex = 2;
            this.btnViewRecipt.Text = "View Recipt";
            this.btnViewRecipt.UseVisualStyleBackColor = false;
            this.btnViewRecipt.Click += new System.EventHandler(this.btnViewRecipt_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.DarkOrange;
            this.btnConfirm.Location = new System.Drawing.Point(58, 255);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(141, 34);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "Confirm Order";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(168, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Product List";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(693, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cart";
            // 
            // FormSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(931, 616);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FormSale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sale";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormSale_FormClosed);
            this.Load += new System.EventHandler(this.FormSale_Load_1);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUpdateCartItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnViewRecipt;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudUpdateCartItem;
        private System.Windows.Forms.Label lblCartRemove;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblCartTotal;
        private System.Windows.Forms.TextBox txtPay;
        private System.Windows.Forms.Label lblCartPay;
        private System.Windows.Forms.TextBox txtCartTotal;
        private System.Windows.Forms.TextBox txtChange;
        private System.Windows.Forms.Label lblCartChange;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.Label lblCartUpdateQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn CartProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CartProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CartQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn CartTotal;
        private System.Windows.Forms.Button btnCartUpdateQuantity;
        private System.Windows.Forms.Label lblChangesPress;
    }
}

