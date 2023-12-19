
namespace Appointment.WindowsForms
{
    partial class frm_ClientDashboard
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
            this.btnRequestServices = new MetroFramework.Controls.MetroButton();
            this.btnRegister = new MetroFramework.Controls.MetroButton();
            this.btnViewStatus = new MetroFramework.Controls.MetroButton();
            this.btnLogout = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btnRequestServices
            // 
            this.btnRequestServices.Location = new System.Drawing.Point(107, 82);
            this.btnRequestServices.Name = "btnRequestServices";
            this.btnRequestServices.Size = new System.Drawing.Size(149, 36);
            this.btnRequestServices.TabIndex = 0;
            this.btnRequestServices.Text = "Request Services";
            this.btnRequestServices.UseSelectable = true;
            this.btnRequestServices.Click += new System.EventHandler(this.btnRequestServices_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(107, 180);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(149, 36);
            this.btnRegister.TabIndex = 2;
            this.btnRegister.Text = "View Transaction History";
            this.btnRegister.UseSelectable = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnViewStatus
            // 
            this.btnViewStatus.Location = new System.Drawing.Point(107, 131);
            this.btnViewStatus.Name = "btnViewStatus";
            this.btnViewStatus.Size = new System.Drawing.Size(149, 36);
            this.btnViewStatus.TabIndex = 1;
            this.btnViewStatus.Text = "View Service Status";
            this.btnViewStatus.UseSelectable = true;
            this.btnViewStatus.Click += new System.EventHandler(this.btnViewStatus_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(107, 229);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(149, 36);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseSelectable = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // frm_ClientDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 325);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnRequestServices);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnViewStatus);
            this.Name = "frm_ClientDashboard";
            this.Text = "Client";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnRequestServices;
        private MetroFramework.Controls.MetroButton btnRegister;
        private MetroFramework.Controls.MetroButton btnViewStatus;
        private MetroFramework.Controls.MetroButton btnLogout;
    }
}