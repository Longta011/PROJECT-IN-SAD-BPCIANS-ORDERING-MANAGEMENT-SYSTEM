namespace BOMS_customer
{
    partial class Forgot_OTP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btn_Verify = new Button();
            LL_backlog = new LinkLabel();
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            linkLabel1 = new LinkLabel();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(180, 229, 162);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(574, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(570, 596);
            panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Bpcian_s_Marketplace_removebg_preview;
            pictureBox1.Location = new Point(33, 84);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(490, 481);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btn_Verify
            // 
            btn_Verify.Font = new Font("Arial Narrow", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Verify.Location = new Point(199, 348);
            btn_Verify.Name = "btn_Verify";
            btn_Verify.Size = new Size(164, 49);
            btn_Verify.TabIndex = 10;
            btn_Verify.Text = "VERIFY";
            btn_Verify.UseVisualStyleBackColor = true;
            btn_Verify.Click += btn_Verify_Click;
            // 
            // LL_backlog
            // 
            LL_backlog.AutoSize = true;
            LL_backlog.LinkColor = Color.Black;
            LL_backlog.Location = new Point(222, 416);
            LL_backlog.Name = "LL_backlog";
            LL_backlog.Size = new Size(116, 25);
            LL_backlog.TabIndex = 9;
            LL_backlog.TabStop = true;
            LL_backlog.Text = "back to login";
            LL_backlog.LinkClicked += LL_backlog_LinkClicked;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(158, 221);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(56, 35);
            textBox1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto Condensed", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(236, 158);
            label1.Name = "label1";
            label1.Size = new Size(80, 43);
            label1.TabIndex = 7;
            label1.Text = "OTP";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(220, 221);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(56, 35);
            textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(282, 221);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(56, 35);
            textBox3.TabIndex = 13;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(344, 221);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(56, 35);
            textBox4.TabIndex = 14;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(232, 274);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(106, 25);
            linkLabel1.TabIndex = 15;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Resend OTP";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(118, 21);
            label4.Name = "label4";
            label4.Size = new Size(337, 60);
            label4.TabIndex = 16;
            label4.Text = "HELLO ADMIN";
            // 
            // Forgot_OTP
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(214, 235, 210);
            ClientSize = new Size(1143, 593);
            Controls.Add(linkLabel1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(btn_Verify);
            Controls.Add(LL_backlog);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Forgot_OTP";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Forgot_OTP";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btn_Verify;
        private LinkLabel LL_backlog;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private LinkLabel linkLabel1;
        private Label label4;
    }
}