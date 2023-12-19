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
    public partial class frm_StaffDashboard : MetroFramework.Forms.MetroForm
    {
        public frm_StaffDashboard()
        {
            InitializeComponent();
        }
        // functions
        private void OpenLoginForm()
        {
            using (var login = new frm_Login())
            {
                this.Hide();
                _ = login.ShowDialog();
                this.Show();
            }
        }
        private void OpenAssigningServices()
        {
            using (var assigningServices = new frm_AssigningServices())
            {
                this.Hide();
                _ = assigningServices.ShowDialog();
                this.Show();
            }
        }

        private void OpenTransHist()
        {
            using (var transactionHist = new frm_StaffTransactionHist())
            {
                this.Hide();
                _ = transactionHist.ShowDialog();
                this.Show();
            }
        }
        private void OpenAssignendServices()
        {
            using (var assignedServices = new frm_AssignedServices())
            {
                this.Hide();
                _ = assignedServices.ShowDialog();
                this.Show();
            }
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            OpenLoginForm();
        }


        private void btnView_Click(object sender, EventArgs e)
        {
            OpenAssignendServices();
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            OpenAssigningServices();
        }

        private void btnTransactionHist_Click(object sender, EventArgs e)
        {
            OpenTransHist();
        }
    }
}
