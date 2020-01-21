namespace CinemaManager
{
    partial class ManageFilmShowForm
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
            this.IncorretMovie = new System.Windows.Forms.Label();
            this.IncoretName = new System.Windows.Forms.Label();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.AddMovieBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MoviesLb = new System.Windows.Forms.ListBox();
            this.FilmDatePicker = new System.Windows.Forms.DateTimePicker();
            this.FilmTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // IncorretMovie
            // 
            this.IncorretMovie.AutoSize = true;
            this.IncorretMovie.ForeColor = System.Drawing.Color.Red;
            this.IncorretMovie.Location = new System.Drawing.Point(372, 65);
            this.IncorretMovie.Name = "IncorretMovie";
            this.IncorretMovie.Size = new System.Drawing.Size(49, 13);
            this.IncorretMovie.TabIndex = 26;
            this.IncorretMovie.Text = "Incorrect";
            this.IncorretMovie.Visible = false;
            // 
            // IncoretName
            // 
            this.IncoretName.AutoSize = true;
            this.IncoretName.ForeColor = System.Drawing.Color.Red;
            this.IncoretName.Location = new System.Drawing.Point(372, 29);
            this.IncoretName.Name = "IncoretName";
            this.IncoretName.Size = new System.Drawing.Size(46, 13);
            this.IncoretName.TabIndex = 25;
            this.IncoretName.Text = "Incorect";
            this.IncoretName.Visible = false;
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(30, 257);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 24;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // AddMovieBtn
            // 
            this.AddMovieBtn.Location = new System.Drawing.Point(291, 257);
            this.AddMovieBtn.Name = "AddMovieBtn";
            this.AddMovieBtn.Size = new System.Drawing.Size(109, 23);
            this.AddMovieBtn.TabIndex = 23;
            this.AddMovieBtn.Text = "Add film screening";
            this.AddMovieBtn.UseVisualStyleBackColor = true;
            this.AddMovieBtn.Click += new System.EventHandler(this.AddFilmShowBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(26, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Movie";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(26, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Date";
            // 
            // MoviesLb
            // 
            this.MoviesLb.FormattingEnabled = true;
            this.MoviesLb.Location = new System.Drawing.Point(94, 65);
            this.MoviesLb.Name = "MoviesLb";
            this.MoviesLb.Size = new System.Drawing.Size(255, 173);
            this.MoviesLb.TabIndex = 27;
            this.MoviesLb.SelectedIndexChanged += new System.EventHandler(this.MoviesLb_SelectedIndexChanged);
            // 
            // FilmDatePicker
            // 
            this.FilmDatePicker.ImeMode = System.Windows.Forms.ImeMode.On;
            this.FilmDatePicker.Location = new System.Drawing.Point(94, 29);
            this.FilmDatePicker.MinDate = new System.DateTime(2020, 1, 20, 0, 0, 0, 0);
            this.FilmDatePicker.Name = "FilmDatePicker";
            this.FilmDatePicker.Size = new System.Drawing.Size(142, 20);
            this.FilmDatePicker.TabIndex = 28;
            this.FilmDatePicker.ValueChanged += new System.EventHandler(this.DateTimeOfFilmScreening_ValueChanged);
            // 
            // FilmTimePicker
            // 
            this.FilmTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.FilmTimePicker.Location = new System.Drawing.Point(249, 29);
            this.FilmTimePicker.MinDate = new System.DateTime(2020, 1, 20, 0, 0, 0, 0);
            this.FilmTimePicker.Name = "FilmTimePicker";
            this.FilmTimePicker.ShowUpDown = true;
            this.FilmTimePicker.Size = new System.Drawing.Size(100, 20);
            this.FilmTimePicker.TabIndex = 30;
            // 
            // ManageFilmShowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 301);
            this.Controls.Add(this.FilmTimePicker);
            this.Controls.Add(this.FilmDatePicker);
            this.Controls.Add(this.MoviesLb);
            this.Controls.Add(this.IncorretMovie);
            this.Controls.Add(this.IncoretName);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.AddMovieBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ManageFilmShowForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj seans filmowy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label IncorretMovie;
        private System.Windows.Forms.Label IncoretName;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button AddMovieBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox MoviesLb;
        private System.Windows.Forms.DateTimePicker FilmDatePicker;
        private System.Windows.Forms.DateTimePicker FilmTimePicker;
    }
}