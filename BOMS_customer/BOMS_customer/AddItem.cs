using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace BOMS_customer
{
    public partial class AddItem : Form
    {
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= D:\FOR CODES\BOMS.accdb";
        private string imageFilePath = ""; // To store the selected image file path
        public AddItem()
        {
            InitializeComponent();
        }

        private void uploadImage_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            // Gather input data
            string productName = productnameTB.Text.Trim();
            decimal productPrice;
            decimal productquantity;

            // Validate the product price input
            if (!decimal.TryParse(priceTB.Text, out productPrice))
            {
                MessageBox.Show("Please enter a valid price.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(tbtbtb.Text, out productquantity))
            {
                MessageBox.Show("Please enter a valid price.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Category is now required
            string productCategory = categoryTB.Text.Trim();

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
                    string query = "INSERT INTO products (product_name, product_price, category, product_image, stock_status, Quantity) " +
                                   "VALUES (@name, @price, @category, @imagePath, 'In Stock', @q)";

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@name", productName);
                        command.Parameters.AddWithValue("@price", productPrice);
                        command.Parameters.AddWithValue("@category", productCategory);  // Save to category column
                        command.Parameters.AddWithValue("@imagePath", imageFilePath);
                        command.Parameters.AddWithValue("@q", productquantity);

                        command.ExecuteNonQuery();
                    }
                }

                // Clear fields after successful addition
                productnameTB.Clear();
                priceTB.Clear();
                categoryTB.Clear();  // Clear the category input as well
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

        private void AddItem_Load(object sender, EventArgs e)
        {

        }
    }
}
