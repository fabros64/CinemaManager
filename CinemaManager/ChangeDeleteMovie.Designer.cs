namespace CinemaManager
{
    partial class ChangeDeleteMovie
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.ListMoviesLb = new System.Windows.Forms.ListBox();
            this.movieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EditPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DescriptionTb = new System.Windows.Forms.TextBox();
            this.RateTb = new System.Windows.Forms.TextBox();
            this.PriceTb = new System.Windows.Forms.TextBox();
            this.NameTb = new System.Windows.Forms.TextBox();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).BeginInit();
            this.EditPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wybierz film";
            // 
            // ListMoviesLb
            // 
            this.ListMoviesLb.DataSource = this.movieBindingSource;
            this.ListMoviesLb.DisplayMember = "Name";
            this.ListMoviesLb.FormattingEnabled = true;
            this.ListMoviesLb.Location = new System.Drawing.Point(15, 31);
            this.ListMoviesLb.Name = "ListMoviesLb";
            this.ListMoviesLb.Size = new System.Drawing.Size(178, 95);
            this.ListMoviesLb.TabIndex = 2;
            this.ListMoviesLb.SelectedIndexChanged += new System.EventHandler(this.ListMoviesLb_SelectedIndexChanged);
            // 
            // movieBindingSource
            // 
            this.movieBindingSource.DataSource = typeof(CinemaManager.Model.Movie);
            // 
            // EditPanel
            // 
            this.EditPanel.Controls.Add(this.label5);
            this.EditPanel.Controls.Add(this.label4);
            this.EditPanel.Controls.Add(this.label3);
            this.EditPanel.Controls.Add(this.label2);
            this.EditPanel.Controls.Add(this.DescriptionTb);
            this.EditPanel.Controls.Add(this.RateTb);
            this.EditPanel.Controls.Add(this.PriceTb);
            this.EditPanel.Controls.Add(this.NameTb);
            this.EditPanel.Controls.Add(this.AcceptButton);
            this.EditPanel.Location = new System.Drawing.Point(223, 26);
            this.EditPanel.Name = "EditPanel";
            this.EditPanel.Size = new System.Drawing.Size(277, 158);
            this.EditPanel.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Description:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Rate:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name:";
            // 
            // DescriptionTb
            // 
            this.DescriptionTb.Location = new System.Drawing.Point(105, 57);
            this.DescriptionTb.Multiline = true;
            this.DescriptionTb.Name = "DescriptionTb";
            this.DescriptionTb.Size = new System.Drawing.Size(151, 43);
            this.DescriptionTb.TabIndex = 4;
            // 
            // RateTb
            // 
            this.RateTb.Location = new System.Drawing.Point(105, 106);
            this.RateTb.Name = "RateTb";
            this.RateTb.Size = new System.Drawing.Size(151, 20);
            this.RateTb.TabIndex = 3;
            // 
            // PriceTb
            // 
            this.PriceTb.Location = new System.Drawing.Point(105, 31);
            this.PriceTb.Name = "PriceTb";
            this.PriceTb.Size = new System.Drawing.Size(151, 20);
            this.PriceTb.TabIndex = 2;
            // 
            // NameTb
            // 
            this.NameTb.Location = new System.Drawing.Point(105, 5);
            this.NameTb.Name = "NameTb";
            this.NameTb.Size = new System.Drawing.Size(151, 20);
            this.NameTb.TabIndex = 1;
            // 
            // AcceptButton
            // 
            this.AcceptButton.Location = new System.Drawing.Point(181, 132);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(75, 23);
            this.AcceptButton.TabIndex = 0;
            this.AcceptButton.Text = "Zatwierdź";
            this.AcceptButton.UseVisualStyleBackColor = true;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.EditBtn.Location = new System.Drawing.Point(15, 161);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(75, 23);
            this.EditBtn.TabIndex = 4;
            this.EditBtn.Text = "Edytuj";
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.DeleteBtn.Location = new System.Drawing.Point(118, 161);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteBtn.TabIndex = 5;
            this.DeleteBtn.Text = "Usuń";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // ChangeDeleteMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 196);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.EditPanel);
            this.Controls.Add(this.ListMoviesLb);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ChangeDeleteMovie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edytuj lub  usuń film";
            this.Load += new System.EventHandler(this.ChangeDeleteMovie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).EndInit();
            this.EditPanel.ResumeLayout(false);
            this.EditPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ListMoviesLb;
        private System.Windows.Forms.Panel EditPanel;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.TextBox DescriptionTb;
        private System.Windows.Forms.TextBox RateTb;
        private System.Windows.Forms.TextBox PriceTb;
        private System.Windows.Forms.TextBox NameTb;
        private System.Windows.Forms.Button AcceptButton;
        private System.Windows.Forms.BindingSource movieBindingSource;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}