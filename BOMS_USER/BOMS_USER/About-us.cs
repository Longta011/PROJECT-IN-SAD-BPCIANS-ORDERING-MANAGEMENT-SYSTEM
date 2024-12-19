using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BOMS_USER
{
    public partial class About_us : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeft,
           int nTop,
           int nRight,
           int nBottom,
           int nWidthEllipse,
           int nHeightEllipse

        );

        public About_us()
        {
            InitializeComponent();
        }

        private void btn_sizeG_Click(object sender, EventArgs e)
        {
            Size_guide Open = new Size_guide();
            Open.Show();
        }

        

        private void About_us_Load(object sender, EventArgs e)
        {


        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            shop_int Open = new shop_int();
            Open.Show();
        }
    }
}
