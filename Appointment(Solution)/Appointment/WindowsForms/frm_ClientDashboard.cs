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
    public partial class frm_ClientDashboard : MetroFramework.Forms.MetroForm
    {
        public frm_ClientDashboard()
        {
            InitializeComponent();
        }
        private void OpenRequestServices()
        {
            using (var requestServices = new RequestServices())
            {
                this.Hide();
                _ = requestServices.ShowDialog();
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

        private void OpenClientStatus()
        {
            using (var clientStatus = new frm_ClientStatus())
            {
                this.Hide();
                _ = clientStatus.ShowDialog();
                this.Show();
            }
        }
        private void OpenClientHistory()
        {
            using (var client_Transaction_History = new Client_Transaction_History())
            {
                this.Hide();
                _ = client_Transaction_History.ShowDialog();
                this.Show();
            }
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            OpenLogin();
        }

        private void btnRequestServices_Click(object sender, EventArgs e)
        {
            OpenRequestServices();
        }

        private void btnViewStatus_Click(object sender, EventArgs e)
        {
            OpenClientStatus();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            OpenClientHistory();
        }
    }
}
