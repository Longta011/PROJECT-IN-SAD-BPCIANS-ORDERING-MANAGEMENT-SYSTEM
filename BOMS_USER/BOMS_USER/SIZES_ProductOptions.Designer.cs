namespace BOMS_USER
{
    partial class SIZES_ProductOptions
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
            pictureBox2 = new PictureBox();
            productPrice = new Label();
            orderBTN = new Button();
            productName = new Label();
            label1 = new Label();
            cbSize = new ComboBox();
            label2 = new Label();
            panel3 = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            panel4 = new Panel();
            Size = new Label();
            ((System.ComponentModel.ISupportInitialize)productPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // productPictureBox
            // 
            productPictureBox.Location = new Point(162, 83);
            productPictureBox.Name = "productPictureBox";
            productPictureBox.Size = new Size(216, 206);
            productPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            productPictureBox.TabIndex = 12;
            productPictureBox.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.back_removebg_preview;
            pictureBox2.Location = new Point(22, 28);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(59, 51);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // productPrice
            // 
            productPrice.AutoSize = true;
            productPrice.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            productPrice.Location = new Point(195, 387);
            productPrice.Name = "productPrice";
            productPrice.Size = new Size(76, 26);
            productPrice.TabIndex = 10;
            productPrice.Text = "₱: 100";
            // 
            // orderBTN
            // 
            orderBTN.BackColor = Color.Green;
            orderBTN.ForeColor = Color.White;
            orderBTN.Location = new Point(178, 590);
            orderBTN.Name = "orderBTN";
            orderBTN.Size = new Size(164, 65);
            orderBTN.TabIndex = 9;
            orderBTN.Text = "CONFIRM";
            orderBTN.UseVisualStyleBackColor = false;
            orderBTN.Click += orderBTN_Click;
            // 
            // productName
            // 
            productName.AutoSize = true;
            productName.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            productName.Location = new Point(178, 313);
            productName.Name = "productName";
            productName.Size = new Size(120, 26);
            productName.TabIndex = 8;
            productName.Text = "Dept Shirt,";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(180, 28);
            label1.Name = "label1";
            label1.Size = new Size(198, 43);
            label1.TabIndex = 7;
            label1.Text = "PRODUCT";
            // 
            // cbSize
            // 
            cbSize.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbSize.FormattingEnabled = true;
            cbSize.Location = new Point(180, 494);
            cbSize.Name = "cbSize";
            cbSize.Size = new Size(175, 40);
            cbSize.TabIndex = 13;
            cbSize.SelectedIndexChanged += cbSize_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(204, 449);
            label2.Name = "label2";
            label2.Size = new Size(124, 26);
            label2.TabIndex = 14;
            label2.Text = "Select SIze";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(531, -6);
            panel3.Name = "panel3";
            panel3.Size = new Size(10, 673);
            panel3.TabIndex = 15;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(-2, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 674);
            panel1.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(6, 659);
            panel2.Name = "panel2";
            panel2.Size = new Size(530, 10);
            panel2.TabIndex = 8;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Location = new Point(5, -2);
            panel4.Name = "panel4";
            panel4.Size = new Size(532, 10);
            panel4.TabIndex = 9;
            // 
            // Size
            // 
            Size.AutoSize = true;
            Size.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Size.Location = new Point(228, 348);
            Size.Name = "Size";
            Size.Size = new Size(29, 26);
            Size.TabIndex = 16;
            Size.Text = "M";
            // 
            // SIZES_ProductOptions
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(537, 667);
            Controls.Add(Size);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(label2);
            Controls.Add(cbSize);
            Controls.Add(productPictureBox);
            Controls.Add(pictureBox2);
            Controls.Add(productPrice);
            Controls.Add(orderBTN);
            Controls.Add(productName);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SIZES_ProductOptions";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SIZES_ProductOptions";
            Load += SIZES_ProductOptions_Load;
            ((System.ComponentModel.ISupportInitialize)productPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox productPictureBox;
        private PictureBox pictureBox2;
        private Label productPrice;
        private Button orderBTN;
        private Label productName;
        private Label label1;
        private ComboBox cbSize;
        private Label label2;
        private Panel panel3;
        private Panel panel1;
        private Panel panel2;
        private Panel panel4;
        private Label Size;
    }
}