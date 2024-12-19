namespace BOMS_customer
{
    partial class ADMIN_acc_admin_
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
            panel3 = new Panel();
            label2 = new Label();
            tbFN = new TextBox();
            label6 = new Label();
            tbID = new TextBox();
            label5 = new Label();
            tbP = new TextBox();
            label4 = new Label();
            tbU = new TextBox();
            label3 = new Label();
            tbLN = new TextBox();
            btnDelete = new Button();
            btnSave = new Button();
            label7 = new Label();
            dgvUser = new DataGridView();
            tbS = new TextBox();
            lS = new Label();
            btnAccAdmin = new Button();
            btnAccCash = new Button();
            panel4 = new Panel();
            pbImage = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUser).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Green;
            panel1.Controls.Add(LL_PROFILE);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, -2);
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
            panel2.Controls.Add(btnSupplier);
            panel2.Controls.Add(btn_Attend);
            panel2.Controls.Add(btn_Order);
            panel2.Controls.Add(btn_Item);
            panel2.Controls.Add(btn_Acc);
            panel2.Location = new Point(-1, 109);
            panel2.Margin = new Padding(2, 3, 2, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1532, 60);
            panel2.TabIndex = 2;
            // 
            // btnInventory
            // 
            btnInventory.BackColor = Color.Green;
            btnInventory.ForeColor = Color.White;
            btnInventory.Location = new Point(705, 11);
            btnInventory.Margin = new Padding(2, 3, 2, 3);
            btnInventory.Name = "btnInventory";
            btnInventory.Size = new Size(119, 42);
            btnInventory.TabIndex = 47;
            btnInventory.Text = "INVENTORY";
            btnInventory.UseVisualStyleBackColor = false;
            btnInventory.Click += btnInventory_Click;
            // 
            // btnSupplier
            // 
            btnSupplier.BackColor = Color.Green;
            btnSupplier.ForeColor = Color.White;
            btnSupplier.Location = new Point(566, 11);
            btnSupplier.Margin = new Padding(2, 3, 2, 3);
            btnSupplier.Name = "btnSupplier";
            btnSupplier.Size = new Size(135, 42);
            btnSupplier.TabIndex = 5;
            btnSupplier.Text = "SUPPLIER";
            btnSupplier.UseVisualStyleBackColor = false;
            btnSupplier.Click += btnSupplier_Click;
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
            btn_Acc.ForeColor = Color.Gold;
            btn_Acc.Location = new Point(158, 11);
            btn_Acc.Margin = new Padding(2, 3, 2, 3);
            btn_Acc.Name = "btn_Acc";
            btn_Acc.Size = new Size(119, 42);
            btn_Acc.TabIndex = 1;
            btn_Acc.Text = "ACCOUNT";
            btn_Acc.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(217, 242, 208);
            panel3.Location = new Point(544, 169);
            panel3.Margin = new Padding(2, 3, 2, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(17, 734);
            panel3.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 10F);
            label2.Location = new Point(48, 486);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(117, 24);
            label2.TabIndex = 18;
            label2.Text = "FIRST NAME:";
            // 
            // tbFN
            // 
            tbFN.Location = new Point(184, 479);
            tbFN.Margin = new Padding(2, 3, 2, 3);
            tbFN.Name = "tbFN";
            tbFN.Size = new Size(286, 31);
            tbFN.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Narrow", 10F);
            label6.Location = new Point(72, 437);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(83, 24);
            label6.TabIndex = 28;
            label6.Text = "USER ID:";
            // 
            // tbID
            // 
            tbID.Location = new Point(184, 430);
            tbID.Margin = new Padding(2, 3, 2, 3);
            tbID.Name = "tbID";
            tbID.ReadOnly = true;
            tbID.Size = new Size(286, 31);
            tbID.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 10F);
            label5.Location = new Point(60, 664);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(111, 24);
            label5.TabIndex = 34;
            label5.Text = "PASSWORD:";
            // 
            // tbP
            // 
            tbP.Location = new Point(184, 657);
            tbP.Margin = new Padding(2, 3, 2, 3);
            tbP.Name = "tbP";
            tbP.Size = new Size(286, 31);
            tbP.TabIndex = 33;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 10F);
            label4.Location = new Point(60, 602);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(110, 24);
            label4.TabIndex = 32;
            label4.Text = "USERNAME:";
            // 
            // tbU
            // 
            tbU.Location = new Point(184, 595);
            tbU.Margin = new Padding(2, 3, 2, 3);
            tbU.Name = "tbU";
            tbU.Size = new Size(286, 31);
            tbU.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 10F);
            label3.Location = new Point(60, 543);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(110, 24);
            label3.TabIndex = 30;
            label3.Text = "LAST NAME:";
            // 
            // tbLN
            // 
            tbLN.Location = new Point(184, 536);
            tbLN.Margin = new Padding(2, 3, 2, 3);
            tbLN.Name = "tbLN";
            tbLN.Size = new Size(286, 31);
            tbLN.TabIndex = 29;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(262, 748);
            btnDelete.Margin = new Padding(2, 3, 2, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(108, 42);
            btnDelete.TabIndex = 37;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(154, 748);
            btnSave.Margin = new Padding(2, 3, 2, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(104, 42);
            btnSave.TabIndex = 35;
            btnSave.Text = "RETRIEVE";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Gold;
            label7.Font = new Font("Arial Rounded MT Bold", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(916, 202);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(225, 51);
            label7.TabIndex = 40;
            label7.Text = "ARCHIVE";
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
            dgvUser.TabIndex = 41;
            dgvUser.CellContentClick += dgvUser_CellContentClick;
            // 
            // tbS
            // 
            tbS.Cursor = Cursors.IBeam;
            tbS.Location = new Point(1328, 272);
            tbS.Name = "tbS";
            tbS.Size = new Size(169, 31);
            tbS.TabIndex = 42;
            tbS.TextChanged += tbS_TextChanged;
            // 
            // lS
            // 
            lS.AutoSize = true;
            lS.Font = new Font("Arial Narrow", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lS.Location = new Point(1238, 272);
            lS.Name = "lS";
            lS.Size = new Size(74, 26);
            lS.TabIndex = 43;
            lS.Text = "Search:";
            // 
            // btnAccAdmin
            // 
            btnAccAdmin.BackColor = Color.Green;
            btnAccAdmin.ForeColor = Color.Gold;
            btnAccAdmin.Location = new Point(727, 266);
            btnAccAdmin.Margin = new Padding(2, 3, 2, 3);
            btnAccAdmin.Name = "btnAccAdmin";
            btnAccAdmin.Size = new Size(119, 42);
            btnAccAdmin.TabIndex = 45;
            btnAccAdmin.Text = "ARCHIVE";
            btnAccAdmin.UseVisualStyleBackColor = false;
            // 
            // btnAccCash
            // 
            btnAccCash.BackColor = Color.Green;
            btnAccCash.ForeColor = Color.White;
            btnAccCash.Location = new Point(594, 266);
            btnAccCash.Margin = new Padding(2, 3, 2, 3);
            btnAccCash.Name = "btnAccCash";
            btnAccCash.Size = new Size(119, 42);
            btnAccCash.TabIndex = 46;
            btnAccCash.Text = "CASHIER";
            btnAccCash.UseVisualStyleBackColor = false;
            btnAccCash.Click += btnAccCash_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(217, 242, 208);
            panel4.Controls.Add(pbImage);
            panel4.Location = new Point(128, 192);
            panel4.Margin = new Padding(2, 3, 2, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(242, 205);
            panel4.TabIndex = 39;
            // 
            // pbImage
            // 
            pbImage.Location = new Point(11, 10);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(222, 187);
            pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbImage.TabIndex = 0;
            pbImage.TabStop = false;
            // 
            // ADMIN_acc_admin_
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1531, 897);
            Controls.Add(btnAccAdmin);
            Controls.Add(btnAccCash);
            Controls.Add(lS);
            Controls.Add(tbS);
            Controls.Add(dgvUser);
            Controls.Add(label7);
            Controls.Add(panel4);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(label5);
            Controls.Add(tbP);
            Controls.Add(label4);
            Controls.Add(tbU);
            Controls.Add(label3);
            Controls.Add(tbLN);
            Controls.Add(label6);
            Controls.Add(tbID);
            Controls.Add(label2);
            Controls.Add(tbFN);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ADMIN_acc_admin_";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ADMIN_acc_admin_";
            Load += ADMIN_acc_admin__Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUser).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
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
        private Panel panel3;
        private Label label2;
        private TextBox tbFN;
        private Label label6;
        private TextBox tbID;
        private Label label5;
        private TextBox tbP;
        private Label label4;
        private TextBox tbU;
        private Label label3;
        private TextBox tbLN;
        private Button btnDelete;
        private Button btnSave;
        private Label label7;
        private DataGridView dgvUser;
        private TextBox tbS;
        private Label lS;
        private Button btnAccAdmin;
        private Button btnAccCash;
        private Button btnSupplier;
        private Panel panel4;
        private PictureBox pbImage;
        private Button btnInventory;
    }
}