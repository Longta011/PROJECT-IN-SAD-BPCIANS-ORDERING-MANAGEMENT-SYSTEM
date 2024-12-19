using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BOMS_customer
{
    public partial class Forgot_OTP : Form
    {
        public Forgot_OTP()
        {
            InitializeComponent();
        }

        private void btn_Verify_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forgot_RP form1 = new Forgot_RP();
            form1.Show();
        }

        private void LL_backlog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login form1 = new Login();
            form1.Show();
        }
    }
}
