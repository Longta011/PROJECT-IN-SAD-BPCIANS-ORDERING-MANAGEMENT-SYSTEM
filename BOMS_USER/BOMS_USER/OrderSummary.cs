using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BOMS_USER
{
    public partial class OrderSummary : Form
    {
        public Image ProductImage { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; } // Current price (includes add-ons)
        public int Quantityy { get; set; }
        public string AddOns { get; set; }
        public string SpecialInstructions { get; set; }
        public decimal Total { get; set; }
        public decimal BaseProductPrice { get; set; }

        public OrderSummary()
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
            productName.Top = 300; // Adjust Y position for product name
            productPrice.Top = productName.Bottom + 10;
        }

        private void OrderSummary_Load(object sender, EventArgs e)
        {
            productPictureBox.Image = ProductImage;
            productName.Text = ProductName;
            productPrice.Text = $"₱ {ProductPrice:F2}"; // Use ProductPrice as the base price
            qtyLabel.Text = Quantityy.ToString();
            specialLabel.Text = SpecialInstructions;
            totalLabel.Text = $"₱ {Total:F2}"; // Use the passed Total value
            AlignLabels();
        }

        private void btnORDER_Click(object sender, EventArgs e)
        {
            var orderReceiptForm = new receipt
            {
                ProductImage = ProductImage,
                ProductName = ProductName,
                ProductPrice = ProductPrice,
                Quantityy = Quantityy,
                SpecialInstructions = SpecialInstructions,
                Total = Total
            };
            orderReceiptForm.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var orderDetailsForm = new Order_Details
            {
                ProductImage = ProductImage,                // Retain product image
                ProductName = ProductName,                  // Retain product name
                BaseProductPrice = BaseProductPrice,        // Pass the original base price
                ProductPrice = BaseProductPrice,            // Reset to the base product price
                                                            // Pass the add-ons
                
                Quantity = Quantityy                         // Retain the current quantity
            };

            // Reapply the add-ons to the ProductPrice
           

            // Show the orderDetails form
            orderDetailsForm.Show();
            this.Close();
        }
    }
}
