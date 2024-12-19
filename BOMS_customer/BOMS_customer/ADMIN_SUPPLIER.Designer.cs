namespace BOMS_customer
{
    partial class ADMIN_SUPPLIER
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
            LL_PROFILE = new LinkLabel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            btnInventory = new Button();
            btnSupplier = new Button();
            btn_Attend = new Button();
            btn_Order = new Button();
            btn_Item = new Button();
            btn_Acc = new Button();
            label2 = new Label();
            panel3 = new Panel();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            tbID = new TextBox();
            tbN = new TextBox();
            tbC = new TextBox();
            tbA = new TextBox();
            tbP = new TextBox();
            button5 = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            btnSave = new Button();
            dgvUser = new DataGridView();
            textBox6 = new TextBox();
            label9 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUser).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Green;
            panel1.Controls.Add(LL_PROFILE);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, 1);
            panel1.Margin = new Padding(2, 3, 2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1532, 111);
            panel1.TabIndex = 3;
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
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(217, 242, 208);
            panel2.Controls.Add(btnInventory);
            panel2.Controls.Add(btnSupplier);
            panel2.Controls.Add(btn_Attend);
            panel2.Controls.Add(btn_Order);
            panel2.Controls.Add(btn_Item);
            panel2.Controls.Add(btn_Acc);
            panel2.Location = new Point(-1, 112);
            panel2.Margin = new Padding(2, 3, 2, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1532, 60);
            panel2.TabIndex = 4;
            // 
            // btnInventory
            // 
            btnInventory.BackColor = Color.Green;
            btnInventory.ForeColor = Color.White;
            btnInventory.Location = new Point(714, 10);
            btnInventory.Margin = new Padding(2, 3, 2, 3);
            btnInventory.Name = "btnInventory";
            btnInventory.Size = new Size(119, 42);
            btnInventory.TabIndex = 32;
            btnInventory.Text = "INVENTORY";
            btnInventory.UseVisualStyleBackColor = false;
            btnInventory.Click += btnInventory_Click;
            // 
            // btnSupplier
            // 
            btnSupplier.BackColor = Color.Green;
            btnSupplier.ForeColor = Color.Gold;
            btnSupplier.Location = new Point(575, 10);
            btnSupplier.Margin = new Padding(2, 3, 2, 3);
            btnSupplier.Name = "btnSupplier";
            btnSupplier.Size = new Size(135, 42);
            btnSupplier.TabIndex = 5;
            btnSupplier.Text = "SUPPLIER";
            btnSupplier.UseVisualStyleBackColor = false;
            // 
            // btn_Attend
            // 
            btn_Attend.BackColor = Color.Green;
            btn_Attend.ForeColor = Color.White;
            btn_Attend.Location = new Point(424, 11);
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
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Gold;
            label2.Font = new Font("Arial Rounded MT Bold", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(861, 224);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(364, 51);
            label2.TabIndex = 9;
            label2.Text = "SUPPLIER INFO";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(217, 242, 208);
            panel3.Location = new Point(544, 169);
            panel3.Margin = new Padding(2, 3, 2, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(17, 734);
            panel3.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Gold;
            label3.Font = new Font("Arial Rounded MT Bold", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(157, 224);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(214, 51);
            label3.TabIndex = 11;
            label3.Text = "DETAILS";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(61, 388);
            label4.Name = "label4";
            label4.Size = new Size(114, 24);
            label4.TabIndex = 12;
            label4.Text = "SUPPLIER ID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(61, 449);
            label5.Name = "label5";
            label5.Size = new Size(109, 24);
            label5.TabIndex = 13;
            label5.Text = "FULL NAME:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Narrow", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(61, 505);
            label6.Name = "label6";
            label6.Size = new Size(95, 24);
            label6.TabIndex = 14;
            label6.Text = "CONTACT:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Narrow", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(60, 559);
            label7.Name = "label7";
            label7.Size = new Size(95, 24);
            label7.TabIndex = 15;
            label7.Text = "ADDRESS:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Narrow", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(61, 610);
            label8.Name = "label8";
            label8.Size = new Size(97, 24);
            label8.TabIndex = 16;
            label8.Text = "PRODUCT:";
            // 
            // tbID
            // 
            tbID.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbID.Location = new Point(192, 388);
            tbID.Name = "tbID";
            tbID.Size = new Size(282, 35);
            tbID.TabIndex = 17;
            // 
            // tbN
            // 
            tbN.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbN.Location = new Point(192, 442);
            tbN.Name = "tbN";
            tbN.Size = new Size(282, 35);
            tbN.TabIndex = 18;
            // 
            // tbC
            // 
            tbC.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbC.Location = new Point(192, 498);
            tbC.Name = "tbC";
            tbC.Size = new Size(282, 35);
            tbC.TabIndex = 19;
            // 
            // tbA
            // 
            tbA.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbA.Location = new Point(192, 557);
            tbA.Name = "tbA";
            tbA.Size = new Size(282, 35);
            tbA.TabIndex = 20;
            // 
            // tbP
            // 
            tbP.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbP.Location = new Point(192, 610);
            tbP.Name = "tbP";
            tbP.Size = new Size(282, 35);
            tbP.TabIndex = 21;
            // 
            // button5
            // 
            button5.Location = new Point(134, 694);
            button5.Margin = new Padding(2, 3, 2, 3);
            button5.Name = "button5";
            button5.Size = new Size(112, 42);
            button5.TabIndex = 28;
            button5.Text = "UPDATE";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(386, 694);
            btnDelete.Margin = new Padding(2, 3, 2, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(108, 42);
            btnDelete.TabIndex = 27;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(256, 694);
            btnClear.Margin = new Padding(2, 3, 2, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 42);
            btnClear.TabIndex = 26;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(26, 694);
            btnSave.Margin = new Padding(2, 3, 2, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(104, 42);
            btnSave.TabIndex = 25;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // dgvUser
            // 
            dgvUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUser.BackgroundColor = Color.FromArgb(217, 242, 208);
            dgvUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUser.Location = new Point(625, 388);
            dgvUser.Name = "dgvUser";
            dgvUser.RowHeadersWidth = 62;
            dgvUser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUser.Size = new Size(857, 485);
            dgvUser.TabIndex = 29;
            dgvUser.CellContentClick += dgvUser_CellContentClick;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox6.Location = new Point(1200, 334);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(282, 35);
            textBox6.TabIndex = 30;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Narrow", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(1110, 341);
            label9.Name = "label9";
            label9.Size = new Size(84, 24);
            label9.TabIndex = 31;
            label9.Text = "SEARCH:";
            // 
            // ADMIN_SUPPLIER
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1531, 897);
            Controls.Add(label9);
            Controls.Add(textBox6);
            Controls.Add(dgvUser);
            Controls.Add(button5);
            Controls.Add(btnDelete);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(tbP);
            Controls.Add(tbA);
            Controls.Add(tbC);
            Controls.Add(tbN);
            Controls.Add(tbID);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel3);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ADMIN_SUPPLIER";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ADMIN_SUPPLIER";
            Load += ADMIN_SUPPLIER_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private LinkLabel LL_PROFILE;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel2;
        private Button btnSupplier;
        private Button btn_Attend;
        private Button btn_Order;
        private Button btn_Item;
        private Button btn_Acc;
        private Label label2;
        private Panel panel3;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox tbID;
        private TextBox tbN;
        private TextBox tbC;
        private TextBox tbA;
        private TextBox tbP;
        private Button button5;
        private Button btnDelete;
        private Button btnClear;
        private Button btnSave;
        private DataGridView dgvUser;
        private TextBox textBox6;
        private Label label9;
        private Button btnInventory;
    }
}