using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BOMS_USER
{
    public partial class SIZES_ProductOptions : Form
    {
        public Image ProductImage { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPriceVS { get; set; }
        public decimal ProductPriceS { get; set; }
        public decimal ProductPriceM { get; set; }
        public decimal ProductPrice { get; set; }
        public decimal ProductPriceL { get; set; }
        public decimal ProductPriceXL { get; set; }
        public int Quantity { get; set; }

        public string FSize { get; set; }

        public int Quantityy { get; set; }


        public SIZES_ProductOptions()
        {
            InitializeComponent();
        }

        private void SIZES_ProductOptions_Load(object sender, EventArgs e)
        {
            cbSize.Items.Add("Very Small");
            cbSize.Items.Add("Small");
            cbSize.Items.Add("Medium");
            cbSize.Items.Add("Large");
            cbSize.Items.Add("Extra Large");

            productPictureBox.Image = ProductImage;
            productName.Text = ProductName;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check which size is selected and display the corresponding price
            decimal selectedPrice = 350;

            string selectedSize = ""; // To store the selected size

            switch (cbSize.SelectedItem.ToString())
            {
                case "Very Small":
                    selectedPrice = ProductPriceVS;
                    selectedSize = "Very Small";
                    break;
                case "Small":
                    selectedPrice = ProductPriceS;
                    selectedSize = "Small";
                    break;
                case "Medium":
                    selectedPrice = ProductPriceM;
                    selectedSize = "Medium";
                    break;
                case "Large":
                    selectedPrice = ProductPriceL;
                    selectedSize = "Large";
                    break;
                case "Extra Large":
                    selectedPrice = ProductPriceXL;
                    selectedSize = "Extra Large";
                    break;
            }

            // Update the label to show the price
            productPrice.Text = $"Price: ₱{selectedPrice:F2}";
            ProductPrice = selectedPrice;

            // Update the label to show the selected size
            Size.Text = $"Size: {selectedSize}";

            FSize = selectedSize;
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

            var orderDetailsForm = new SIZES_OrderDetails
            {
                ProductImage = ProductImage,      // Set the product image
                ProductName = ProductName,        // Set the product name
                BaseProductPrice = ProductPrice,  // Pass the current ProductPrice as BaseProductPrice
                ProductPrice = ProductPrice,      // Initialize ProductPrice with the correct value
                ProductPriceVS = ProductPriceVS,
                ProductPriceS = ProductPriceS,
                ProductPriceM = ProductPriceM,
                ProductPriceL = ProductPriceL,
                ProductPriceXL = ProductPriceXL,
                Quantityy = 1,                 // Default quantity is 1
                /* Quantity = Quantity*/
                FSize = FSize

            };

            orderDetailsForm.Show();
            this.Close();
        }
    }
}

