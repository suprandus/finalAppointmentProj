using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Appointment.WindowsForms
{
    public partial class frm_AssigningServices : MetroFramework.Forms.MetroForm
    {

        private SqlConnection connection = new SqlConnection("data source = .\\SQLEXPRESS; database = HairServicesDB; integrated security = True");
        // access the current userID
        int userId = CurrentUser.UserId;
        string full_name = CurrentUser.user_name;
        public frm_AssigningServices()
        {
            InitializeComponent();
            loadData();
        }
        //functions
        private void OpenStaffDashboard()
        {
            using (var staffDashboard = new frm_StaffDashboard())
            {
                this.Hide();
                _ = staffDashboard.ShowDialog();
                this.Show();
            }
        }
        private void loadData()
        {
            try
            {
                connection.Open();


                // Query to select data
                string query = "SELECT user_id AS 'User ID', service_name AS 'Service Name', price AS 'Price', date AS 'Date', staff_name AS 'Assigned Staff', status AS 'Status' FROM requested_services ORDER BY date ASC";
                // SqlDataAdapter and DataTable
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();

                // Fill
                adapter.Fill(dataTable);

                // Bind the DataTable to the DataGridView
                dgv_Services.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void frm_AssigningServices_Load(object sender, EventArgs e)
        {
            // pass the value
            txtCurrentUserId.Text = userId.ToString();
            txtName.Text = full_name.ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            OpenStaffDashboard();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                // Check if there are selected rows
                if (dgv_Services.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow row in dgv_Services.SelectedRows)
                    {
                        int staff_id_hahays = Convert.ToInt32(txtCurrentUserId.Text.ToString());
                        string cancelStatus = "Cancelled";
                        string staff_name = full_name.ToString();
                        int client_user_id = Convert.ToInt32(row.Cells["User ID"].Value);
                        string serviceName = row.Cells["Service Name"].Value.ToString();
                        string price = row.Cells["Price"].Value.ToString();
                        DateTime date = Convert.ToDateTime(row.Cells["Date"].Value);

                        using (SqlCommand cmd = new SqlCommand("UpdateServiceStatus1", connection))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@user_id", client_user_id);
                            cmd.Parameters.AddWithValue("@service_name", serviceName);
                            cmd.Parameters.AddWithValue("@price", price);
                            cmd.Parameters.AddWithValue("@date", date);
                            cmd.Parameters.AddWithValue("@staff_id", staff_id_hahays);
                            cmd.Parameters.AddWithValue("@staff_name", staff_name);
                            cmd.Parameters.AddWithValue("@new_status", cancelStatus);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Successfully cancelled!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show("Please select rows to update.", "No Rows Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
            // Reload
            loadData();
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                // Check if there are selected rows
                if (dgv_Services.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow row in dgv_Services.SelectedRows)
                    {
                        int staff_id_hahays = Convert.ToInt32(txtCurrentUserId.Text.ToString());
                        string completeStatus = "Completed";
                        string staff_name = full_name.ToString();
                        int client_user_id = Convert.ToInt32(row.Cells["User ID"].Value);
                        string serviceName = row.Cells["Service Name"].Value.ToString();
                        string price = row.Cells["Price"].Value.ToString();
                        DateTime date = Convert.ToDateTime(row.Cells["Date"].Value);

                        using (SqlCommand cmd = new SqlCommand("UpdateServiceStatus1", connection))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@user_id", client_user_id);
                            cmd.Parameters.AddWithValue("@service_name", serviceName);
                            cmd.Parameters.AddWithValue("@price", price);
                            cmd.Parameters.AddWithValue("@date", date);
                            cmd.Parameters.AddWithValue("@staff_id", staff_id_hahays);
                            cmd.Parameters.AddWithValue("@staff_name", staff_name);
                            cmd.Parameters.AddWithValue("@new_status", completeStatus);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Successfully completed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show("Please select rows to update.", "No Rows Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
            // Reload
            loadData();
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                // Check if there are selected rows
                if (dgv_Services.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow row in dgv_Services.SelectedRows)
                    {
                        int staff_id_hahays = Convert.ToInt32(txtCurrentUserId.Text.ToString());
                        string approveStatus = "Approved";
                        string staff_name = full_name.ToString();
                        int client_user_id = Convert.ToInt32(row.Cells["User ID"].Value);
                        string serviceName = row.Cells["Service Name"].Value.ToString();
                        string price = row.Cells["Price"].Value.ToString();
                        DateTime date = Convert.ToDateTime(row.Cells["Date"].Value);

                        using (SqlCommand cmd = new SqlCommand("UpdateServiceStatus1", connection))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@user_id", client_user_id);
                            cmd.Parameters.AddWithValue("@service_name", serviceName);
                            cmd.Parameters.AddWithValue("@price", price);
                            cmd.Parameters.AddWithValue("@date", date);
                            cmd.Parameters.AddWithValue("@staff_id", staff_id_hahays);
                            cmd.Parameters.AddWithValue("@staff_name", staff_name);
                            cmd.Parameters.AddWithValue("@new_status", approveStatus);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Successfully assigned!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show("Please select rows to update.", "No Rows Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
            // Reload
            loadData();
        }
    }
}
