namespace BOMS_customer
{
    partial class ADMIN_int_Order_
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
            label2 = new Label();
            dgvUser = new DataGridView();
            dtpFilter = new DateTimePicker();
            btnReset = new Button();
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
            panel2.Location = new Point(-1, 109);
            panel2.Margin = new Padding(2, 3, 2, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1532, 60);
            panel2.TabIndex = 5;
            // 
            // btnInventory
            // 
            btnInventory.BackColor = Color.Green;
            btnInventory.ForeColor = Color.White;
            btnInventory.Location = new Point(666, 11);
            btnInventory.Margin = new Padding(2, 3, 2, 3);
            btnInventory.Name = "btnInventory";
            btnInventory.Size = new Size(119, 42);
            btnInventory.TabIndex = 14;
            btnInventory.Text = "INVENTORY";
            btnInventory.UseVisualStyleBackColor = false;
            btnInventory.Click += btnInventory_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.ForeColor = Color.White;
            button1.Location = new Point(543, 11);
            button1.Margin = new Padding(2, 3, 2, 3);
            button1.Name = "button1";
            button1.Size = new Size(119, 42);
            button1.TabIndex = 5;
            button1.Text = "SUPPLIER";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btn_Attend
            // 
            btn_Attend.BackColor = Color.Green;
            btn_Attend.ForeColor = Color.White;
            btn_Attend.Location = new Point(404, 10);
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
            btn_Order.ForeColor = Color.Gold;
            btn_Order.Location = new Point(281, 10);
            btn_Order.Margin = new Padding(2, 3, 2, 3);
            btn_Order.Name = "btn_Order";
            btn_Order.Size = new Size(119, 42);
            btn_Order.TabIndex = 3;
            btn_Order.Text = "SALES";
            btn_Order.UseVisualStyleBackColor = false;
            // 
            // btn_Item
            // 
            btn_Item.BackColor = Color.Green;
            btn_Item.ForeColor = Color.White;
            btn_Item.Location = new Point(23, 11);
            btn_Item.Margin = new Padding(2, 3, 2, 3);
            btn_Item.Name = "btn_Item";
            btn_Item.Size = new Size(131, 42);
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
            panel1.Location = new Point(-1, 2);
            panel1.Margin = new Padding(2, 3, 2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1532, 111);
            panel1.TabIndex = 4;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Gold;
            label2.Font = new Font("Arial Rounded MT Bold", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(700, 200);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(168, 51);
            label2.TabIndex = 12;
            label2.Text = "SALES";
            // 
            // dgvUser
            // 
            dgvUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUser.BackgroundColor = Color.FromArgb(217, 242, 208);
            dgvUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUser.Location = new Point(85, 316);
            dgvUser.Name = "dgvUser";
            dgvUser.RowHeadersWidth = 62;
            dgvUser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUser.Size = new Size(1340, 582);
            dgvUser.TabIndex = 10;
            // 
            // dtpFilter
            // 
            dtpFilter.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFilter.Location = new Point(1105, 269);
            dtpFilter.Name = "dtpFilter";
            dtpFilter.Size = new Size(320, 39);
            dtpFilter.TabIndex = 14;
            dtpFilter.ValueChanged += dtpFilter_ValueChanged;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(963, 269);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(122, 41);
            btnReset.TabIndex = 15;
            btnReset.Text = "RESET";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // ADMIN_int_Order_
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1531, 897);
            Controls.Add(btnReset);
            Controls.Add(dtpFilter);
            Controls.Add(label2);
            Controls.Add(dgvUser);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ADMIN_int_Order_";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ADMIN_int_Order_";
            Load += ADMIN_int_Order__Load;
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
        private Button btn_Attend;
        private Button btn_Order;
        private Button btn_Item;
        private Button btn_Acc;
        private Panel panel1;
        private LinkLabel LL_PROFILE;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private DataGridView dgvUser;
        private Button button1;
        private Button btnInventory;
        private DateTimePicker dtpFilter;
        private Button btnReset;
    }
}