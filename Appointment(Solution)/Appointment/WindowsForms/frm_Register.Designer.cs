
namespace Appointment
{
    partial class frm_Register
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
            this.components = new System.ComponentModel.Container();
            this.btnRegister = new MetroFramework.Controls.MetroButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtEmailAddress = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtPhoneNumber = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txtFullName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtConfirmPassword = new MetroFramework.Controls.MetroTextBox();
            this.cmbRole = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtUserPassword = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtUserName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(367, 296);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(80, 23);
            this.btnRegister.TabIndex = 16;
            this.btnRegister.Text = "Create";
            this.btnRegister.UseSelectable = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtEmailAddress);
            this.groupBox2.Controls.Add(this.metroLabel7);
            this.groupBox2.Controls.Add(this.txtPhoneNumber);
            this.groupBox2.Controls.Add(this.metroLabel8);
            this.groupBox2.Controls.Add(this.txtFullName);
            this.groupBox2.Controls.Add(this.metroLabel9);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(367, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(195, 227);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Personal Details";
            // 
            // txtEmailAddress
            // 
            // 
            // 
            // 
            this.txtEmailAddress.CustomButton.Image = null;
            this.txtEmailAddress.CustomButton.Location = new System.Drawing.Point(122, 1);
            this.txtEmailAddress.CustomButton.Name = "";
            this.txtEmailAddress.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtEmailAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmailAddress.CustomButton.TabIndex = 1;
            this.txtEmailAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmailAddress.CustomButton.UseSelectable = true;
            this.txtEmailAddress.CustomButton.Visible = false;
            this.txtEmailAddress.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtEmailAddress.Lines = new string[0];
            this.txtEmailAddress.Location = new System.Drawing.Point(24, 170);
            this.txtEmailAddress.MaxLength = 32767;
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.PasswordChar = '\0';
            this.txtEmailAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmailAddress.SelectedText = "";
            this.txtEmailAddress.SelectionLength = 0;
            this.txtEmailAddress.SelectionStart = 0;
            this.txtEmailAddress.ShortcutsEnabled = true;
            this.txtEmailAddress.Size = new System.Drawing.Size(150, 29);
            this.txtEmailAddress.TabIndex = 2;
            this.txtEmailAddress.UseSelectable = true;
            this.txtEmailAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmailAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(19, 148);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(92, 19);
            this.metroLabel7.TabIndex = 10;
            this.metroLabel7.Text = "Email Address";
            // 
            // txtPhoneNumber
            // 
            // 
            // 
            // 
            this.txtPhoneNumber.CustomButton.Image = null;
            this.txtPhoneNumber.CustomButton.Location = new System.Drawing.Point(122, 1);
            this.txtPhoneNumber.CustomButton.Name = "";
            this.txtPhoneNumber.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtPhoneNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPhoneNumber.CustomButton.TabIndex = 1;
            this.txtPhoneNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPhoneNumber.CustomButton.UseSelectable = true;
            this.txtPhoneNumber.CustomButton.Visible = false;
            this.txtPhoneNumber.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtPhoneNumber.Lines = new string[0];
            this.txtPhoneNumber.Location = new System.Drawing.Point(24, 114);
            this.txtPhoneNumber.MaxLength = 32767;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.PasswordChar = '\0';
            this.txtPhoneNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPhoneNumber.SelectedText = "";
            this.txtPhoneNumber.SelectionLength = 0;
            this.txtPhoneNumber.SelectionStart = 0;
            this.txtPhoneNumber.ShortcutsEnabled = true;
            this.txtPhoneNumber.Size = new System.Drawing.Size(150, 29);
            this.txtPhoneNumber.TabIndex = 1;
            this.txtPhoneNumber.UseSelectable = true;
            this.txtPhoneNumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPhoneNumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(19, 92);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(99, 19);
            this.metroLabel8.TabIndex = 8;
            this.metroLabel8.Text = "Phone Number";
            // 
            // txtFullName
            // 
            // 
            // 
            // 
            this.txtFullName.CustomButton.Image = null;
            this.txtFullName.CustomButton.Location = new System.Drawing.Point(122, 1);
            this.txtFullName.CustomButton.Name = "";
            this.txtFullName.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtFullName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFullName.CustomButton.TabIndex = 1;
            this.txtFullName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFullName.CustomButton.UseSelectable = true;
            this.txtFullName.CustomButton.Visible = false;
            this.txtFullName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtFullName.Lines = new string[0];
            this.txtFullName.Location = new System.Drawing.Point(24, 58);
            this.txtFullName.MaxLength = 32767;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.PasswordChar = '\0';
            this.txtFullName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFullName.SelectedText = "";
            this.txtFullName.SelectionLength = 0;
            this.txtFullName.SelectionStart = 0;
            this.txtFullName.ShortcutsEnabled = true;
            this.txtFullName.Size = new System.Drawing.Size(150, 29);
            this.txtFullName.TabIndex = 0;
            this.txtFullName.UseSelectable = true;
            this.txtFullName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFullName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(19, 36);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(69, 19);
            this.metroLabel9.TabIndex = 5;
            this.metroLabel9.Text = "Full Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.txtConfirmPassword);
            this.groupBox1.Controls.Add(this.cmbRole);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.txtUserPassword);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(62, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 292);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account Details";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel6.Location = new System.Drawing.Point(47, 49);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(43, 19);
            this.metroLabel6.TabIndex = 42;
            this.metroLabel6.Text = "Select";
            // 
            // txtConfirmPassword
            // 
            // 
            // 
            // 
            this.txtConfirmPassword.CustomButton.Image = null;
            this.txtConfirmPassword.CustomButton.Location = new System.Drawing.Point(122, 1);
            this.txtConfirmPassword.CustomButton.Name = "";
            this.txtConfirmPassword.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtConfirmPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConfirmPassword.CustomButton.TabIndex = 1;
            this.txtConfirmPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtConfirmPassword.CustomButton.UseSelectable = true;
            this.txtConfirmPassword.CustomButton.Visible = false;
            this.txtConfirmPassword.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtConfirmPassword.Lines = new string[0];
            this.txtConfirmPassword.Location = new System.Drawing.Point(32, 230);
            this.txtConfirmPassword.MaxLength = 32767;
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '●';
            this.txtConfirmPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtConfirmPassword.SelectedText = "";
            this.txtConfirmPassword.SelectionLength = 0;
            this.txtConfirmPassword.SelectionStart = 0;
            this.txtConfirmPassword.ShortcutsEnabled = true;
            this.txtConfirmPassword.Size = new System.Drawing.Size(150, 29);
            this.txtConfirmPassword.TabIndex = 3;
            this.txtConfirmPassword.UseSelectable = true;
            this.txtConfirmPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtConfirmPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cmbRole
            // 
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.ItemHeight = 23;
            this.cmbRole.Items.AddRange(new object[] {
            "Client",
            "Staff",
            "Administrator"});
            this.cmbRole.Location = new System.Drawing.Point(32, 60);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(146, 29);
            this.cmbRole.TabIndex = 0;
            this.cmbRole.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(32, 208);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(115, 19);
            this.metroLabel3.TabIndex = 10;
            this.metroLabel3.Text = "Confirm Password";
            // 
            // txtUserPassword
            // 
            // 
            // 
            // 
            this.txtUserPassword.CustomButton.Image = null;
            this.txtUserPassword.CustomButton.Location = new System.Drawing.Point(122, 1);
            this.txtUserPassword.CustomButton.Name = "";
            this.txtUserPassword.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtUserPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUserPassword.CustomButton.TabIndex = 1;
            this.txtUserPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUserPassword.CustomButton.UseSelectable = true;
            this.txtUserPassword.CustomButton.Visible = false;
            this.txtUserPassword.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtUserPassword.Lines = new string[0];
            this.txtUserPassword.Location = new System.Drawing.Point(32, 172);
            this.txtUserPassword.MaxLength = 32767;
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.PasswordChar = '●';
            this.txtUserPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUserPassword.SelectedText = "";
            this.txtUserPassword.SelectionLength = 0;
            this.txtUserPassword.SelectionStart = 0;
            this.txtUserPassword.ShortcutsEnabled = true;
            this.txtUserPassword.Size = new System.Drawing.Size(150, 29);
            this.txtUserPassword.TabIndex = 2;
            this.txtUserPassword.UseSelectable = true;
            this.txtUserPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUserPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(32, 150);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(63, 19);
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "Password";
            // 
            // txtUserName
            // 
            // 
            // 
            // 
            this.txtUserName.CustomButton.Image = null;
            this.txtUserName.CustomButton.Location = new System.Drawing.Point(122, 1);
            this.txtUserName.CustomButton.Name = "";
            this.txtUserName.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtUserName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUserName.CustomButton.TabIndex = 1;
            this.txtUserName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUserName.CustomButton.UseSelectable = true;
            this.txtUserName.CustomButton.Visible = false;
            this.txtUserName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtUserName.Lines = new string[0];
            this.txtUserName.Location = new System.Drawing.Point(32, 114);
            this.txtUserName.MaxLength = 32767;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PasswordChar = '\0';
            this.txtUserName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUserName.SelectedText = "";
            this.txtUserName.SelectionLength = 0;
            this.txtUserName.SelectionStart = 0;
            this.txtUserName.ShortcutsEnabled = true;
            this.txtUserName.Size = new System.Drawing.Size(150, 29);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.UseSelectable = true;
            this.txtUserName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUserName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(32, 92);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(68, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Username";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(482, 296);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(80, 23);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "Back";
            this.btnBack.UseSelectable = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frm_Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 418);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_Register";
            this.Load += new System.EventHandler(this.frm_Register_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnRegister;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroTextBox txtEmailAddress;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox txtPhoneNumber;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox txtFullName;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox txtConfirmPassword;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtUserPassword;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtUserName;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnBack;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroComboBox cmbRole;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}