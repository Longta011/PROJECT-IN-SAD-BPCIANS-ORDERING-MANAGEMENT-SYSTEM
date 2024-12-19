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
    public partial class SIZES_OrderDetails : Form
    {
        public Image ProductImage { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }

        public int Quantityy { get; set; } = 1;

        public int Quantity { get; set; }
        public decimal BaseProductPrice { get; set; }
        public string ID { get; set; }
        public decimal ProductPriceVS { get; set; }
        public decimal ProductPriceS { get; set; }
        public decimal ProductPriceM { get; set; }
        public decimal ProductPriceL { get; set; }
        public decimal ProductPriceXL { get; set; }
        public string FSize { get; set; }

        public SIZES_OrderDetails()
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

        private void SIZES_OrderDetails_Load(object sender, EventArgs e)
        {
            productPictureBox.Image = ProductImage;
            productName.Text = ProductName;

            // Display ProductPrice which should now correctly reflect the base price + add-ons
            productPrice.Text = $"₱ {ProductPrice:F2}";
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

        private void increaseQtyBTN_Click(object sender, EventArgs e)
        {
            Quantityy++;
            quantityLabell.Text = Quantityy.ToString();
            UpdateTotal();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var productOrderOptionForm = new SIZES_ProductOptions
            {
                ProductImage = ProductImage,
                ProductName = ProductName,
                ProductPrice = BaseProductPrice, // Reset to the original price
                ProductPriceVS = ProductPriceVS,
                ProductPriceS = ProductPriceS,
                ProductPriceM = ProductPriceM,
                ProductPriceL = ProductPriceL,
                ProductPriceXL = ProductPriceXL,

            };

            productOrderOptionForm.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal total = (BaseProductPrice * Quantityy); // Correct total calculation

            var orderSummaryForm = new SIZES_OrderSummary
            {
                ProductImage = ProductImage,
                ProductName = ProductName,
                BaseProductPrice = BaseProductPrice, // Ensure base price consistency
                ProductPrice = ProductPrice,         // Keep the adjusted price with add-ons
                Quantityy = Quantityy,
                Total = (BaseProductPrice * Quantityy) + (ProductPrice - BaseProductPrice),
                SpecialInstructions = specialTB.Text,
                FSize = FSize
            };

            orderSummaryForm.Show();
            this.Hide();  // Hide the current orderDetails form
        }
    }
}
