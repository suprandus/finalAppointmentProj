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
        private void btnLogout_Click(object sender, EventArgs e)
        {
            OpenLoginForm();
        }


        private void btnView_Click(object sender, EventArgs e)
        {

        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            OpenAssigningServices();
        }
    }
}
