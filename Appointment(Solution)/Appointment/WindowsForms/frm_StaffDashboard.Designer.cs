
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
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.btnRegister = new MetroFramework.Controls.MetroButton();
            this.btnLogin = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(120, 91);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(149, 36);
            this.metroButton1.TabIndex = 0;
            this.metroButton1.Text = "View Assigned Services";
            this.metroButton1.UseSelectable = true;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(120, 197);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(149, 36);
            this.btnRegister.TabIndex = 2;
            this.btnRegister.Text = "View Transaction History";
            this.btnRegister.UseSelectable = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(120, 144);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(149, 36);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "View Service Request";
            this.btnLogin.UseSelectable = true;
            // 
            // frm_StaffDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 325);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnLogin);
            this.Name = "frm_StaffDashboard";
            this.Text = "Staff";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton btnRegister;
        private MetroFramework.Controls.MetroButton btnLogin;
    }
}