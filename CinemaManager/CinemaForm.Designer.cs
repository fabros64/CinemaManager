namespace CinemaManager
{
    partial class CinemaForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.EmployeeLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DateTimeLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.SellTicketButton = new System.Windows.Forms.Button();
            this.DeleteTicketBtn = new System.Windows.Forms.Button();
            this.TimerMinutes = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.zarząToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zarządzajKinemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajFilmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuńFilmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.dodajSeansFilmowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edytujUsuńSeansFilmowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.użytkownikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wylogujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zablokujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.zarejestrujNowegoUżytkownikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edytujUsuńUżytkownikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NewestFilmShowsLb = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.SurnameLabel);
            this.panel1.Controls.Add(this.NameLabel);
            this.panel1.Controls.Add(this.EmployeeLabel);
            this.panel1.Location = new System.Drawing.Point(588, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(198, 95);
            this.panel1.TabIndex = 0;
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SurnameLabel.Location = new System.Drawing.Point(17, 63);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(164, 20);
            this.SurnameLabel.TabIndex = 2;
            this.SurnameLabel.Text = "Nazwisko  pracownika";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NameLabel.Location = new System.Drawing.Point(17, 43);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(123, 20);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Imie pracownika";
            // 
            // EmployeeLabel
            // 
            this.EmployeeLabel.AutoSize = true;
            this.EmployeeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EmployeeLabel.Location = new System.Drawing.Point(12, 9);
            this.EmployeeLabel.Name = "EmployeeLabel";
            this.EmployeeLabel.Size = new System.Drawing.Size(102, 25);
            this.EmployeeLabel.TabIndex = 0;
            this.EmployeeLabel.Text = "Pracownik";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel2.Controls.Add(this.DateTimeLabel);
            this.panel2.Controls.Add(this.TimeLabel);
            this.panel2.Location = new System.Drawing.Point(685, 457);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(101, 44);
            this.panel2.TabIndex = 3;
            // 
            // DateTimeLabel
            // 
            this.DateTimeLabel.AutoSize = true;
            this.DateTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DateTimeLabel.Location = new System.Drawing.Point(9, 23);
            this.DateTimeLabel.Name = "DateTimeLabel";
            this.DateTimeLabel.Size = new System.Drawing.Size(91, 20);
            this.DateTimeLabel.TabIndex = 2;
            this.DateTimeLabel.Text = "01-03-2020";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TimeLabel.Location = new System.Drawing.Point(30, 3);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(49, 20);
            this.TimeLabel.TabIndex = 1;
            this.TimeLabel.Text = "21:19";
            // 
            // SellTicketButton
            // 
            this.SellTicketButton.BackColor = System.Drawing.Color.ForestGreen;
            this.SellTicketButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SellTicketButton.Location = new System.Drawing.Point(620, 128);
            this.SellTicketButton.Name = "SellTicketButton";
            this.SellTicketButton.Size = new System.Drawing.Size(168, 54);
            this.SellTicketButton.TabIndex = 4;
            this.SellTicketButton.Text = "Sprzedaj Bilet";
            this.SellTicketButton.UseVisualStyleBackColor = false;
            this.SellTicketButton.Click += new System.EventHandler(this.SellTicketButton_Click);
            // 
            // DeleteTicketBtn
            // 
            this.DeleteTicketBtn.BackColor = System.Drawing.Color.Khaki;
            this.DeleteTicketBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DeleteTicketBtn.Location = new System.Drawing.Point(618, 188);
            this.DeleteTicketBtn.Name = "DeleteTicketBtn";
            this.DeleteTicketBtn.Size = new System.Drawing.Size(168, 54);
            this.DeleteTicketBtn.TabIndex = 5;
            this.DeleteTicketBtn.Text = "Zwrot Biletów";
            this.DeleteTicketBtn.UseVisualStyleBackColor = false;
            this.DeleteTicketBtn.Click += new System.EventHandler(this.DeleteTicketBtn_Click);
            // 
            // TimerMinutes
            // 
            this.TimerMinutes.Interval = 60000;
            this.TimerMinutes.Tick += new System.EventHandler(this.TimerMinutes_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zarząToolStripMenuItem,
            this.zarządzajKinemToolStripMenuItem,
            this.użytkownikToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(798, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // zarząToolStripMenuItem
            // 
            this.zarząToolStripMenuItem.Name = "zarząToolStripMenuItem";
            this.zarząToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            this.zarząToolStripMenuItem.Click += new System.EventHandler(this.zarząToolStripMenuItem_Click);
            // 
            // zarządzajKinemToolStripMenuItem
            // 
            this.zarządzajKinemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajFilmToolStripMenuItem,
            this.usuńFilmToolStripMenuItem,
            this.toolStripSeparator1,
            this.dodajSeansFilmowyToolStripMenuItem,
            this.edytujUsuńSeansFilmowyToolStripMenuItem});
            this.zarządzajKinemToolStripMenuItem.Name = "zarządzajKinemToolStripMenuItem";
            this.zarządzajKinemToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.zarządzajKinemToolStripMenuItem.Text = "Zarządzaj kinem";
            // 
            // dodajFilmToolStripMenuItem
            // 
            this.dodajFilmToolStripMenuItem.Name = "dodajFilmToolStripMenuItem";
            this.dodajFilmToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.dodajFilmToolStripMenuItem.Text = "Dodaj film";
            this.dodajFilmToolStripMenuItem.Click += new System.EventHandler(this.dodajFilmToolStripMenuItem_Click);
            // 
            // usuńFilmToolStripMenuItem
            // 
            this.usuńFilmToolStripMenuItem.Name = "usuńFilmToolStripMenuItem";
            this.usuńFilmToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.usuńFilmToolStripMenuItem.Text = "Edytuj / Usuń film";
            this.usuńFilmToolStripMenuItem.Click += new System.EventHandler(this.usuńFilmToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(220, 6);
            // 
            // dodajSeansFilmowyToolStripMenuItem
            // 
            this.dodajSeansFilmowyToolStripMenuItem.Name = "dodajSeansFilmowyToolStripMenuItem";
            this.dodajSeansFilmowyToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.dodajSeansFilmowyToolStripMenuItem.Text = "Dodaj seans filmowy";
            this.dodajSeansFilmowyToolStripMenuItem.Click += new System.EventHandler(this.dodajSeansFilmowyToolStripMenuItem_Click);
            // 
            // edytujUsuńSeansFilmowyToolStripMenuItem
            // 
            this.edytujUsuńSeansFilmowyToolStripMenuItem.Name = "edytujUsuńSeansFilmowyToolStripMenuItem";
            this.edytujUsuńSeansFilmowyToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.edytujUsuńSeansFilmowyToolStripMenuItem.Text = "Edytuj / Usuń seans filmowy";
            this.edytujUsuńSeansFilmowyToolStripMenuItem.Click += new System.EventHandler(this.edytujUsuńSeansFilmowyToolStripMenuItem_Click);
            // 
            // użytkownikToolStripMenuItem
            // 
            this.użytkownikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wylogujToolStripMenuItem,
            this.zablokujToolStripMenuItem,
            this.toolStripSeparator2,
            this.zarejestrujNowegoUżytkownikaToolStripMenuItem,
            this.edytujUsuńUżytkownikaToolStripMenuItem});
            this.użytkownikToolStripMenuItem.Name = "użytkownikToolStripMenuItem";
            this.użytkownikToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.użytkownikToolStripMenuItem.Text = "Użytkownik";
            // 
            // wylogujToolStripMenuItem
            // 
            this.wylogujToolStripMenuItem.Name = "wylogujToolStripMenuItem";
            this.wylogujToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.wylogujToolStripMenuItem.Text = "Wyloguj";
            this.wylogujToolStripMenuItem.Click += new System.EventHandler(this.wylogujToolStripMenuItem_Click);
            // 
            // zablokujToolStripMenuItem
            // 
            this.zablokujToolStripMenuItem.Name = "zablokujToolStripMenuItem";
            this.zablokujToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.zablokujToolStripMenuItem.Text = "Zablokuj";
            this.zablokujToolStripMenuItem.Click += new System.EventHandler(this.zablokujToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(241, 6);
            // 
            // zarejestrujNowegoUżytkownikaToolStripMenuItem
            // 
            this.zarejestrujNowegoUżytkownikaToolStripMenuItem.Enabled = false;
            this.zarejestrujNowegoUżytkownikaToolStripMenuItem.Name = "zarejestrujNowegoUżytkownikaToolStripMenuItem";
            this.zarejestrujNowegoUżytkownikaToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.zarejestrujNowegoUżytkownikaToolStripMenuItem.Text = "Zarejestruj nowego użytkownika";
            this.zarejestrujNowegoUżytkownikaToolStripMenuItem.Click += new System.EventHandler(this.zarejestrujNowegoUżytkownikaToolStripMenuItem_Click);
            // 
            // edytujUsuńUżytkownikaToolStripMenuItem
            // 
            this.edytujUsuńUżytkownikaToolStripMenuItem.Enabled = false;
            this.edytujUsuńUżytkownikaToolStripMenuItem.Name = "edytujUsuńUżytkownikaToolStripMenuItem";
            this.edytujUsuńUżytkownikaToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.edytujUsuńUżytkownikaToolStripMenuItem.Text = "Edytuj / Usuń użytkownika";
            this.edytujUsuńUżytkownikaToolStripMenuItem.Click += new System.EventHandler(this.edytujUsuńUżytkownikaToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NewestFilmShowsLb);
            this.groupBox1.Location = new System.Drawing.Point(91, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 151);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zbliżające się seanse:";
            // 
            // NewestFilmShowsLb
            // 
            this.NewestFilmShowsLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NewestFilmShowsLb.FormattingEnabled = true;
            this.NewestFilmShowsLb.ItemHeight = 16;
            this.NewestFilmShowsLb.Location = new System.Drawing.Point(6, 19);
            this.NewestFilmShowsLb.Name = "NewestFilmShowsLb";
            this.NewestFilmShowsLb.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.NewestFilmShowsLb.Size = new System.Drawing.Size(271, 116);
            this.NewestFilmShowsLb.TabIndex = 0;
            // 
            // CinemaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CinemaManager.Properties.Resources.kisspng_overlay_5b3b365b30f975_8372723615306071952006;
            this.ClientSize = new System.Drawing.Size(798, 507);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DeleteTicketBtn);
            this.Controls.Add(this.SellTicketButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "CinemaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cinema Manager";
            this.Load += new System.EventHandler(this.CinemaForm_Load);
            this.LocationChanged += new System.EventHandler(this.CinemaForm_LocationChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label EmployeeLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label DateTimeLabel;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Button SellTicketButton;
        private System.Windows.Forms.Button DeleteTicketBtn;
        private System.Windows.Forms.Timer TimerMinutes;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem zarząToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zarządzajKinemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajFilmToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem usuńFilmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem użytkownikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zarejestrujNowegoUżytkownikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wylogujToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zablokujToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajSeansFilmowyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edytujUsuńSeansFilmowyToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox NewestFilmShowsLb;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem edytujUsuńUżytkownikaToolStripMenuItem;
    }
}

