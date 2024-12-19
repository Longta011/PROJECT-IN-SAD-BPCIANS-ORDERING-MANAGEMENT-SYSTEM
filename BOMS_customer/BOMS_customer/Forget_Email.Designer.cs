namespace BOMS_customer
{
    partial class Forget_Email
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
            label1 = new Label();
            textBox1 = new TextBox();
            LL_backlog = new LinkLabel();
            btn_Send = new Button();
            label2 = new Label();
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
            panel1.Location = new Point(573, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(570, 596);
            panel1.TabIndex = 1;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto Condensed", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(228, 158);
            label1.Name = "label1";
            label1.Size = new Size(113, 43);
            label1.TabIndex = 2;
            label1.Text = "EMAIL";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(88, 222);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "kuyaStevenpogi123@gmail.com";
            textBox1.Size = new Size(382, 35);
            textBox1.TabIndex = 3;
            // 
            // LL_backlog
            // 
            LL_backlog.AutoSize = true;
            LL_backlog.LinkColor = Color.Black;
            LL_backlog.Location = new Point(228, 273);
            LL_backlog.Name = "LL_backlog";
            LL_backlog.Size = new Size(116, 25);
            LL_backlog.TabIndex = 4;
            LL_backlog.TabStop = true;
            LL_backlog.Text = "back to login";
            LL_backlog.LinkClicked += LL_backlog_LinkClicked;
            // 
            // btn_Send
            // 
            btn_Send.Font = new Font("Arial Narrow", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Send.Location = new Point(197, 348);
            btn_Send.Name = "btn_Send";
            btn_Send.Size = new Size(164, 49);
            btn_Send.TabIndex = 5;
            btn_Send.Text = "SEND";
            btn_Send.UseVisualStyleBackColor = true;
            btn_Send.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(151, 562);
            label2.Name = "label2";
            label2.Size = new Size(260, 22);
            label2.TabIndex = 6;
            label2.Text = "Note: Enter your correct  Email for OTP";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(122, 21);
            label4.Name = "label4";
            label4.Size = new Size(337, 60);
            label4.TabIndex = 12;
            label4.Text = "HELLO ADMIN";
            // 
            // Forget_Email
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(214, 235, 210);
            ClientSize = new Size(1143, 593);
            Controls.Add(label2);
            Controls.Add(btn_Send);
            Controls.Add(LL_backlog);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Forget_Email";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Forget_Email";
            Load += Forget_Email_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox textBox1;
        private LinkLabel LL_backlog;
        private Button btn_Send;
        private Label label2;
        private Label label4;
    }
}