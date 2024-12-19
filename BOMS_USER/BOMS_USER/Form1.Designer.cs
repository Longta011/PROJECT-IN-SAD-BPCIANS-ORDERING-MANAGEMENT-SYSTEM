namespace BOMS_USER
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.Windows.Forms.Timer timerClickhere;
            panel2 = new Panel();
            label2 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            panel3 = new Panel();
            labelBanner = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            timerClickhere = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // timerClickhere
            // 
            timerClickhere.Enabled = true;
            timerClickhere.Interval = 800;
            timerClickhere.Tick += timerClickhere_Tick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(73, 249);
            panel2.Name = "panel2";
            panel2.Size = new Size(676, 12);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Green;
            label2.Location = new Point(175, 181);
            label2.Name = "label2";
            label2.Size = new Size(483, 65);
            label2.TabIndex = 1;
            label2.Text = "ORDER AND PAY";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(59, 125, 35);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(-3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1654, 143);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 28F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(143, 35);
            label4.Name = "label4";
            label4.Size = new Size(1274, 65);
            label4.TabIndex = 1;
            label4.Text = "BPCIANS ORDERING MANAGEMENT SYSTEM\r\n";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(59, 125, 35);
            panel3.Controls.Add(labelBanner);
            panel3.Location = new Point(-3, 780);
            panel3.Name = "panel3";
            panel3.Size = new Size(1654, 105);
            panel3.TabIndex = 1;
            // 
            // labelBanner
            // 
            labelBanner.AutoSize = true;
            labelBanner.BackColor = Color.Transparent;
            labelBanner.Font = new Font("Arial Rounded MT Bold", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelBanner.ForeColor = Color.White;
            labelBanner.Location = new Point(571, 34);
            labelBanner.Name = "labelBanner";
            labelBanner.Size = new Size(435, 46);
            labelBanner.TabIndex = 4;
            labelBanner.Text = "click here to proceed";
            labelBanner.TextAlign = ContentAlignment.TopCenter;
            labelBanner.Click += labelBanner_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Picsart_24_10_28_11_02_01_370_removebg_preview;
            pictureBox1.Location = new Point(85, 267);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(654, 507);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.Bpcian_s_Marketplace_removebg_preview;
            pictureBox2.Location = new Point(834, 194);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(615, 523);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1601, 884);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(panel3);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "INTRO FOR SHOP";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel2;
        private Label label2;
        private Panel panel1;
        private Panel panel3;
        private Label label4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private System.Windows.Forms.Timer timerClickhere;
        private Label labelBanner;
    }
}
