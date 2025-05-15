namespace EmployeeApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.L_Username = new System.Windows.Forms.TextBox();
            this.L_Password = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.L_ShowPass = new System.Windows.Forms.CheckBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.registerButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 427);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(10, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(309, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Employee Management System";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.registerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.registerButton.Location = new System.Drawing.Point(64, 338);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(154, 54);
            this.registerButton.TabIndex = 9;
            this.registerButton.Text = "REGISTER";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Location = new System.Drawing.Point(692, 9);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(16, 15);
            this.exit.TabIndex = 1;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.label1_Click);
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(319, 145);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(108, 24);
            this.username.TabIndex = 2;
            this.username.Text = "Username";
            this.username.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(318, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Login Account";
            // 
            // L_Username
            // 
            this.L_Username.BackColor = System.Drawing.Color.White;
            this.L_Username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.L_Username.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Username.Location = new System.Drawing.Point(449, 145);
            this.L_Username.Name = "L_Username";
            this.L_Username.Size = new System.Drawing.Size(237, 32);
            this.L_Username.TabIndex = 4;
            // 
            // L_Password
            // 
            this.L_Password.BackColor = System.Drawing.Color.White;
            this.L_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.L_Password.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Password.Location = new System.Drawing.Point(449, 194);
            this.L_Password.Name = "L_Password";
            this.L_Password.PasswordChar = '*';
            this.L_Password.Size = new System.Drawing.Size(237, 32);
            this.L_Password.TabIndex = 6;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(319, 196);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(100, 24);
            this.password.TabIndex = 5;
            this.password.Text = "Password";
            this.password.Click += new System.EventHandler(this.label4_Click);
            // 
            // L_ShowPass
            // 
            this.L_ShowPass.AutoSize = true;
            this.L_ShowPass.BackColor = System.Drawing.Color.Transparent;
            this.L_ShowPass.Location = new System.Drawing.Point(581, 232);
            this.L_ShowPass.Name = "L_ShowPass";
            this.L_ShowPass.Size = new System.Drawing.Size(124, 19);
            this.L_ShowPass.TabIndex = 7;
            this.L_ShowPass.Text = "Show Password";
            this.L_ShowPass.UseVisualStyleBackColor = false;
            this.L_ShowPass.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.loginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.loginButton.Location = new System.Drawing.Point(436, 340);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(159, 54);
            this.loginButton.TabIndex = 8;
            this.loginButton.Text = "LOGIN";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(90, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 427);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.L_ShowPass);
            this.Controls.Add(this.L_Password);
            this.Controls.Add(this.password);
            this.Controls.Add(this.L_Username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.username);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Constantia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox L_Username;
        private System.Windows.Forms.TextBox L_Password;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.CheckBox L_ShowPass;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

