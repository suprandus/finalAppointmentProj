
namespace Appointment.WindowsForms
{
    partial class frm_UserAccounts
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
            this.dgv_UserAccounts = new System.Windows.Forms.DataGridView();
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.btnModifyRecords = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UserAccounts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_UserAccounts
            // 
            this.dgv_UserAccounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_UserAccounts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgv_UserAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_UserAccounts.Location = new System.Drawing.Point(100, 63);
            this.dgv_UserAccounts.Name = "dgv_UserAccounts";
            this.dgv_UserAccounts.Size = new System.Drawing.Size(484, 258);
            this.dgv_UserAccounts.TabIndex = 1;
            this.dgv_UserAccounts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_UserAccounts_CellContentClick);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(351, 327);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(96, 41);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back";
            this.btnBack.UseSelectable = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnModifyRecords
            // 
            this.btnModifyRecords.Location = new System.Drawing.Point(214, 327);
            this.btnModifyRecords.Name = "btnModifyRecords";
            this.btnModifyRecords.Size = new System.Drawing.Size(96, 41);
            this.btnModifyRecords.TabIndex = 12;
            this.btnModifyRecords.Text = "Modify Records";
            this.btnModifyRecords.UseSelectable = true;
            this.btnModifyRecords.Click += new System.EventHandler(this.btnModifyRecords_Click);
            // 
            // frm_UserAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 421);
            this.Controls.Add(this.btnModifyRecords);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgv_UserAccounts);
            this.Name = "frm_UserAccounts";
            this.Text = "List of User Accounts";
            this.Load += new System.EventHandler(this.frm_UserAccounts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UserAccounts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_UserAccounts;
        private MetroFramework.Controls.MetroButton btnBack;
        private MetroFramework.Controls.MetroButton btnModifyRecords;
    }
}