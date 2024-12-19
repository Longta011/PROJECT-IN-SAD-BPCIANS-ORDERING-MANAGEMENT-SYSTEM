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

namespace BOMS_USER
{
    public partial class ProductOption : Form
    {
        public Image ProductImage { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public int Quantity { get; set; }

        public int Quantityy { get; set; }

        public ProductOption()
        {
            InitializeComponent();
        }


        private void AlignLabels()
        {
            productName.Width = 300; // Set a width for the name label (you can adjust this value as needed)
            productName.Location = new Point((this.Width - productName.Width) / 2, productName.Location.Y);

            // Center-align the product price label horizontally
            productPrice.Width = 300; // Set a width for the price label (you can adjust this value as needed)
            productPrice.Location = new Point((this.Width - productPrice.Width) / 2, productPrice.Location.Y);

            // Optional: Adjust the Y-positions of the labels if necessary to make them look better
            productName.Top = 350; // Adjust Y position for product name
            productPrice.Top = productName.Bottom + 10;
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ProductOption_Load(object sender, EventArgs e)
        {

            productPictureBox.Image = ProductImage;
            productName.Text = ProductName;
            productPrice.Text = $"₱ {ProductPrice:F2}";
            AlignLabels();
        }

        private void orderBTN_Click(object sender, EventArgs e)
        {
            // Ensure ProductPrice is initialized correctly
            // Ensure ProductPrice is correctly set before navigating to the next form
            if (ProductPrice <= 0)
            {
                MessageBox.Show("Invalid product price. Please ensure the price is set correctly.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var orderDetailsForm = new Order_Details
            {
                ProductImage = ProductImage,      // Set the product image
                ProductName = ProductName,        // Set the product name
                BaseProductPrice = ProductPrice,  // Pass the current ProductPrice as BaseProductPrice
                ProductPrice = ProductPrice,      // Initialize ProductPrice with the correct value
                Quantityy = 1,                 // Default quantity is 1
                Quantity = Quantity

            };

            orderDetailsForm.Show();
            this.Close();
        }

        private void productPrice_Click(object sender, EventArgs e)
        {

        }
    }
}
