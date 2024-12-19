namespace BOMS_customer
{
    partial class ST_HISTORY
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel2 = new Panel();
            dgvUser = new DataGridView();
            buttonInv = new Button();
            buttonOrder = new Button();
            btnSupp = new Button();
            btnHistory = new Button();
            panel1 = new Panel();
            LL_PROFILE = new LinkLabel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            dgvUserr = new DataGridView();
            button1 = new Button();
            label2 = new Label();
            tbS = new TextBox();
            label7 = new Label();
            cbProcess = new ComboBox();
            label3 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUser).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUserr).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(217, 242, 208);
            panel2.Controls.Add(dgvUser);
            panel2.Controls.Add(buttonInv);
            panel2.Controls.Add(buttonOrder);
            panel2.Controls.Add(btnSupp);
            panel2.Controls.Add(btnHistory);
            panel2.Location = new Point(-1, 106);
            panel2.Margin = new Padding(2, 3, 2, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1532, 60);
            panel2.TabIndex = 7;
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
            dgvUser.Location = new Point(28, 115);
            dgvUser.Name = "dgvUser";
            dgvUser.RowHeadersWidth = 62;
            dgvUser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUser.Size = new Size(1476, 502);
            dgvUser.TabIndex = 23;
            // 
            // buttonInv
            // 
            buttonInv.BackColor = Color.Green;
            buttonInv.ForeColor = Color.White;
            buttonInv.Location = new Point(291, 11);
            buttonInv.Margin = new Padding(2, 3, 2, 3);
            buttonInv.Name = "buttonInv";
            buttonInv.Size = new Size(119, 42);
            buttonInv.TabIndex = 6;
            buttonInv.Text = "INVENTORY";
            buttonInv.UseVisualStyleBackColor = false;
            buttonInv.Click += buttonInv_Click;
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
            btnHistory.ForeColor = Color.Gold;
            btnHistory.Location = new Point(158, 11);
            btnHistory.Margin = new Padding(2, 3, 2, 3);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(119, 42);
            btnHistory.TabIndex = 1;
            btnHistory.Text = "HISTORY";
            btnHistory.UseVisualStyleBackColor = false;
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
            panel1.TabIndex = 6;
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
            dataGridViewCellStyle3.BackColor = Color.White;
            dgvUserr.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvUserr.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUserr.BackgroundColor = Color.FromArgb(217, 242, 208);
            dgvUserr.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvUserr.DefaultCellStyle = dataGridViewCellStyle4;
            dgvUserr.Location = new Point(27, 288);
            dgvUserr.Name = "dgvUserr";
            dgvUserr.RowHeadersWidth = 62;
            dgvUserr.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUserr.Size = new Size(1476, 502);
            dgvUserr.TabIndex = 23;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(661, 811);
            button1.Margin = new Padding(2, 3, 2, 3);
            button1.Name = "button1";
            button1.Size = new Size(165, 61);
            button1.TabIndex = 24;
            button1.Text = "CANCEL";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1072, 244);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(68, 25);
            label2.TabIndex = 27;
            label2.Text = "Search:";
            // 
            // tbS
            // 
            tbS.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbS.ForeColor = Color.Black;
            tbS.Location = new Point(1146, 238);
            tbS.Name = "tbS";
            tbS.Size = new Size(357, 35);
            tbS.TabIndex = 26;
            tbS.TextChanged += tbS_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Gold;
            label7.Font = new Font("Arial Rounded MT Bold", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(693, 183);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(221, 51);
            label7.TabIndex = 29;
            label7.Text = "HISTORY";
            // 
            // cbProcess
            // 
            cbProcess.FormattingEnabled = true;
            cbProcess.Location = new Point(121, 244);
            cbProcess.Name = "cbProcess";
            cbProcess.Size = new Size(157, 33);
            cbProcess.TabIndex = 30;
            cbProcess.SelectedIndexChanged += cbProcess_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 248);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(76, 25);
            label3.TabIndex = 31;
            label3.Text = "Process:";
            // 
            // ST_HISTORY
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1531, 897);
            Controls.Add(label3);
            Controls.Add(cbProcess);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(tbS);
            Controls.Add(button1);
            Controls.Add(dgvUserr);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ST_HISTORY";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ST_HISTORY";
            Load += ST_HISTORY_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUser).EndInit();
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
        private DataGridView dgvUser;
        private DataGridView dgvUserr;
        private Button button1;
        private Label label2;
        private TextBox tbS;
        private Label label7;
        private ComboBox cbProcess;
        private Label label3;
    }
}