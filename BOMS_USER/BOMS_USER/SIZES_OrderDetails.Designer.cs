namespace BOMS_USER
{
    partial class SIZES_OrderDetails
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
            dtbQuantity = new Label();
            quantityLabell = new Label();
            specialTB = new TextBox();
            label3 = new Label();
            totalLabel = new Label();
            label2 = new Label();
            button1 = new Button();
            decreaseQtyBTN = new PictureBox();
            increaseQtyBTN = new PictureBox();
            productPrice = new Label();
            pictureBox2 = new PictureBox();
            productPictureBox = new PictureBox();
            productName = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)decreaseQtyBTN).BeginInit();
            ((System.ComponentModel.ISupportInitialize)increaseQtyBTN).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productPictureBox).BeginInit();
            SuspendLayout();
            // 
            // dtbQuantity
            // 
            dtbQuantity.AutoSize = true;
            dtbQuantity.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtbQuantity.Location = new Point(211, 372);
            dtbQuantity.Name = "dtbQuantity";
            dtbQuantity.Size = new Size(55, 26);
            dtbQuantity.TabIndex = 38;
            dtbQuantity.Text = "Size";
            // 
            // quantityLabell
            // 
            quantityLabell.AutoSize = true;
            quantityLabell.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            quantityLabell.Location = new Point(234, 425);
            quantityLabell.Name = "quantityLabell";
            quantityLabell.Size = new Size(26, 29);
            quantityLabell.TabIndex = 37;
            quantityLabell.Text = "1";
            // 
            // specialTB
            // 
            specialTB.Location = new Point(107, 591);
            specialTB.Name = "specialTB";
            specialTB.Size = new Size(274, 31);
            specialTB.TabIndex = 36;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(107, 545);
            label3.Name = "label3";
            label3.Size = new Size(286, 26);
            label3.TabIndex = 35;
            label3.Text = "ENTER YOUR SCHOOL ID";
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalLabel.Location = new Point(247, 486);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(40, 26);
            totalLabel.TabIndex = 34;
            totalLabel.Text = "₱: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(173, 486);
            label2.Name = "label2";
            label2.Size = new Size(69, 26);
            label2.TabIndex = 33;
            label2.Text = "Total:";
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.ForeColor = Color.White;
            button1.ImageAlign = ContentAlignment.TopLeft;
            button1.Location = new Point(156, 658);
            button1.Name = "button1";
            button1.Size = new Size(185, 50);
            button1.TabIndex = 32;
            button1.Text = " ORDER";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // decreaseQtyBTN
            // 
            decreaseQtyBTN.Image = Properties.Resources.minus_removebg_preview;
            decreaseQtyBTN.Location = new Point(173, 425);
            decreaseQtyBTN.Name = "decreaseQtyBTN";
            decreaseQtyBTN.Size = new Size(37, 37);
            decreaseQtyBTN.SizeMode = PictureBoxSizeMode.StretchImage;
            decreaseQtyBTN.TabIndex = 31;
            decreaseQtyBTN.TabStop = false;
            decreaseQtyBTN.Click += decreaseQtyBTN_Click;
            // 
            // increaseQtyBTN
            // 
            increaseQtyBTN.Image = Properties.Resources.plus_sign_removebg_preview;
            increaseQtyBTN.Location = new Point(277, 414);
            increaseQtyBTN.Name = "increaseQtyBTN";
            increaseQtyBTN.Size = new Size(55, 57);
            increaseQtyBTN.SizeMode = PictureBoxSizeMode.StretchImage;
            increaseQtyBTN.TabIndex = 30;
            increaseQtyBTN.TabStop = false;
            increaseQtyBTN.Click += increaseQtyBTN_Click;
            // 
            // productPrice
            // 
            productPrice.AutoSize = true;
            productPrice.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            productPrice.Location = new Point(211, 333);
            productPrice.Name = "productPrice";
            productPrice.Size = new Size(76, 26);
            productPrice.TabIndex = 29;
            productPrice.Text = "₱: 350";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.back_removebg_preview;
            pictureBox2.Location = new Point(23, 14);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(59, 51);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 28;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // productPictureBox
            // 
            productPictureBox.Location = new Point(136, 82);
            productPictureBox.Name = "productPictureBox";
            productPictureBox.Size = new Size(233, 188);
            productPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            productPictureBox.TabIndex = 27;
            productPictureBox.TabStop = false;
            // 
            // productName
            // 
            productName.AutoSize = true;
            productName.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            productName.Location = new Point(173, 292);
            productName.Name = "productName";
            productName.Size = new Size(143, 26);
            productName.TabIndex = 26;
            productName.Text = "Dept Shirt, M";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(156, 22);
            label1.Name = "label1";
            label1.Size = new Size(198, 43);
            label1.TabIndex = 25;
            label1.Text = "PRODUCT";
            // 
            // SIZES_OrderDetails
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(515, 743);
            Controls.Add(dtbQuantity);
            Controls.Add(quantityLabell);
            Controls.Add(specialTB);
            Controls.Add(label3);
            Controls.Add(totalLabel);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(decreaseQtyBTN);
            Controls.Add(increaseQtyBTN);
            Controls.Add(productPrice);
            Controls.Add(pictureBox2);
            Controls.Add(productPictureBox);
            Controls.Add(productName);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SIZES_OrderDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SIZES_OrderDetails";
            Load += SIZES_OrderDetails_Load;
            ((System.ComponentModel.ISupportInitialize)decreaseQtyBTN).EndInit();
            ((System.ComponentModel.ISupportInitialize)increaseQtyBTN).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)productPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label dtbQuantity;
        private Label quantityLabell;
        private TextBox specialTB;
        private Label label3;
        private Label totalLabel;
        private Label label2;
        private Button button1;
        private PictureBox decreaseQtyBTN;
        private PictureBox increaseQtyBTN;
        private Label productPrice;
        private PictureBox pictureBox2;
        private PictureBox productPictureBox;
        private Label productName;
        private Label label1;
    }
}