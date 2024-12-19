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
    public partial class ST_INVENTORY : Form
    {

        OleDbConnection conn; // Manages the connection to the Access database
        OleDbCommand cmd; // Executes SQL commands
        OleDbDataAdapter adapter; // Bridges data between Access and the application
        DataTable dt; // Stores data in-memory for binding to controls
        private bool isImageUploaded = false; // Tracks if an image is uploaded

        
        public ST_INVENTORY()
        {
            InitializeComponent();
            conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"D:\\FOR CODES\\BOMS.accdb\"");
        }
        private void LoadLogTableData()
        {
            try
            {
                // Open the database connection
                conn.Open();

                // SQL query to fetch all records from LogTable
                string query = "SELECT * FROM products";

                // Use OleDbDataAdapter to fetch the data
                OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);

                // Fill a DataTable with the data
                DataTable logTable = new DataTable();
                adapter.Fill(logTable);

                // Bind the DataTable to the DataGridView (dgvAttend)
                dgvUserr.DataSource = logTable;

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

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            ST_POS form1 = new ST_POS();
            form1.Show();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            this.Hide();
            ST_HISTORY form1 = new ST_HISTORY();
            form1.Show();
        }

        private void btnSupp_Click(object sender, EventArgs e)
        {
            this.Hide();
            ST_SUPPLIER form1 = new ST_SUPPLIER();
            form1.Show();
        }

        private void ST_INVENTORY_Load(object sender, EventArgs e)
        {
            LoadLogTableData();

            dgvUserr.Columns["product_image"].Visible = false; // Hide the Photo column
        }
    }
}
