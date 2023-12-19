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
    public partial class frm_ClientStatus : MetroFramework.Forms.MetroForm
    {
        private SqlConnection connection = new SqlConnection("data source = .\\SQLEXPRESS; database = HairServicesDB; integrated security = True");
        // access the current userID
        int userId = CurrentUser.UserId;
        public frm_ClientStatus()
        {
            InitializeComponent();
            loadData();
        }

        // functions
        private void loadData()
        {
            try
            {
                connection.Open();


                // Query to select data
                string query = "SELECT service_name AS 'Service Name', price AS 'Price', date AS 'Date', staff_name AS 'Assigned Staff', status AS 'Status' FROM requested_services WHERE user_id = " + userId + " ORDER BY date ASC";
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

        private void OpenClientDashboard()
        {
            using (var clientDashboard = new frm_ClientDashboard())
            {
                this.Hide();
                _ = clientDashboard.ShowDialog();
                this.Show();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            OpenClientDashboard();
        }

        private void frm_ClientStatus_Load(object sender, EventArgs e)
        {
            // pass the value
            txtCurrentUserId.Text = userId.ToString();

            // Set the minimum date for the DateTimePicker
            dtSelectDate.MinDate = DateTime.Today;
        }

        private void dgv_Services_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCancelRequest_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                // Check if there are selected rows
                if (dgv_Services.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow row in dgv_Services.SelectedRows)
                    {
                        string cancelStatus = "Cancelled";
                        string serviceName = row.Cells["Service Name"].Value.ToString();
                        string price = row.Cells["Price"].Value.ToString();
                        DateTime date = Convert.ToDateTime(row.Cells["Date"].Value);

                        using (SqlCommand cmd = new SqlCommand("UpdateServiceStatus", connection))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@user_id", userId);
                            cmd.Parameters.AddWithValue("@service_name", serviceName);
                            cmd.Parameters.AddWithValue("@date", date);
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
        }
    }
}
