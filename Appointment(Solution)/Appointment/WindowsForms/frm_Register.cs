using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Appointment.Database;
using Appointment.UserRepo;

namespace Appointment
{
    public partial class frm_Register : MetroFramework.Forms.MetroForm
    {
       private UserRepo.UserRepo UserRepo;
        public frm_Register()
        {
            InitializeComponent();
            UserRepo = new UserRepo.UserRepo();
        }

        //-----------------------------------------------
        // functions
        private void OpenLoginForm()
        {
            using (var loginForm = new frm_Login())
            {
                this.Hide();
                _ = loginForm.ShowDialog();
                this.Show();
            }
        }
        private void loadCmbRole()
        {
            // load user_category table
            try
            {
                using (var db = new ServicesEntities()) // DBContext
                {
                    var roles = db.user_category.ToList();

                    cmbRole.DataSource = roles;
                    cmbRole.DisplayMember = "description"; // actual property
                    cmbRole.ValueMember = "role_id"; // actual property
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading roles: {ex.Message}");
            }
        }
        //------------------------------------------------
        private void btnBack_Click(object sender, EventArgs e)
        {
            OpenLoginForm();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // validation checks
            if (String.IsNullOrEmpty(txtUserName.Text))
            {
                errorProvider1.SetError(txtUserName, "Empty field");
                return;
            }

            if (String.IsNullOrEmpty(txtUserPassword.Text))
            {
                errorProvider1.SetError(txtUserPassword, "Empty field");
                return;
            }

            if (String.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                errorProvider1.SetError(txtConfirmPassword, "Empty field");
                return;
            }

            if (String.IsNullOrEmpty(txtFullName.Text))
            {
                errorProvider1.SetError(txtFullName, "Empty field");
                return;
            }

            if (String.IsNullOrEmpty(txtPhoneNumber.Text))
            {
                errorProvider1.SetError(txtPhoneNumber, "Empty field");
                return;
            }

            if (String.IsNullOrEmpty(txtEmailAddress.Text))
            {
                errorProvider1.SetError(txtEmailAddress, "Empty field");
                return;
            }

            // role selection
            if (cmbRole.SelectedValue == null)
            {
                errorProvider1.SetError(cmbRole, "Please select a role");
                return;
            }

            // if password do not match
            if (txtUserPassword.Text != txtConfirmPassword.Text)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtConfirmPassword, "Passwords do not match");
                return;
            }

            // calling register function and pass the parameter
            ErrorCode result = UserRepo.Register((int)cmbRole.SelectedValue, txtUserName.Text,
                txtUserPassword.Text, txtFullName.Text, txtPhoneNumber.Text, txtEmailAddress.Text);
            if (result == ErrorCode.Success)
            {
                cmbRole.SelectedIndex = -1;
                txtUserName.Clear();
                txtUserPassword.Clear();
                txtConfirmPassword.Clear();
                txtFullName.Clear();
                txtEmailAddress.Clear();
                txtPhoneNumber.Clear();
                MessageBox.Show("Account Created Successfully!");

                // Back to login
                OpenLoginForm();
            }
            else
            {
                MessageBox.Show("Retry.");
            }
        }

        private void frm_Register_Load(object sender, EventArgs e)
        {
            loadCmbRole();
        }
    }
}

