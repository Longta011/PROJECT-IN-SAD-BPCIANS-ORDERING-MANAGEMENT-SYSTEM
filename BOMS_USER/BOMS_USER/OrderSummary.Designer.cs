namespace BOMS_USER
{
    partial class OrderSummary
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
            pictureBox2 = new PictureBox();
            productPictureBox = new PictureBox();
            label1 = new Label();
            productPrice = new Label();
            productName = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            qtyLabel = new Label();
            totalLabel = new Label();
            btnORDER = new Button();
            specialLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productPictureBox).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.back_removebg_preview;
            pictureBox2.Location = new Point(12, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(59, 51);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // productPictureBox
            // 
            productPictureBox.Location = new Point(181, 76);
            productPictureBox.Name = "productPictureBox";
            productPictureBox.Size = new Size(240, 207);
            productPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            productPictureBox.TabIndex = 7;
            productPictureBox.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(153, 12);
            label1.Name = "label1";
            label1.Size = new Size(268, 33);
            label1.TabIndex = 8;
            label1.Text = "ORDER SUMMARY";
            // 
            // productPrice
            // 
            productPrice.AutoSize = true;
            productPrice.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            productPrice.Location = new Point(254, 358);
            productPrice.Name = "productPrice";
            productPrice.Size = new Size(76, 26);
            productPrice.TabIndex = 10;
            productPrice.Text = "₱: 100";
            // 
            // productName
            // 
            productName.AutoSize = true;
            productName.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            productName.Location = new Point(225, 312);
            productName.Name = "productName";
            productName.Size = new Size(143, 26);
            productName.TabIndex = 9;
            productName.Text = "Dept Shirt, M";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 445);
            label2.Name = "label2";
            label2.Size = new Size(117, 26);
            label2.TabIndex = 11;
            label2.Text = "School ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 532);
            label3.Name = "label3";
            label3.Size = new Size(127, 26);
            label3.TabIndex = 12;
            label3.Text = "Total Price:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 490);
            label4.Name = "label4";
            label4.Size = new Size(104, 26);
            label4.TabIndex = 13;
            label4.Text = "Quantity:";
            // 
            // qtyLabel
            // 
            qtyLabel.AutoSize = true;
            qtyLabel.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            qtyLabel.Location = new Point(122, 490);
            qtyLabel.Name = "qtyLabel";
            qtyLabel.Size = new Size(24, 26);
            qtyLabel.TabIndex = 14;
            qtyLabel.Text = "1";
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalLabel.Location = new Point(145, 532);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(34, 26);
            totalLabel.TabIndex = 16;
            totalLabel.Text = "₱:";
            // 
            // btnORDER
            // 
            btnORDER.BackColor = Color.Green;
            btnORDER.ForeColor = Color.White;
            btnORDER.Location = new Point(222, 597);
            btnORDER.Name = "btnORDER";
            btnORDER.Size = new Size(144, 43);
            btnORDER.TabIndex = 17;
            btnORDER.Text = "CONFIRM";
            btnORDER.UseVisualStyleBackColor = false;
            btnORDER.Click += btnORDER_Click;
            // 
            // specialLabel
            // 
            specialLabel.AutoSize = true;
            specialLabel.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            specialLabel.Location = new Point(135, 445);
            specialLabel.Name = "specialLabel";
            specialLabel.Size = new Size(140, 26);
            specialLabel.TabIndex = 18;
            specialLabel.Text = "MA23015555";
            // 
            // OrderSummary
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 666);
            Controls.Add(specialLabel);
            Controls.Add(btnORDER);
            Controls.Add(totalLabel);
            Controls.Add(qtyLabel);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(productPrice);
            Controls.Add(productName);
            Controls.Add(label1);
            Controls.Add(productPictureBox);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "OrderSummary";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OrderSummary";
            Load += OrderSummary_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)productPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private PictureBox productPictureBox;
        private Label label1;
        private Label productPrice;
        private Label productName;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label qtyLabel;
        private Label tbIDD;
        private Label totalLabel;
        private Button btnORDER;
        private Label specialLabel;
    }
}