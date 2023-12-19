
namespace Appointment.WindowsForms
{
    partial class frm_StaffTransactionHist
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
            this.dgv_Services = new System.Windows.Forms.DataGridView();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Services)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Services
            // 
            this.dgv_Services.AllowUserToAddRows = false;
            this.dgv_Services.AllowUserToDeleteRows = false;
            this.dgv_Services.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Services.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgv_Services.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Services.Location = new System.Drawing.Point(23, 56);
            this.dgv_Services.Name = "dgv_Services";
            this.dgv_Services.ReadOnly = true;
            this.dgv_Services.Size = new System.Drawing.Size(462, 234);
            this.dgv_Services.TabIndex = 16;
            this.dgv_Services.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Services_CellContentClick);
            // 
            // metroLink1
            // 
            this.metroLink1.Location = new System.Drawing.Point(410, 27);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(75, 23);
            this.metroLink1.TabIndex = 17;
            this.metroLink1.Text = "Back";
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // frm_StaffTransactionHist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 322);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.dgv_Services);
            this.Name = "frm_StaffTransactionHist";
            this.Text = "Staff Transaction History";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Services)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Services;
        private MetroFramework.Controls.MetroLink metroLink1;
    }
}