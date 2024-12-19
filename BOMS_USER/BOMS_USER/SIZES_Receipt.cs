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

namespace BOMS_USER
{
    public partial class SIZES_Receipt : Form
    {
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= D:\FOR CODES\BOMS.accdb";
        public Image ProductImage { get; set; }
        public string ProductName { get; set; }
        public string FSize { get; set; }
        public decimal ProductPrice { get; set; } // Current price (includes add-ons)
        public int Quantityy { get; set; }
        public string AddOns { get; set; }
        public string SpecialInstructions { get; set; }
        public decimal Total { get; set; }
        public decimal BaseProductPrice { get; set; }

        public SIZES_Receipt()
        {
            InitializeComponent();
        }

        private void SaveOrderToDatabase(int orderId)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO orders ([Order ID], [Order List and Quantity],Total, [Status], [Date and Time]) " +
                               "VALUES (@orderId, @orderListQuantity, @total, @status, @dateTime)";
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    // Concatenate product name and quantity for "Order List and Quantity"
                    string orderListQuantity = $"{ProductName} ({FSize}) - {Quantityy} pcs";

                    // Default status
                    string status = "On process";

                    // Get the current date and time
                    DateTime currentDateTime = DateTime.Now;

                    // Add parameters
                    command.Parameters.AddWithValue("@orderId", orderId);
                    command.Parameters.AddWithValue("@orderListQuantity", orderListQuantity);
                    command.Parameters.AddWithValue("@total", Total);
                    command.Parameters.AddWithValue("@status", status);

                    // Add the DateTime parameter with correct type
                    OleDbParameter dateTimeParam = new OleDbParameter("@dateTime", OleDbType.Date);
                    dateTimeParam.Value = currentDateTime;
                    command.Parameters.Add(dateTimeParam);

                    // Execute query
                    command.ExecuteNonQuery();


                }

                /* // Update the products table to reduce the quantity
                 string updateQuery = "UPDATE products SET Quantity = Quantity - @orderQuantity WHERE [product_name] = @productName";
                 using (OleDbCommand updateCommand = new OleDbCommand(updateQuery, connection))
                 {
                     updateCommand.Parameters.AddWithValue("@orderQuantity", Quantityy);
                     updateCommand.Parameters.AddWithValue("@productName", ProductName);

                     updateCommand.ExecuteNonQuery();
                 }*/

            }
        }

        private void SIZES_Receipt_Load(object sender, EventArgs e)
        {
            productPictureBox.Image = ProductImage;
            productName.Text = ProductName;
            productPrice.Text = $"₱ {ProductPrice:F2}";
            qtyLabel.Text = Quantityy.ToString();

            specialLabel.Text = SpecialInstructions;
            totalLabel.Text = $"₱ {Total:F2}";
            Size.Text = FSize;
            // Generate Order ID
            Random random = new Random();
            int orderId = random.Next(100, 1000);
            orderIdLabel.Text = orderId.ToString();

            // Save to database
            SaveOrderToDatabase(orderId);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Restart();
            this.Close();
            /*this.Refresh();*/
        }
    }
}
