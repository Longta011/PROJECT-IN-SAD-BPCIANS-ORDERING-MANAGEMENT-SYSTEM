namespace BOMS_USER
{
    partial class shop_int
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
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            panel4 = new Panel();
            btn_About = new Button();
            btn_sizeG = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnAll = new Button();
            btnDept = new Button();
            btnUnif = new Button();
            btnOthers = new Button();
            dashboardPanel = new FlowLayoutPanel();
            tbS = new TextBox();
            label4 = new Label();
            fileSystemWatcher1 = new FileSystemWatcher();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(59, 125, 35);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-6, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1661, 103);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Bpcian_s_Marketplace_removebg_preview;
            pictureBox1.Location = new Point(83, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(121, 92);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(59, 125, 35);
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(10, 105);
            panel3.Name = "panel3";
            panel3.Size = new Size(1661, 103);
            panel3.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(65, 7);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(116, 93);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 28F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(214, 19);
            label2.Name = "label2";
            label2.Size = new Size(1274, 65);
            label2.TabIndex = 1;
            label2.Text = "BPCIANS ORDERING MANAGEMENT SYSTEM\r\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 28F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(214, 19);
            label1.Name = "label1";
            label1.Size = new Size(1274, 65);
            label1.TabIndex = 1;
            label1.Text = "BPCIANS ORDERING MANAGEMENT SYSTEM\r\n";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(217, 242, 208);
            panel4.Controls.Add(btn_About);
            panel4.Controls.Add(btn_sizeG);
            panel4.Location = new Point(0, 101);
            panel4.Name = "panel4";
            panel4.Size = new Size(1661, 69);
            panel4.TabIndex = 4;
            // 
            // btn_About
            // 
            btn_About.BackColor = Color.Green;
            btn_About.BackgroundImageLayout = ImageLayout.Zoom;
            btn_About.DialogResult = DialogResult.TryAgain;
            btn_About.ForeColor = Color.White;
            btn_About.Location = new Point(1466, 16);
            btn_About.Name = "btn_About";
            btn_About.Size = new Size(123, 39);
            btn_About.TabIndex = 2;
            btn_About.Text = "ABOUT US";
            btn_About.UseVisualStyleBackColor = false;
            btn_About.Click += btn_About_Click;
            // 
            // btn_sizeG
            // 
            btn_sizeG.BackColor = Color.Green;
            btn_sizeG.BackgroundImageLayout = ImageLayout.Zoom;
            btn_sizeG.DialogResult = DialogResult.TryAgain;
            btn_sizeG.ForeColor = Color.White;
            btn_sizeG.Location = new Point(1337, 16);
            btn_sizeG.Name = "btn_sizeG";
            btn_sizeG.Size = new Size(123, 39);
            btn_sizeG.TabIndex = 0;
            btn_sizeG.Text = "SIZE GUIDE";
            btn_sizeG.UseVisualStyleBackColor = false;
            btn_sizeG.Click += btn_sizeG_Click;
            // 
            // btnAll
            // 
            btnAll.BackColor = Color.Green;
            btnAll.ForeColor = Color.White;
            btnAll.Location = new Point(14, 187);
            btnAll.Name = "btnAll";
            btnAll.Size = new Size(184, 48);
            btnAll.TabIndex = 9;
            btnAll.Text = "ALL CATEGORY";
            btnAll.UseVisualStyleBackColor = false;
            btnAll.Click += btnAll_Click;
            // 
            // btnDept
            // 
            btnDept.Location = new Point(204, 187);
            btnDept.Name = "btnDept";
            btnDept.Size = new Size(184, 48);
            btnDept.TabIndex = 10;
            btnDept.Text = "DEPT SHIRT";
            btnDept.UseVisualStyleBackColor = true;
            btnDept.Click += btnDept_Click;
            // 
            // btnUnif
            // 
            btnUnif.Location = new Point(394, 185);
            btnUnif.Name = "btnUnif";
            btnUnif.Size = new Size(184, 48);
            btnUnif.TabIndex = 11;
            btnUnif.Text = "SCHOOL UNIF";
            btnUnif.UseVisualStyleBackColor = true;
            btnUnif.Click += btnUnif_Click;
            // 
            // btnOthers
            // 
            btnOthers.Location = new Point(584, 185);
            btnOthers.Name = "btnOthers";
            btnOthers.Size = new Size(184, 48);
            btnOthers.TabIndex = 12;
            btnOthers.Text = "LANYARD/OTHERS";
            btnOthers.UseVisualStyleBackColor = true;
            btnOthers.Click += btnOthers_Click;
            // 
            // dashboardPanel
            // 
            dashboardPanel.AutoScroll = true;
            dashboardPanel.Location = new Point(81, 299);
            dashboardPanel.Name = "dashboardPanel";
            dashboardPanel.Size = new Size(1444, 566);
            dashboardPanel.TabIndex = 28;
            // 
            // tbS
            // 
            tbS.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbS.Location = new Point(868, 190);
            tbS.Name = "tbS";
            tbS.Size = new Size(217, 37);
            tbS.TabIndex = 29;
            tbS.TextChanged += tbS_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(776, 194);
            label4.Name = "label4";
            label4.Size = new Size(90, 32);
            label4.TabIndex = 30;
            label4.Text = "Search:";
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // shop_int
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1601, 884);
            Controls.Add(label4);
            Controls.Add(tbS);
            Controls.Add(dashboardPanel);
            Controls.Add(btnOthers);
            Controls.Add(btnUnif);
            Controls.Add(btnDept);
            Controls.Add(btnAll);
            Controls.Add(panel4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "shop_int";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "shop_int";
            Load += shop_int_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label1;
        private Panel panel4;
        private Button btn_About;
        private PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnAll;
        private Button btnDept;
        private Button btnUnif;
        private Button btnOthers;
        private FlowLayoutPanel dashboardPanel;
        private Button btn_sizeG;
        private TextBox tbS;
        private Label label4;
        private FileSystemWatcher fileSystemWatcher1;
    }
}