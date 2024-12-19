using Microsoft.VisualBasic.ApplicationServices;
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

namespace BOMS_customer
{
    public partial class ST_POS : Form
    {

        DataTable dt; // Stores data in-memory for binding to controls

        /*OleDbConnection conn;*/
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        private OleDbConnection conn;

        public ST_POS()
        {
            InitializeComponent();
            /*this.userId = userId;*/
            conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"D:\\FOR CODES\\BOMS.accdb\"");
        }

        void GetUsers()
        {
            conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"D:\\FOR CODES\\BOMS.accdb\"");
            dt = new DataTable();
            adapter = new OleDbDataAdapter("SELECT * FROM orders", conn);
            conn.Open();
            adapter.Fill(dt);
            dgvUser.DataSource = dt;
            conn.Close();
        }

        private void LoadLogTableData()
        {
            try
            {
                // Open the database connection
                conn.Open();

                // SQL query to fetch all records from LogTable
                string query = "SELECT * FROM orders";

                // Use OleDbDataAdapter to fetch the data
                OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);

                // Fill a DataTable with the data
                DataTable logTable = new DataTable();
                adapter.Fill(logTable);

                // Bind the DataTable to the DataGridView (dgvAttend)
                dgvUser.DataSource = logTable;

                // Optional: Set DataGridView column headers (if needed)
                /* dgvUser.Columns["SUPPLIER_ID"].HeaderText = "SUPPLIER ID";
                 dgvUser.Columns["SUPPLIER_NAME"].HeaderText = "SUPPLIER CONTACT ";
                 dgvUser.Columns["SUPPLIER_CONTACT"].HeaderText = "Product Price";
                 dgvUser.Columns["SUPPLIER_ADDRESS"].HeaderText = "SUPPLIER ADDRESS";
                 dgvUser.Columns["PRODUCT"].HeaderText = "Category";*/

            }
            catch (Exception ex)
            {
                // Handle any errors
                MessageBox.Show("Error loading data: " + ex.Message);
            }
            finally
            {
                // Ensure the connection is closed
                conn.Close();
            }
        }

        private void LL_PROFILE_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login form1 = new Login();
            form1.Show();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            this.Hide();
            ST_HISTORY form1 = new ST_HISTORY();
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

        private void ST_POS_Load(object sender, EventArgs e)
        {
            GetUsers();
        }

        private void tbS_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = "SELECT * FROM orders WHERE [Order ID]  LIKE @i";
            adapter = new OleDbDataAdapter(searchQuery, conn);
            adapter.SelectCommand.Parameters.AddWithValue("@i", tbS.Text + "%");

            dt = new DataTable();
            conn.Open();
            adapter.Fill(dt);
            conn.Close();
            dgvUser.DataSource = dt;
        }

        private void btnpaid_Click(object sender, EventArgs e)
        {
            if (dgvUser.SelectedRows.Count > 0)
            {
                try
                {
                    // Get the selected row's ID (Primary Key)
                    int selectedId = Convert.ToInt32(dgvUser.SelectedRows[0].Cells["Order ID"].Value);

                    // Open a connection to the database
                    conn.Open();

                    // Use a transaction to ensure atomicity
                    OleDbTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        // Step 1: Update the status to "PAID" in the `orders` table
                        string updateQuery = "UPDATE orders SET [Status] = 'PAID' WHERE [Order ID] = @orderId";
                        using (OleDbCommand updateCmd = new OleDbCommand(updateQuery, conn, transaction))
                        {
                            updateCmd.Parameters.AddWithValue("@orderId", selectedId);
                            updateCmd.ExecuteNonQuery();
                        }

                        // Step 2: Transfer the record to the `history` table
                        string transferQuery = @"
                    INSERT INTO history ([Order ID], [Order List and Quantity], [Total], [Status], [Date and Time])
                    SELECT [Order ID], [Order List and Quantity], [Total], [Status], [Date and Time]
                    FROM orders
                    WHERE [Order ID] = @orderId";
                        using (OleDbCommand transferCmd = new OleDbCommand(transferQuery, conn, transaction))
                        {
                            transferCmd.Parameters.AddWithValue("@orderId", selectedId);
                            transferCmd.ExecuteNonQuery();
                        }

                        // Step 3: Delete the record from the `orders` table
                        string deleteQuery = "DELETE FROM orders WHERE [Order ID] = @orderId";
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

                        MessageBox.Show("Record updated to 'PAID' and transferred to history.");
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
                MessageBox.Show("Please select an order to mark as PAID.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvUser.SelectedRows.Count > 0)
            {
                try
                {
                    // Get the selected row's ID (Primary Key)
                    int selectedId = Convert.ToInt32(dgvUser.SelectedRows[0].Cells["Order ID"].Value);

                    // Open a connection to the database
                    conn.Open();

                    // Use a transaction to ensure atomicity
                    OleDbTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        // Step 1: Update the status to "PAID" in the `orders` table
                        string updateQuery = "UPDATE orders SET [Status] = 'VOID' WHERE [Order ID] = @orderId";
                        using (OleDbCommand updateCmd = new OleDbCommand(updateQuery, conn, transaction))
                        {
                            updateCmd.Parameters.AddWithValue("@orderId", selectedId);
                            updateCmd.ExecuteNonQuery();
                        }

                        // Step 2: Transfer the record to the `history` table
                        string transferQuery = @"
                    INSERT INTO history ([Order ID], [Order List and Quantity], [Total], [Status], [Date and Time])
                    SELECT [Order ID], [Order List and Quantity], [Total], [Status], [Date and Time]
                    FROM orders
                    WHERE [Order ID] = @orderId";
                        using (OleDbCommand transferCmd = new OleDbCommand(transferQuery, conn, transaction))
                        {
                            transferCmd.Parameters.AddWithValue("@orderId", selectedId);
                            transferCmd.ExecuteNonQuery();
                        }

                        // Step 3: Delete the record from the `orders` table
                        string deleteQuery = "DELETE FROM orders WHERE [Order ID] = @orderId";
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

                        MessageBox.Show("Record updated to 'VOID' and transferred to history.");
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
                MessageBox.Show("Please select an order to mark as PAID.");
            }
        
    }
    }
}
