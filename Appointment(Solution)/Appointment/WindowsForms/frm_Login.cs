using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Appointment.Database; // to use service entities
using Appointment.UserRepo;
namespace Appointment
{
    public partial class frm_Login : MetroFramework.Forms.MetroForm
    {
        private UserRepo.UserRepo UserRepo;
        public frm_Login()
        {
            InitializeComponent();
            UserRepo = new UserRepo.UserRepo();
        }
        
        //-------------------------------------------------
        // functions
        private void OpenRegistrationForm()
        {
            using (var registrationForm = new frm_Register())
            {
                this.Hide();
                _ = registrationForm.ShowDialog();
                this.Show();
            }
        }

        //-------------------------------------------------

        private void btnRegister_Click(object sender, EventArgs e)
        {
            OpenRegistrationForm();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.Enabled = chkShowPassword.Checked;
            txtPassword.PasswordChar = chkShowPassword.Checked ? '\0' : '●';
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
           // txtUsername.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (SqlConnection con = new SqlConnection("data source = .\\SQLEXPRESS; database = HairServicesDB; integrated security = True"))
            {
                con.Open();
                string query = "SELECT * FROM UserView WHERE username COLLATE SQL_Latin1_General_CP1_CS_AS = @Username AND password COLLATE SQL_Latin1_General_CP1_CS_AS = @Password";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    
                    // Execute the query
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        // Store to current user
                        WindowsForms.CurrentUser.UserId = Convert.ToInt32(reader["user_id"]);
                        WindowsForms.CurrentUser.user_name = reader["full_name"].ToString();

                        string roleDescription = reader["description"].ToString();
                        switch (roleDescription.ToLower())
                        {
                            case "client":
                                MessageBox.Show("Welcome, Client!");
                                var client = new WindowsForms.frm_ClientDashboard();
                                this.Hide();
                                client.ShowDialog();
                                break;
                            case "staff":
                                MessageBox.Show("Welcome, Staff!");
                                var staff = new WindowsForms.frm_StaffDashboard();
                                this.Hide();
                                staff.ShowDialog();
                                break;
                            case "administrator":
                                MessageBox.Show("Welcome, Administrator!");
                                var administrator = new WindowsForms.frm_AdminDashboard();
                                this.Hide();
                                administrator.ShowDialog();
                                break;
                            default:
                                MessageBox.Show("Invalid username or password");
                                break;
                        }
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    reader.Close();
                }
            }
        }
        //

    }
}
