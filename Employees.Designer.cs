namespace Management_System
{
    partial class Employees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employees));
            EmployeeNameTb = new TextBox();
            label3 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            EmployeeSalaryTb = new TextBox();
            label7 = new Label();
            label8 = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            EmployeeGenderCb = new ComboBox();
            EmployeeDepartmentCb = new ComboBox();
            EmployeeDateBirthTp = new DateTimePicker();
            EmployeeJoinDateTp = new DateTimePicker();
            btnAddToEmployee = new Button();
            btnUpdateToEmployee = new Button();
            EmployeeList = new DataGridView();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            btnDeleteToEmployee = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EmployeeList).BeginInit();
            SuspendLayout();
            // 
            // EmployeeNameTb
            // 
            EmployeeNameTb.Location = new Point(22, 212);
            EmployeeNameTb.Name = "EmployeeNameTb";
            EmployeeNameTb.Size = new Size(221, 23);
            EmployeeNameTb.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonFace;
            label3.ForeColor = SystemColors.ActiveCaption;
            label3.Location = new Point(22, 179);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 4;
            label3.Text = "Employee Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonFace;
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(22, 251);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 6;
            label1.Text = "Employee Gender";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1146, 100);
            panel1.TabIndex = 8;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonFace;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = SystemColors.ActiveCaption;
            label4.Location = new Point(580, 174);
            label4.Name = "label4";
            label4.Size = new Size(138, 21);
            label4.TabIndex = 1;
            label4.Text = "Manage Employee";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ButtonFace;
            label5.ForeColor = SystemColors.ActiveCaption;
            label5.Location = new Point(23, 392);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 11;
            label5.Text = "Date of Birth";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ButtonFace;
            label6.ForeColor = SystemColors.ActiveCaption;
            label6.Location = new Point(22, 320);
            label6.Name = "label6";
            label6.Size = new Size(125, 15);
            label6.TabIndex = 9;
            label6.Text = "Employee Department";
            // 
            // EmployeeSalaryTb
            // 
            EmployeeSalaryTb.Location = new Point(22, 537);
            EmployeeSalaryTb.Name = "EmployeeSalaryTb";
            EmployeeSalaryTb.Size = new Size(221, 23);
            EmployeeSalaryTb.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ButtonFace;
            label7.ForeColor = SystemColors.ActiveCaption;
            label7.Location = new Point(22, 519);
            label7.Name = "label7";
            label7.Size = new Size(122, 15);
            label7.TabIndex = 15;
            label7.Text = "Employee Daily Salary";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.ButtonFace;
            label8.ForeColor = SystemColors.ActiveCaption;
            label8.Location = new Point(22, 456);
            label8.Name = "label8";
            label8.Size = new Size(55, 15);
            label8.TabIndex = 13;
            label8.Text = "Join Date";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 606);
            panel2.Name = "panel2";
            panel2.Size = new Size(1146, 10);
            panel2.TabIndex = 17;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(134, 113);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(99, 81);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // EmployeeGenderCb
            // 
            EmployeeGenderCb.FormattingEnabled = true;
            EmployeeGenderCb.Items.AddRange(new object[] { "Male", "Female" });
            EmployeeGenderCb.Location = new Point(23, 281);
            EmployeeGenderCb.Name = "EmployeeGenderCb";
            EmployeeGenderCb.Size = new Size(220, 23);
            EmployeeGenderCb.TabIndex = 19;
            // 
            // EmployeeDepartmentCb
            // 
            EmployeeDepartmentCb.FormattingEnabled = true;
            EmployeeDepartmentCb.Location = new Point(23, 356);
            EmployeeDepartmentCb.Name = "EmployeeDepartmentCb";
            EmployeeDepartmentCb.Size = new Size(220, 23);
            EmployeeDepartmentCb.TabIndex = 20;
            // 
            // EmployeeDateBirthTp
            // 
            EmployeeDateBirthTp.CalendarMonthBackground = SystemColors.GradientActiveCaption;
            EmployeeDateBirthTp.Format = DateTimePickerFormat.Short;
            EmployeeDateBirthTp.Location = new Point(23, 420);
            EmployeeDateBirthTp.Name = "EmployeeDateBirthTp";
            EmployeeDateBirthTp.Size = new Size(220, 23);
            EmployeeDateBirthTp.TabIndex = 21;
            // 
            // EmployeeJoinDateTp
            // 
            EmployeeJoinDateTp.CalendarMonthBackground = SystemColors.GradientActiveCaption;
            EmployeeJoinDateTp.Format = DateTimePickerFormat.Short;
            EmployeeJoinDateTp.Location = new Point(22, 483);
            EmployeeJoinDateTp.Name = "EmployeeJoinDateTp";
            EmployeeJoinDateTp.Size = new Size(221, 23);
            EmployeeJoinDateTp.TabIndex = 22;
            // 
            // btnAddToEmployee
            // 
            btnAddToEmployee.BackColor = SystemColors.ActiveCaption;
            btnAddToEmployee.Location = new Point(5, 566);
            btnAddToEmployee.Name = "btnAddToEmployee";
            btnAddToEmployee.Size = new Size(81, 34);
            btnAddToEmployee.TabIndex = 23;
            btnAddToEmployee.Text = "Add";
            btnAddToEmployee.UseVisualStyleBackColor = false;
            btnAddToEmployee.Click += btnAddToEmployee_Click;
            // 
            // btnUpdateToEmployee
            // 
            btnUpdateToEmployee.BackColor = SystemColors.ActiveBorder;
            btnUpdateToEmployee.Location = new Point(92, 566);
            btnUpdateToEmployee.Name = "btnUpdateToEmployee";
            btnUpdateToEmployee.Size = new Size(81, 34);
            btnUpdateToEmployee.TabIndex = 24;
            btnUpdateToEmployee.Text = "Update";
            btnUpdateToEmployee.UseVisualStyleBackColor = false;
            btnUpdateToEmployee.Click += btnUpdateToEmployee_Click;
            // 
            // EmployeeList
            // 
            EmployeeList.BackgroundColor = SystemColors.ButtonFace;
            EmployeeList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EmployeeList.Location = new Point(290, 212);
            EmployeeList.Name = "EmployeeList";
            EmployeeList.Size = new Size(812, 378);
            EmployeeList.TabIndex = 25;
            EmployeeList.CellContentClick += EmployeeList_CellContentClick;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.ButtonFace;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Underline);
            label9.ForeColor = SystemColors.ActiveCaption;
            label9.Location = new Point(829, 113);
            label9.Name = "label9";
            label9.Size = new Size(56, 19);
            label9.TabIndex = 55;
            label9.Text = "Logout";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = SystemColors.ButtonFace;
            label10.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label10.ForeColor = SystemColors.ActiveCaption;
            label10.Location = new Point(506, 113);
            label10.Name = "label10";
            label10.Size = new Size(95, 19);
            label10.TabIndex = 54;
            label10.Text = "Departments";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = SystemColors.ButtonFace;
            label11.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label11.ForeColor = SystemColors.ActiveCaption;
            label11.Location = new Point(648, 113);
            label11.Name = "label11";
            label11.Size = new Size(52, 19);
            label11.TabIndex = 53;
            label11.Text = "Salary";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = SystemColors.ButtonFace;
            label12.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label12.ForeColor = SystemColors.ActiveCaption;
            label12.Location = new Point(397, 113);
            label12.Name = "label12";
            label12.Size = new Size(75, 19);
            label12.TabIndex = 52;
            label12.Text = "Employee";
            // 
            // btnDeleteToEmployee
            // 
            btnDeleteToEmployee.BackColor = SystemColors.GradientActiveCaption;
            btnDeleteToEmployee.Location = new Point(179, 566);
            btnDeleteToEmployee.Name = "btnDeleteToEmployee";
            btnDeleteToEmployee.Size = new Size(81, 34);
            btnDeleteToEmployee.TabIndex = 56;
            btnDeleteToEmployee.Text = "Delete";
            btnDeleteToEmployee.UseVisualStyleBackColor = false;
            btnDeleteToEmployee.Click += btnDeleteToEmployee_Click;
            // 
            // Employees
            // 
            AccessibleName = "";
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1146, 616);
            Controls.Add(btnDeleteToEmployee);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(EmployeeList);
            Controls.Add(btnUpdateToEmployee);
            Controls.Add(btnAddToEmployee);
            Controls.Add(EmployeeJoinDateTp);
            Controls.Add(EmployeeDateBirthTp);
            Controls.Add(EmployeeDepartmentCb);
            Controls.Add(EmployeeGenderCb);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(EmployeeSalaryTb);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(EmployeeNameTb);
            Controls.Add(label3);
            Name = "Employees";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employees";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)EmployeeList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox EmployeeNameTb;
        private Label label3;
        private Label label1;
        private Panel panel1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox EmployeeSalaryTb;
        private Label label7;
        private Label label8;
        private Panel panel2;
        private PictureBox pictureBox1;
        private ComboBox EmployeeGenderCb;
        private ComboBox EmployeeDepartmentCb;
        private DateTimePicker EmployeeDateBirthTp;
        private DateTimePicker EmployeeJoinDateTp;
        private Button btnAddToEmployee;
        private Button btnUpdateToEmployee;
        private DataGridView EmployeeList;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Button btnDeleteToEmployee;
    }
}