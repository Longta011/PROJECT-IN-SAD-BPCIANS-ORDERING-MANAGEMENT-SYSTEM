namespace BOMS_USER
{
    partial class ProductOption
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
            label1 = new Label();
            productName = new Label();
            orderBTN = new Button();
            productPrice = new Label();
            pictureBox2 = new PictureBox();
            productPictureBox = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productPictureBox).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(179, 33);
            label1.Name = "label1";
            label1.Size = new Size(198, 43);
            label1.TabIndex = 0;
            label1.Text = "PRODUCT";
            label1.Click += label1_Click;
            // 
            // productName
            // 
            productName.AutoSize = true;
            productName.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            productName.Location = new Point(194, 344);
            productName.Name = "productName";
            productName.Size = new Size(143, 26);
            productName.TabIndex = 2;
            productName.Text = "Dept Shirt, M";
            // 
            // orderBTN
            // 
            orderBTN.BackColor = Color.Green;
            orderBTN.ForeColor = Color.White;
            orderBTN.Location = new Point(191, 443);
            orderBTN.Name = "orderBTN";
            orderBTN.Size = new Size(164, 65);
            orderBTN.TabIndex = 3;
            orderBTN.Text = "CONFIRM";
            orderBTN.UseVisualStyleBackColor = false;
            orderBTN.Click += orderBTN_Click;
            // 
            // productPrice
            // 
            productPrice.AutoSize = true;
            productPrice.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            productPrice.Location = new Point(223, 390);
            productPrice.Name = "productPrice";
            productPrice.Size = new Size(76, 26);
            productPrice.TabIndex = 4;
            productPrice.Text = "₱: 100";
            productPrice.Click += productPrice_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.back_removebg_preview;
            pictureBox2.Location = new Point(21, 33);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(59, 51);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // productPictureBox
            // 
            productPictureBox.Location = new Point(161, 88);
            productPictureBox.Name = "productPictureBox";
            productPictureBox.Size = new Size(216, 206);
            productPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            productPictureBox.TabIndex = 6;
            productPictureBox.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(0, 560);
            panel1.Name = "panel1";
            panel1.Size = new Size(537, 10);
            panel1.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(-2, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(537, 10);
            panel2.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(529, -1);
            panel3.Name = "panel3";
            panel3.Size = new Size(10, 571);
            panel3.TabIndex = 8;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Location = new Point(-2, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(10, 564);
            panel4.TabIndex = 9;
            // 
            // ProductOption
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(537, 567);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(productPictureBox);
            Controls.Add(pictureBox2);
            Controls.Add(productPrice);
            Controls.Add(orderBTN);
            Controls.Add(productName);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProductOption";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProductOption";
            Load += ProductOption_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)productPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label productName;
        private Button orderBTN;
        private Label productPrice;
        private PictureBox pictureBox2;
        private PictureBox productPictureBox;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
    }
}