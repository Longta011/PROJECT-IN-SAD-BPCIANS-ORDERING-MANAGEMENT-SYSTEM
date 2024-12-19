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
    public partial class INVENTORY_SIZES : Form
    {
        OleDbConnection conn; // Manages the connection to the Access database
        OleDbCommand cmd; // Executes SQL commands
        OleDbDataAdapter adapter; // Bridges data between Access and the application
        DataTable dt; // Stores data in-memory for binding to controls
        private bool isImageUploaded = false; // Tracks if an image is uploaded

        public INVENTORY_SIZES()
        {
            InitializeComponent();
        }
        void GetUsers()
        {
            conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"D:\\FOR CODES\\BOMS.accdb\"");
            dt = new DataTable();
            adapter = new OleDbDataAdapter("SELECT * FROM Products_Size", conn);
            conn.Open();
            adapter.Fill(dt);
            dgvUser.DataSource = dt;
            conn.Close();
        }

        private void INVENTORY_SIZES_Load(object sender, EventArgs e)
        {
            cbSt.Items.Clear();
            cbSt.Items.Add("Out of Stock");
            cbSt.Items.Add("In Stock");

            GetUsers();
            dgvUser.Columns["Picture"].Visible = false; // Hide the Photo column


        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(tbN.Text) || string.IsNullOrWhiteSpace(tbVS.Text) || string.IsNullOrWhiteSpace(tbS.Text) || string.IsNullOrWhiteSpace(tbM.Text) || string.IsNullOrWhiteSpace(tbL.Text) ||
                string.IsNullOrWhiteSpace(tbXL.Text) ||
                string.IsNullOrWhiteSpace(tbC.Text) || string.IsNullOrWhiteSpace(cbSt.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            string query = isImageUploaded
                ? "UPDATE Products_Size SET Product_name=@n, Price_Size_VS=@pVS,Price_Size_S=@pS ,Price_Size_M=@pM, Price_Size_L=@pL, Price_Size_XL=@pXL,  Category=@c, stock_status =@st WHERE Product_ID=@id"
                : "UPDATE Products_Size  SET Product_name=@n, Price_Size_VS=@pVS,Price_Size_S=@pS ,Price_Size_M=@pM, Price_Size_L=@pL, Price_Size_XL=@pXL,  Category=@c, stock_status =@st WHERE Product_ID=@id";

            cmd = new OleDbCommand(query, conn);

            cmd.Parameters.AddWithValue("@n", tbN.Text);
            cmd.Parameters.AddWithValue("@pVS", tbVS.Text);
            cmd.Parameters.AddWithValue("@pS", tbS.Text);
            cmd.Parameters.AddWithValue("@pM", tbM.Text);
            cmd.Parameters.AddWithValue("@pL", tbL.Text);
            cmd.Parameters.AddWithValue("@pXL", tbXL.Text);
            cmd.Parameters.AddWithValue("@c", tbC.Text);
            cmd.Parameters.AddWithValue("@st", cbSt.SelectedItem.ToString());


            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(dgvUser.CurrentRow.Cells[0].Value));

            conn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("User Updated Successfully");
            conn.Close();

            GetUsers();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // SQL query to delete a user based on their ID
            string query = "DELETE FROM products WHERE Product_ID = @i";

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

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbN.Clear();
            tbVS.Clear();
            tbM.Clear();
            tbL.Clear();
            tbXL.Clear();
            tbC.Clear();
            tbS.Clear();
            tbID.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ADMIN_SUPPLIER form1 = new ADMIN_SUPPLIER();
            form1.Show();
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            INVENTORY form1 = new INVENTORY();
            form1.Show();
        }

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbID.Text = dgvUser.CurrentRow.Cells[0].Value.ToString();
            tbN.Text = dgvUser.CurrentRow.Cells[1].Value.ToString();
            tbVS.Text = dgvUser.CurrentRow.Cells[2].Value.ToString();
            tbS.Text = dgvUser.CurrentRow.Cells[3].Value.ToString();
            tbM.Text = dgvUser.CurrentRow.Cells[4].Value.ToString();
            tbL.Text = dgvUser.CurrentRow.Cells[5].Value.ToString();
            tbXL.Text = dgvUser.CurrentRow.Cells[6].Value.ToString();
            tbC.Text = dgvUser.CurrentRow.Cells[7].Value.ToString();

            string stockStatus = dgvUser.CurrentRow.Cells[8].Value.ToString();
            if (cbSt.Items.Contains(stockStatus))
            {
                cbSt.SelectedItem = stockStatus;
            }
            else
            {
                cbSt.SelectedIndex = -1; // Clear selection if value not found
            }



        }
    }
}
