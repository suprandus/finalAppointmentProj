
namespace Appointment.WindowsForms
{
    partial class frm_AdminDashboard
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
            this.btnViewTransactionHistory = new MetroFramework.Controls.MetroButton();
            this.btnManageUserAccounts = new MetroFramework.Controls.MetroButton();
            this.manage_Services = new MetroFramework.Controls.MetroButton();
            this.btnLogout = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btnViewTransactionHistory
            // 
            this.btnViewTransactionHistory.Location = new System.Drawing.Point(100, 201);
            this.btnViewTransactionHistory.Name = "btnViewTransactionHistory";
            this.btnViewTransactionHistory.Size = new System.Drawing.Size(149, 36);
            this.btnViewTransactionHistory.TabIndex = 2;
            this.btnViewTransactionHistory.Text = "View Transaction History";
            this.btnViewTransactionHistory.UseSelectable = true;
            this.btnViewTransactionHistory.Click += new System.EventHandler(this.btnViewTransactionHistory_Click);
            // 
            // btnManageUserAccounts
            // 
            this.btnManageUserAccounts.Location = new System.Drawing.Point(100, 152);
            this.btnManageUserAccounts.Name = "btnManageUserAccounts";
            this.btnManageUserAccounts.Size = new System.Drawing.Size(149, 36);
            this.btnManageUserAccounts.TabIndex = 1;
            this.btnManageUserAccounts.Text = "Manage User Accounts";
            this.btnManageUserAccounts.UseSelectable = true;
            this.btnManageUserAccounts.Click += new System.EventHandler(this.btnManageUserAccounts_Click);
            // 
            // manage_Services
            // 
            this.manage_Services.Location = new System.Drawing.Point(100, 103);
            this.manage_Services.Name = "manage_Services";
            this.manage_Services.Size = new System.Drawing.Size(149, 36);
            this.manage_Services.TabIndex = 0;
            this.manage_Services.Text = "Manage Services";
            this.manage_Services.UseSelectable = true;
            this.manage_Services.Click += new System.EventHandler(this.manage_Services_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(100, 250);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(149, 36);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseSelectable = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // frm_AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 325);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.manage_Services);
            this.Controls.Add(this.btnViewTransactionHistory);
            this.Controls.Add(this.btnManageUserAccounts);
            this.Name = "frm_AdminDashboard";
            this.Text = "Administrator";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnViewTransactionHistory;
        private MetroFramework.Controls.MetroButton btnManageUserAccounts;
        private MetroFramework.Controls.MetroButton manage_Services;
        private MetroFramework.Controls.MetroButton btnLogout;
    }
}