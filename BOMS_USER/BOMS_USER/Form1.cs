using Microsoft.VisualBasic.ApplicationServices;
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
using static System.Windows.Forms.DataFormats;


namespace BOMS_USER
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int num = 0;

        private void panel_intro_Paint(object sender, PaintEventArgs e)
        {

        }







       

            private void timerClickhere_Tick(object sender, EventArgs e)
            {
                if (num == 0)
            {
                labelBanner.ForeColor = Color.Gold;
                num++;
                }
                else if (num == 1)
            {
                labelBanner.ForeColor = Color.White;
                num--;
                }
            }

        private void labelBanner_Click(object sender, EventArgs e)
        {
            shop_int logoutForm = new shop_int();
            logoutForm.Show();
            this.Hide();
        }
    }
}
