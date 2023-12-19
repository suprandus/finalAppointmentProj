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
    public partial class frm_StaffTransactionHist : MetroFramework.Forms.MetroForm
    {
        private SqlConnection connection = new SqlConnection("data source = .\\SQLEXPRESS; database = HairServicesDB; integrated security = True");
        int userId = CurrentUser.UserId;
        public frm_StaffTransactionHist()
        {
            InitializeComponent();
            loadData();
        }
        // funct
        private void loadData()
        {
            try
            {
                connection.Open();


                // Query to select data
                string query = "SELECT staff_id AS 'Staff ID', date AS 'Completion Date', totalAmount AS 'Total Amount' FROM s_transations_history_view WHERE staff_id = " +userId;
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

        private void OpenStaffDashboard()
        {
            using (var staffDashboard = new frm_StaffDashboard())
            {
                this.Hide();
                _ = staffDashboard.ShowDialog();
                this.Show();
            }
        }
        private void metroLink1_Click(object sender, EventArgs e)
        {
            OpenStaffDashboard();
        }

        private void dgv_Services_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
