using Microsoft.VisualBasic;
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
    public partial class Order_Details : Form


    {
        public Image ProductImage { get; set; }
        public string ProductName { get; set; }

        
        public decimal ProductPrice { get; set; }

        public int Quantityy { get; set; } = 1;

        public int Quantity {  get; set; }
        public decimal BaseProductPrice { get; set; }
        public string ID { get; set; }



        public Order_Details()
        {
            InitializeComponent();
        }



        private void UpdateTotal()
        {
           

            // Calculate the total
            decimal total = (BaseProductPrice * Quantityy);

            // Update the total label
            totalLabel.Text = $"₱ {total:F2}";
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



        private void productImage_Click(object sender, EventArgs e)
        {

        }

        private void Order_Details_Load(object sender, EventArgs e)
        {
            productPictureBox.Image = ProductImage;
            productName.Text = ProductName;

            // Display ProductPrice which should now correctly reflect the base price + add-ons
            productPrice.Text = $"₱ {ProductPrice:F2}";
            quantityLabell.Text = Quantityy.ToString();
            dtbQuantity.Text = $"Stock: { Quantity}".ToString();


            UpdateTotal();
            AlignLabels();

        }

        private void increaseQtyBTN_Click(object sender, EventArgs e)
        {
            Quantityy++;
            quantityLabell.Text = Quantityy.ToString();
            UpdateTotal();
        }

        private void decreaseQtyBTN_Click(object sender, EventArgs e)
        {
            if (Quantityy > 1)
            {
                Quantityy--;
                quantityLabell.Text = Quantityy.ToString();
                UpdateTotal();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
          /*  var productOrderOptionForm = new ProductOption
            {
                ProductImage = ProductImage,
                ProductName = ProductName,
               *//* ProductPrice = BaseProductPrice // Reset to the original price*//*
            };

            productOrderOptionForm.Show();*/
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            /*if (Quantityy > Quantity )
            {
                MessageBox.Show("Invalid Number of orders");
            }

            else
            {

                decimal total = (BaseProductPrice * Quantityy);// Correct total calculation

                var orderSummaryForm = new OrderSummary
                {
                    ProductImage = ProductImage,
                    ProductName = ProductName,
                    BaseProductPrice = BaseProductPrice, // Ensure base price consistency
                    ProductPrice = ProductPrice,         // Keep the adjuste    d price with add-ons
                    Quantityy = Quantityy,
                    Total = (BaseProductPrice * Quantityy) + (ProductPrice - BaseProductPrice),
                    SpecialInstructions = specialTB.Text
                };

                orderSummaryForm.Show();
                this.Hide();  // Hide the current orderDetails form

            }*/

            if (Quantityy > Quantity)
            {
                MessageBox.Show("Innsufficient Stocks");
            }
            else
            {
                decimal total = (BaseProductPrice * Quantityy); // Correct total calculation

                var orderSummaryForm = new OrderSummary
                {
                    ProductImage = ProductImage,
                    ProductName = ProductName,
                    BaseProductPrice = BaseProductPrice, // Ensure base price consistency
                    ProductPrice = ProductPrice,         // Keep the adjusted price with add-ons
                    Quantityy = Quantityy,
                    Total = (BaseProductPrice * Quantityy) + (ProductPrice - BaseProductPrice),
                    SpecialInstructions = specialTB.Text
                };

                orderSummaryForm.Show();
                this.Hide();  // Hide the current orderDetails form
            }
        }


    }
}
