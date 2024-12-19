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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BOMS_customer
{
    public partial class ADMIN_int_Order_ : Form
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


        public ADMIN_int_Order_()
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
            dgvUser.DataSource = dt;
            conn.Close();
        }

        private void btn_Item_Click(object sender, EventArgs e)
        {
            this.Hide();
            ADMIN_int_Item_ form1 = new ADMIN_int_Item_();
            form1.Show();
        }

        private void btn_Acc_Click(object sender, EventArgs e)
        {
            this.Hide();
            ADMIN_int form1 = new ADMIN_int();
            form1.Show();
        }

        private void btn_Attend_Click(object sender, EventArgs e)
        {
            this.Hide();
            ADMIN_int_attendace_ form1 = new ADMIN_int_attendace_();
            form1.Show();
        }

        private void ADMIN_int_Order__Load(object sender, EventArgs e)
        {

            btn_Acc.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_Acc.Width, btn_Acc.Height, 40, 40));
            btn_Item.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_Item.Width, btn_Item.Height, 40, 40));
            btn_Order.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_Order.Width, btn_Order.Height, 40, 40));
            btn_Attend.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_Attend.Width, btn_Attend.Height, 40, 40));

            GetUsers();

            // Hook up the DateTimePicker event
            dtpFilter.ValueChanged += dtpFilter_ValueChanged;
        }

        private void LL_PROFILE_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ADMIN_Profile form1 = new ADMIN_Profile();
            form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ADMIN_Profile form1 = new ADMIN_Profile();
            form1.Show();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            this.Hide();
            INVENTORY form1 = new INVENTORY();
            form1.Show();
        }

       

        private void dtpFilter_ValueChanged(object sender, EventArgs e)
        {
            /* string selectedDate = dtpFilter.Value.ToString("yyyy-MM-dd"); // Format the date

             // Query to filter records by date
             string searchQuery = "SELECT * FROM history WHERE FORMAT([Date and Time], 'yyyy-MM-dd') = @date";
             adapter = new OleDbDataAdapter(searchQuery, conn);
             adapter.SelectCommand.Parameters.AddWithValue("@date", selectedDate);

             // Fetch and display the filtered data
             dt = new DataTable();
             try
             {
                 conn.Open();
                 adapter.Fill(dt);
                 dgvUser.DataSource = dt;
             }
             catch (Exception ex)
             {
                 MessageBox.Show("Error filtering data: " + ex.Message);
             }
             finally
             {
                 conn.Close();
             }*/

            // Check if the selected date is set to a specific "Show All" date (e.g., 01/01/0001 or a special value)
            if (dtpFilter.Value == DateTime.MinValue)
            {
                // Load and display all records if the date picker is set to the special "Show All" value
                GetUsers(); // This will reload all data without any filter
            }
            else
            {
                string selectedDate = dtpFilter.Value.ToString("yyyy-MM-dd"); // Format the date for comparison

                // Query to filter records by date
                string searchQuery = "SELECT * FROM history WHERE FORMAT([Date and Time], 'yyyy-MM-dd') = @date";
                adapter = new OleDbDataAdapter(searchQuery, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@date", selectedDate);

                // Fetch and display the filtered data
                dt = new DataTable();
                try
                {
                    conn.Open();
                    adapter.Fill(dt);
                    dgvUser.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error filtering data: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            /* GetUsers(); // Reload all data
             dtpFilter.Value = DateTime.Now; // Reset the DateTimePicker*/

            // Load all data from the database without any date filter
            string query = "SELECT * FROM history";
            adapter = new OleDbDataAdapter(query, conn);

            dt = new DataTable();
            try
            {
                conn.Open();
                adapter.Fill(dt);
                dgvUser.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            // Reset the DateTimePicker to show the current date (optional)
            dtpFilter.Value = DateTime.Now;
        }
    }
}
