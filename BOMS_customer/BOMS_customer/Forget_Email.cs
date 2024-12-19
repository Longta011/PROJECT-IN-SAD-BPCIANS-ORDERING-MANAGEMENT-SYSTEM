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
    public partial class Forget_Email : Form
    {
        public Forget_Email()
        {
            InitializeComponent();
        }

        private void Forget_Email_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forgot_OTP form1 = new Forgot_OTP();
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
