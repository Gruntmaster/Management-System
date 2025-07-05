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
            btnUpdateToSalary = new Button();
            btnAddToSalary = new Button();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            employeeNameCb = new ComboBox();
            daysAttendedTb = new TextBox();
            periodTp = new DateTimePicker();
            LogoutLbl = new Label();
            label10 = new Label();
            SalaryLbl = new Label();
            label12 = new Label();
            salaryTb = new TextBox();
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
            dataGridViewSalary.CellContentClick += dataGridViewSalary_CellContentClick;
            // 
            // btnUpdateToSalary
            // 
            btnUpdateToSalary.Location = new Point(152, 581);
            btnUpdateToSalary.Name = "btnUpdateToSalary";
            btnUpdateToSalary.Size = new Size(81, 34);
            btnUpdateToSalary.TabIndex = 42;
            btnUpdateToSalary.Text = "Update";
            btnUpdateToSalary.UseVisualStyleBackColor = true;
            // 
            // btnAddToSalary
            // 
            btnAddToSalary.Location = new Point(13, 581);
            btnAddToSalary.Name = "btnAddToSalary";
            btnAddToSalary.Size = new Size(81, 34);
            btnAddToSalary.TabIndex = 41;
            btnAddToSalary.Text = "Add";
            btnAddToSalary.UseVisualStyleBackColor = true;
            btnAddToSalary.Click += btnAddToSalary_Click;
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
            // employeeNameCb
            // 
            employeeNameCb.FormattingEnabled = true;
            employeeNameCb.Items.AddRange(new object[] { "Male", "Female" });
            employeeNameCb.Location = new Point(13, 224);
            employeeNameCb.Name = "employeeNameCb";
            employeeNameCb.Size = new Size(220, 29);
            employeeNameCb.TabIndex = 44;
            employeeNameCb.SelectionChangeCommitted += employeeNameCb_SelectionChangeCommitted;
            // 
            // daysAttendedTb
            // 
            daysAttendedTb.Location = new Point(13, 290);
            daysAttendedTb.Name = "daysAttendedTb";
            daysAttendedTb.Size = new Size(221, 29);
            daysAttendedTb.TabIndex = 45;
            // 
            // periodTp
            // 
            periodTp.CalendarMonthBackground = SystemColors.GradientActiveCaption;
            periodTp.Location = new Point(14, 359);
            periodTp.Name = "periodTp";
            periodTp.Size = new Size(220, 29);
            periodTp.TabIndex = 46;
            // 
            // LogoutLbl
            // 
            LogoutLbl.AutoSize = true;
            LogoutLbl.BackColor = SystemColors.ButtonFace;
            LogoutLbl.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Underline);
            LogoutLbl.ForeColor = SystemColors.ActiveCaption;
            LogoutLbl.Location = new Point(875, 113);
            LogoutLbl.Name = "LogoutLbl";
            LogoutLbl.Size = new Size(56, 19);
            LogoutLbl.TabIndex = 59;
            LogoutLbl.Text = "Logout";
            LogoutLbl.Click += LogoutLbl_Click;
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
            label10.Click += label10_Click;
            // 
            // SalaryLbl
            // 
            SalaryLbl.AutoSize = true;
            SalaryLbl.BackColor = SystemColors.ButtonFace;
            SalaryLbl.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            SalaryLbl.ForeColor = SystemColors.ActiveCaption;
            SalaryLbl.Location = new Point(694, 113);
            SalaryLbl.Name = "SalaryLbl";
            SalaryLbl.Size = new Size(52, 19);
            SalaryLbl.TabIndex = 57;
            SalaryLbl.Text = "Salary";
            SalaryLbl.Click += SalaryLbl_Click;
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
            label12.Click += label12_Click;
            // 
            // salaryTb
            // 
            salaryTb.BackColor = SystemColors.ButtonFace;
            salaryTb.BorderStyle = BorderStyle.None;
            salaryTb.Enabled = false;
            salaryTb.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            salaryTb.ForeColor = SystemColors.ActiveCaption;
            salaryTb.Location = new Point(13, 426);
            salaryTb.Name = "salaryTb";
            salaryTb.Size = new Size(221, 22);
            salaryTb.TabIndex = 60;
            salaryTb.TextAlign = HorizontalAlignment.Right;
            // 
            // Salaries
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1184, 645);
            Controls.Add(salaryTb);
            Controls.Add(LogoutLbl);
            Controls.Add(label10);
            Controls.Add(SalaryLbl);
            Controls.Add(label12);
            Controls.Add(periodTp);
            Controls.Add(daysAttendedTb);
            Controls.Add(employeeNameCb);
            Controls.Add(dataGridViewSalary);
            Controls.Add(btnUpdateToSalary);
            Controls.Add(btnAddToSalary);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(label3);
            Font = new Font("Segoe UI", 12F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
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
        private Button btnUpdateToSalary;
        private Button btnAddToSalary;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label6;
        private Label label4;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label label3;
        private ComboBox employeeNameCb;
        private TextBox daysAttendedTb;
        private DateTimePicker periodTp;
        private Label LogoutLbl;
        private Label label10;
        private Label SalaryLbl;
        private Label label12;
        private TextBox salaryTb;
    }
}