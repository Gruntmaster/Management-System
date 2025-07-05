namespace Management_System
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
            panel2 = new Panel();
            labelUsername = new Label();
            labelPassword = new Label();
            tbUsername = new TextBox();
            tbPassword = new TextBox();
            pictureBox1 = new PictureBox();
            btnLogin = new Button();
            resetLbl = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(4, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(255, 447);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Location = new Point(543, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(255, 447);
            panel2.TabIndex = 1;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Segoe UI", 14F);
            labelUsername.Location = new Point(295, 125);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(97, 25);
            labelUsername.TabIndex = 2;
            labelUsername.Text = "Username";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 14F);
            labelPassword.Location = new Point(295, 213);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(91, 25);
            labelPassword.TabIndex = 3;
            labelPassword.Text = "Password";
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(295, 163);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(219, 23);
            tbUsername.TabIndex = 4;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(295, 250);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = 'X';
            tbPassword.Size = new Size(219, 23);
            tbPassword.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._2020061110124099561_dengi;
            pictureBox1.Location = new Point(345, 62);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(345, 314);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(100, 35);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // resetLbl
            // 
            resetLbl.AutoSize = true;
            resetLbl.BackColor = SystemColors.Control;
            resetLbl.Font = new Font("Segoe UI", 10F, FontStyle.Underline);
            resetLbl.ForeColor = SystemColors.WindowFrame;
            resetLbl.Location = new Point(375, 371);
            resetLbl.Name = "resetLbl";
            resetLbl.Size = new Size(42, 19);
            resetLbl.TabIndex = 8;
            resetLbl.Text = "Reset";
            resetLbl.Click += resetLbl_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(19, 195);
            label1.Name = "label1";
            label1.Size = new Size(209, 41);
            label1.TabIndex = 0;
            label1.Text = "Employee MS";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(resetLbl);
            Controls.Add(btnLogin);
            Controls.Add(pictureBox1);
            Controls.Add(tbPassword);
            Controls.Add(tbUsername);
            Controls.Add(labelPassword);
            Controls.Add(labelUsername);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Login";
            Text = "Management System";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label labelUsername;
        private Label labelPassword;
        private TextBox tbUsername;
        private TextBox tbPassword;
        private PictureBox pictureBox1;
        private Button btnLogin;
        private Label resetLbl;
        private Label label1;
    }
}
