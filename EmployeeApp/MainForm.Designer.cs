namespace EmployeeApp
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.addEmployee1 = new EmployeeApp.AddEmployee();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.signoutBtn = new System.Windows.Forms.Button();
            this.addEmployeeBtn = new System.Windows.Forms.Button();
            this.salaryBtn = new System.Windows.Forms.Button();
            this.dashboardBtn = new System.Windows.Forms.Button();
            this.greetUser = new System.Windows.Forms.Label();
            this.dashboard1 = new EmployeeApp.Dashboard();
            this.salary1 = new EmployeeApp.Salary();
            this.addEmployee2 = new EmployeeApp.AddEmployee();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1355, 45);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(6, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employee Management System";
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Font = new System.Drawing.Font("Constantia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.exit.Location = new System.Drawing.Point(1319, 8);
            this.exit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(22, 22);
            this.exit.TabIndex = 0;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Controls.Add(this.addEmployee1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.signoutBtn);
            this.panel2.Controls.Add(this.addEmployeeBtn);
            this.panel2.Controls.Add(this.salaryBtn);
            this.panel2.Controls.Add(this.dashboardBtn);
            this.panel2.Controls.Add(this.greetUser);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(316, 630);
            this.panel2.TabIndex = 1;
            // 
            // addEmployee1
            // 
            this.addEmployee1.Location = new System.Drawing.Point(312, 0);
            this.addEmployee1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addEmployee1.Name = "addEmployee1";
            this.addEmployee1.Size = new System.Drawing.Size(1039, 630);
            this.addEmployee1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(83, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(125, 571);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sign out";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // signoutBtn
            // 
            this.signoutBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.signoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signoutBtn.FlatAppearance.BorderSize = 0;
            this.signoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signoutBtn.Image = ((System.Drawing.Image)(resources.GetObject("signoutBtn.Image")));
            this.signoutBtn.Location = new System.Drawing.Point(59, 557);
            this.signoutBtn.Name = "signoutBtn";
            this.signoutBtn.Size = new System.Drawing.Size(72, 61);
            this.signoutBtn.TabIndex = 2;
            this.signoutBtn.UseVisualStyleBackColor = false;
            this.signoutBtn.Click += new System.EventHandler(this.signoutBtn_Click);
            // 
            // addEmployeeBtn
            // 
            this.addEmployeeBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.addEmployeeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addEmployeeBtn.FlatAppearance.BorderSize = 2;
            this.addEmployeeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.addEmployeeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.addEmployeeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEmployeeBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addEmployeeBtn.Image = ((System.Drawing.Image)(resources.GetObject("addEmployeeBtn.Image")));
            this.addEmployeeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addEmployeeBtn.Location = new System.Drawing.Point(12, 362);
            this.addEmployeeBtn.Name = "addEmployeeBtn";
            this.addEmployeeBtn.Size = new System.Drawing.Size(289, 60);
            this.addEmployeeBtn.TabIndex = 4;
            this.addEmployeeBtn.Text = "ADD EMPLOYEE";
            this.addEmployeeBtn.UseVisualStyleBackColor = false;
            this.addEmployeeBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // salaryBtn
            // 
            this.salaryBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.salaryBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salaryBtn.FlatAppearance.BorderSize = 2;
            this.salaryBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.salaryBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.salaryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salaryBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.salaryBtn.Image = ((System.Drawing.Image)(resources.GetObject("salaryBtn.Image")));
            this.salaryBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salaryBtn.Location = new System.Drawing.Point(12, 296);
            this.salaryBtn.Name = "salaryBtn";
            this.salaryBtn.Size = new System.Drawing.Size(289, 60);
            this.salaryBtn.TabIndex = 3;
            this.salaryBtn.Text = "SALARY";
            this.salaryBtn.UseVisualStyleBackColor = false;
            this.salaryBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // dashboardBtn
            // 
            this.dashboardBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.dashboardBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashboardBtn.FlatAppearance.BorderSize = 2;
            this.dashboardBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.dashboardBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.dashboardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dashboardBtn.Image = ((System.Drawing.Image)(resources.GetObject("dashboardBtn.Image")));
            this.dashboardBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardBtn.Location = new System.Drawing.Point(12, 230);
            this.dashboardBtn.Name = "dashboardBtn";
            this.dashboardBtn.Size = new System.Drawing.Size(289, 60);
            this.dashboardBtn.TabIndex = 2;
            this.dashboardBtn.Text = "DASHBOARD";
            this.dashboardBtn.UseVisualStyleBackColor = false;
            this.dashboardBtn.Click += new System.EventHandler(this.dashboardBtn_Click);
            // 
            // greetUser
            // 
            this.greetUser.AutoSize = true;
            this.greetUser.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greetUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.greetUser.Location = new System.Drawing.Point(97, 187);
            this.greetUser.Name = "greetUser";
            this.greetUser.Size = new System.Drawing.Size(130, 21);
            this.greetUser.TabIndex = 1;
            this.greetUser.Text = "Welcome, User";
            // 
            // dashboard1
            // 
            this.dashboard1.Location = new System.Drawing.Point(312, 45);
            this.dashboard1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(1043, 630);
            this.dashboard1.TabIndex = 4;
            this.dashboard1.Load += new System.EventHandler(this.dashboard1_Load);
            // 
            // salary1
            // 
            this.salary1.Location = new System.Drawing.Point(312, 45);
            this.salary1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.salary1.Name = "salary1";
            this.salary1.Size = new System.Drawing.Size(1043, 643);
            this.salary1.TabIndex = 3;
            // 
            // addEmployee2
            // 
            this.addEmployee2.Location = new System.Drawing.Point(312, 45);
            this.addEmployee2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.addEmployee2.Name = "addEmployee2";
            this.addEmployee2.Size = new System.Drawing.Size(1385, 725);
            this.addEmployee2.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 675);
            this.Controls.Add(this.dashboard1);
            this.Controls.Add(this.salary1);
            this.Controls.Add(this.addEmployee2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label greetUser;
        private System.Windows.Forms.Button dashboardBtn;
        private System.Windows.Forms.Button addEmployeeBtn;
        private System.Windows.Forms.Button salaryBtn;
        private System.Windows.Forms.Button signoutBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private AddEmployee addEmployee1;
        private AddEmployee addEmployee2;
        private Salary salary1;
        private Dashboard dashboard1;
    }
}