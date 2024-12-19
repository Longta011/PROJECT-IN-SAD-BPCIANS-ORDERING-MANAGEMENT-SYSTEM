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
    public partial class shop_deptShirt : Form
    {
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= D:\FOR CODES\BOMS.accdb";

        public shop_deptShirt()
        {
            InitializeComponent();
        }
        public void LoadProductsToDashboard()
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT Product_ID, Product_name, Price_Size_VS, Price_Size_S, Price_Size_M,Price_Size_L,Price_Size_XL,Picture, stock_status FROM Products_Size WHERE Category = 'Department' ";
                    OleDbCommand command = new OleDbCommand(query, connection);
                    OleDbDataReader reader = command.ExecuteReader();

                    dashboardPanel.FlowDirection = FlowDirection.LeftToRight;
                    dashboardPanel.WrapContents = true;
                    dashboardPanel.AutoScroll = true;

                    while (reader.Read())
                    {
                        int productId = reader.GetInt32(0);
                        string productName = reader["Product_name"]?.ToString() ?? "Unnamed Product";
                        decimal productPrice_VS = Convert.ToDecimal(reader["Price_Size_VS"]);
                        decimal productPrice_S = Convert.ToDecimal(reader["Price_Size_S"]);
                        decimal productPrice_M = Convert.ToDecimal(reader["Price_Size_M"]);
                        decimal productPrice_L = Convert.ToDecimal(reader["Price_Size_L"]);
                        decimal productPrice_XL = Convert.ToDecimal(reader["Price_Size_XL"]);

                        string productImagePath = reader["Picture"]?.ToString();

                        string stockStatus = reader["stock_status"]?.ToString() ?? "In Stocks";

                        Panel productPanel = new Panel
                        {
                            Width = 205,
                            Height = 300,
                            Margin = new Padding(15)
                        };

                        productPanel.Tag = new Tuple<int, string, string>(productId, stockStatus, productImagePath);

                        PictureBox pictureBox = new PictureBox
                        {
                            Width = productPanel.Width,
                            Height = 218,
                            SizeMode = PictureBoxSizeMode.Zoom,
                            Cursor = Cursors.Hand,
                            Dock = DockStyle.Top,
                        };

                        if (!string.IsNullOrEmpty(productImagePath) && File.Exists(productImagePath))
                        {
                            pictureBox.Image = Image.FromFile(productImagePath);
                        }
                        else
                        {
                            pictureBox.Image = Properties.Resources.Bpcian_s_Marketplace_removebg_preview;
                        }

                        if (stockStatus == "Out of Stock")
                        {
                            Bitmap dimmedImage = new Bitmap(pictureBox.Image);
                            using (Graphics g = Graphics.FromImage(dimmedImage))
                            {
                                using (Brush dimBrush = new SolidBrush(Color.FromArgb(100, Color.Black)))
                                {
                                    g.FillRectangle(dimBrush, new Rectangle(0, 0, dimmedImage.Width, dimmedImage.Height));
                                }
                            }
                            pictureBox.Image = dimmedImage;
                            Label outOfStockLabel = new Label
                            {
                                Text = "Out of Stock",
                                ForeColor = Color.Red,
                                Dock = DockStyle.Bottom,
                                TextAlign = ContentAlignment.MiddleCenter
                            };
                            productPanel.Controls.Add(outOfStockLabel);
                            pictureBox.Enabled = false;
                        }

                        else

                        {
                            pictureBox.Enabled = true;

                            pictureBox.Click += (s, e) =>
                            {
                                var ProductOption = new SIZES_ProductOptions
                                {
                                    ProductImage = pictureBox.Image,
                                    ProductName = productName,
                                    ProductPriceVS = productPrice_VS,
                                    ProductPriceS = productPrice_S,
                                    ProductPriceM = productPrice_M,
                                    ProductPriceL = productPrice_L,
                                    ProductPriceXL = productPrice_XL
                                };
                                ProductOption.Show();
                            };
                        }

                        Label nameLabel = new Label
                        {
                            Text = productName,
                            AutoSize = false,
                            TextAlign = ContentAlignment.MiddleCenter,
                            Height = 40,
                            Dock = DockStyle.Bottom,
                            Font = new Font("Tahoma", 11, FontStyle.Regular),
                        };

                        Label priceLabel = new Label
                        {
                            Text = $"₱{productPrice_VS:F2}",
                            AutoSize = false,
                            TextAlign = ContentAlignment.MiddleCenter,
                            Dock = DockStyle.Bottom,
                            Font = new Font("Tahoma", 10, FontStyle.Bold)
                        };

                        productPanel.Controls.Add(priceLabel);
                        productPanel.Controls.Add(pictureBox);
                        productPanel.Controls.Add(nameLabel);

                        dashboardPanel.Controls.Add(productPanel);
                    }

                    reader.Close();
                    dashboardPanel.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading products: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void shop_deptShirt_Load(object sender, EventArgs e)
        {
            LoadProductsToDashboard();
        }

        private void btn_About_Click(object sender, EventArgs e)
        {
            this.Hide();
            About_us about_Us = new About_us();
            about_Us.Show();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            this.Hide();
            shop_int form = new shop_int();
            form.Show();
        }

        private void btnUnif_Click(object sender, EventArgs e)
        {
            this.Hide();
            shop_SchoolUnif form = new shop_SchoolUnif();
            form.Show();
        }

        private void btnOthers_Click(object sender, EventArgs e)
        {
            this.Hide();
            shop_Others form = new shop_Others();
            form.Show();
        }

        private void btn_sizeG_Click(object sender, EventArgs e)
        {
            Size_guide Open = new Size_guide();
            Open.Show();
        }

        private void tbS_TextChanged(object sender, EventArgs e)
        {
          /*  try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    string searchQuery = "SELECT product_id, product_name, product_price, product_image, stock_status " +
                                         "FROM products WHERE category = 'Department Shirt' AND product_name LIKE @searchText";

                    using (OleDbCommand command = new OleDbCommand(searchQuery, connection))
                    {
                        command.Parameters.AddWithValue("@searchText", "%" + tbS.Text.Trim() + "%");

                        using (OleDbDataReader reader = command.ExecuteReader())
                        {
                            dashboardPanel.Controls.Clear();

                            while (reader.Read())
                            {
                                int productId = reader.GetInt32(0);
                                string productName = reader["product_name"]?.ToString() ?? "Unnamed Product";
                                decimal productPrice = Convert.ToDecimal(reader["product_price"]);
                                string productImagePath = reader["product_image"]?.ToString();
                                string stockStatus = reader["stock_status"]?.ToString() ?? "In Stock";

                                Panel productPanel = new Panel
                                {
                                    Width = 205,
                                    Height = 300,
                                    Margin = new Padding(15)
                                };

                                PictureBox pictureBox = new PictureBox
                                {
                                    Width = productPanel.Width,
                                    Height = 218,
                                    SizeMode = PictureBoxSizeMode.Zoom,
                                    Cursor = Cursors.Hand,
                                    Dock = DockStyle.Top,
                                };

                                if (!string.IsNullOrEmpty(productImagePath) && File.Exists(productImagePath))
                                {
                                    pictureBox.Image = Image.FromFile(productImagePath);
                                }
                                else
                                {
                                    pictureBox.Image = Properties.Resources.Bpcian_s_Marketplace_removebg_preview;
                                }

                                Label nameLabel = new Label
                                {
                                    Text = productName,
                                    AutoSize = false,
                                    TextAlign = ContentAlignment.MiddleCenter,
                                    Height = 40,
                                    Dock = DockStyle.Bottom,
                                    Font = new Font("Tahoma", 11, FontStyle.Regular),
                                };

                                Label priceLabel = new Label
                                {
                                    Text = $"₱{productPrice:F2}",
                                    AutoSize = false,
                                    TextAlign = ContentAlignment.MiddleCenter,
                                    Dock = DockStyle.Bottom,
                                    Font = new Font("Tahoma", 10, FontStyle.Bold)
                                };

                                productPanel.Controls.Add(priceLabel);
                                productPanel.Controls.Add(pictureBox);
                                productPanel.Controls.Add(nameLabel);

                                dashboardPanel.Controls.Add(productPanel);
                            }
                        }
                    }

                    dashboardPanel.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching products: {ex.Message}", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }
    }
}
