namespace CinemaManager
{
    partial class RegistrationForm
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
            this.NameLbl = new System.Windows.Forms.Label();
            this.SurnameLbl = new System.Windows.Forms.Label();
            this.LoginLbl = new System.Windows.Forms.Label();
            this.PasswordLbl = new System.Windows.Forms.Label();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.surnameTxtBox = new System.Windows.Forms.TextBox();
            this.LoginTxtBox = new System.Windows.Forms.TextBox();
            this.PasswordTxtBox = new System.Windows.Forms.TextBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.registerBtn = new System.Windows.Forms.Button();
            this.errorLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FalseChBox = new System.Windows.Forms.RadioButton();
            this.TrueChBox = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Location = new System.Drawing.Point(18, 26);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(38, 13);
            this.NameLbl.TabIndex = 0;
            this.NameLbl.Text = "Name:";
            // 
            // SurnameLbl
            // 
            this.SurnameLbl.AutoSize = true;
            this.SurnameLbl.Location = new System.Drawing.Point(18, 63);
            this.SurnameLbl.Name = "SurnameLbl";
            this.SurnameLbl.Size = new System.Drawing.Size(52, 13);
            this.SurnameLbl.TabIndex = 1;
            this.SurnameLbl.Text = "Surname:";
            // 
            // LoginLbl
            // 
            this.LoginLbl.AutoSize = true;
            this.LoginLbl.Location = new System.Drawing.Point(18, 101);
            this.LoginLbl.Name = "LoginLbl";
            this.LoginLbl.Size = new System.Drawing.Size(36, 13);
            this.LoginLbl.TabIndex = 2;
            this.LoginLbl.Text = "Login:";
            // 
            // PasswordLbl
            // 
            this.PasswordLbl.AutoSize = true;
            this.PasswordLbl.Location = new System.Drawing.Point(18, 136);
            this.PasswordLbl.Name = "PasswordLbl";
            this.PasswordLbl.Size = new System.Drawing.Size(56, 13);
            this.PasswordLbl.TabIndex = 3;
            this.PasswordLbl.Text = "Password:";
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(102, 26);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(141, 20);
            this.nameTxtBox.TabIndex = 4;
            // 
            // surnameTxtBox
            // 
            this.surnameTxtBox.Location = new System.Drawing.Point(102, 63);
            this.surnameTxtBox.Name = "surnameTxtBox";
            this.surnameTxtBox.Size = new System.Drawing.Size(141, 20);
            this.surnameTxtBox.TabIndex = 5;
            // 
            // LoginTxtBox
            // 
            this.LoginTxtBox.Location = new System.Drawing.Point(102, 101);
            this.LoginTxtBox.Name = "LoginTxtBox";
            this.LoginTxtBox.Size = new System.Drawing.Size(141, 20);
            this.LoginTxtBox.TabIndex = 6;
            // 
            // PasswordTxtBox
            // 
            this.PasswordTxtBox.Location = new System.Drawing.Point(102, 136);
            this.PasswordTxtBox.Name = "PasswordTxtBox";
            this.PasswordTxtBox.Size = new System.Drawing.Size(141, 20);
            this.PasswordTxtBox.TabIndex = 7;
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cancelBtn.Location = new System.Drawing.Point(12, 243);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(96, 33);
            this.cancelBtn.TabIndex = 8;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // registerBtn
            // 
            this.registerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.registerBtn.Location = new System.Drawing.Point(143, 243);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(100, 33);
            this.registerBtn.TabIndex = 9;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = false;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // errorLbl
            // 
            this.errorLbl.AutoSize = true;
            this.errorLbl.ForeColor = System.Drawing.Color.Red;
            this.errorLbl.Location = new System.Drawing.Point(57, 9);
            this.errorLbl.Name = "errorLbl";
            this.errorLbl.Size = new System.Drawing.Size(90, 13);
            this.errorLbl.TabIndex = 10;
            this.errorLbl.Text = "Error: Invalid data";
            this.errorLbl.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "IsAdmin:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FalseChBox);
            this.groupBox1.Controls.Add(this.TrueChBox);
            this.groupBox1.Location = new System.Drawing.Point(102, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(141, 46);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "IsAdmin";
            // 
            // FalseChBox
            // 
            this.FalseChBox.AutoSize = true;
            this.FalseChBox.Location = new System.Drawing.Point(80, 19);
            this.FalseChBox.Name = "FalseChBox";
            this.FalseChBox.Size = new System.Drawing.Size(41, 17);
            this.FalseChBox.TabIndex = 3;
            this.FalseChBox.TabStop = true;
            this.FalseChBox.Text = "NO";
            this.FalseChBox.UseVisualStyleBackColor = true;
            // 
            // TrueChBox
            // 
            this.TrueChBox.AutoSize = true;
            this.TrueChBox.Location = new System.Drawing.Point(19, 19);
            this.TrueChBox.Name = "TrueChBox";
            this.TrueChBox.Size = new System.Drawing.Size(46, 17);
            this.TrueChBox.TabIndex = 2;
            this.TrueChBox.TabStop = true;
            this.TrueChBox.Text = "YES";
            this.TrueChBox.UseVisualStyleBackColor = true;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 288);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.errorLbl);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.PasswordTxtBox);
            this.Controls.Add(this.LoginTxtBox);
            this.Controls.Add(this.surnameTxtBox);
            this.Controls.Add(this.nameTxtBox);
            this.Controls.Add(this.PasswordLbl);
            this.Controls.Add(this.LoginLbl);
            this.Controls.Add(this.SurnameLbl);
            this.Controls.Add(this.NameLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RegistrationForm_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Label SurnameLbl;
        private System.Windows.Forms.Label LoginLbl;
        private System.Windows.Forms.Label PasswordLbl;
        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.TextBox surnameTxtBox;
        private System.Windows.Forms.TextBox LoginTxtBox;
        private System.Windows.Forms.TextBox PasswordTxtBox;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.Label errorLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton FalseChBox;
        private System.Windows.Forms.RadioButton TrueChBox;
    }
}