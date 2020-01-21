namespace CinemaManager
{
    partial class SeatingManagementForm
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
            this.screen = new System.Windows.Forms.Panel();
            this.seats = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.salaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.małaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.średniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dużaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wyczyśćToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // screen
            // 
            this.screen.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.screen.Location = new System.Drawing.Point(50, 68);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(668, 32);
            this.screen.TabIndex = 0;
            // 
            // seats
            // 
            this.seats.BackColor = System.Drawing.Color.Transparent;
            this.seats.Location = new System.Drawing.Point(75, 136);
            this.seats.Name = "seats";
            this.seats.Size = new System.Drawing.Size(615, 265);
            this.seats.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salaToolStripMenuItem,
            this.zapiszToolStripMenuItem,
            this.wyczyśćToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // salaToolStripMenuItem
            // 
            this.salaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.małaToolStripMenuItem,
            this.średniaToolStripMenuItem,
            this.dużaToolStripMenuItem1});
            this.salaToolStripMenuItem.Name = "salaToolStripMenuItem";
            this.salaToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.salaToolStripMenuItem.Text = "Sala";
            // 
            // małaToolStripMenuItem
            // 
            this.małaToolStripMenuItem.Name = "małaToolStripMenuItem";
            this.małaToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.małaToolStripMenuItem.Text = "Mała";
            this.małaToolStripMenuItem.Click += new System.EventHandler(this.małaToolStripMenuItem_Click);
            // 
            // średniaToolStripMenuItem
            // 
            this.średniaToolStripMenuItem.Name = "średniaToolStripMenuItem";
            this.średniaToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.średniaToolStripMenuItem.Text = "Średnia";
            this.średniaToolStripMenuItem.Click += new System.EventHandler(this.średniaToolStripMenuItem_Click);
            // 
            // dużaToolStripMenuItem1
            // 
            this.dużaToolStripMenuItem1.Name = "dużaToolStripMenuItem1";
            this.dużaToolStripMenuItem1.Size = new System.Drawing.Size(113, 22);
            this.dużaToolStripMenuItem1.Text = "Duża";
            this.dużaToolStripMenuItem1.Click += new System.EventHandler(this.dużaToolStripMenuItem1_Click);
            // 
            // zapiszToolStripMenuItem
            // 
            this.zapiszToolStripMenuItem.Name = "zapiszToolStripMenuItem";
            this.zapiszToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.zapiszToolStripMenuItem.Text = "Zapisz";
            this.zapiszToolStripMenuItem.Click += new System.EventHandler(this.zapiszToolStripMenuItem_Click);
            // 
            // wyczyśćToolStripMenuItem
            // 
            this.wyczyśćToolStripMenuItem.Name = "wyczyśćToolStripMenuItem";
            this.wyczyśćToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.wyczyśćToolStripMenuItem.Text = "Wyczyść";
            this.wyczyśćToolStripMenuItem.Click += new System.EventHandler(this.wyczyśćToolStripMenuItem_Click);
            // 
            // SeatingManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.seats);
            this.Controls.Add(this.screen);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SeatingManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SeatingManagementForm";
            this.Load += new System.EventHandler(this.SeatingManagementForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel screen;
        private System.Windows.Forms.Panel seats;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem małaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dużaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem średniaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wyczyśćToolStripMenuItem;
    }
}