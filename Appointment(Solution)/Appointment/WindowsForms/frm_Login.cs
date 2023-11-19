using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appointment
{
    public partial class frm_Login : MetroFramework.Forms.MetroForm
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        // functions
        private void OpenRegistrationForm()
        {
            using (var registrationForm = new frm_Register())
            {
                _ = registrationForm.ShowDialog();
            }
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            OpenRegistrationForm();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.Enabled = chkShowPassword.Checked;
            txtPassword.PasswordChar = chkShowPassword.Checked ? '\0' : '●';
        }


    }
}
