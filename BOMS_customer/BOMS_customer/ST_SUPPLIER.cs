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
    public partial class ST_SUPPLIER : Form
    {

        private OleDbConnection conn; // Manages the connection to the Access database
        OleDbCommand cmd; // Executes SQL commands
        OleDbDataAdapter adapter; // Bridges data between Access and the application
        DataTable dt; // Stores data in-memory for binding to controls
        private bool isImageUploaded = false; // Tracks if an image is uploaded


        public ST_SUPPLIER()
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
                string query = "SELECT * FROM SUPPLIER";

                // Use OleDbDataAdapter to fetch the data
                OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);

                // Fill a DataTable with the data
                DataTable logTable = new DataTable();
                adapter.Fill(logTable);

                // Bind the DataTable to the DataGridView (dgvAttend)
                dgvUserr.DataSource = logTable;

                // Optional: Set DataGridView column headers (if needed)
                dgvUserr.Columns["SUPPLIER_ID"].HeaderText = "SUPPLIER ID";
                dgvUserr.Columns["SUPPLIER_NAME"].HeaderText = "SUPPLIER CONTACT ";
                dgvUserr.Columns["SUPPLIER_CONTACT"].HeaderText = "Product Price";
                dgvUserr.Columns["SUPPLIER_ADDRESS"].HeaderText = "SUPPLIER ADDRESS";
                dgvUserr.Columns["PRODUCT"].HeaderText = "Category";

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

        private void buttonInv_Click(object sender, EventArgs e)
        {
            this.Hide();
            ST_INVENTORY form1 = new ST_INVENTORY();
            form1.Show();
        }

        private void ST_SUPPLIER_Load(object sender, EventArgs e)
        {
            LoadLogTableData();
        }

        private void tbS_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = "SELECT * FROM SUPPLIER WHERE SUPPLIER_NAME LIKE @i";
            adapter = new OleDbDataAdapter(searchQuery, conn);
            adapter.SelectCommand.Parameters.AddWithValue("@i", tbS.Text + "%");

            dt = new DataTable();
            conn.Open();
            adapter.Fill(dt);
            conn.Close();
            dgvUserr.DataSource = dt;
        }
    }
}
