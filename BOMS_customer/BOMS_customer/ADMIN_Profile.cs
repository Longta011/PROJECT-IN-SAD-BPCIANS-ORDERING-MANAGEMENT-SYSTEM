using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices; // For working with images
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.IO; // For handling file and memory streams



namespace BOMS_customer
{
    public partial class ADMIN_Profile : Form
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

        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\FOR CODES\BOMS.accdb"; // Adjust path to your database

        OleDbConnection conn; // Manages the connection to the Access database
        OleDbCommand cmd; // Executes SQL commands
        OleDbDataAdapter adapter; // Bridges data between Access and the application
        DataTable dt; // Stores data in-memory for binding to controls
        private bool isImageUploaded = false; // Tracks if an image is uploaded


        public ADMIN_Profile()
        {
            InitializeComponent();
        }
        /* void GetUsers()
         {
             conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"D:\\FOR CODES\\BOMS.accdb\"");
             dt = new DataTable();
             adapter = new OleDbDataAdapter("SELECT * FROM CashierAcc", conn);
             conn.Open();
             adapter.Fill(dt);

             conn.Close();x
         }*/


        private void panel8_Paint(object sender, PaintEventArgs e)
        {


        }

        private void ADMIN_Profile_Load(object sender, EventArgs e)
        {
            Pprofile.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Pprofile.Width, Pprofile.Height, 40, 40));
            PSec.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, PSec.Width, PSec.Height, 40, 40));

            btnPass.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnPass.Width, btnPass.Height, 40, 40));



            using (OleDbConnection connection = new OleDbConnection(connectionString))

            {
                string query = "SELECT Firstname, Lastname, Gmail, Contact FROM UserAcc WHERE Username  = 'Steven' "; // Adjust condition as needed
                OleDbCommand command = new OleDbCommand(query, connection);
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    tbFname.Text = reader["Firstname"].ToString();
                    tbLname.Text = reader["Lastname"].ToString();
                    tbMail.Text = reader["Gmail"].ToString();
                    tbNumber.Text = reader["Contact"].ToString();

                }

                connection.Close();
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnPass_Click(object sender, EventArgs e)
        {

            // Ensure all fields are filled in
            if (string.IsNullOrWhiteSpace(tbCPass.Text) ||
                string.IsNullOrWhiteSpace(tbNPass.Text) ||
                string.IsNullOrWhiteSpace(tbRNPass.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            // Check if New Password and Re-entered New Password match
            if (tbNPass.Text != tbRNPass.Text)
            {
                MessageBox.Show("New password and Re-entered password do not match.");
                return;
            }

            // Ensure the connection is initialized
            conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"D:\\FOR CODES\\BOMS.accdb\"");

            try
            {


                // Query to verify the current password
                string validateQuery = "SELECT COUNT(*) FROM UserAcc WHERE [Password] = @currentPassword ";


                cmd = new OleDbCommand(validateQuery, conn);
                cmd.Parameters.AddWithValue("@currentPassword", tbCPass.Text);

                conn.Open();

                // Check if the current password is correct
                int result = Convert.ToInt32(cmd.ExecuteScalar());
                if (result == 0)
                {
                    MessageBox.Show("Current password is incorrect.");
                    conn.Close();
                    return;
                }

                // Query to update the password
                string updateQuery = "UPDATE UserAcc SET [Password] = @newPassword WHERE [Password] = @currentPassword  ";
                cmd = new OleDbCommand(updateQuery, conn);
                cmd.Parameters.AddWithValue("@newPassword", tbNPass.Text);
                cmd.Parameters.AddWithValue("@currentPassword", tbCPass.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Password updated successfully.");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();

                tbCPass.Clear();
                tbNPass.Clear();
                tbRNPass.Clear();

            }
        }

        private void cbCPass_CheckedChanged(object sender, EventArgs e)
        {
            tbCPass.PasswordChar = cbCPass.Checked ? '\0' : '*';
        }

        private void cbNPass_CheckedChanged(object sender, EventArgs e)
        {
            tbNPass.PasswordChar = cbNPass.Checked ? '\0' : '*';
        }

        private void cbRNPass_CheckedChanged(object sender, EventArgs e)
        {
            tbRNPass.PasswordChar = cbRNPass.Checked ? '\0' : '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            ADMIN_int form1 = new ADMIN_int();
            form1.Show();
        }

        private void pbPhoto_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login form1 = new Login();
            form1.Show();
        }

        private void tbFname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}