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
    public partial class INVENTORY : Form
    {
        OleDbConnection conn; // Manages the connection to the Access database
        OleDbCommand cmd; // Executes SQL commands
        OleDbDataAdapter adapter; // Bridges data between Access and the application
        DataTable dt; // Stores data in-memory for binding to controls
        private bool isImageUploaded = false; // Tracks if an image is uploaded

        public INVENTORY()
        {
            InitializeComponent();
        }

        void GetUsers()
        {
            conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"D:\\FOR CODES\\BOMS.accdb\"");
            dt = new DataTable();
            adapter = new OleDbDataAdapter("SELECT * FROM products", conn);
            conn.Open();
            adapter.Fill(dt);
            dgvUser.DataSource = dt;
            conn.Close();
        }

        private void INVENTORY_Load(object sender, EventArgs e)
        {

            GetUsers();
            dgvUser.Columns["product_image"].Visible = false; // Hide the Photo column



            cbSt.Items.Clear();
            cbSt.Items.Add("Out of Stock");
            cbSt.Items.Add("In Stock");

        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(tbN.Text) || string.IsNullOrWhiteSpace(tbP.Text) ||
                string.IsNullOrWhiteSpace(tbC.Text) || string.IsNullOrWhiteSpace(tbQ.Text) || string.IsNullOrWhiteSpace(cbSt.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            string query = isImageUploaded
                ? "UPDATE products SET product_name=@n, product_Price=@p, category=@c, Quantity=@q, stock_status =@st WHERE product_id=@id"
                : "UPDATE products  SET product_name=@n, product_Price=@p, category=@c, Quantity=@q, stock_status =@st WHERE product_id=@id";

            cmd = new OleDbCommand(query, conn);

            cmd.Parameters.AddWithValue("@n", tbN.Text);
            cmd.Parameters.AddWithValue("@p", tbP.Text);
            cmd.Parameters.AddWithValue("@c", tbC.Text);
            cmd.Parameters.AddWithValue("@q", tbQ.Text);
            cmd.Parameters.AddWithValue("@st", cbSt.SelectedItem.ToString());


            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(dgvUser.CurrentRow.Cells[0].Value));

            conn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("User Updated Successfully");
            conn.Close();

            GetUsers();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbN.Clear();
            tbP.Clear();
            tbC.Clear();
            tbQ.Clear();
            tbID.Clear();
            tbSt.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // SQL query to delete a user based on their ID
            string query = "DELETE FROM products WHERE product_id = @i";

            // Create a new OleDbCommand with the query and the database connection
            cmd = new OleDbCommand(query, conn);

            // Add the user ID parameter to the command
            cmd.Parameters.AddWithValue("@i", Convert.ToInt32(tbID.Text)); // Convert the ID from the textbox to an integer

            // Open the connection, execute the command, and close the connection
            conn.Open(); // Open the connection to the database
            cmd.ExecuteNonQuery(); // Execute the delete query
            MessageBox.Show("Product Deleted"); // Show a success message
            conn.Close(); // Close the connection to the database

            // Refresh the DataGridView to reflect changes
            GetUsers();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ADMIN_SUPPLIER form1 = new ADMIN_SUPPLIER();
            form1.Show();
        }

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbID.Text = dgvUser.CurrentRow.Cells[0].Value.ToString();
            tbN.Text = dgvUser.CurrentRow.Cells[1].Value.ToString();
            tbP.Text = dgvUser.CurrentRow.Cells[2].Value.ToString();
            tbC.Text = dgvUser.CurrentRow.Cells[3].Value.ToString();
            tbQ.Text = dgvUser.CurrentRow.Cells[4].Value.ToString();
            /*tbSt.Text = dgvUser.CurrentRow.Cells[5].Value.ToString();*/

            string stockStatus = dgvUser.CurrentRow.Cells[5].Value.ToString();
            if (cbSt.Items.Contains(stockStatus))
            {
                cbSt.SelectedItem = stockStatus;
            }
            else
            {
                cbSt.SelectedIndex = -1; // Clear selection if value not found
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = "SELECT * FROM products WHERE product_name LIKE @i";
            adapter = new OleDbDataAdapter(searchQuery, conn);
            adapter.SelectCommand.Parameters.AddWithValue("@i", textBox1.Text + "%");

            dt = new DataTable();
            conn.Open();
            adapter.Fill(dt);
            conn.Close();
            dgvUser.DataSource = dt;
        }

        private void btn_Attend_Click(object sender, EventArgs e)
        {
            this.Hide();
            ADMIN_int_attendace_ form1 = new ADMIN_int_attendace_();
            form1.Show();
        }

        private void btn_Order_Click(object sender, EventArgs e)
        {
            this.Hide();
            ADMIN_int_Order_ form1 = new ADMIN_int_Order_();
            form1.Show();
        }

        private void btn_Acc_Click(object sender, EventArgs e)
        {
            this.Hide();
            ADMIN_int form1 = new ADMIN_int();
            form1.Show();
        }

        private void btn_Item_Click(object sender, EventArgs e)
        {
            this.Hide();
            ADMIN_int_Item_ form1 = new ADMIN_int_Item_();
            form1.Show();
        }

        private void LL_PROFILE_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ADMIN_Profile form1 = new ADMIN_Profile();
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            INVENTORY_SIZES form1 = new INVENTORY_SIZES();
            form1.Show();
        }
    }




}
