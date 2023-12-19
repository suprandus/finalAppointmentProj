
namespace Appointment.WindowsForms
{
    partial class RequestServices
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
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.dgv_Services = new System.Windows.Forms.DataGridView();
            this.txtCurrentUserId = new MetroFramework.Controls.MetroTextBox();
            this.dtSelectDate = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnAddRequest = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Services)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(455, 303);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(96, 41);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseSelectable = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
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
            this.dgv_Services.TabIndex = 12;
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
            this.txtCurrentUserId.Location = new System.Drawing.Point(48, 128);
            this.txtCurrentUserId.MaxLength = 32767;
            this.txtCurrentUserId.Name = "txtCurrentUserId";
            this.txtCurrentUserId.PasswordChar = '\0';
            this.txtCurrentUserId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCurrentUserId.SelectedText = "";
            this.txtCurrentUserId.SelectionLength = 0;
            this.txtCurrentUserId.SelectionStart = 0;
            this.txtCurrentUserId.ShortcutsEnabled = true;
            this.txtCurrentUserId.Size = new System.Drawing.Size(116, 23);
            this.txtCurrentUserId.TabIndex = 15;
            this.txtCurrentUserId.UseSelectable = true;
            this.txtCurrentUserId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCurrentUserId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dtSelectDate
            // 
            this.dtSelectDate.Location = new System.Drawing.Point(48, 268);
            this.dtSelectDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtSelectDate.Name = "dtSelectDate";
            this.dtSelectDate.Size = new System.Drawing.Size(116, 29);
            this.dtSelectDate.TabIndex = 16;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 89);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(102, 19);
            this.metroLabel1.TabIndex = 18;
            this.metroLabel1.Text = "Current User ID:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 229);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(125, 19);
            this.metroLabel2.TabIndex = 19;
            this.metroLabel2.Text = "Select Desired Date:";
            // 
            // btnAddRequest
            // 
            this.btnAddRequest.Location = new System.Drawing.Point(288, 303);
            this.btnAddRequest.Name = "btnAddRequest";
            this.btnAddRequest.Size = new System.Drawing.Size(96, 41);
            this.btnAddRequest.TabIndex = 0;
            this.btnAddRequest.Text = "Add Request";
            this.btnAddRequest.UseSelectable = true;
            this.btnAddRequest.Click += new System.EventHandler(this.btnAddRequest_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 171);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(107, 38);
            this.metroLabel3.TabIndex = 20;
            this.metroLabel3.Text = "Do you wish to \r\nrequest services?";
            this.metroLabel3.Click += new System.EventHandler(this.metroLabel3_Click);
            // 
            // RequestServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 379);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.dtSelectDate);
            this.Controls.Add(this.txtCurrentUserId);
            this.Controls.Add(this.btnAddRequest);
            this.Controls.Add(this.dgv_Services);
            this.Controls.Add(this.btnBack);
            this.Name = "RequestServices";
            this.Text = "Request Services";
            this.Load += new System.EventHandler(this.RequestServices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Services)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnBack;
        private System.Windows.Forms.DataGridView dgv_Services;
        private MetroFramework.Controls.MetroTextBox txtCurrentUserId;
        private MetroFramework.Controls.MetroDateTime dtSelectDate;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btnAddRequest;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}