
namespace Appointment.WindowsForms
{
    partial class frm_AssigningServices
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
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtCurrentUserId = new MetroFramework.Controls.MetroTextBox();
            this.btnAssign = new MetroFramework.Controls.MetroButton();
            this.dgv_Services = new System.Windows.Forms.DataGridView();
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.btnComplete = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Services)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 211);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(109, 19);
            this.metroLabel2.TabIndex = 30;
            this.metroLabel2.Text = "Enter your name:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 89);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(84, 19);
            this.metroLabel1.TabIndex = 29;
            this.metroLabel1.Text = "Staff User ID:";
            // 
            // txtCurrentUserId
            // 
            // 
            // 
            // 
            this.txtCurrentUserId.CustomButton.Image = null;
            this.txtCurrentUserId.CustomButton.Location = new System.Drawing.Point(94, 1);
            this.txtCurrentUserId.CustomButton.Name = "";
            this.txtCurrentUserId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCurrentUserId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCurrentUserId.CustomButton.TabIndex = 1;
            this.txtCurrentUserId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCurrentUserId.CustomButton.UseSelectable = true;
            this.txtCurrentUserId.CustomButton.Visible = false;
            this.txtCurrentUserId.Enabled = false;
            this.txtCurrentUserId.Lines = new string[0];
            this.txtCurrentUserId.Location = new System.Drawing.Point(46, 122);
            this.txtCurrentUserId.MaxLength = 32767;
            this.txtCurrentUserId.Name = "txtCurrentUserId";
            this.txtCurrentUserId.PasswordChar = '\0';
            this.txtCurrentUserId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCurrentUserId.SelectedText = "";
            this.txtCurrentUserId.SelectionLength = 0;
            this.txtCurrentUserId.SelectionStart = 0;
            this.txtCurrentUserId.ShortcutsEnabled = true;
            this.txtCurrentUserId.Size = new System.Drawing.Size(116, 23);
            this.txtCurrentUserId.TabIndex = 28;
            this.txtCurrentUserId.UseSelectable = true;
            this.txtCurrentUserId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCurrentUserId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnAssign
            // 
            this.btnAssign.Location = new System.Drawing.Point(214, 303);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(96, 41);
            this.btnAssign.TabIndex = 25;
            this.btnAssign.Text = "Assign";
            this.btnAssign.UseSelectable = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // dgv_Services
            // 
            this.dgv_Services.AllowUserToAddRows = false;
            this.dgv_Services.AllowUserToDeleteRows = false;
            this.dgv_Services.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Services.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgv_Services.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Services.Location = new System.Drawing.Point(188, 63);
            this.dgv_Services.Name = "dgv_Services";
            this.dgv_Services.ReadOnly = true;
            this.dgv_Services.Size = new System.Drawing.Size(462, 234);
            this.dgv_Services.TabIndex = 27;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(535, 303);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(96, 41);
            this.btnBack.TabIndex = 26;
            this.btnBack.Text = "Back";
            this.btnBack.UseSelectable = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.CustomButton.Image = null;
            this.txtName.CustomButton.Location = new System.Drawing.Point(94, 1);
            this.txtName.CustomButton.Name = "";
            this.txtName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName.CustomButton.TabIndex = 1;
            this.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.CustomButton.UseSelectable = true;
            this.txtName.CustomButton.Visible = false;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(46, 244);
            this.txtName.MaxLength = 32767;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.Size = new System.Drawing.Size(116, 23);
            this.txtName.TabIndex = 32;
            this.txtName.UseSelectable = true;
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 159);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(134, 38);
            this.metroLabel4.TabIndex = 33;
            this.metroLabel4.Text = "Do you wish to assign\r\nthe services?";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(428, 303);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 41);
            this.btnCancel.TabIndex = 34;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnComplete
            // 
            this.btnComplete.Location = new System.Drawing.Point(321, 303);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(96, 41);
            this.btnComplete.TabIndex = 35;
            this.btnComplete.Text = "Complete";
            this.btnComplete.UseSelectable = true;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // frm_AssigningServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 379);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtCurrentUserId);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.dgv_Services);
            this.Controls.Add(this.btnBack);
            this.Name = "frm_AssigningServices";
            this.Text = "Assign Services to Specific Staff";
            this.Load += new System.EventHandler(this.frm_AssigningServices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Services)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtCurrentUserId;
        private MetroFramework.Controls.MetroButton btnAssign;
        private System.Windows.Forms.DataGridView dgv_Services;
        private MetroFramework.Controls.MetroButton btnBack;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroButton btnComplete;
    }
}