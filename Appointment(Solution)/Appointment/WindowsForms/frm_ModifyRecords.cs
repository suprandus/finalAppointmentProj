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
    public partial class frm_ModifyRecords : MetroFramework.Forms.MetroForm
    {
        private SqlConnection connection = new SqlConnection("data source = .\\SQLEXPRESS; database = HairServicesDB; integrated security = True");
        public frm_ModifyRecords()
        {
            InitializeComponent();
            loadData();
            dgv_UserAccountss.AllowUserToAddRows = true;
        }

        // functions
        private void OpenUserAccounts()
        {
            using (var userAccounts = new frm_UserAccounts())
            {
                this.Hide();
                _ = userAccounts.ShowDialog();
                this.Show();
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            OpenUserAccounts();
        }
        private void loadData()
        {
            try
            {
                connection.Open();


                // Query to select data
                string query = "EXEC GetUsers";

                // SqlDataAdapter and DataTable
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();

                // Fill
                adapter.Fill(dataTable);

                // Bind the DataTable to the DataGridView
                dgv_UserAccountss.DataSource = dataTable;
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

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                // Get the DataTable from the DataSource
                DataTable dataTable = (DataTable)dgv_UserAccountss.DataSource;

                // Manually update each row in the DataTable
                foreach (DataRow row in dataTable.Rows)
                {
                    int userId = Convert.ToInt32(row["User ID"]);
                    string username = Convert.ToString(row["Username"]);
                    string fullName = Convert.ToString(row["Full Name"]);
                    string phoneNumber = Convert.ToString(row["Phone Number"]);
                    string emailAddress = Convert.ToString(row["Email Address"]);
                    // You may need to handle role ID or description based on your database structure

                    // Update user_account table
                    using (SqlCommand cmd = new SqlCommand("UPDATE user_account SET username = @Username WHERE user_id = @UserId", connection))
                    {
                        cmd.Parameters.AddWithValue("@UserId", userId);
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.ExecuteNonQuery();
                    }

                    // Update user_information table
                    using (SqlCommand cmd = new SqlCommand("UPDATE user_information SET full_name = @FullName, phone_number = @PhoneNumber, email_address = @EmailAddress WHERE user_id = @UserId", connection))
                    {
                        cmd.Parameters.AddWithValue("@UserId", userId);
                        cmd.Parameters.AddWithValue("@FullName", fullName);
                        cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                        cmd.Parameters.AddWithValue("@EmailAddress", emailAddress);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Changes saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnDeleteRecords_Click(object sender, EventArgs e)
        {
            // Check if there are selected rows
            if (dgv_UserAccountss.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete the selected records?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Open the connection if it is not already open
                        if (connection.State != ConnectionState.Open)
                        {
                            connection.Open();
                        }

                        // Get the selected rows
                        DataGridViewSelectedRowCollection selectedRows = dgv_UserAccountss.SelectedRows;

                        foreach (DataGridViewRow row in selectedRows)
                        {
                            int userId = Convert.ToInt32(row.Cells["User ID"].Value);

                            // Delete from user_information first
                            using (SqlCommand cmd = new SqlCommand("DELETE FROM user_information WHERE [user_id] = @UserId", connection))
                            {
                                cmd.Parameters.AddWithValue("@UserId", userId);
                                cmd.ExecuteNonQuery();
                            }

                            // Then delete from user_account
                            using (SqlCommand cmd = new SqlCommand("DELETE FROM user_account WHERE [user_id] = @UserId", connection))
                            {
                                cmd.Parameters.AddWithValue("@UserId", userId);
                                cmd.ExecuteNonQuery();
                            }
                        }

                        // Reload data after deletion
                        loadData();
                    }
                    catch (SqlException ex)
                    {
                        // Check if the exception is due to a foreign key constraint violation
                        if (ex.Number == 547)
                        {
                            MessageBox.Show("Cannot delete the selected records because they are being referenced by other records.", "Deletion Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    finally
                    {
                        // Close the connection if it is open
                        if (connection.State == ConnectionState.Open)
                        {
                            connection.Close();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select records to delete.", "No Records Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
