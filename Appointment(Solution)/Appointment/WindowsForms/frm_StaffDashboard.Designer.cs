
namespace Appointment.WindowsForms
{
    partial class frm_StaffDashboard
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
            this.btnRegister = new MetroFramework.Controls.MetroButton();
            this.btnLogout = new MetroFramework.Controls.MetroButton();
            this.btnAssign = new MetroFramework.Controls.MetroButton();
            this.btnView = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(114, 167);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(149, 36);
            this.btnRegister.TabIndex = 2;
            this.btnRegister.Text = "View Transaction History";
            this.btnRegister.UseSelectable = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(114, 211);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(149, 36);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseSelectable = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnAssign
            // 
            this.btnAssign.Location = new System.Drawing.Point(114, 79);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(149, 36);
            this.btnAssign.TabIndex = 0;
            this.btnAssign.Text = "Assign Service Requests ";
            this.btnAssign.UseSelectable = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(114, 123);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(149, 36);
            this.btnView.TabIndex = 1;
            this.btnView.Text = "View Assigned Services";
            this.btnView.UseSelectable = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // frm_StaffDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 325);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnRegister);
            this.Name = "frm_StaffDashboard";
            this.Text = "Staff";
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton btnRegister;
        private MetroFramework.Controls.MetroButton btnLogout;
        private MetroFramework.Controls.MetroButton btnAssign;
        private MetroFramework.Controls.MetroButton btnView;
    }
}