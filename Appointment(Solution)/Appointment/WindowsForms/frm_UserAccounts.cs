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
    public partial class frm_UserAccounts : MetroFramework.Forms.MetroForm
    {
        private SqlConnection connection = new SqlConnection("data source = .\\SQLEXPRESS; database = HairServicesDB; integrated security = True");
        public frm_UserAccounts()
        {
            InitializeComponent();
            loadData();
            dgv_UserAccounts.AllowUserToAddRows = true;
        }

        // functions
        private void OpenAdminDashboard()
        {
            using (var adminDashboard = new frm_AdminDashboard())
            {
                this.Hide();
                _ = adminDashboard.ShowDialog();
                this.Show();
            }
        }

        private void OpenModifyRecords()
        {
            using (var modifyRecords = new frm_ModifyRecords())
            {
                this.Hide();
                _ = modifyRecords.ShowDialog();
                this.Show();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            OpenAdminDashboard();
        }
        private void loadData()
        {
            try
            {
                connection.Open();

                // Query to select data
                string query = "EXEC GetUsers1";

                // SqlDataAdapter and DataTable
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();

                // Fill
                adapter.Fill(dataTable);

                // Bind the DataTable to the DataGridView
                dgv_UserAccounts.DataSource = dataTable;
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

        private void frm_UserAccounts_Load(object sender, EventArgs e)
        {

        }

        private void dgv_UserAccounts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnModifyRecords_Click(object sender, EventArgs e)
        {
            OpenModifyRecords();
        }
    }
}
