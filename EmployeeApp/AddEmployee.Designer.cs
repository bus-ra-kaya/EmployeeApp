namespace EmployeeApp
{
    partial class AddEmployee
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.newEmployeeBranch = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.newEmployeeDeleteBtn = new System.Windows.Forms.Button();
            this.newEmployeeClearBtn = new System.Windows.Forms.Button();
            this.newEmployeeUpdateBtn = new System.Windows.Forms.Button();
            this.newEmployeeAddBtn = new System.Windows.Forms.Button();
            this.newEmployeeImportBtn = new System.Windows.Forms.Button();
            this.newEmployeePic = new System.Windows.Forms.PictureBox();
            this.newEmployeePosition = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.newEmployeePhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.newEmployeeGender = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.newEmployeeName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.newEmployeeID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newEmployeePic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(26, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 323);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(907, 246);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Info";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.newEmployeeBranch);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.newEmployeeDeleteBtn);
            this.panel2.Controls.Add(this.newEmployeeClearBtn);
            this.panel2.Controls.Add(this.newEmployeeUpdateBtn);
            this.panel2.Controls.Add(this.newEmployeeAddBtn);
            this.panel2.Controls.Add(this.newEmployeeImportBtn);
            this.panel2.Controls.Add(this.newEmployeePic);
            this.panel2.Controls.Add(this.newEmployeePosition);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.newEmployeePhone);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.newEmployeeGender);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.newEmployeeName);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.newEmployeeID);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(25, 369);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(983, 240);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // newEmployeeBranch
            // 
            this.newEmployeeBranch.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newEmployeeBranch.FormattingEnabled = true;
            this.newEmployeeBranch.Items.AddRange(new object[] {
            "City1",
            "City2",
            "City3"});
            this.newEmployeeBranch.Location = new System.Drawing.Point(557, 113);
            this.newEmployeeBranch.Name = "newEmployeeBranch";
            this.newEmployeeBranch.Size = new System.Drawing.Size(232, 29);
            this.newEmployeeBranch.TabIndex = 17;
            this.newEmployeeBranch.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(407, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 24);
            this.label7.TabIndex = 16;
            this.label7.Text = "Branch:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // newEmployeeDeleteBtn
            // 
            this.newEmployeeDeleteBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.newEmployeeDeleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newEmployeeDeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newEmployeeDeleteBtn.Font = new System.Drawing.Font("Constantia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newEmployeeDeleteBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.newEmployeeDeleteBtn.Location = new System.Drawing.Point(649, 160);
            this.newEmployeeDeleteBtn.Name = "newEmployeeDeleteBtn";
            this.newEmployeeDeleteBtn.Size = new System.Drawing.Size(151, 68);
            this.newEmployeeDeleteBtn.TabIndex = 15;
            this.newEmployeeDeleteBtn.Text = "Delete";
            this.newEmployeeDeleteBtn.UseVisualStyleBackColor = false;
            // 
            // newEmployeeClearBtn
            // 
            this.newEmployeeClearBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.newEmployeeClearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newEmployeeClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newEmployeeClearBtn.Font = new System.Drawing.Font("Constantia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newEmployeeClearBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.newEmployeeClearBtn.Location = new System.Drawing.Point(480, 160);
            this.newEmployeeClearBtn.Name = "newEmployeeClearBtn";
            this.newEmployeeClearBtn.Size = new System.Drawing.Size(151, 68);
            this.newEmployeeClearBtn.TabIndex = 14;
            this.newEmployeeClearBtn.Text = "Clear";
            this.newEmployeeClearBtn.UseVisualStyleBackColor = false;
            // 
            // newEmployeeUpdateBtn
            // 
            this.newEmployeeUpdateBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.newEmployeeUpdateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newEmployeeUpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newEmployeeUpdateBtn.Font = new System.Drawing.Font("Constantia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newEmployeeUpdateBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.newEmployeeUpdateBtn.Location = new System.Drawing.Point(316, 160);
            this.newEmployeeUpdateBtn.Name = "newEmployeeUpdateBtn";
            this.newEmployeeUpdateBtn.Size = new System.Drawing.Size(151, 68);
            this.newEmployeeUpdateBtn.TabIndex = 13;
            this.newEmployeeUpdateBtn.Text = "Update";
            this.newEmployeeUpdateBtn.UseVisualStyleBackColor = false;
            // 
            // newEmployeeAddBtn
            // 
            this.newEmployeeAddBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.newEmployeeAddBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newEmployeeAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newEmployeeAddBtn.Font = new System.Drawing.Font("Constantia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newEmployeeAddBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.newEmployeeAddBtn.Location = new System.Drawing.Point(147, 160);
            this.newEmployeeAddBtn.Name = "newEmployeeAddBtn";
            this.newEmployeeAddBtn.Size = new System.Drawing.Size(151, 68);
            this.newEmployeeAddBtn.TabIndex = 12;
            this.newEmployeeAddBtn.Text = "Add";
            this.newEmployeeAddBtn.UseVisualStyleBackColor = false;
            this.newEmployeeAddBtn.Click += new System.EventHandler(this.newEmployeeAddBtn_Click);
            // 
            // newEmployeeImportBtn
            // 
            this.newEmployeeImportBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.newEmployeeImportBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newEmployeeImportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newEmployeeImportBtn.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newEmployeeImportBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.newEmployeeImportBtn.Location = new System.Drawing.Point(838, 151);
            this.newEmployeeImportBtn.Name = "newEmployeeImportBtn";
            this.newEmployeeImportBtn.Size = new System.Drawing.Size(118, 30);
            this.newEmployeeImportBtn.TabIndex = 11;
            this.newEmployeeImportBtn.Text = "Import";
            this.newEmployeeImportBtn.UseVisualStyleBackColor = false;
            this.newEmployeeImportBtn.Click += new System.EventHandler(this.newEmployeeImportBtn_Click);
            // 
            // newEmployeePic
            // 
            this.newEmployeePic.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.newEmployeePic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newEmployeePic.Location = new System.Drawing.Point(838, 27);
            this.newEmployeePic.Name = "newEmployeePic";
            this.newEmployeePic.Size = new System.Drawing.Size(118, 131);
            this.newEmployeePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.newEmployeePic.TabIndex = 10;
            this.newEmployeePic.TabStop = false;
            this.newEmployeePic.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // newEmployeePosition
            // 
            this.newEmployeePosition.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newEmployeePosition.FormattingEnabled = true;
            this.newEmployeePosition.Items.AddRange(new object[] {
            "Business Manager",
            "Front-end Developer",
            "Back-end Developer",
            "Data Administator ",
            "CEO"});
            this.newEmployeePosition.Location = new System.Drawing.Point(557, 72);
            this.newEmployeePosition.Name = "newEmployeePosition";
            this.newEmployeePosition.Size = new System.Drawing.Size(232, 29);
            this.newEmployeePosition.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(407, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "Position:";
            // 
            // newEmployeePhone
            // 
            this.newEmployeePhone.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newEmployeePhone.Location = new System.Drawing.Point(557, 27);
            this.newEmployeePhone.Name = "newEmployeePhone";
            this.newEmployeePhone.Size = new System.Drawing.Size(232, 28);
            this.newEmployeePhone.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(407, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Phone Number:";
            // 
            // newEmployeeGender
            // 
            this.newEmployeeGender.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newEmployeeGender.FormattingEnabled = true;
            this.newEmployeeGender.Items.AddRange(new object[] {
            "Female",
            "Male",
            "Other"});
            this.newEmployeeGender.Location = new System.Drawing.Point(172, 113);
            this.newEmployeeGender.Name = "newEmployeeGender";
            this.newEmployeeGender.Size = new System.Drawing.Size(214, 29);
            this.newEmployeeGender.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Gender:";
            // 
            // newEmployeeName
            // 
            this.newEmployeeName.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newEmployeeName.Location = new System.Drawing.Point(171, 68);
            this.newEmployeeName.Name = "newEmployeeName";
            this.newEmployeeName.Size = new System.Drawing.Size(215, 28);
            this.newEmployeeName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Full Name:";
            // 
            // newEmployeeID
            // 
            this.newEmployeeID.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newEmployeeID.Location = new System.Drawing.Point(171, 23);
            this.newEmployeeID.Name = "newEmployeeID";
            this.newEmployeeID.Size = new System.Drawing.Size(215, 28);
            this.newEmployeeID.TabIndex = 1;
            this.newEmployeeID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Employee ID:";
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddEmployee";
            this.Size = new System.Drawing.Size(1039, 630);
            this.Load += new System.EventHandler(this.AddEmployee_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newEmployeePic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox newEmployeeID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox newEmployeeGender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox newEmployeeName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox newEmployeePosition;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox newEmployeePhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button newEmployeeAddBtn;
        private System.Windows.Forms.Button newEmployeeImportBtn;
        private System.Windows.Forms.PictureBox newEmployeePic;
        private System.Windows.Forms.Button newEmployeeUpdateBtn;
        private System.Windows.Forms.Button newEmployeeDeleteBtn;
        private System.Windows.Forms.Button newEmployeeClearBtn;
        private System.Windows.Forms.ComboBox newEmployeeBranch;
        private System.Windows.Forms.Label label7;
    }
}
