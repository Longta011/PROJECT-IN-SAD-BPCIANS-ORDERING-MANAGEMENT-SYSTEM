namespace BOMS_customer
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            tb_User = new TextBox();
            tb_Pass = new TextBox();
            label2 = new Label();
            label3 = new Label();
            checkBox1 = new CheckBox();
            btn_Log = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(180, 229, 162);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(570, 596);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Bpcian_s_Marketplace_removebg_preview;
            pictureBox1.Location = new Point(33, 84);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(490, 481);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(792, 72);
            label1.Name = "label1";
            label1.Size = new Size(136, 42);
            label1.TabIndex = 1;
            label1.Text = "LOGIN";
            // 
            // tb_User
            // 
            tb_User.BorderStyle = BorderStyle.None;
            tb_User.Font = new Font("Arial Narrow", 12F);
            tb_User.Location = new Point(666, 236);
            tb_User.Name = "tb_User";
            tb_User.Size = new Size(409, 28);
            tb_User.TabIndex = 2;
            // 
            // tb_Pass
            // 
            tb_Pass.Font = new Font("Arial Narrow", 12F);
            tb_Pass.Location = new Point(658, 329);
            tb_Pass.Name = "tb_Pass";
            tb_Pass.PasswordChar = '*';
            tb_Pass.Size = new Size(409, 35);
            tb_Pass.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F);
            label2.Location = new Point(658, 190);
            label2.Name = "label2";
            label2.Size = new Size(139, 28);
            label2.TabIndex = 4;
            label2.Text = "Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 12F);
            label3.Location = new Point(658, 289);
            label3.Name = "label3";
            label3.Size = new Size(136, 28);
            label3.TabIndex = 5;
            label3.Text = "Password:";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(666, 373);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(162, 29);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // btn_Log
            // 
            btn_Log.Location = new Point(769, 419);
            btn_Log.Name = "btn_Log";
            btn_Log.Size = new Size(195, 48);
            btn_Log.TabIndex = 10;
            btn_Log.Text = "LOGIN";
            btn_Log.UseVisualStyleBackColor = true;
            btn_Log.Click += btn_Log_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(214, 235, 210);
            ClientSize = new Size(1143, 593);
            Controls.Add(btn_Log);
            Controls.Add(checkBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tb_Pass);
            Controls.Add(tb_User);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Login_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox tb_User;
        private TextBox tb_Pass;
        private Label label2;
        private Label label3;
        private CheckBox checkBox1;
        private Button btn_Log;
        private Label label4;
    }
}
