
namespace Appointment.WindowsForms
{
    partial class frm_ModifyRecords
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
            this.dgv_UserAccountss = new System.Windows.Forms.DataGridView();
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.btnSaveChanges = new MetroFramework.Controls.MetroButton();
            this.btnDeleteRecords = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UserAccountss)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_UserAccountss
            // 
            this.dgv_UserAccountss.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_UserAccountss.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgv_UserAccountss.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_UserAccountss.Location = new System.Drawing.Point(86, 75);
            this.dgv_UserAccountss.Name = "dgv_UserAccountss";
            this.dgv_UserAccountss.Size = new System.Drawing.Size(484, 258);
            this.dgv_UserAccountss.TabIndex = 2;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(423, 339);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(96, 41);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Back";
            this.btnBack.UseSelectable = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(163, 339);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(96, 41);
            this.btnSaveChanges.TabIndex = 13;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseSelectable = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // btnDeleteRecords
            // 
            this.btnDeleteRecords.Location = new System.Drawing.Point(293, 339);
            this.btnDeleteRecords.Name = "btnDeleteRecords";
            this.btnDeleteRecords.Size = new System.Drawing.Size(96, 41);
            this.btnDeleteRecords.TabIndex = 14;
            this.btnDeleteRecords.Text = "Delete Records";
            this.btnDeleteRecords.UseSelectable = true;
            this.btnDeleteRecords.Click += new System.EventHandler(this.btnDeleteRecords_Click);
            // 
            // frm_ModifyRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 421);
            this.Controls.Add(this.btnDeleteRecords);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgv_UserAccountss);
            this.Name = "frm_ModifyRecords";
            this.Text = "Modify Records";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UserAccountss)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_UserAccountss;
        private MetroFramework.Controls.MetroButton btnBack;
        private MetroFramework.Controls.MetroButton btnSaveChanges;
        private MetroFramework.Controls.MetroButton btnDeleteRecords;
    }
}