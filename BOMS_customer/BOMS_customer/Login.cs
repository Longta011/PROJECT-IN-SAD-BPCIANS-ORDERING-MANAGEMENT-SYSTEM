using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;


namespace BOMS_customer
{


    public partial class Login : Form
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

        OleDbConnection conn;
        OleDbCommand cmd;
        OleDbDataAdapter adapter;

        private int loginAttempts = 0; // Counter for login attempts

        public Login()
        {
            InitializeComponent();
        }

        private void btn_Log_Click(object sender, EventArgs e)


        {
            /*

                        // Establish the connection string to connect to the Access database
                        conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"D:\\FOR CODES\\BOMS.accdb\"");

                        // SQL query to check if the username and password match
                        string query = "SELECT COUNT(*) FROM UserAcc WHERE Username = @username AND [Password] = @password";

                        // Create and configure the command
                        cmd = new OleDbCommand(query, conn);
                        cmd.Parameters.AddWithValue("@username", tb_User.Text);
                        cmd.Parameters.AddWithValue("@password", tb_Pass.Text);

                        // Open the connection
                        conn.Open();
                        int count = (int)cmd.ExecuteScalar(); // Execute the query and get the result


                        if (string.IsNullOrWhiteSpace(tb_User.Text) || string.IsNullOrWhiteSpace(tb_Pass.Text))
                        {
                            MessageBox.Show("Please fill in all fields.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                        if (count > 0)
                        {
                            // Close the login form and open Form1 if credentials are correct
                            this.Hide();
                            ADMIN_int form1 = new ADMIN_int();
                            form1.Show();
                        }
                        else
                        {
                            // Increment the login attempts and show an error message
                            loginAttempts++;
                            MessageBox.Show("Invalid username or password.", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            if (loginAttempts >= 3)
                            {
                                // Close the application if 3 failed login attempts
                                Application.Exit();
                            }
                        }*/

            // Establish the connection string to connect to the Access database
            conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"D:\\FOR CODES\\BOMS.accdb\"");

            // SQL query to check if the username and password match and retrieve the user type
            string query = "SELECT [Type] FROM CashierAcc WHERE Username = @username AND [Password] = @password";

            // Create and configure the command
            cmd = new OleDbCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", tb_User.Text);
            cmd.Parameters.AddWithValue("@password", tb_Pass.Text);

            try
            {
                // Open the connection
                conn.Open();

                // Execute the query and get the result
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    // The user exists, and we have retrieved the Type
                    string userType = result.ToString();

                    // Check the user type and open the corresponding form
                    this.Hide();

                    if (userType == "Admin")
                    {
                        ADMIN_int_Item_ form2 = new ADMIN_int_Item_();  // Admin Form
                        form2.Show();
                    }
                    else if (userType == "Staff")
                    {
                        ST_POS form3 = new ST_POS();  // Student Form
                        form3.Show();
                    }
                    else
                    {
                        MessageBox.Show("Unrecognized user type.");
                        this.Show(); // Show the login form again if type is unrecognized
                    }
                }
                else
                {
                    // Increment the login attempts and show an error message
                    loginAttempts++;
                    MessageBox.Show("Invalid username or password.");

                    if (loginAttempts >= 3)
                    {
                        // Close the application if 3 failed login attempts
                        Application.Exit();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Close the connection
                conn.Close();
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            tb_Pass.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Forget_Email form1 = new Forget_Email();
            form1.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            btn_Log.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_Log.Width, btn_Log.Height, 50, 50));
        }
    }
}
