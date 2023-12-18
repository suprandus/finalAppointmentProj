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
    public partial class Services : MetroFramework.Forms.MetroForm
    {
        private SqlConnection connection = new SqlConnection("data source = .\\SQLEXPRESS; database = HairServicesDB; integrated security = True");
        public Services()
        {
            InitializeComponent();
            loadData();
            dgv_Services.AllowUserToAddRows = true;
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Saves changes
            try
            {
                connection.Open();

                // Use a DataAdapter to update changes to the database
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM services", connection);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                adapter.Update((DataTable)dgv_Services.DataSource);
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Check if there are selected rows
            if (dgv_Services.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete the selected rows?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Create a DataTable to store the selected rows
                        DataTable selectedData = new DataTable();
                        foreach (DataGridViewColumn column in dgv_Services.Columns)
                        {
                            selectedData.Columns.Add(column.Name);
                        }

                        // Add data from selected rows to the DataTable
                        foreach (DataGridViewRow row in dgv_Services.SelectedRows)
                        {
                            DataRow dataRow = selectedData.NewRow();
                            foreach (DataGridViewColumn column in dgv_Services.Columns)
                            {
                                dataRow[column.Name] = row.Cells[column.Name].Value;
                            }
                            selectedData.Rows.Add(dataRow);
                        }

                        // Use a DataAdapter to update changes to the database
                        SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM services", connection);
                        SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                        // Delete the selected rows from the DataTable
                        foreach (DataRow dataRow in selectedData.Rows)
                        {
                            DataRow[] rowsToDelete = ((DataTable)dgv_Services.DataSource).Select($"Services = '{dataRow["Services"]}'");
                            foreach (DataRow rowToDelete in rowsToDelete)
                            {
                                rowToDelete.Delete();
                            }
                        }

                        // Update the database
                        adapter.Update((DataTable)dgv_Services.DataSource);
                        dgv_Services.ClearSelection();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select rows to delete.", "No Rows Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            OpenAdminDashboard();
        }
    }
}
