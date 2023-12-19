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
    public partial class Client_Transaction_History : MetroFramework.Forms.MetroForm
    {
        int currentUser = CurrentUser.UserId;
        private SqlConnection connection = new SqlConnection("data source = .\\SQLEXPRESS; database = HairServicesDB; integrated security = True");
        public Client_Transaction_History()
        {
            InitializeComponent();
            loadData();
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
        private void metroLink1_Click(object sender, EventArgs e)
        {
            OpenClientDashboard();
        }
        private void loadData()
        {
            try
            {
                connection.Open();
                // Query to select data
                string query = "SELECT * FROM service_view WHERE [My ID] = '" + currentUser + "'";
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

    }
}
