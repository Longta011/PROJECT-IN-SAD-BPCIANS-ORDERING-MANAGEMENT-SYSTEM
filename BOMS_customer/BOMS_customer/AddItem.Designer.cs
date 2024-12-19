namespace BOMS_customer
{
    partial class AddItem
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
            uploadImage = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button2 = new Button();
            label4 = new Label();
            productnameTB = new TextBox();
            priceTB = new TextBox();
            categoryTB = new TextBox();
            tbtbtb = new TextBox();
            ((System.ComponentModel.ISupportInitialize)productPictureBox).BeginInit();
            SuspendLayout();
            // 
            // productPictureBox
            // 
            productPictureBox.Location = new Point(166, 45);
            productPictureBox.Name = "productPictureBox";
            productPictureBox.Size = new Size(198, 170);
            productPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            productPictureBox.TabIndex = 0;
            productPictureBox.TabStop = false;
            // 
            // uploadImage
            // 
            uploadImage.BackColor = Color.White;
            uploadImage.Location = new Point(139, 248);
            uploadImage.Name = "uploadImage";
            uploadImage.Size = new Size(248, 47);
            uploadImage.TabIndex = 1;
            uploadImage.Text = "UPLOAD IMAGE";
            uploadImage.UseVisualStyleBackColor = false;
            uploadImage.Click += uploadImage_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(46, 343);
            label1.Name = "label1";
            label1.Size = new Size(161, 25);
            label1.TabIndex = 2;
            label1.Text = "PRODUCT NAME:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(46, 402);
            label2.Name = "label2";
            label2.Size = new Size(157, 25);
            label2.TabIndex = 3;
            label2.Text = "PRODUCT PRICE:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(69, 462);
            label3.Name = "label3";
            label3.Size = new Size(111, 25);
            label3.TabIndex = 4;
            label3.Text = "CATEGORY:";
            // 
            // button2
            // 
            button2.BackColor = Color.Green;
            button2.ForeColor = Color.White;
            button2.Location = new Point(195, 597);
            button2.Name = "button2";
            button2.Size = new Size(156, 47);
            button2.TabIndex = 8;
            button2.Text = "CONFIRM";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(69, 524);
            label4.Name = "label4";
            label4.Size = new Size(110, 25);
            label4.TabIndex = 9;
            label4.Text = "QUANTITY:";
            // 
            // productnameTB
            // 
            productnameTB.Location = new Point(207, 340);
            productnameTB.Name = "productnameTB";
            productnameTB.Size = new Size(233, 31);
            productnameTB.TabIndex = 11;
            // 
            // priceTB
            // 
            priceTB.Location = new Point(209, 399);
            priceTB.Name = "priceTB";
            priceTB.Size = new Size(231, 31);
            priceTB.TabIndex = 12;
            // 
            // categoryTB
            // 
            categoryTB.Location = new Point(207, 459);
            categoryTB.Name = "categoryTB";
            categoryTB.Size = new Size(233, 31);
            categoryTB.TabIndex = 13;
            // 
            // tbtbtb
            // 
            tbtbtb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbtbtb.Location = new Point(207, 515);
            tbtbtb.Name = "tbtbtb";
            tbtbtb.Size = new Size(233, 39);
            tbtbtb.TabIndex = 10;
            // 
            // AddItem
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(217, 242, 208);
            ClientSize = new Size(486, 667);
            Controls.Add(categoryTB);
            Controls.Add(priceTB);
            Controls.Add(productnameTB);
            Controls.Add(tbtbtb);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(uploadImage);
            Controls.Add(productPictureBox);
            Name = "AddItem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddItem";
            Load += AddItem_Load;
            ((System.ComponentModel.ISupportInitialize)productPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox productPictureBox;
        private Button uploadImage;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button2;
        private Label label4;
        private TextBox productnameTB;
        private TextBox priceTB;
        private TextBox categoryTB;
        private TextBox tbtbtb;
    }
}