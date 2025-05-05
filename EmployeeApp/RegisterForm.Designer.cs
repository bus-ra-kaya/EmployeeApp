namespace EmployeeApp
{
    partial class RegisterForm
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
            this.exit = new System.Windows.Forms.Label();
            this.R_signupButton = new System.Windows.Forms.Button();
            this.R_ShowPass = new System.Windows.Forms.CheckBox();
            this.R_Password = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.R_Username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.R_LoginButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Location = new System.Drawing.Point(689, 6);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(14, 13);
            this.exit.TabIndex = 10;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // R_signupButton
            // 
            this.R_signupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.R_signupButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.R_signupButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.R_signupButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.R_signupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.R_signupButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.R_signupButton.Location = new System.Drawing.Point(451, 340);
            this.R_signupButton.Name = "R_signupButton";
            this.R_signupButton.Size = new System.Drawing.Size(159, 54);
            this.R_signupButton.TabIndex = 18;
            this.R_signupButton.Text = "REGISTER";
            this.R_signupButton.UseVisualStyleBackColor = false;
            this.R_signupButton.Click += new System.EventHandler(this.R_signupButton_Click);
            // 
            // R_ShowPass
            // 
            this.R_ShowPass.AutoSize = true;
            this.R_ShowPass.Location = new System.Drawing.Point(568, 232);
            this.R_ShowPass.Name = "R_ShowPass";
            this.R_ShowPass.Size = new System.Drawing.Size(102, 17);
            this.R_ShowPass.TabIndex = 17;
            this.R_ShowPass.Text = "Show Password";
            this.R_ShowPass.UseVisualStyleBackColor = true;
            this.R_ShowPass.CheckedChanged += new System.EventHandler(this.loginShowPass_CheckedChanged);
            // 
            // R_Password
            // 
            this.R_Password.BackColor = System.Drawing.Color.White;
            this.R_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.R_Password.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R_Password.Location = new System.Drawing.Point(464, 194);
            this.R_Password.Name = "R_Password";
            this.R_Password.PasswordChar = '*';
            this.R_Password.Size = new System.Drawing.Size(237, 27);
            this.R_Password.TabIndex = 16;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(315, 196);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(81, 19);
            this.password.TabIndex = 15;
            this.password.Text = "Password";
            // 
            // R_Username
            // 
            this.R_Username.BackColor = System.Drawing.Color.White;
            this.R_Username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.R_Username.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R_Username.Location = new System.Drawing.Point(464, 145);
            this.R_Username.Name = "R_Username";
            this.R_Username.Size = new System.Drawing.Size(237, 27);
            this.R_Username.TabIndex = 14;
            this.R_Username.Text = "testing";
            this.R_Username.TextChanged += new System.EventHandler(this.loginUsername_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(315, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "Register Account";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(315, 145);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(87, 19);
            this.username.TabIndex = 12;
            this.username.Text = "Username";
            this.username.Click += new System.EventHandler(this.username_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.R_LoginButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 427);
            this.panel1.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EmployeeApp.Properties.Resources.icons8_employee_80;
            this.pictureBox1.Location = new System.Drawing.Point(79, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(10, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(247, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Employee Management System";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // R_LoginButton
            // 
            this.R_LoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.R_LoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.R_LoginButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.R_LoginButton.Location = new System.Drawing.Point(64, 338);
            this.R_LoginButton.Name = "R_LoginButton";
            this.R_LoginButton.Size = new System.Drawing.Size(154, 54);
            this.R_LoginButton.TabIndex = 9;
            this.R_LoginButton.Text = "LOGIN";
            this.R_LoginButton.UseVisualStyleBackColor = false;
            this.R_LoginButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 427);
            this.Controls.Add(this.R_signupButton);
            this.Controls.Add(this.R_ShowPass);
            this.Controls.Add(this.R_Password);
            this.Controls.Add(this.password);
            this.Controls.Add(this.R_Username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.username);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Button R_signupButton;
        private System.Windows.Forms.CheckBox R_ShowPass;
        private System.Windows.Forms.TextBox R_Password;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox R_Username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button R_LoginButton;
    }
}