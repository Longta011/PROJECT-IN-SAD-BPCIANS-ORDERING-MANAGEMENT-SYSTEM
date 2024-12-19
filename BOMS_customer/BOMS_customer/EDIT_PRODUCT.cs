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
using System.IO; // For handling file and memory streams
using System.Runtime.InteropServices; // For working with images
using static BOMS_customer.ADMIN_int_Item_;

namespace BOMS_customer
{
    public partial class EDIT_PRODUCT : Form
    {
        private int productId;
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= D:\FOR CODES\BOMS.accdb";

        public EDIT_PRODUCT()
        {
            InitializeComponent();
            this.productId = productId;
            LoadProductDetails();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void LoadProductDetails()
        {
            // Code to load product details into the form fields
        }

        private void EDIT_PRODUCT_Load(object sender, EventArgs e)
        {

        }


    }


}
