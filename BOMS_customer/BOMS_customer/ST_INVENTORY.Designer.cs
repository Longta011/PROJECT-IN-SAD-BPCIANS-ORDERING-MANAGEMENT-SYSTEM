namespace BOMS_customer
{
    partial class ST_INVENTORY
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
            buttonInv = new Button();
            buttonOrder = new Button();
            btnSupp = new Button();
            btnHistory = new Button();
            panel1 = new Panel();
            LL_PROFILE = new LinkLabel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            dgvUserr = new DataGridView();
            label7 = new Label();
            label2 = new Label();
            tbS = new TextBox();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUserr).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(217, 242, 208);
            panel2.Controls.Add(buttonInv);
            panel2.Controls.Add(buttonOrder);
            panel2.Controls.Add(btnSupp);
            panel2.Controls.Add(btnHistory);
            panel2.Location = new Point(-1, 106);
            panel2.Margin = new Padding(2, 3, 2, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1532, 60);
            panel2.TabIndex = 9;
            // 
            // buttonInv
            // 
            buttonInv.BackColor = Color.Green;
            buttonInv.ForeColor = Color.Gold;
            buttonInv.Location = new Point(291, 11);
            buttonInv.Margin = new Padding(2, 3, 2, 3);
            buttonInv.Name = "buttonInv";
            buttonInv.Size = new Size(119, 42);
            buttonInv.TabIndex = 6;
            buttonInv.Text = "INVENTORY";
            buttonInv.UseVisualStyleBackColor = false;
            // 
            // buttonOrder
            // 
            buttonOrder.BackColor = Color.Green;
            buttonOrder.ForeColor = Color.White;
            buttonOrder.Location = new Point(23, 11);
            buttonOrder.Margin = new Padding(2, 3, 2, 3);
            buttonOrder.Name = "buttonOrder";
            buttonOrder.Size = new Size(119, 42);
            buttonOrder.TabIndex = 5;
            buttonOrder.Text = "ORDER";
            buttonOrder.UseVisualStyleBackColor = false;
            buttonOrder.Click += buttonOrder_Click;
            // 
            // btnSupp
            // 
            btnSupp.BackColor = Color.Green;
            btnSupp.ForeColor = Color.White;
            btnSupp.Location = new Point(424, 11);
            btnSupp.Margin = new Padding(2, 3, 2, 3);
            btnSupp.Name = "btnSupp";
            btnSupp.Size = new Size(135, 42);
            btnSupp.TabIndex = 4;
            btnSupp.Text = "SUPPLIER";
            btnSupp.UseVisualStyleBackColor = false;
            btnSupp.Click += btnSupp_Click;
            // 
            // btnHistory
            // 
            btnHistory.BackColor = Color.Green;
            btnHistory.ForeColor = Color.White;
            btnHistory.Location = new Point(158, 11);
            btnHistory.Margin = new Padding(2, 3, 2, 3);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(119, 42);
            btnHistory.TabIndex = 1;
            btnHistory.Text = "HISTORY";
            btnHistory.UseVisualStyleBackColor = false;
            btnHistory.Click += btnHistory_Click;
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
            panel1.TabIndex = 8;
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
            LL_PROFILE.Text = "LOGOUT";
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
            // dgvUserr
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvUserr.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvUserr.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUserr.BackgroundColor = Color.FromArgb(217, 242, 208);
            dgvUserr.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvUserr.DefaultCellStyle = dataGridViewCellStyle2;
            dgvUserr.Location = new Point(19, 327);
            dgvUserr.Name = "dgvUserr";
            dgvUserr.RowHeadersWidth = 62;
            dgvUserr.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUserr.Size = new Size(1476, 573);
            dgvUserr.TabIndex = 25;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Gold;
            label7.Font = new Font("Arial Rounded MT Bold", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(647, 183);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(284, 51);
            label7.TabIndex = 30;
            label7.Text = "INVENTORY";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(1109, 281);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(83, 30);
            label2.TabIndex = 32;
            label2.Text = "Search:";
            // 
            // tbS
            // 
            tbS.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbS.ForeColor = Color.Black;
            tbS.Location = new Point(1198, 276);
            tbS.Name = "tbS";
            tbS.Size = new Size(299, 35);
            tbS.TabIndex = 31;
            // 
            // ST_INVENTORY
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1531, 897);
            Controls.Add(label2);
            Controls.Add(tbS);
            Controls.Add(label7);
            Controls.Add(dgvUserr);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ST_INVENTORY";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ST_INVENTORY";
            Load += ST_INVENTORY_Load;
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUserr).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Button buttonInv;
        private Button buttonOrder;
        private Button btnSupp;
        private Button btnHistory;
        private Panel panel1;
        private LinkLabel LL_PROFILE;
        private PictureBox pictureBox1;
        private Label label1;
        private DataGridView dgvUserr;
        private Label label7;
        private Label label2;
        private TextBox tbS;
    }
}