namespace BOMS_customer
{
    partial class Forgot_RP
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
            label1 = new Label();
            tb_NP = new TextBox();
            label2 = new Label();
            label3 = new Label();
            tb_NRP = new TextBox();
            cb_NP = new CheckBox();
            checkBox2 = new CheckBox();
            btn_Confirm = new Button();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(180, 229, 162);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(572, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(570, 596);
            panel1.TabIndex = 3;
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
            label1.Font = new Font("Roboto Condensed", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(163, 82);
            label1.Name = "label1";
            label1.Size = new Size(229, 43);
            label1.TabIndex = 8;
            label1.Text = "New Password";
            // 
            // tb_NP
            // 
            tb_NP.Location = new Point(107, 216);
            tb_NP.Name = "tb_NP";
            tb_NP.Size = new Size(314, 31);
            tb_NP.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(107, 178);
            label2.Name = "label2";
            label2.Size = new Size(197, 23);
            label2.TabIndex = 10;
            label2.Text = "Enter new password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(107, 304);
            label3.Name = "label3";
            label3.Size = new Size(197, 23);
            label3.TabIndex = 11;
            label3.Text = "Enter new password:";
            // 
            // tb_NRP
            // 
            tb_NRP.Location = new Point(107, 347);
            tb_NRP.Name = "tb_NRP";
            tb_NRP.Size = new Size(314, 31);
            tb_NRP.TabIndex = 12;
            // 
            // cb_NP
            // 
            cb_NP.AutoSize = true;
            cb_NP.Font = new Font("Arial Narrow", 9F);
            cb_NP.Location = new Point(107, 253);
            cb_NP.Name = "cb_NP";
            cb_NP.Size = new Size(139, 26);
            cb_NP.TabIndex = 13;
            cb_NP.Text = "Show password";
            cb_NP.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Arial Narrow", 9F);
            checkBox2.Location = new Point(107, 384);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(139, 26);
            checkBox2.TabIndex = 14;
            checkBox2.Text = "Show password";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // btn_Confirm
            // 
            btn_Confirm.Font = new Font("Arial Narrow", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Confirm.Location = new Point(181, 444);
            btn_Confirm.Name = "btn_Confirm";
            btn_Confirm.Size = new Size(164, 49);
            btn_Confirm.TabIndex = 15;
            btn_Confirm.Text = "CONFIRM";
            btn_Confirm.UseVisualStyleBackColor = true;
            btn_Confirm.Click += btn_Confirm_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(118, 21);
            label4.Name = "label4";
            label4.Size = new Size(337, 60);
            label4.TabIndex = 16;
            label4.Text = "HELLO ADMIN";
            // 
            // Forgot_RP
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(214, 235, 210);
            ClientSize = new Size(1143, 593);
            Controls.Add(btn_Confirm);
            Controls.Add(checkBox2);
            Controls.Add(cb_NP);
            Controls.Add(tb_NRP);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tb_NP);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Forgot_RP";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Forgot_RP";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox tb_NP;
        private Label label2;
        private Label label3;
        private TextBox tb_NRP;
        private CheckBox cb_NP;
        private CheckBox checkBox2;
        private Button btn_Confirm;
        private Label label4;
    }
}