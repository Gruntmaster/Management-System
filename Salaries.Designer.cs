namespace Management_System
{
    partial class Salaries
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Salaries));
            dataGridViewSalary = new DataGridView();
            btnUpdateToSystem = new Button();
            btnAddToSystem = new Button();
            dateTimePicker1 = new DateTimePicker();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            comboBox3 = new ComboBox();
            textBox1 = new TextBox();
            dateTimePicker3 = new DateTimePicker();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSalary).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewSalary
            // 
            dataGridViewSalary.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewSalary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSalary.Location = new Point(322, 224);
            dataGridViewSalary.Name = "dataGridViewSalary";
            dataGridViewSalary.Size = new Size(812, 378);
            dataGridViewSalary.TabIndex = 43;
            // 
            // btnUpdateToSystem
            // 
            btnUpdateToSystem.Location = new Point(152, 581);
            btnUpdateToSystem.Name = "btnUpdateToSystem";
            btnUpdateToSystem.Size = new Size(81, 34);
            btnUpdateToSystem.TabIndex = 42;
            btnUpdateToSystem.Text = "Update";
            btnUpdateToSystem.UseVisualStyleBackColor = true;
            // 
            // btnAddToSystem
            // 
            btnAddToSystem.Location = new Point(13, 581);
            btnAddToSystem.Name = "btnAddToSystem";
            btnAddToSystem.Size = new Size(81, 34);
            btnAddToSystem.TabIndex = 41;
            btnAddToSystem.Text = "Add";
            btnAddToSystem.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarMonthBackground = SystemColors.GradientActiveCaption;
            dateTimePicker1.Location = new Point(13, 435);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(220, 29);
            dateTimePicker1.TabIndex = 39;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(152, 124);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(99, 81);
            pictureBox1.TabIndex = 36;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ButtonFace;
            label5.ForeColor = SystemColors.ActiveCaption;
            label5.Location = new Point(14, 402);
            label5.Name = "label5";
            label5.Size = new Size(113, 21);
            label5.TabIndex = 32;
            label5.Text = "Salary Amount";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ButtonFace;
            label6.ForeColor = SystemColors.ActiveCaption;
            label6.Location = new Point(12, 335);
            label6.Name = "label6";
            label6.Size = new Size(54, 21);
            label6.TabIndex = 31;
            label6.Text = "Period";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonFace;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = SystemColors.ActiveCaption;
            label4.Location = new Point(563, 168);
            label4.Name = "label4";
            label4.Size = new Size(113, 21);
            label4.TabIndex = 26;
            label4.Text = "Manage Salary";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1184, 100);
            panel1.TabIndex = 30;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Segoe UI", 20F);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(378, 31);
            label2.Name = "label2";
            label2.Size = new Size(389, 37);
            label2.TabIndex = 0;
            label2.Text = "Employee Management System";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonFace;
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(12, 266);
            label1.Name = "label1";
            label1.Size = new Size(111, 21);
            label1.TabIndex = 29;
            label1.Text = "Days Attended";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonFace;
            label3.ForeColor = SystemColors.ActiveCaption;
            label3.Location = new Point(12, 194);
            label3.Name = "label3";
            label3.Size = new Size(78, 21);
            label3.TabIndex = 27;
            label3.Text = "Employee";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Male", "Female" });
            comboBox3.Location = new Point(13, 224);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(220, 29);
            comboBox3.TabIndex = 44;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(13, 290);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(221, 29);
            textBox1.TabIndex = 45;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.CalendarMonthBackground = SystemColors.GradientActiveCaption;
            dateTimePicker3.Location = new Point(14, 359);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(220, 29);
            dateTimePicker3.TabIndex = 46;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.ButtonFace;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Underline);
            label9.ForeColor = SystemColors.ActiveCaption;
            label9.Location = new Point(875, 113);
            label9.Name = "label9";
            label9.Size = new Size(56, 19);
            label9.TabIndex = 59;
            label9.Text = "Logout";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = SystemColors.ButtonFace;
            label10.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label10.ForeColor = SystemColors.ActiveCaption;
            label10.Location = new Point(552, 113);
            label10.Name = "label10";
            label10.Size = new Size(95, 19);
            label10.TabIndex = 58;
            label10.Text = "Departments";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = SystemColors.ButtonFace;
            label11.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label11.ForeColor = SystemColors.ActiveCaption;
            label11.Location = new Point(694, 113);
            label11.Name = "label11";
            label11.Size = new Size(52, 19);
            label11.TabIndex = 57;
            label11.Text = "Salary";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = SystemColors.ButtonFace;
            label12.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label12.ForeColor = SystemColors.ActiveCaption;
            label12.Location = new Point(443, 113);
            label12.Name = "label12";
            label12.Size = new Size(75, 19);
            label12.TabIndex = 56;
            label12.Text = "Employee";
            // 
            // Salaries
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1184, 645);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(dateTimePicker3);
            Controls.Add(textBox1);
            Controls.Add(comboBox3);
            Controls.Add(dataGridViewSalary);
            Controls.Add(btnUpdateToSystem);
            Controls.Add(btnAddToSystem);
            Controls.Add(dateTimePicker1);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(label3);
            Font = new Font("Segoe UI", 12F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 4, 4, 4);
            Name = "Salaries";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Salaries";
            ((System.ComponentModel.ISupportInitialize)dataGridViewSalary).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewSalary;
        private Button btnUpdateToSystem;
        private Button btnAddToSystem;
        private DateTimePicker dateTimePicker1;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label6;
        private Label label4;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label label3;
        private ComboBox comboBox3;
        private TextBox textBox1;
        private DateTimePicker dateTimePicker3;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
    }
}