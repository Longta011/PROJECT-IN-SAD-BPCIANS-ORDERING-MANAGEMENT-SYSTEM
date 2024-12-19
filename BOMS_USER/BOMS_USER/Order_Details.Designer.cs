namespace BOMS_USER
{
    partial class Order_Details
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
            productPictureBox = new PictureBox();
            productName = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            productPrice = new Label();
            increaseQtyBTN = new PictureBox();
            decreaseQtyBTN = new PictureBox();
            button1 = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            label2 = new Label();
            totalLabel = new Label();
            label3 = new Label();
            specialTB = new TextBox();
            quantityLabell = new Label();
            dtbQuantity = new Label();
            ((System.ComponentModel.ISupportInitialize)productPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)increaseQtyBTN).BeginInit();
            ((System.ComponentModel.ISupportInitialize)decreaseQtyBTN).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // productPictureBox
            // 
            productPictureBox.Location = new Point(135, 83);
            productPictureBox.Name = "productPictureBox";
            productPictureBox.Size = new Size(233, 188);
            productPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            productPictureBox.TabIndex = 9;
            productPictureBox.TabStop = false;
            productPictureBox.Click += productImage_Click;
            // 
            // productName
            // 
            productName.AutoSize = true;
            productName.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            productName.Location = new Point(172, 293);
            productName.Name = "productName";
            productName.Size = new Size(143, 26);
            productName.TabIndex = 8;
            productName.Text = "Dept Shirt, M";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(155, 23);
            label1.Name = "label1";
            label1.Size = new Size(198, 43);
            label1.TabIndex = 7;
            label1.Text = "PRODUCT";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.back_removebg_preview;
            pictureBox2.Location = new Point(39, 23);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(59, 51);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // productPrice
            // 
            productPrice.AutoSize = true;
            productPrice.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            productPrice.Location = new Point(210, 334);
            productPrice.Name = "productPrice";
            productPrice.Size = new Size(76, 26);
            productPrice.TabIndex = 11;
            productPrice.Text = "₱: 350";
            // 
            // increaseQtyBTN
            // 
            increaseQtyBTN.Image = Properties.Resources.plus_sign_removebg_preview;
            increaseQtyBTN.Location = new Point(276, 415);
            increaseQtyBTN.Name = "increaseQtyBTN";
            increaseQtyBTN.Size = new Size(55, 57);
            increaseQtyBTN.SizeMode = PictureBoxSizeMode.StretchImage;
            increaseQtyBTN.TabIndex = 12;
            increaseQtyBTN.TabStop = false;
            increaseQtyBTN.Click += increaseQtyBTN_Click;
            // 
            // decreaseQtyBTN
            // 
            decreaseQtyBTN.Image = Properties.Resources.minus_removebg_preview;
            decreaseQtyBTN.Location = new Point(172, 426);
            decreaseQtyBTN.Name = "decreaseQtyBTN";
            decreaseQtyBTN.Size = new Size(37, 37);
            decreaseQtyBTN.SizeMode = PictureBoxSizeMode.StretchImage;
            decreaseQtyBTN.TabIndex = 13;
            decreaseQtyBTN.TabStop = false;
            decreaseQtyBTN.Click += decreaseQtyBTN_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.ForeColor = Color.White;
            button1.ImageAlign = ContentAlignment.TopLeft;
            button1.Location = new Point(155, 659);
            button1.Name = "button1";
            button1.Size = new Size(185, 50);
            button1.TabIndex = 15;
            button1.Text = " ORDER";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(0, 735);
            panel1.Name = "panel1";
            panel1.Size = new Size(519, 10);
            panel1.TabIndex = 16;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(501, -8);
            panel2.Name = "panel2";
            panel2.Size = new Size(15, 750);
            panel2.TabIndex = 17;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(0, -5);
            panel3.Name = "panel3";
            panel3.Size = new Size(16, 750);
            panel3.TabIndex = 18;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Location = new Point(4, 9);
            panel4.Name = "panel4";
            panel4.Size = new Size(519, 15);
            panel4.TabIndex = 17;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Black;
            panel5.Location = new Point(4, -1);
            panel5.Name = "panel5";
            panel5.Size = new Size(509, 10);
            panel5.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(172, 487);
            label2.Name = "label2";
            label2.Size = new Size(69, 26);
            label2.TabIndex = 19;
            label2.Text = "Total:";
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalLabel.Location = new Point(246, 487);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(40, 26);
            totalLabel.TabIndex = 20;
            totalLabel.Text = "₱: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(106, 546);
            label3.Name = "label3";
            label3.Size = new Size(286, 26);
            label3.TabIndex = 21;
            label3.Text = "ENTER YOUR SCHOOL ID";
            // 
            // specialTB
            // 
            specialTB.Location = new Point(106, 592);
            specialTB.Name = "specialTB";
            specialTB.Size = new Size(274, 31);
            specialTB.TabIndex = 22;
            // 
            // quantityLabell
            // 
            quantityLabell.AutoSize = true;
            quantityLabell.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            quantityLabell.Location = new Point(233, 426);
            quantityLabell.Name = "quantityLabell";
            quantityLabell.Size = new Size(26, 29);
            quantityLabell.TabIndex = 23;
            quantityLabell.Text = "1";
            // 
            // dtbQuantity
            // 
            dtbQuantity.AutoSize = true;
            dtbQuantity.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtbQuantity.Location = new Point(210, 373);
            dtbQuantity.Name = "dtbQuantity";
            dtbQuantity.Size = new Size(76, 26);
            dtbQuantity.TabIndex = 24;
            dtbQuantity.Text = "₱: 350";
            // 
            // Order_Details
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(515, 743);
            Controls.Add(dtbQuantity);
            Controls.Add(quantityLabell);
            Controls.Add(specialTB);
            Controls.Add(label3);
            Controls.Add(totalLabel);
            Controls.Add(label2);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(decreaseQtyBTN);
            Controls.Add(increaseQtyBTN);
            Controls.Add(productPrice);
            Controls.Add(pictureBox2);
            Controls.Add(productPictureBox);
            Controls.Add(productName);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Order_Details";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Order_Details";
            Load += Order_Details_Load;
            ((System.ComponentModel.ISupportInitialize)productPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)increaseQtyBTN).EndInit();
            ((System.ComponentModel.ISupportInitialize)decreaseQtyBTN).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox productPictureBox;
        private Label productName;
        private Label label1;
        private PictureBox pictureBox2;
        private Label productPrice;
        private PictureBox increaseQtyBTN;
        private PictureBox decreaseQtyBTN;
        private Label textBox1;
        private Button button1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Label label2;
        private Label totalLabel;
        private Label label3;
        private TextBox specialTB;
        private Label quantityLabel;
       
        private Label quantityLabell;
        private Label dtbQuantity;
    }
}