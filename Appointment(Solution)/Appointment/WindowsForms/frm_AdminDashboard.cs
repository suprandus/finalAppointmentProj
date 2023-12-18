using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appointment.WindowsForms
{
    public partial class frm_AdminDashboard : MetroFramework.Forms.MetroForm
    {
        public frm_AdminDashboard()
        {
            InitializeComponent();
        }

        //functions
        private void OpenServicesForm()
        {
            using (var services = new Services())
            {
                this.Hide();
                _ = services.ShowDialog();
                this.Show();
            }
        }
        private void OpenUserAccounts()
        {
            using (var userAccounts = new frm_UserAccounts())
            {
                this.Hide();
                _ = userAccounts.ShowDialog();
                this.Show();
            }
        }
        private void OpenTransactions()
        {
            using (var transactionHistory = new frm_TransactionHistory())
            {
                this.Hide();
                _ = transactionHistory.ShowDialog();
                this.Show();
            }
        }

        private void OpenLogin()
        {
            using (var login = new frm_Login())
            {
                this.Hide();
                _ = login.ShowDialog();
                this.Show();
            }
        }
        private void manage_Services_Click(object sender, EventArgs e)
        {
            OpenServicesForm();
        }

        private void btnManageUserAccounts_Click(object sender, EventArgs e)
        {
            OpenUserAccounts();
        }

        private void btnViewTransactionHistory_Click(object sender, EventArgs e)
        {
            OpenTransactions();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            OpenLogin();
        }
    }
}
