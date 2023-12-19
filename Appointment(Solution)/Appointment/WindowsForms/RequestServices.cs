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
    public partial class RequestServices : MetroFramework.Forms.MetroForm
    {
        private SqlConnection connection = new SqlConnection("data source = .\\SQLEXPRESS; database = HairServicesDB; integrated security = True");
        // access the current userID
        int userId = CurrentUser.UserId;

        public RequestServices()
        {
            InitializeComponent();
            loadData();
            dgv_Services.AllowUserToAddRows = true;
        }

        // functions
        private void loadData()
        {
            try
            {
                connection.Open();


                // Query to select data
                string query = "SELECT Services, price AS 'Price' FROM services ORDER BY price ASC";

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
        private void RequestServices_Load(object sender, EventArgs e)
        {
            // pass the value
            txtCurrentUserId.Text = userId.ToString();

            // Set the minimum date for the DateTimePicker
            dtSelectDate.MinDate =  DateTime.Today;

        }

        private void btnAddRequest_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                string serviceName = dgv_Services.CurrentRow.Cells["Services"].Value.ToString();
                decimal price = Convert.ToDecimal(dgv_Services.CurrentRow.Cells["Price"].Value);
                
                DateTime date = dtSelectDate.Value.Date;

                using (SqlCommand cmd = new SqlCommand("AddServiceRequest", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Add parameters
                     cmd.Parameters.AddWithValue("@user_id", userId);
                    cmd.Parameters.AddWithValue("@service_name", serviceName);
                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.Parameters.AddWithValue("@date", date);

                    // Execute the stored procedure
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Service request added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Close the connection
                connection.Close();

            }
        }

        private void brnCancelRequest_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }
    }
}
