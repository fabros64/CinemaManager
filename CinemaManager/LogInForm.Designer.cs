namespace CinemaManager
{
    partial class LogInForm
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
            this.LoginLbl = new System.Windows.Forms.Label();
            this.PasswordLbl = new System.Windows.Forms.Label();
            this.LoginTxtBox = new System.Windows.Forms.TextBox();
            this.PasswordTxtBox = new System.Windows.Forms.TextBox();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.LogInBtn = new System.Windows.Forms.Button();
            this.ErrorLoginLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoginLbl
            // 
            this.LoginLbl.AutoSize = true;
            this.LoginLbl.Location = new System.Drawing.Point(23, 24);
            this.LoginLbl.Name = "LoginLbl";
            this.LoginLbl.Size = new System.Drawing.Size(36, 13);
            this.LoginLbl.TabIndex = 0;
            this.LoginLbl.Text = "Login:";
            // 
            // PasswordLbl
            // 
            this.PasswordLbl.AutoSize = true;
            this.PasswordLbl.Location = new System.Drawing.Point(5, 50);
            this.PasswordLbl.Name = "PasswordLbl";
            this.PasswordLbl.Size = new System.Drawing.Size(56, 13);
            this.PasswordLbl.TabIndex = 1;
            this.PasswordLbl.Text = "Password:";
            // 
            // LoginTxtBox
            // 
            this.LoginTxtBox.Location = new System.Drawing.Point(67, 21);
            this.LoginTxtBox.Name = "LoginTxtBox";
            this.LoginTxtBox.Size = new System.Drawing.Size(171, 20);
            this.LoginTxtBox.TabIndex = 2;
            // 
            // PasswordTxtBox
            // 
            this.PasswordTxtBox.Location = new System.Drawing.Point(67, 47);
            this.PasswordTxtBox.Name = "PasswordTxtBox";
            this.PasswordTxtBox.PasswordChar = '*';
            this.PasswordTxtBox.Size = new System.Drawing.Size(171, 20);
            this.PasswordTxtBox.TabIndex = 3;
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ExitBtn.Location = new System.Drawing.Point(8, 91);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(89, 40);
            this.ExitBtn.TabIndex = 5;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // LogInBtn
            // 
            this.LogInBtn.BackColor = System.Drawing.Color.Green;
            this.LogInBtn.Location = new System.Drawing.Point(149, 91);
            this.LogInBtn.Name = "LogInBtn";
            this.LogInBtn.Size = new System.Drawing.Size(89, 40);
            this.LogInBtn.TabIndex = 6;
            this.LogInBtn.Text = "Log in";
            this.LogInBtn.UseVisualStyleBackColor = false;
            this.LogInBtn.Click += new System.EventHandler(this.LogInBtn_Click);
            // 
            // ErrorLoginLabel
            // 
            this.ErrorLoginLabel.AutoSize = true;
            this.ErrorLoginLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLoginLabel.Location = new System.Drawing.Point(64, 5);
            this.ErrorLoginLabel.Name = "ErrorLoginLabel";
            this.ErrorLoginLabel.Size = new System.Drawing.Size(151, 13);
            this.ErrorLoginLabel.TabIndex = 7;
            this.ErrorLoginLabel.Text = "Incorrect Login and Password!";
            this.ErrorLoginLabel.Visible = false;
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 140);
            this.Controls.Add(this.ErrorLoginLabel);
            this.Controls.Add(this.LogInBtn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.PasswordTxtBox);
            this.Controls.Add(this.LoginTxtBox);
            this.Controls.Add(this.PasswordLbl);
            this.Controls.Add(this.LoginLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "LogInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logowanie";
            this.Load += new System.EventHandler(this.LogInForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LogInForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LoginLbl;
        private System.Windows.Forms.Label PasswordLbl;
        private System.Windows.Forms.TextBox LoginTxtBox;
        private System.Windows.Forms.TextBox PasswordTxtBox;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button LogInBtn;
        private System.Windows.Forms.Label ErrorLoginLabel;
    }
}