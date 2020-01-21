using System.Windows.Forms;

namespace CinemaManager
{
    partial class SellTicketForm
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
            this.FilmScreeningsLB = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            PlaceTb = new System.Windows.Forms.TextBox();
            HallTB = new System.Windows.Forms.TextBox();
            this.ChoosePlaceBTN = new System.Windows.Forms.Button();
            this.SellBTN = new System.Windows.Forms.Button();
            this.CancelBTN = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TicketPriceTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.RoomPlaceTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DateTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MovieNameTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FilmScreeningsLB);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 314);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wybierz seans filmowy";
            // 
            // FilmScreeningsLB
            // 
            this.FilmScreeningsLB.FormattingEnabled = true;
            this.FilmScreeningsLB.Location = new System.Drawing.Point(7, 20);
            this.FilmScreeningsLB.Name = "FilmScreeningsLB";
            this.FilmScreeningsLB.Size = new System.Drawing.Size(261, 290);
            this.FilmScreeningsLB.TabIndex = 0;
            this.FilmScreeningsLB.SelectedIndexChanged += new System.EventHandler(this.FilmScreeningsLB_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(PlaceTb);
            this.groupBox2.Controls.Add(HallTB);
            this.groupBox2.Controls.Add(this.ChoosePlaceBTN);
            this.groupBox2.Location = new System.Drawing.Point(292, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(202, 128);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Wybierz miejsce";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Miejsce:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sala:";
            // 
            // PlaceTB
            // 
            PlaceTb.Enabled = false;
            PlaceTb.Location = new System.Drawing.Point(58, 66);
            PlaceTb.Name = "PlaceTB";
            PlaceTb.Size = new System.Drawing.Size(160, 20);
            PlaceTb.TabIndex = 2;
            PlaceTb.TextChanged += new System.EventHandler(this.PlaceTB_TextChanged);
            // 
            // HallTB
            // 
            HallTB.Enabled = false;
            HallTB.Location = new System.Drawing.Point(58, 33);
            HallTB.Name = "HallTB";
            HallTB.Size = new System.Drawing.Size(87, 20);
            HallTB.TabIndex = 1;
            HallTB.TextChanged += new System.EventHandler(this.HallTB_TextChanged);
            // 
            // ChoosePlaceBTN
            // 
            this.ChoosePlaceBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ChoosePlaceBTN.Location = new System.Drawing.Point(37, 92);
            this.ChoosePlaceBTN.Name = "ChoosePlaceBTN";
            this.ChoosePlaceBTN.Size = new System.Drawing.Size(133, 28);
            this.ChoosePlaceBTN.TabIndex = 0;
            this.ChoosePlaceBTN.Text = "Miejsce i sala";
            this.ChoosePlaceBTN.UseVisualStyleBackColor = false;
            this.ChoosePlaceBTN.Click += new System.EventHandler(this.ChoosePlaceBTN_Click);
            // 
            // SellBTN
            // 
            this.SellBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.SellBTN.Location = new System.Drawing.Point(344, 332);
            this.SellBTN.Name = "SellBTN";
            this.SellBTN.Size = new System.Drawing.Size(142, 46);
            this.SellBTN.TabIndex = 3;
            this.SellBTN.Text = "Sprzedaj";
            this.SellBTN.UseVisualStyleBackColor = false;
            this.SellBTN.Click += new System.EventHandler(this.SellBTN_Click);
            // 
            // CancelBTN
            // 
            this.CancelBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.CancelBTN.Location = new System.Drawing.Point(19, 332);
            this.CancelBTN.Name = "CancelBTN";
            this.CancelBTN.Size = new System.Drawing.Size(136, 46);
            this.CancelBTN.TabIndex = 4;
            this.CancelBTN.Text = "Anuluj";
            this.CancelBTN.UseVisualStyleBackColor = false;
            this.CancelBTN.Click += new System.EventHandler(this.CancelBTN_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TicketPriceTB);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.RoomPlaceTB);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.DateTB);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.MovieNameTB);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(292, 146);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 180);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dane biletu";
            // 
            // TicketPriceTB
            // 
            this.TicketPriceTB.Enabled = false;
            this.TicketPriceTB.Location = new System.Drawing.Point(79, 144);
            this.TicketPriceTB.Name = "TicketPriceTB";
            this.TicketPriceTB.Size = new System.Drawing.Size(115, 20);
            this.TicketPriceTB.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Cena:";
            // 
            // RoomPlaceTB
            // 
            this.RoomPlaceTB.Enabled = false;
            this.RoomPlaceTB.Location = new System.Drawing.Point(79, 102);
            this.RoomPlaceTB.Name = "RoomPlaceTB";
            this.RoomPlaceTB.Size = new System.Drawing.Size(115, 20);
            this.RoomPlaceTB.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Miejsce/sala:";
            // 
            // DateTB
            // 
            this.DateTB.Enabled = false;
            this.DateTB.Location = new System.Drawing.Point(79, 62);
            this.DateTB.Name = "DateTB";
            this.DateTB.Size = new System.Drawing.Size(115, 20);
            this.DateTB.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Data:";
            // 
            // MovieNameTB
            // 
            this.MovieNameTB.Enabled = false;
            this.MovieNameTB.Location = new System.Drawing.Point(79, 26);
            this.MovieNameTB.Name = "MovieNameTB";
            this.MovieNameTB.Size = new System.Drawing.Size(115, 20);
            this.MovieNameTB.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nazwa filmu:";
            // 
            // SellTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 390);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.CancelBTN);
            this.Controls.Add(this.SellBTN);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SellTicketForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sprzedaj bilet";
            this.Load += new System.EventHandler(this.SellTicketForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox FilmScreeningsLB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public static TextBox PlaceTb { get; set; }
        public static System.Windows.Forms.TextBox HallTB;
        private System.Windows.Forms.Button ChoosePlaceBTN;
        private System.Windows.Forms.Button SellBTN;
        private System.Windows.Forms.Button CancelBTN;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox RoomPlaceTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DateTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MovieNameTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TicketPriceTB;
        private System.Windows.Forms.Label label7;
    }
}