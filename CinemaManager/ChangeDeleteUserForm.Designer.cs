namespace CinemaManager
{
    partial class ChangeDeleteUserForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FalseChBox = new System.Windows.Forms.RadioButton();
            this.TrueChBox = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.errorLbl = new System.Windows.Forms.Label();
            this.AcceptBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.PasswordTxtBox = new System.Windows.Forms.TextBox();
            this.LoginTxtBox = new System.Windows.Forms.TextBox();
            this.surnameTxtBox = new System.Windows.Forms.TextBox();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.PasswordLbl = new System.Windows.Forms.Label();
            this.LoginLbl = new System.Windows.Forms.Label();
            this.SurnameLbl = new System.Windows.Forms.Label();
            this.NameLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EditBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.UsersListBox = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FalseChBox);
            this.groupBox1.Controls.Add(this.TrueChBox);
            this.groupBox1.Location = new System.Drawing.Point(91, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(141, 46);
            this.groupBox1.TabIndex = 25;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "IsAdmin:";
            // 
            // errorLbl
            // 
            this.errorLbl.AutoSize = true;
            this.errorLbl.ForeColor = System.Drawing.Color.Red;
            this.errorLbl.Location = new System.Drawing.Point(46, 9);
            this.errorLbl.Name = "errorLbl";
            this.errorLbl.Size = new System.Drawing.Size(90, 13);
            this.errorLbl.TabIndex = 23;
            this.errorLbl.Text = "Error: Invalid data";
            this.errorLbl.Visible = false;
            // 
            // AcceptBtn
            // 
            this.AcceptBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.AcceptBtn.Location = new System.Drawing.Point(91, 243);
            this.AcceptBtn.Name = "AcceptBtn";
            this.AcceptBtn.Size = new System.Drawing.Size(100, 33);
            this.AcceptBtn.TabIndex = 22;
            this.AcceptBtn.Text = "Zatwierdź";
            this.AcceptBtn.UseVisualStyleBackColor = false;
            this.AcceptBtn.Click += new System.EventHandler(this.AcceptBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DeleteBtn.Location = new System.Drawing.Point(137, 255);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(96, 33);
            this.DeleteBtn.TabIndex = 21;
            this.DeleteBtn.Text = "Usuń";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // PasswordTxtBox
            // 
            this.PasswordTxtBox.Location = new System.Drawing.Point(91, 136);
            this.PasswordTxtBox.Name = "PasswordTxtBox";
            this.PasswordTxtBox.Size = new System.Drawing.Size(141, 20);
            this.PasswordTxtBox.TabIndex = 20;
            // 
            // LoginTxtBox
            // 
            this.LoginTxtBox.Location = new System.Drawing.Point(91, 101);
            this.LoginTxtBox.Name = "LoginTxtBox";
            this.LoginTxtBox.Size = new System.Drawing.Size(141, 20);
            this.LoginTxtBox.TabIndex = 19;
            // 
            // surnameTxtBox
            // 
            this.surnameTxtBox.Location = new System.Drawing.Point(91, 63);
            this.surnameTxtBox.Name = "surnameTxtBox";
            this.surnameTxtBox.Size = new System.Drawing.Size(141, 20);
            this.surnameTxtBox.TabIndex = 18;
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(91, 26);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(141, 20);
            this.nameTxtBox.TabIndex = 17;
            // 
            // PasswordLbl
            // 
            this.PasswordLbl.AutoSize = true;
            this.PasswordLbl.Location = new System.Drawing.Point(7, 136);
            this.PasswordLbl.Name = "PasswordLbl";
            this.PasswordLbl.Size = new System.Drawing.Size(56, 13);
            this.PasswordLbl.TabIndex = 16;
            this.PasswordLbl.Text = "Password:";
            // 
            // LoginLbl
            // 
            this.LoginLbl.AutoSize = true;
            this.LoginLbl.Location = new System.Drawing.Point(7, 101);
            this.LoginLbl.Name = "LoginLbl";
            this.LoginLbl.Size = new System.Drawing.Size(36, 13);
            this.LoginLbl.TabIndex = 15;
            this.LoginLbl.Text = "Login:";
            // 
            // SurnameLbl
            // 
            this.SurnameLbl.AutoSize = true;
            this.SurnameLbl.Location = new System.Drawing.Point(7, 63);
            this.SurnameLbl.Name = "SurnameLbl";
            this.SurnameLbl.Size = new System.Drawing.Size(52, 13);
            this.SurnameLbl.TabIndex = 14;
            this.SurnameLbl.Text = "Surname:";
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Location = new System.Drawing.Point(7, 26);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(38, 13);
            this.NameLbl.TabIndex = 13;
            this.NameLbl.Text = "Name:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.errorLbl);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.NameLbl);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.SurnameLbl);
            this.panel1.Controls.Add(this.LoginLbl);
            this.panel1.Controls.Add(this.AcceptBtn);
            this.panel1.Controls.Add(this.PasswordLbl);
            this.panel1.Controls.Add(this.nameTxtBox);
            this.panel1.Controls.Add(this.PasswordTxtBox);
            this.panel1.Controls.Add(this.surnameTxtBox);
            this.panel1.Controls.Add(this.LoginTxtBox);
            this.panel1.Location = new System.Drawing.Point(261, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 285);
            this.panel1.TabIndex = 26;
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.EditBtn.Location = new System.Drawing.Point(12, 255);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(96, 33);
            this.EditBtn.TabIndex = 27;
            this.EditBtn.Text = "Edytuj";
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.UsersListBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(221, 237);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Wybierz użytkownika";
            // 
            // UsersListBox
            // 
            this.UsersListBox.FormattingEnabled = true;
            this.UsersListBox.Location = new System.Drawing.Point(6, 26);
            this.UsersListBox.Name = "UsersListBox";
            this.UsersListBox.Size = new System.Drawing.Size(209, 199);
            this.UsersListBox.TabIndex = 0;
            this.UsersListBox.SelectedIndexChanged += new System.EventHandler(this.UsersListBox_SelectedIndexChanged);
            // 
            // ChangeDeleteUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 300);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DeleteBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ChangeDeleteUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edytuj lub usun użytkownika";
            this.Load += new System.EventHandler(this.ChangeDeleteUserForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton FalseChBox;
        private System.Windows.Forms.RadioButton TrueChBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label errorLbl;
        private System.Windows.Forms.Button AcceptBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.TextBox PasswordTxtBox;
        private System.Windows.Forms.TextBox LoginTxtBox;
        private System.Windows.Forms.TextBox surnameTxtBox;
        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.Label PasswordLbl;
        private System.Windows.Forms.Label LoginLbl;
        private System.Windows.Forms.Label SurnameLbl;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox UsersListBox;
    }
}