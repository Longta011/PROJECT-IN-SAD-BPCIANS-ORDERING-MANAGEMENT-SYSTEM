namespace BOMS_customer
{
    partial class INVENTORY
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel2 = new Panel();
            btnInventory = new Button();
            button1 = new Button();
            btn_Attend = new Button();
            btn_Order = new Button();
            btn_Item = new Button();
            btn_Acc = new Button();
            panel1 = new Panel();
            LL_PROFILE = new LinkLabel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel3 = new Panel();
            dgvUser = new DataGridView();
            label7 = new Label();
            label6 = new Label();
            tbID = new TextBox();
            button5 = new Button();
            label5 = new Label();
            tbQ = new TextBox();
            label4 = new Label();
            tbC = new TextBox();
            label2 = new Label();
            btnDelete = new Button();
            btnClear = new Button();
            label3 = new Label();
            tbP = new TextBox();
            tbN = new TextBox();
            label8 = new Label();
            textBox1 = new TextBox();
            label9 = new Label();
            cbSt = new ComboBox();
            button3 = new Button();
            button2 = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUser).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(217, 242, 208);
            panel2.Controls.Add(btnInventory);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(btn_Attend);
            panel2.Controls.Add(btn_Order);
            panel2.Controls.Add(btn_Item);
            panel2.Controls.Add(btn_Acc);
            panel2.Location = new Point(-1, 110);
            panel2.Margin = new Padding(2, 3, 2, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1532, 60);
            panel2.TabIndex = 3;
            // 
            // btnInventory
            // 
            btnInventory.BackColor = Color.Green;
            btnInventory.ForeColor = Color.Gold;
            btnInventory.Location = new Point(689, 11);
            btnInventory.Margin = new Padding(2, 3, 2, 3);
            btnInventory.Name = "btnInventory";
            btnInventory.Size = new Size(119, 42);
            btnInventory.TabIndex = 8;
            btnInventory.Text = "INVENTORY";
            btnInventory.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.ForeColor = Color.White;
            button1.Location = new Point(566, 11);
            button1.Margin = new Padding(2, 3, 2, 3);
            button1.Name = "button1";
            button1.Size = new Size(119, 42);
            button1.TabIndex = 7;
            button1.Text = "SUPPLIER";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btn_Attend
            // 
            btn_Attend.BackColor = Color.Green;
            btn_Attend.ForeColor = Color.White;
            btn_Attend.Location = new Point(427, 11);
            btn_Attend.Margin = new Padding(2, 3, 2, 3);
            btn_Attend.Name = "btn_Attend";
            btn_Attend.Size = new Size(135, 42);
            btn_Attend.TabIndex = 4;
            btn_Attend.Text = "ATTENDANCE";
            btn_Attend.UseVisualStyleBackColor = false;
            btn_Attend.Click += btn_Attend_Click;
            // 
            // btn_Order
            // 
            btn_Order.BackColor = Color.Green;
            btn_Order.ForeColor = Color.White;
            btn_Order.Location = new Point(292, 11);
            btn_Order.Margin = new Padding(2, 3, 2, 3);
            btn_Order.Name = "btn_Order";
            btn_Order.Size = new Size(119, 42);
            btn_Order.TabIndex = 3;
            btn_Order.Text = "SALES";
            btn_Order.UseVisualStyleBackColor = false;
            btn_Order.Click += btn_Order_Click;
            // 
            // btn_Item
            // 
            btn_Item.BackColor = Color.Green;
            btn_Item.ForeColor = Color.White;
            btn_Item.Location = new Point(12, 11);
            btn_Item.Margin = new Padding(2, 3, 2, 3);
            btn_Item.Name = "btn_Item";
            btn_Item.Size = new Size(132, 42);
            btn_Item.TabIndex = 2;
            btn_Item.Text = "DASHBOARD";
            btn_Item.UseVisualStyleBackColor = false;
            btn_Item.Click += btn_Item_Click;
            // 
            // btn_Acc
            // 
            btn_Acc.BackColor = Color.Green;
            btn_Acc.ForeColor = Color.White;
            btn_Acc.Location = new Point(158, 11);
            btn_Acc.Margin = new Padding(2, 3, 2, 3);
            btn_Acc.Name = "btn_Acc";
            btn_Acc.Size = new Size(119, 42);
            btn_Acc.TabIndex = 1;
            btn_Acc.Text = "ACCOUNT";
            btn_Acc.UseVisualStyleBackColor = false;
            btn_Acc.Click += btn_Acc_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Green;
            panel1.Controls.Add(LL_PROFILE);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, 0);
            panel1.Margin = new Padding(2, 3, 2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1532, 111);
            panel1.TabIndex = 2;
            // 
            // LL_PROFILE
            // 
            LL_PROFILE.AutoSize = true;
            LL_PROFILE.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LL_PROFILE.LinkColor = Color.White;
            LL_PROFILE.Location = new Point(1382, 47);
            LL_PROFILE.Name = "LL_PROFILE";
            LL_PROFILE.Size = new Size(116, 28);
            LL_PROFILE.TabIndex = 4;
            LL_PROFILE.TabStop = true;
            LL_PROFILE.Text = "PROFILE";
            LL_PROFILE.LinkClicked += LL_PROFILE_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Bpcian_s_Marketplace_removebg_preview;
            pictureBox1.Location = new Point(12, 10);
            pictureBox1.Margin = new Padding(2, 3, 2, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(104, 98);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(221, 28);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(1005, 51);
            label1.TabIndex = 0;
            label1.Text = "BPCIANS ORDERING MANAGEMENT SYSTEM";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(217, 242, 208);
            panel3.Location = new Point(544, 169);
            panel3.Margin = new Padding(2, 3, 2, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(17, 734);
            panel3.TabIndex = 4;
            // 
            // dgvUser
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvUser.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUser.BackgroundColor = Color.FromArgb(217, 242, 208);
            dgvUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvUser.DefaultCellStyle = dataGridViewCellStyle2;
            dgvUser.Location = new Point(584, 322);
            dgvUser.Name = "dgvUser";
            dgvUser.RowHeadersWidth = 62;
            dgvUser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUser.Size = new Size(913, 563);
            dgvUser.TabIndex = 22;
            dgvUser.CellContentClick += dgvUser_CellContentClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Gold;
            label7.Font = new Font("Arial Rounded MT Bold", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(902, 190);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(284, 51);
            label7.TabIndex = 28;
            label7.Text = "INVENTORY";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Narrow", 10F);
            label6.Location = new Point(60, 346);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(119, 24);
            label6.TabIndex = 42;
            label6.Text = "PRODUCT ID:";
            // 
            // tbID
            // 
            tbID.Location = new Point(184, 339);
            tbID.Margin = new Padding(2, 3, 2, 3);
            tbID.Name = "tbID";
            tbID.ReadOnly = true;
            tbID.Size = new Size(286, 31);
            tbID.TabIndex = 41;
            // 
            // button5
            // 
            button5.Location = new Point(110, 701);
            button5.Margin = new Padding(2, 3, 2, 3);
            button5.Name = "button5";
            button5.Size = new Size(112, 42);
            button5.TabIndex = 40;
            button5.Text = "EDIT";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 10F);
            label5.Location = new Point(60, 573);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(99, 24);
            label5.TabIndex = 39;
            label5.Text = "QUANTITY:";
            // 
            // tbQ
            // 
            tbQ.Location = new Point(184, 566);
            tbQ.Margin = new Padding(2, 3, 2, 3);
            tbQ.Name = "tbQ";
            tbQ.Size = new Size(286, 31);
            tbQ.TabIndex = 38;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 10F);
            label4.Location = new Point(60, 511);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(108, 24);
            label4.TabIndex = 37;
            label4.Text = "CATEGORY:";
            // 
            // tbC
            // 
            tbC.Location = new Point(184, 504);
            tbC.Margin = new Padding(2, 3, 2, 3);
            tbC.Name = "tbC";
            tbC.Size = new Size(286, 31);
            tbC.TabIndex = 36;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 10F);
            label2.Location = new Point(28, 392);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(151, 24);
            label2.TabIndex = 35;
            label2.Text = "PRODUCT NAME:";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(362, 701);
            btnDelete.Margin = new Padding(2, 3, 2, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(108, 42);
            btnDelete.TabIndex = 34;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(232, 701);
            btnClear.Margin = new Padding(2, 3, 2, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 42);
            btnClear.TabIndex = 33;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 10F);
            label3.Location = new Point(77, 452);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(66, 24);
            label3.TabIndex = 31;
            label3.Text = "PRICE:";
            // 
            // tbP
            // 
            tbP.Location = new Point(184, 445);
            tbP.Margin = new Padding(2, 3, 2, 3);
            tbP.Name = "tbP";
            tbP.Size = new Size(286, 31);
            tbP.TabIndex = 30;
            // 
            // tbN
            // 
            tbN.Location = new Point(184, 388);
            tbN.Margin = new Padding(2, 3, 2, 3);
            tbN.Name = "tbN";
            tbN.Size = new Size(286, 31);
            tbN.TabIndex = 29;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Narrow", 10F);
            label8.Location = new Point(63, 631);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(80, 24);
            label8.TabIndex = 44;
            label8.Text = "STATUS:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1313, 285);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(184, 31);
            textBox1.TabIndex = 45;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(1239, 285);
            label9.Name = "label9";
            label9.Size = new Size(68, 25);
            label9.TabIndex = 46;
            label9.Text = "Search:";
            // 
            // cbSt
            // 
            cbSt.FormattingEnabled = true;
            cbSt.Location = new Point(184, 627);
            cbSt.Name = "cbSt";
            cbSt.Size = new Size(278, 33);
            cbSt.TabIndex = 47;
            // 
            // button3
            // 
            button3.BackColor = Color.Green;
            button3.ForeColor = Color.Gold;
            button3.Location = new Point(580, 255);
            button3.Margin = new Padding(2, 3, 2, 3);
            button3.Name = "button3";
            button3.Size = new Size(119, 42);
            button3.TabIndex = 76;
            button3.Text = "INV";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Green;
            button2.ForeColor = Color.White;
            button2.Location = new Point(703, 255);
            button2.Margin = new Padding(2, 3, 2, 3);
            button2.Name = "button2";
            button2.Size = new Size(119, 42);
            button2.TabIndex = 75;
            button2.Text = "INV/SIZE";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // INVENTORY
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1531, 897);
            Controls.Add(button3);
            Controls.Add(cbSt);
            Controls.Add(button2);
            Controls.Add(label9);
            Controls.Add(textBox1);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(tbID);
            Controls.Add(button5);
            Controls.Add(label5);
            Controls.Add(tbQ);
            Controls.Add(label4);
            Controls.Add(tbC);
            Controls.Add(label2);
            Controls.Add(btnDelete);
            Controls.Add(btnClear);
            Controls.Add(label3);
            Controls.Add(tbP);
            Controls.Add(tbN);
            Controls.Add(label7);
            Controls.Add(dgvUser);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "INVENTORY";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "INVENTORY";
            Load += INVENTORY_Load;
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Button button1;
        private Button btn_Attend;
        private Button btn_Order;
        private Button btn_Item;
        private Button btn_Acc;
        private Panel panel1;
        private LinkLabel LL_PROFILE;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel3;
        private DataGridView dgvUser;
        private Label label7;
        private Label label6;
        private TextBox tbID;
        private Button button5;
        private Label label5;
        private TextBox tbQ;
        private Label label4;
        private TextBox tbC;
        private Label label2;
        private Button btnDelete;
        private Button btnClear;
        private Label label3;
        private TextBox tbP;
        private TextBox tbN;
        private Label label8;
        private TextBox tbSt;
        private Button btnInventory;
        private TextBox textBox1;
        private Label label9;
        private ComboBox cbSt;
        private Button button3;
        private Button button2;
    }
}