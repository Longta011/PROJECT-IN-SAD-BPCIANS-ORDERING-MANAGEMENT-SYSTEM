using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BOMS_customer
{
    public partial class ADMIN_int_attendace_ : Form
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

        public ADMIN_int_attendace_()
        {
            InitializeComponent();

            conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"D:\\FOR CODES\\BOMS.accdb\"");
        }

        // Method to retrieve and display users from the database
        /* void GetUsers()
         {
             conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"D:\\FOR CODES\\BOMS.accdb\"");
             dt = new DataTable();
             adapter = new OleDbDataAdapter("SELECT * FROM LogTable", conn);
             conn.Open();
             adapter.Fill(dt);
             dgvAttend.DataSource = dt;
             conn.Close();
         }*/

        private void LoadLogTableData()
        {
            try
            {
                // Open the database connection
                conn.Open();

                // SQL query to fetch all records from LogTable
                string query = "SELECT * FROM LogTable";

                // Use OleDbDataAdapter to fetch the data
                OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);

                // Fill a DataTable with the data
                DataTable logTable = new DataTable();
                adapter.Fill(logTable);

                // Bind the DataTable to the DataGridView (dgvAttend)
                dgvAttend.DataSource = logTable;

                // Optional: Set DataGridView column headers (if needed)
                dgvAttend.Columns["userID"].HeaderText = "User ID";
                dgvAttend.Columns["FirstName"].HeaderText = "First Name";
                dgvAttend.Columns["LastName"].HeaderText = "Last Name";
                dgvAttend.Columns["TimeIn"].HeaderText = "Time In";
                dgvAttend.Columns["TimeOut"].HeaderText = "Time Out";
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

        private void ADMIN_int_attendace__Load(object sender, EventArgs e)
        {
            LoadLogTableData();
            btn_Acc.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_Acc.Width, btn_Acc.Height, 40, 40));
            btn_Item.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_Item.Width, btn_Item.Height, 40, 40));
            btn_Order.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_Order.Width, btn_Order.Height, 40, 40));
            btn_Attend.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_Attend.Width, btn_Attend.Height, 40, 40));



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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbS_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = "SELECT * FROM LogTable WHERE userID LIKE @i";
            adapter = new OleDbDataAdapter(searchQuery, conn);
            adapter.SelectCommand.Parameters.AddWithValue("@i", tbS.Text + "%");

            dt = new DataTable();
            conn.Open();
            adapter.Fill(dt);
            conn.Close();
            dgvAttend.DataSource = dt;

        }

        private void lbSearch_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LL_PROFILE_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ADMIN_Profile form1 = new ADMIN_Profile();
            form1.Show();
        }

        private void btn_Order_Click(object sender, EventArgs e)
        {
            this.Hide();
            ADMIN_int_Order_ form1 = new ADMIN_int_Order_();
            form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
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
