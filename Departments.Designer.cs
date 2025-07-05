namespace Management_System
{
    partial class Departments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Departments));
            DepList = new DataGridView();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label4 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            DepartNameTb = new TextBox();
            label3 = new Label();
            label1 = new Label();
            btnUpdateToDepartment = new Button();
            btnAddToDepartment = new Button();
            EmpLbl = new Label();
            salaryLbl = new Label();
            label7 = new Label();
            label8 = new Label();
            btnDeleteToDepartment = new Button();
            ((System.ComponentModel.ISupportInitialize)DepList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // DepList
            // 
            DepList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            DepList.BackgroundColor = SystemColors.ButtonFace;
            DepList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DepList.Location = new Point(322, 209);
            DepList.Name = "DepList";
            DepList.ReadOnly = true;
            DepList.Size = new Size(812, 378);
            DepList.TabIndex = 44;
            DepList.CellContentClick += DepList_CellContentClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(151, 187);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(99, 81);
            pictureBox1.TabIndex = 37;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 620);
            panel2.Name = "panel2";
            panel2.Size = new Size(1180, 10);
            panel2.TabIndex = 36;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonFace;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = SystemColors.ActiveCaption;
            label4.Location = new Point(511, 147);
            label4.Name = "label4";
            label4.Size = new Size(160, 21);
            label4.TabIndex = 26;
            label4.Text = "Manage Departments";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1180, 100);
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
            // DepartNameTb
            // 
            DepartNameTb.Location = new Point(12, 274);
            DepartNameTb.Name = "DepartNameTb";
            DepartNameTb.Size = new Size(221, 29);
            DepartNameTb.TabIndex = 28;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonFace;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label3.ForeColor = SystemColors.ActiveCaption;
            label3.Location = new Point(12, 237);
            label3.Name = "label3";
            label3.Size = new Size(136, 21);
            label3.TabIndex = 27;
            label3.Text = "Employee Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(643, 177);
            label1.Name = "label1";
            label1.Size = new Size(128, 21);
            label1.TabIndex = 45;
            label1.Text = "Departments List";
            // 
            // btnUpdateToDepartment
            // 
            btnUpdateToDepartment.BackColor = SystemColors.ActiveBorder;
            btnUpdateToDepartment.Location = new Point(151, 321);
            btnUpdateToDepartment.Name = "btnUpdateToDepartment";
            btnUpdateToDepartment.Size = new Size(81, 34);
            btnUpdateToDepartment.TabIndex = 47;
            btnUpdateToDepartment.Text = "Update";
            btnUpdateToDepartment.UseVisualStyleBackColor = false;
            btnUpdateToDepartment.Click += btnUpdateToDepartment_Click;
            // 
            // btnAddToDepartment
            // 
            btnAddToDepartment.BackColor = SystemColors.ActiveCaption;
            btnAddToDepartment.Location = new Point(12, 321);
            btnAddToDepartment.Name = "btnAddToDepartment";
            btnAddToDepartment.Size = new Size(81, 34);
            btnAddToDepartment.TabIndex = 46;
            btnAddToDepartment.Text = "Add";
            btnAddToDepartment.UseVisualStyleBackColor = false;
            btnAddToDepartment.Click += btnAddToDepartment_Click;
            // 
            // EmpLbl
            // 
            EmpLbl.AutoSize = true;
            EmpLbl.BackColor = SystemColors.ButtonFace;
            EmpLbl.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            EmpLbl.ForeColor = SystemColors.ActiveCaption;
            EmpLbl.Location = new Point(434, 112);
            EmpLbl.Name = "EmpLbl";
            EmpLbl.Size = new Size(75, 19);
            EmpLbl.TabIndex = 48;
            EmpLbl.Text = "Employee";
            EmpLbl.Click += EmpLbl_Click;
            // 
            // salaryLbl
            // 
            salaryLbl.AutoSize = true;
            salaryLbl.BackColor = SystemColors.ButtonFace;
            salaryLbl.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            salaryLbl.ForeColor = SystemColors.ActiveCaption;
            salaryLbl.Location = new Point(685, 112);
            salaryLbl.Name = "salaryLbl";
            salaryLbl.Size = new Size(52, 19);
            salaryLbl.TabIndex = 49;
            salaryLbl.Text = "Salary";
            salaryLbl.Click += salaryLbl_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ButtonFace;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ActiveCaption;
            label7.Location = new Point(543, 112);
            label7.Name = "label7";
            label7.Size = new Size(95, 19);
            label7.TabIndex = 50;
            label7.Text = "Departments";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.ButtonFace;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Underline);
            label8.ForeColor = SystemColors.ActiveCaption;
            label8.Location = new Point(866, 112);
            label8.Name = "label8";
            label8.Size = new Size(56, 19);
            label8.TabIndex = 51;
            label8.Text = "Logout";
            // 
            // btnDeleteToDepartment
            // 
            btnDeleteToDepartment.BackColor = SystemColors.GradientInactiveCaption;
            btnDeleteToDepartment.Location = new Point(81, 361);
            btnDeleteToDepartment.Name = "btnDeleteToDepartment";
            btnDeleteToDepartment.Size = new Size(81, 34);
            btnDeleteToDepartment.TabIndex = 52;
            btnDeleteToDepartment.Text = "Delete";
            btnDeleteToDepartment.UseVisualStyleBackColor = false;
            btnDeleteToDepartment.Click += btnDeleteToDepartment_Click;
            // 
            // Departments
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1180, 630);
            Controls.Add(btnDeleteToDepartment);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(salaryLbl);
            Controls.Add(EmpLbl);
            Controls.Add(btnUpdateToDepartment);
            Controls.Add(btnAddToDepartment);
            Controls.Add(label1);
            Controls.Add(DepList);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(DepartNameTb);
            Controls.Add(label3);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Departments";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Departments";
            ((System.ComponentModel.ISupportInitialize)DepList).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DepList;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label4;
        private Panel panel1;
        private Label label2;
        private TextBox DepartNameTb;
        private Label label3;
        private Label label1;
        private Button btnUpdateToDepartment;
        private Button btnAddToDepartment;
        private Label EmpLbl;
        private Label salaryLbl;
        private Label label7;
        private Label label8;
        private Button btnDeleteToDepartment;
    }
}