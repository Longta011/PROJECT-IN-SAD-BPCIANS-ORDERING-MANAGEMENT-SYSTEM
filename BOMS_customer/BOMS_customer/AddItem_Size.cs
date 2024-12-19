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
    public partial class AddItem_Size : Form
    {
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= D:\FOR CODES\BOMS.accdb";
        private string imageFilePath = ""; // To store the selected image file path

        public AddItem_Size()
        {
            InitializeComponent();
        }




        private void priceTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddItem_Size_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Gather input data
            string productName = productnameTB.Text.Trim();
            decimal productPriceVS;
            decimal productPriceS;
            decimal productPriceM;
            decimal productPriceL;
            decimal productPriceXL;


            // Validate the product price input
            if (!decimal.TryParse(tbS.Text, out productPriceVS))
            {
                MessageBox.Show("Please enter a valid price.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(tbSS.Text, out productPriceS))
            {
                MessageBox.Show("Please enter a valid price.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(tbM.Text, out productPriceM))
            {
                MessageBox.Show("Please enter a valid price.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(tbL.Text, out productPriceL))
            {
                MessageBox.Show("Please enter a valid price.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(tbXL.Text, out productPriceXL))
            {
                MessageBox.Show("Please enter a valid price.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            // Category is now required
            string productCategory = tbcat.Text.Trim();

            // Check if any required field (product name, category, or image) is missing
            if (string.IsNullOrEmpty(productName) || string.IsNullOrEmpty(imageFilePath) || string.IsNullOrEmpty(productCategory))
            {
                MessageBox.Show("All fields are required.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Save the product to the database
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    // Update SQL query to insert into 'category' column instead of 'product_size'
                    string query = "INSERT INTO Products_Size (Product_name, Price_Size_VS,Price_Size_S,Price_Size_M,Price_Size_L,Price_Size_XL, Category, Picture, stock_status) " +
                                   "VALUES (@name, @priceVS,@priceS,@priceM,@priceL,@priceXL, @category, @imagePath, 'In Stock')";

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@name", productName);
                        command.Parameters.AddWithValue("@priceVS", productPriceVS);
                        command.Parameters.AddWithValue("@priceS", productPriceS);
                        command.Parameters.AddWithValue("@priceM", productPriceM);
                        command.Parameters.AddWithValue("@priceL", productPriceL);
                        command.Parameters.AddWithValue("@priceXL", productPriceXL);

                        command.Parameters.AddWithValue("@category", productCategory);  // Save to category column
                        command.Parameters.AddWithValue("@imagePath", imageFilePath);


                        command.ExecuteNonQuery();
                    }
                }

                // Clear fields after successful addition
                productnameTB.Clear();
                tbS.Clear();
                tbSS.Clear();
                tbXL.Clear();
                tbM.Clear();
                tbL.Clear();
                tbcat.Clear();  // Clear the category input as well
                productPictureBox.Image = null;
                imageFilePath = "";

                // Notify the user of success
                MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh the dashboard by calling LoadProductsToDashboard on the Dashboard form
                if (this.Owner != null && this.Owner is ADMIN_int_Item_ dashboard)
                {
                    dashboard.LoadProductsToDashboard();
                }

                // Close the addProduct form
                this.Close();
            }
            catch (Exception ex)
            {
                // Display error message if something goes wrong
                MessageBox.Show($"Error adding product: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void productPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void uploadImage_Click_1(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files (*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png",
                Title = "Select a Product Image"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imageFilePath = openFileDialog.FileName;
                productPictureBox.Image = Image.FromFile(imageFilePath); // Show the image in PictureBox
            }
        }
    }
}
