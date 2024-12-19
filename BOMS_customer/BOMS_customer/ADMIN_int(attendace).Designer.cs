namespace BOMS_customer
{
    partial class ADMIN_int_attendace_
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
            button1 = new Button();
            btn_Attend = new Button();
            btn_Order = new Button();
            btn_Item = new Button();
            btn_Acc = new Button();
            dgvAttend = new DataGridView();
            tbS = new TextBox();
            lbSearch = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAttend).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Green;
            panel1.Controls.Add(LL_PROFILE);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, -1);
            panel1.Margin = new Padding(2, 3, 2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1532, 111);
            panel1.TabIndex = 1;
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
            panel2.Controls.Add(button1);
            panel2.Controls.Add(btn_Attend);
            panel2.Controls.Add(btn_Order);
            panel2.Controls.Add(btn_Item);
            panel2.Controls.Add(btn_Acc);
            panel2.Location = new Point(-1, 108);
            panel2.Margin = new Padding(2, 3, 2, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1532, 60);
            panel2.TabIndex = 2;
            // 
            // btnInventory
            // 
            btnInventory.BackColor = Color.Green;
            btnInventory.ForeColor = Color.White;
            btnInventory.Location = new Point(675, 11);
            btnInventory.Margin = new Padding(2, 3, 2, 3);
            btnInventory.Name = "btnInventory";
            btnInventory.Size = new Size(119, 42);
            btnInventory.TabIndex = 9;
            btnInventory.Text = "INVENTORY";
            btnInventory.UseVisualStyleBackColor = false;
            btnInventory.Click += btnInventory_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.ForeColor = Color.White;
            button1.Location = new Point(552, 11);
            button1.Margin = new Padding(2, 3, 2, 3);
            button1.Name = "button1";
            button1.Size = new Size(119, 42);
            button1.TabIndex = 6;
            button1.Text = "SUPPLIER";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btn_Attend
            // 
            btn_Attend.BackColor = Color.Green;
            btn_Attend.ForeColor = Color.Gold;
            btn_Attend.Location = new Point(413, 11);
            btn_Attend.Margin = new Padding(2, 3, 2, 3);
            btn_Attend.Name = "btn_Attend";
            btn_Attend.Size = new Size(135, 42);
            btn_Attend.TabIndex = 4;
            btn_Attend.Text = "ATTENDANCE";
            btn_Attend.UseVisualStyleBackColor = false;
            // 
            // btn_Order
            // 
            btn_Order.BackColor = Color.Green;
            btn_Order.ForeColor = Color.White;
            btn_Order.Location = new Point(290, 11);
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
            // dgvAttend
            // 
            dgvAttend.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAttend.BackgroundColor = Color.FromArgb(217, 242, 208);
            dgvAttend.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAttend.Location = new Point(85, 384);
            dgvAttend.Name = "dgvAttend";
            dgvAttend.RowHeadersWidth = 62;
            dgvAttend.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAttend.Size = new Size(1340, 514);
            dgvAttend.TabIndex = 3;
            dgvAttend.CellContentClick += dataGridView1_CellContentClick;
            // 
            // tbS
            // 
            tbS.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbS.Location = new Point(1187, 329);
            tbS.Name = "tbS";
            tbS.Size = new Size(238, 35);
            tbS.TabIndex = 4;
            tbS.TextChanged += tbS_TextChanged;
            // 
            // lbSearch
            // 
            lbSearch.AutoSize = true;
            lbSearch.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbSearch.Location = new Point(1082, 335);
            lbSearch.Name = "lbSearch";
            lbSearch.Size = new Size(81, 29);
            lbSearch.TabIndex = 5;
            lbSearch.Text = "Search;";
            lbSearch.Click += lbSearch_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Gold;
            label2.Font = new Font("Arial Rounded MT Bold", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(468, 227);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(650, 51);
            label2.TabIndex = 5;
            label2.Text = "ATTENDANCE FOR CASHIER";
            label2.Click += label2_Click;
            // 
            // ADMIN_int_attendace_
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1531, 897);
            Controls.Add(label2);
            Controls.Add(lbSearch);
            Controls.Add(tbS);
            Controls.Add(dgvAttend);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ADMIN_int_attendace_";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ADMIN_int_attendace_";
            Load += ADMIN_int_attendace__Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAttend).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private LinkLabel LL_PROFILE;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel2;
        private Button btn_Attend;
        private Button btn_Order;
        private Button btn_Item;
        private Button btn_Acc;
        private DataGridView dgvAttend;
        private TextBox tbS;
        private Label lbSearch;
        private Label label2;
        private Button button1;
        private Button btnInventory;
    }
}