using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BOMS_customer
{
    public partial class ST_HISTORY : Form
    {

        OleDbConnection conn; // Manages the connection to the Access database
        OleDbCommand cmd; // Executes SQL commands
        OleDbDataAdapter adapter; // Bridges data between Access and the application
        DataTable dt; // Stores data in-memory for binding to controls
        private bool isImageUploaded = false; // Tracks if an image is uploaded
        /*private int userId;*/

        public ST_HISTORY()
        {
            InitializeComponent();
        }

        void GetUsers()
        {
            conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"D:\\FOR CODES\\BOMS.accdb\"");
            dt = new DataTable();
            adapter = new OleDbDataAdapter("SELECT * FROM history", conn);
            conn.Open();
            adapter.Fill(dt);
            dgvUserr.DataSource = dt;
            conn.Close();
        }

        private void LL_PROFILE_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login form1 = new Login();
            form1.Show();
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            ST_POS form1 = new ST_POS();
            form1.Show();
        }

        private void buttonInv_Click(object sender, EventArgs e)
        {
            this.Hide();
            ST_INVENTORY form1 = new ST_INVENTORY();
            form1.Show();
        }

        private void btnSupp_Click(object sender, EventArgs e)
        {
            this.Hide();
            ST_SUPPLIER form1 = new ST_SUPPLIER();
            form1.Show();
        }

        private void ST_HISTORY_Load(object sender, EventArgs e)
        {
            GetUsers();
            cbProcess.Items.Clear();
            cbProcess.Items.Add("VOID");
            cbProcess.Items.Add("PAID");
            cbProcess.Items.Insert(0, "Show All"); // Optional "Show All" item
            cbProcess.SelectedIndex = 0; // Set default selection to "Show All"

            // Wire up the combo box event handler
            cbProcess.SelectedIndexChanged += cbProcess_SelectedIndexChanged;
        }

        private void tbS_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = "SELECT * FROM history WHERE [Order ID] LIKE @i";
            adapter = new OleDbDataAdapter(searchQuery, conn);
            adapter.SelectCommand.Parameters.AddWithValue("@i", tbS.Text + "%");

            dt = new DataTable();
            conn.Open();
            adapter.Fill(dt);
            conn.Close();
            dgvUserr.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvUserr.SelectedRows.Count > 0)
            {
                try
                {
                    // Get the selected row's ID (Primary Key)
                    int selectedId = Convert.ToInt32(dgvUserr.SelectedRows[0].Cells["Order ID"].Value);

                    // Open a connection to the database
                    conn.Open();

                    // Use a transaction to ensure atomicity
                    OleDbTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        // Step 1: Update the status to "PAID" in the `orders` table
                        string updateQuery = "UPDATE history SET [Status] = 'On process' WHERE [Order ID] = @orderId";
                        using (OleDbCommand updateCmd = new OleDbCommand(updateQuery, conn, transaction))
                        {
                            updateCmd.Parameters.AddWithValue("@orderId", selectedId);
                            updateCmd.ExecuteNonQuery();
                        }

                        // Step 2: Transfer the record to the `history` table
                        string transferQuery = @"
                    INSERT INTO orders ([Order ID], [Order List and Quantity], [Total], [Status], [Date and Time])
                    SELECT [Order ID], [Order List and Quantity], [Total], [Status], [Date and Time]
                    FROM history
                    WHERE [Order ID] = @orderId";
                        using (OleDbCommand transferCmd = new OleDbCommand(transferQuery, conn, transaction))
                        {
                            transferCmd.Parameters.AddWithValue("@orderId", selectedId);
                            transferCmd.ExecuteNonQuery();
                        }

                        // Step 3: Delete the record from the `orders` table
                        string deleteQuery = "DELETE FROM history WHERE [Order ID] = @orderId";
                        using (OleDbCommand deleteCmd = new OleDbCommand(deleteQuery, conn, transaction))
                        {
                            deleteCmd.Parameters.AddWithValue("@orderId", selectedId);
                            deleteCmd.ExecuteNonQuery();
                        }

                        // Commit the transaction
                        transaction.Commit();

                        // Refresh the DataGridView to reflect changes
                        /*LoadLogTableData();*/
                        GetUsers();

                        MessageBox.Show("Record updated to 'On process' and transferred to Orders.");
                    }
                    catch (Exception ex)
                    {
                        // Roll back the transaction in case of error
                        transaction.Rollback();
                        MessageBox.Show("Error processing payment: " + ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error connecting to database: " + ex.Message);
                }
                finally
                {
                    // Ensure the database connection is closed
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Please select an order to mark as On process.");
            }
        }

        private void cbProcess_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProcess.SelectedItem != null)
            {
                string selectedValue = cbProcess.SelectedItem.ToString();

                if (selectedValue == "Show All")
                {
                    // Show all rows
                    dgvUser.DataSource = dt;
                }
                else
                {
                    try
                    {
                        // Create a DataView and apply the RowFilter
                        DataView dv = dt.DefaultView;
                        dv.RowFilter = $"[Status] = '{selectedValue}'";
                        dgvUser.DataSource = dv;

                        // Debug: Show message if no rows are found
                        if (dv.Count == 0)
                        {
                            MessageBox.Show("No records match the selected status.", "Filter Result");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error filtering data: " + ex.Message, "Filter Error");
                    }
                }
                /*if (cbProcess.SelectedItem != null)
                {
                    string selectedValue = cbProcess.SelectedItem.ToString();

                    if (selectedValue == "Show All")
                    {
                        // Show all rows if "Show All" is selected
                        dgvUser.DataSource = dt;
                    }
                    else
                    {
                        // Filter rows based on the selected status
                        DataView dv = new DataView(dt);
                        dv.RowFilter = $"[Status] = '{selectedValue}'";
                        dgvUser.DataSource = dv;
                    }
                }
                }*/
            }
        } }
}
