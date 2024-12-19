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
    public partial class ADMIN_int_Others_ : Form
    {
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= D:\FOR CODES\BOMS.accdb";

        public ADMIN_int_Others_()
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
                    string query = "SELECT product_id, product_name, product_price, product_image, stock_status FROM products";
                    OleDbCommand command = new OleDbCommand(query, connection);
                    OleDbDataReader reader = command.ExecuteReader();

                    dashboardPanel.FlowDirection = FlowDirection.LeftToRight;
                    dashboardPanel.WrapContents = true;
                    dashboardPanel.AutoScroll = true;

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

                    reader.Close();
                    dashboardPanel.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading products: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            this.Hide();
            ADMIN_int_Item_ form1 = new ADMIN_int_Item_();
            form1.Show();
        }

        private void btnDept_Click(object sender, EventArgs e)
        {
            this.Hide();
            ADMIN_int_DEPTSHIRT_ form1 = new ADMIN_int_DEPTSHIRT_();
            form1.Show();
        }

        private void btnSchool_Click(object sender, EventArgs e)
        {
            this.Hide();
            ADMIN_int_SchoolUnif_ form1 = new ADMIN_int_SchoolUnif_();
            form1.Show();
        }

        private void btnOthers_Click(object sender, EventArgs e)
        {

        }

        private void ADMIN_int_Others__Load(object sender, EventArgs e)
        {
            LoadProductsToDashboard();
        }



        private void btn_Acc_Click(object sender, EventArgs e)
        {
            this.Hide();
            ADMIN_int form1 = new ADMIN_int();
            form1.Show();
        }

        private void btn_Order_Click(object sender, EventArgs e)
        {

            this.Hide();
            ADMIN_int_Order_ form1 = new ADMIN_int_Order_();
            form1.Show();
        }

        private void btn_Attend_Click(object sender, EventArgs e)
        {
            this.Hide();
            ADMIN_int_attendace_ form1 = new ADMIN_int_attendace_();
            form1.Show();
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            this.Hide();
            ADMIN_SUPPLIER form1 = new ADMIN_SUPPLIER();
            form1.Show();
        }

        private void btn_Item_Click(object sender, EventArgs e)
        {
            /* this.Hide();
             ADMIN_int_Item_ form1 = new ADMIN_int_Item_();
             form1.Show();*/
        }

        private void LL_PROFILE_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ADMIN_Profile form1 = new ADMIN_Profile();
            form1.Show();
        }

        private void tbS_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    string searchQuery = "SELECT product_id, product_name, product_price, product_image, stock_status " +
                                         "FROM products WHERE category = 'Others' AND product_name LIKE @searchText";

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
            }
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            this.Hide();
            INVENTORY form1 = new INVENTORY();
            form1.Show();
        }

        private void dashboardPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddItem_Size form1 = new AddItem_Size();
            form1.Show();
        }
    }
}

