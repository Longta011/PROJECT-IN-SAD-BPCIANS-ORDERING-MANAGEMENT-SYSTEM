using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb; // For connecting to Access databases
using System.IO; // For handling file and memory streams
using System.Runtime.InteropServices; // For working with images

namespace BOMS_customer
{
    public partial class ADMIN_acc_admin_ : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeft,
            int nTop,
            int nRight,
            int nBottom,
            int nWidthEllipse,
            int nHeightEllipse

         );

        OleDbConnection conn; // Manages the connection to the Access database
        OleDbCommand cmd; // Executes SQL commands
        OleDbDataAdapter adapter; // Bridges data between Access and the application
        DataTable dt; // Stores data in-memory for binding to controls
        private bool isImageUploaded = false; // Tracks if an image is uploaded


        public ADMIN_acc_admin_()
        {
            InitializeComponent();
        }

        void GetUsers()
        {
            conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"D:\\FOR CODES\\BOMS.accdb\"");
            dt = new DataTable();
            adapter = new OleDbDataAdapter("SELECT * FROM Archive", conn);
            conn.Open();
            adapter.Fill(dt);
            dgvUser.DataSource = dt;
            conn.Close();
        }

        private void ADMIN_acc_admin__Load(object sender, EventArgs e)
        {
            btnSave.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnSave.Width, btnSave.Height, 20, 20));


            btnDelete.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnDelete.Width, btnDelete.Height, 20, 20));

            btn_Acc.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_Acc.Width, btn_Acc.Height, 40, 40));
            btn_Item.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_Item.Width, btn_Item.Height, 40, 40));
            btn_Order.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_Order.Width, btn_Order.Height, 40, 40));
            btn_Attend.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_Attend.Width, btn_Attend.Height, 40, 40));

            GetUsers();
            dgvUser.Columns["Picture"].Visible = false; // Hide the Photo column
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            /* // Check for required fields
             if (string.IsNullOrWhiteSpace(tbFN.Text) || string.IsNullOrWhiteSpace(tbLN.Text) ||
                 string.IsNullOrWhiteSpace(tbU.Text) || string.IsNullOrWhiteSpace(tbP.Text) || pbImage.Image == null)

             {
                 MessageBox.Show("Please fill in all fields.");
                 return;
             }




             // SQL query to insert a new user
             string query = "INSERT INTO UserAcc (Firstname, Lastname,Username, [Password], Picture) " +
                            "VALUES (@fn, @ln,@u, @p, @i)";
             cmd = new OleDbCommand(query, conn);

             // Add parameters from textboxes and controls
             cmd.Parameters.AddWithValue("@fn", tbFN.Text);
             cmd.Parameters.AddWithValue("@ln", tbLN.Text);

             cmd.Parameters.AddWithValue("@u", tbU.Text);
             cmd.Parameters.AddWithValue("@p", tbP.Text);

             // Convert the image to a byte array and add it to the parameters
             using (MemoryStream ms = new MemoryStream())
             {
                 pbImage.Image.Save(ms, pbImage.Image.RawFormat);
                 cmd.Parameters.AddWithValue("@i", ms.ToArray());
             }

             // Insert the new user
             conn.Open();
             cmd.ExecuteNonQuery();
             MessageBox.Show("User Inserted Successfully");
             conn.Close();

             // Refresh DataGridView
             GetUsers();*/

            if (dgvUser.SelectedRows.Count > 0)
            {
                try
                {
                    // Get the selected row's ID (Primary Key)
                    int selectedId = Convert.ToInt32(dgvUser.SelectedRows[0].Cells["userID"].Value);

                    // Open a connection to the database

                    conn.Open();

                    // Step 1: Insert data into Archive table
                    string transferQuery = "INSERT INTO CashierAcc ( userID, Firstname, Lastname, Username, [Password], Type, Picture) " +
                                           "SELECT  userID ,Firstname, Lastname, Username, [Password], Type, Picture " +
                                           "FROM Archive WHERE userID = @id";
                    using (OleDbCommand transferCommand = new OleDbCommand(transferQuery, conn))
                    {
                        transferCommand.Parameters.AddWithValue("@id", selectedId);
                        transferCommand.ExecuteNonQuery();
                    }

                    // Step 2: Delete the record from CashierAcc
                    string deleteQuery = "DELETE FROM Archive WHERE userID = @id";
                    using (OleDbCommand deleteCommand = new OleDbCommand(deleteQuery, conn))
                    {
                        deleteCommand.Parameters.AddWithValue("@id", selectedId);
                        deleteCommand.ExecuteNonQuery();
                    }

                    // Notify the user
                    MessageBox.Show("Record successfully .", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refresh the DataGridView to reflect the changes
                    GetUsers();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (conn != null && conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a record to delete.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            // SQL query to delete a user based on their ID
            string query = "DELETE FROM Archive WHERE userID = @i";

            // Create a new OleDbCommand with the query and the database connection
            cmd = new OleDbCommand(query, conn);

            // Add the user ID parameter to the command
            cmd.Parameters.AddWithValue("@i", Convert.ToInt32(tbID.Text)); // Convert the ID from the textbox to an integer

            // Open the connection, execute the command, and close the connection
            conn.Open(); // Open the connection to the database
            cmd.ExecuteNonQuery(); // Execute the delete query
            MessageBox.Show("ACCOUNT Deleted"); // Show a success message
            conn.Close(); // Close the connection to the database

            // Refresh the DataGridView to reflect changes
            GetUsers();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {


        }

        private void tbS_TextChanged(object sender, EventArgs e)
        {

            string searchQuery = "SELECT * FROM UserAcc WHERE userID LIKE @i";
            adapter = new OleDbDataAdapter(searchQuery, conn);
            adapter.SelectCommand.Parameters.AddWithValue("@i", tbS.Text + "%");

            dt = new DataTable();
            conn.Open();
            adapter.Fill(dt);
            conn.Close();
            dgvUser.DataSource = dt;
        }

        private void btnAccCash_Click(object sender, EventArgs e)
        {
            this.Hide();
            ADMIN_int form1 = new ADMIN_int();
            form1.Show();
        }

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbID.Text = dgvUser.CurrentRow.Cells[0].Value.ToString();
            tbFN.Text = dgvUser.CurrentRow.Cells[3].Value.ToString();
            tbLN.Text = dgvUser.CurrentRow.Cells[4].Value.ToString();
            tbU.Text = dgvUser.CurrentRow.Cells[1].Value.ToString();
            tbP.Text = dgvUser.CurrentRow.Cells[2].Value.ToString();

            if (dgvUser.CurrentRow.Cells["Picture"].Value != DBNull.Value)
            {
                byte[] imgData = (byte[])dgvUser.CurrentRow.Cells["Picture"].Value;
                using (MemoryStream ms = new MemoryStream(imgData))
                {
                    pbImage.Image = Image.FromStream(ms);
                }
            }
            else
            {
                pbImage.Image = null;
            }
        }

        private void btn_Order_Click(object sender, EventArgs e)
        {
            this.Hide();
            ADMIN_int_Order_ form1 = new ADMIN_int_Order_();
            form1.Show();
        }

        private void btn_Item_Click(object sender, EventArgs e)
        {
            this.Hide();
            ADMIN_int_Item_ form1 = new ADMIN_int_Item_();
            form1.Show();
        }

        private void btn_Attend_Click(object sender, EventArgs e)
        {
            this.Hide();
            ADMIN_int_attendace_ form1 = new ADMIN_int_attendace_();
            form1.Show();
        }

        private void LL_PROFILE_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ADMIN_Profile form1 = new ADMIN_Profile();
            form1.Show();
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            this.Hide();
            ADMIN_SUPPLIER form1 = new ADMIN_SUPPLIER();
            form1.Show();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            this.Hide();
            INVENTORY form1 = new INVENTORY();
            form1.Show();
        }
    }
}
