namespace CinemaManager
{
    partial class ChangeDeleteFilmShow
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
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.EditPanel = new System.Windows.Forms.Panel();
            this.FilmTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FilmDatePicker = new System.Windows.Forms.DateTimePicker();
            this.MoviesLB = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MovieIDTb = new System.Windows.Forms.TextBox();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.ListFilmShowsLb = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EditPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.DeleteBtn.Location = new System.Drawing.Point(161, 162);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteBtn.TabIndex = 10;
            this.DeleteBtn.Text = "Usuń";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.EditBtn.Location = new System.Drawing.Point(12, 162);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(75, 23);
            this.EditBtn.TabIndex = 9;
            this.EditBtn.Text = "Edytuj";
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // EditPanel
            // 
            this.EditPanel.Controls.Add(this.FilmTimePicker);
            this.EditPanel.Controls.Add(this.FilmDatePicker);
            this.EditPanel.Controls.Add(this.MoviesLB);
            this.EditPanel.Controls.Add(this.label4);
            this.EditPanel.Controls.Add(this.label3);
            this.EditPanel.Controls.Add(this.label2);
            this.EditPanel.Controls.Add(this.MovieIDTb);
            this.EditPanel.Controls.Add(this.AcceptButton);
            this.EditPanel.Location = new System.Drawing.Point(290, 27);
            this.EditPanel.Name = "EditPanel";
            this.EditPanel.Size = new System.Drawing.Size(349, 158);
            this.EditPanel.TabIndex = 8;
            // 
            // FilmTimePicker
            // 
            this.FilmTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.FilmTimePicker.Location = new System.Drawing.Point(209, 5);
            this.FilmTimePicker.MinDate = new System.DateTime(2020, 1, 20, 0, 0, 0, 0);
            this.FilmTimePicker.Name = "FilmTimePicker";
            this.FilmTimePicker.ShowUpDown = true;
            this.FilmTimePicker.Size = new System.Drawing.Size(72, 20);
            this.FilmTimePicker.TabIndex = 32;
            // 
            // FilmDatePicker
            // 
            this.FilmDatePicker.ImeMode = System.Windows.Forms.ImeMode.On;
            this.FilmDatePicker.Location = new System.Drawing.Point(54, 5);
            this.FilmDatePicker.MinDate = new System.DateTime(2020, 1, 20, 0, 0, 0, 0);
            this.FilmDatePicker.Name = "FilmDatePicker";
            this.FilmDatePicker.Size = new System.Drawing.Size(149, 20);
            this.FilmDatePicker.TabIndex = 31;
            // 
            // MoviesLB
            // 
            this.MoviesLB.FormattingEnabled = true;
            this.MoviesLB.Location = new System.Drawing.Point(54, 34);
            this.MoviesLB.Name = "MoviesLB";
            this.MoviesLB.Size = new System.Drawing.Size(163, 108);
            this.MoviesLB.TabIndex = 8;
            this.MoviesLB.SelectedIndexChanged += new System.EventHandler(this.MoviesLB_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(223, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "MovieId:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Film:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Date:";
            // 
            // MovieIDTb
            // 
            this.MovieIDTb.Enabled = false;
            this.MovieIDTb.Location = new System.Drawing.Point(277, 58);
            this.MovieIDTb.Name = "MovieIDTb";
            this.MovieIDTb.Size = new System.Drawing.Size(50, 20);
            this.MovieIDTb.TabIndex = 3;
            // 
            // AcceptButton
            // 
            this.AcceptButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.AcceptButton.Location = new System.Drawing.Point(252, 106);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(75, 36);
            this.AcceptButton.TabIndex = 0;
            this.AcceptButton.Text = "Zatwierdź";
            this.AcceptButton.UseVisualStyleBackColor = false;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // ListFilmShowsLb
            // 
            this.ListFilmShowsLb.DisplayMember = "Name";
            this.ListFilmShowsLb.FormattingEnabled = true;
            this.ListFilmShowsLb.HorizontalScrollbar = true;
            this.ListFilmShowsLb.Location = new System.Drawing.Point(12, 32);
            this.ListFilmShowsLb.Name = "ListFilmShowsLb";
            this.ListFilmShowsLb.Size = new System.Drawing.Size(259, 121);
            this.ListFilmShowsLb.TabIndex = 7;
            this.ListFilmShowsLb.SelectedIndexChanged += new System.EventHandler(this.ListFilmShowsLb_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Wybierz seans filmowy";
            // 
            // ChangeDeleteFilmShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 197);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.EditPanel);
            this.Controls.Add(this.ListFilmShowsLb);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ChangeDeleteFilmShow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edytuj lub usuń seans filmowy";
            this.Load += new System.EventHandler(this.ChangeDeleteFilmShow_Load);
            this.EditPanel.ResumeLayout(false);
            this.EditPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Panel EditPanel;
        private System.Windows.Forms.ListBox MoviesLB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MovieIDTb;
        private System.Windows.Forms.Button AcceptButton;
        private System.Windows.Forms.ListBox ListFilmShowsLb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker FilmTimePicker;
        private System.Windows.Forms.DateTimePicker FilmDatePicker;
    }
}