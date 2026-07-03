namespace WindowsFormsNewProject
{
    partial class FormAdmin
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnSalesCorner = new System.Windows.Forms.Button();
            this.btnSHistory = new System.Windows.Forms.Button();
            this.btnMUser = new System.Windows.Forms.Button();
            this.btnMProduct = new System.Windows.Forms.Button();
            this.btnViewProfile = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnSalesCorner);
            this.panel1.Controls.Add(this.btnSHistory);
            this.panel1.Controls.Add(this.btnMUser);
            this.panel1.Controls.Add(this.btnMProduct);
            this.panel1.Controls.Add(this.btnViewProfile);
            this.panel1.Controls.Add(this.lblInfo);
            this.panel1.Controls.Add(this.lblUsername);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 626);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PracticeGridview.Properties.Resources.Admin;
            this.pictureBox1.Location = new System.Drawing.Point(76, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLogOut.Location = new System.Drawing.Point(76, 565);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(100, 36);
            this.btnLogOut.TabIndex = 7;
            this.btnLogOut.Text = "LogOut";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            this.btnLogOut.MouseLeave += new System.EventHandler(this.btnLogOut_MouseLeave);
            this.btnLogOut.MouseHover += new System.EventHandler(this.btnLogOut_MouseHover);
            // 
            // btnSalesCorner
            // 
            this.btnSalesCorner.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnSalesCorner.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesCorner.Location = new System.Drawing.Point(28, 404);
            this.btnSalesCorner.Name = "btnSalesCorner";
            this.btnSalesCorner.Size = new System.Drawing.Size(205, 41);
            this.btnSalesCorner.TabIndex = 6;
            this.btnSalesCorner.Text = "Sales Corner";
            this.btnSalesCorner.UseVisualStyleBackColor = false;
            this.btnSalesCorner.Click += new System.EventHandler(this.btnSalesCorner_Click);
            this.btnSalesCorner.MouseLeave += new System.EventHandler(this.btnSale_MouseLeave);
            this.btnSalesCorner.MouseHover += new System.EventHandler(this.btnSale_MouseHover);
            // 
            // btnSHistory
            // 
            this.btnSHistory.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnSHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSHistory.Location = new System.Drawing.Point(28, 353);
            this.btnSHistory.Name = "btnSHistory";
            this.btnSHistory.Size = new System.Drawing.Size(205, 45);
            this.btnSHistory.TabIndex = 5;
            this.btnSHistory.Text = "Sales History";
            this.btnSHistory.UseVisualStyleBackColor = false;
            this.btnSHistory.Click += new System.EventHandler(this.btnSHistory_Click);
            this.btnSHistory.MouseLeave += new System.EventHandler(this.btnSHistory_MouseLeave);
            this.btnSHistory.MouseHover += new System.EventHandler(this.btnSHistory_MouseHover);
            // 
            // btnMUser
            // 
            this.btnMUser.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnMUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMUser.Location = new System.Drawing.Point(28, 302);
            this.btnMUser.Name = "btnMUser";
            this.btnMUser.Size = new System.Drawing.Size(205, 45);
            this.btnMUser.TabIndex = 4;
            this.btnMUser.Text = "Manage User";
            this.btnMUser.UseVisualStyleBackColor = false;
            this.btnMUser.Click += new System.EventHandler(this.btnMUser_Click);
            this.btnMUser.MouseLeave += new System.EventHandler(this.btnMUser_MouseLeave);
            this.btnMUser.MouseHover += new System.EventHandler(this.btnMUser_MouseHover);
            // 
            // btnMProduct
            // 
            this.btnMProduct.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnMProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMProduct.Location = new System.Drawing.Point(28, 251);
            this.btnMProduct.Name = "btnMProduct";
            this.btnMProduct.Size = new System.Drawing.Size(205, 45);
            this.btnMProduct.TabIndex = 3;
            this.btnMProduct.Text = "Manage Product";
            this.btnMProduct.UseVisualStyleBackColor = false;
            this.btnMProduct.Click += new System.EventHandler(this.btnMProduct_Click);
            this.btnMProduct.MouseLeave += new System.EventHandler(this.btnMProduct_MouseLeave);
            this.btnMProduct.MouseHover += new System.EventHandler(this.btnMProduct_MouseHover);
            // 
            // btnViewProfile
            // 
            this.btnViewProfile.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnViewProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewProfile.Location = new System.Drawing.Point(28, 201);
            this.btnViewProfile.Name = "btnViewProfile";
            this.btnViewProfile.Size = new System.Drawing.Size(205, 44);
            this.btnViewProfile.TabIndex = 2;
            this.btnViewProfile.Text = "Profile";
            this.btnViewProfile.UseVisualStyleBackColor = false;
            this.btnViewProfile.Click += new System.EventHandler(this.btnViewProfile_Click);
            this.btnViewProfile.MouseLeave += new System.EventHandler(this.btnViewProfile_MouseLeave);
            this.btnViewProfile.MouseHover += new System.EventHandler(this.btnViewProfile_MouseHover);
            // 
            // lblInfo
            // 
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(106, 143);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(95, 20);
            this.lblInfo.TabIndex = 1;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUsername.Location = new System.Drawing.Point(24, 143);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(76, 20);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "UserId :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Location = new System.Drawing.Point(270, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(787, 623);
            this.panel2.TabIndex = 1;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 622);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAdmin_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMUser;
        private System.Windows.Forms.Button btnMProduct;
        private System.Windows.Forms.Button btnViewProfile;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnSalesCorner;
        private System.Windows.Forms.Button btnSHistory;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

