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
    public partial class frm_GeneralAdminTransactionsHistory : MetroFramework.Forms.MetroForm
    {
        string staff_name = CurrentUser.user_name;
        private SqlConnection connection = new SqlConnection("data source = .\\SQLEXPRESS; database = HairServicesDB; integrated security = True");
        public frm_GeneralAdminTransactionsHistory()
        {
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            try
            {
                connection.Open();
                // Query to select data
                string query = "SELECT * FROM userview_general";
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


        private void OpenAdminDashboard()
        {
            using (var adminDashboard = new frm_AdminDashboard())
            {
                this.Hide();
                _ = adminDashboard.ShowDialog();
                this.Show();
            }
        }
        private void frm_GeneralAdminTransactionsHistory_Load(object sender, EventArgs e)
        {

        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            OpenAdminDashboard();
        }
    }
}
