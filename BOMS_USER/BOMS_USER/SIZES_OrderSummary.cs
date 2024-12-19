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
    public partial class SIZES_OrderSummary : Form
    {
        public Image ProductImage { get; set; }
        public string ProductName { get; set; }
        public string FSize { get; set; }
        public decimal ProductPrice { get; set; } // Current price (includes add-ons)
        public int Quantityy { get; set; }
        public string AddOns { get; set; }
        public string SpecialInstructions { get; set; }
        public decimal Total { get; set; }
        public decimal BaseProductPrice { get; set; }
        public decimal ProductPriceVS { get; set; }
        public decimal ProductPriceS { get; set; }
        public decimal ProductPriceM { get; set; }
        
        public decimal ProductPriceL { get; set; }
        public decimal ProductPriceXL { get; set; }
        public SIZES_OrderSummary()
        {
            InitializeComponent();
        }

        private void SIZES_OrderSummary_Load(object sender, EventArgs e)
        {
            productPictureBox.Image = ProductImage;
            productName.Text = ProductName;
            productPrice.Text = $"₱ {ProductPrice:F2}"; // Use ProductPrice as the base price
            qtyLabel.Text = Quantityy.ToString();
            specialLabel.Text = SpecialInstructions;
            totalLabel.Text = $"₱ {Total:F2}"; // Use the passed Total value
            Size.Text = FSize;
        }

        private void btnORDER_Click(object sender, EventArgs e)
        {
            var orderReceiptForm = new SIZES_Receipt
            {
                ProductImage = ProductImage,
                ProductName = ProductName,
                ProductPrice = ProductPrice,
                Quantityy = Quantityy,
                SpecialInstructions = SpecialInstructions,
                Total = Total,
                FSize = FSize
            };
            orderReceiptForm.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var orderDetailsForm = new SIZES_OrderDetails
            {
                ProductImage = ProductImage,                // Retain product image
                ProductName = ProductName,                  // Retain product name
                BaseProductPrice = BaseProductPrice,        // Pass the original base price
                ProductPrice = BaseProductPrice,            // Reset to the base product price
                ProductPriceVS = ProductPriceVS,
                ProductPriceS = ProductPriceS,
                ProductPriceM = ProductPriceM,
                ProductPriceL = ProductPriceL,
                ProductPriceXL = ProductPriceXL,
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
