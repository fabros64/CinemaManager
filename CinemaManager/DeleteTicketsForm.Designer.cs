namespace CinemaManager
{
    partial class DeleteTicketsForm
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
            this.CancelBTN = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TicketsLB = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TicketPriceTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.RoomPlaceTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DateTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MovieNameTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ReturnTicketBTN = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // CancelBTN
            // 
            this.CancelBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.CancelBTN.Location = new System.Drawing.Point(18, 198);
            this.CancelBTN.Name = "CancelBTN";
            this.CancelBTN.Size = new System.Drawing.Size(136, 46);
            this.CancelBTN.TabIndex = 6;
            this.CancelBTN.Text = "Anuluj";
            this.CancelBTN.UseVisualStyleBackColor = false;
            this.CancelBTN.Click += new System.EventHandler(this.CancelBTN_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TicketsLB);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 180);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wybierz bilet";
            // 
            // TicketsLB
            // 
            this.TicketsLB.FormattingEnabled = true;
            this.TicketsLB.HorizontalScrollbar = true;
            this.TicketsLB.Location = new System.Drawing.Point(6, 18);
            this.TicketsLB.Name = "TicketsLB";
            this.TicketsLB.Size = new System.Drawing.Size(271, 160);
            this.TicketsLB.TabIndex = 0;
            this.TicketsLB.SelectedIndexChanged += new System.EventHandler(this.TicketsLB_SelectedIndexChanged);
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
            this.groupBox3.Location = new System.Drawing.Point(301, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(249, 180);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dane biletu";
            // 
            // TicketPriceTB
            // 
            this.TicketPriceTB.Enabled = false;
            this.TicketPriceTB.Location = new System.Drawing.Point(79, 144);
            this.TicketPriceTB.Name = "TicketPriceTB";
            this.TicketPriceTB.Size = new System.Drawing.Size(164, 20);
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
            this.RoomPlaceTB.Size = new System.Drawing.Size(164, 20);
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
            this.DateTB.Size = new System.Drawing.Size(164, 20);
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
            this.MovieNameTB.Size = new System.Drawing.Size(164, 20);
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
            // ReturnTicketBTN
            // 
            this.ReturnTicketBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ReturnTicketBTN.Location = new System.Drawing.Point(402, 198);
            this.ReturnTicketBTN.Name = "ReturnTicketBTN";
            this.ReturnTicketBTN.Size = new System.Drawing.Size(142, 46);
            this.ReturnTicketBTN.TabIndex = 7;
            this.ReturnTicketBTN.Text = "Zwróć";
            this.ReturnTicketBTN.UseVisualStyleBackColor = false;
            this.ReturnTicketBTN.Click += new System.EventHandler(this.ReturnTicketBTN_Click);
            // 
            // DeleteTicketsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 253);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.ReturnTicketBTN);
            this.Controls.Add(this.CancelBTN);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "DeleteTicketsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zwróć bilet";
            this.Load += new System.EventHandler(this.DeleteTicketsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CancelBTN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox TicketsLB;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TicketPriceTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox RoomPlaceTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DateTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MovieNameTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ReturnTicketBTN;
    }
}