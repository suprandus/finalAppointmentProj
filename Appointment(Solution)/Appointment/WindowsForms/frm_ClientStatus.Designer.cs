
namespace Appointment.WindowsForms
{
    partial class frm_ClientStatus
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
            this.btnCancelRequest = new MetroFramework.Controls.MetroButton();
            this.dgv_Services = new System.Windows.Forms.DataGridView();
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtCurrentUserId = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.dtSelectDate = new MetroFramework.Controls.MetroDateTime();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Services)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelRequest
            // 
            this.btnCancelRequest.Location = new System.Drawing.Point(288, 303);
            this.btnCancelRequest.Name = "btnCancelRequest";
            this.btnCancelRequest.Size = new System.Drawing.Size(96, 41);
            this.btnCancelRequest.TabIndex = 13;
            this.btnCancelRequest.Text = "Cancel Request";
            this.btnCancelRequest.UseSelectable = true;
            this.btnCancelRequest.Click += new System.EventHandler(this.btnCancelRequest_Click);
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
            this.dgv_Services.TabIndex = 15;
            this.dgv_Services.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Services_CellContentClick);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(455, 303);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(96, 41);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "Back";
            this.btnBack.UseSelectable = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(25, 212);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(150, 19);
            this.metroLabel2.TabIndex = 23;
            this.metroLabel2.Text = "\"Just select specific row.\"";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(25, 84);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(91, 19);
            this.metroLabel1.TabIndex = 22;
            this.metroLabel1.Text = "Client User ID:";
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
            this.txtCurrentUserId.Location = new System.Drawing.Point(48, 119);
            this.txtCurrentUserId.MaxLength = 32767;
            this.txtCurrentUserId.Name = "txtCurrentUserId";
            this.txtCurrentUserId.PasswordChar = '\0';
            this.txtCurrentUserId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCurrentUserId.SelectedText = "";
            this.txtCurrentUserId.SelectionLength = 0;
            this.txtCurrentUserId.SelectionStart = 0;
            this.txtCurrentUserId.ShortcutsEnabled = true;
            this.txtCurrentUserId.Size = new System.Drawing.Size(116, 23);
            this.txtCurrentUserId.TabIndex = 20;
            this.txtCurrentUserId.UseSelectable = true;
            this.txtCurrentUserId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCurrentUserId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(25, 158);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(135, 38);
            this.metroLabel3.TabIndex = 24;
            this.metroLabel3.Text = "Do you wish to cancel\r\nthe service request?";
            // 
            // dtSelectDate
            // 
            this.dtSelectDate.Location = new System.Drawing.Point(534, 28);
            this.dtSelectDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtSelectDate.Name = "dtSelectDate";
            this.dtSelectDate.Size = new System.Drawing.Size(116, 29);
            this.dtSelectDate.TabIndex = 21;
            this.dtSelectDate.Visible = false;
            // 
            // frm_ClientStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 379);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.dtSelectDate);
            this.Controls.Add(this.txtCurrentUserId);
            this.Controls.Add(this.btnCancelRequest);
            this.Controls.Add(this.dgv_Services);
            this.Controls.Add(this.btnBack);
            this.Name = "frm_ClientStatus";
            this.Text = "Requested Services Status";
            this.Load += new System.EventHandler(this.frm_ClientStatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Services)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnCancelRequest;
        private System.Windows.Forms.DataGridView dgv_Services;
        private MetroFramework.Controls.MetroButton btnBack;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtCurrentUserId;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroDateTime dtSelectDate;
    }
}