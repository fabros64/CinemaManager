namespace CinemaManager
{
    partial class ManageMovieForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NameTb = new System.Windows.Forms.TextBox();
            this.DescriptionTb = new System.Windows.Forms.TextBox();
            this.RateTb = new System.Windows.Forms.TextBox();
            this.AddMovieBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.IncoretName = new System.Windows.Forms.Label();
            this.IncoretPrice = new System.Windows.Forms.Label();
            this.IncoretDescription = new System.Windows.Forms.Label();
            this.IncoretRate = new System.Windows.Forms.Label();
            this.PriceTb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(25, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(25, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(25, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(25, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Rate";
            // 
            // NameTb
            // 
            this.NameTb.Location = new System.Drawing.Point(123, 31);
            this.NameTb.Name = "NameTb";
            this.NameTb.Size = new System.Drawing.Size(172, 20);
            this.NameTb.TabIndex = 1;
            // 
            // DescriptionTb
            // 
            this.DescriptionTb.Location = new System.Drawing.Point(123, 94);
            this.DescriptionTb.Multiline = true;
            this.DescriptionTb.Name = "DescriptionTb";
            this.DescriptionTb.Size = new System.Drawing.Size(172, 64);
            this.DescriptionTb.TabIndex = 3;
            // 
            // RateTb
            // 
            this.RateTb.Location = new System.Drawing.Point(123, 169);
            this.RateTb.Name = "RateTb";
            this.RateTb.Size = new System.Drawing.Size(171, 20);
            this.RateTb.TabIndex = 4;
            // 
            // AddMovieBtn
            // 
            this.AddMovieBtn.Location = new System.Drawing.Point(220, 206);
            this.AddMovieBtn.Name = "AddMovieBtn";
            this.AddMovieBtn.Size = new System.Drawing.Size(75, 23);
            this.AddMovieBtn.TabIndex = 5;
            this.AddMovieBtn.Text = "Add movie";
            this.AddMovieBtn.UseVisualStyleBackColor = true;
            this.AddMovieBtn.Click += new System.EventHandler(this.AddMovieBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(39, 206);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 6;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // IncoretName
            // 
            this.IncoretName.AutoSize = true;
            this.IncoretName.ForeColor = System.Drawing.Color.Red;
            this.IncoretName.Location = new System.Drawing.Point(310, 34);
            this.IncoretName.Name = "IncoretName";
            this.IncoretName.Size = new System.Drawing.Size(46, 13);
            this.IncoretName.TabIndex = 11;
            this.IncoretName.Text = "Incorect";
            this.IncoretName.Visible = false;
            // 
            // IncoretPrice
            // 
            this.IncoretPrice.AutoSize = true;
            this.IncoretPrice.ForeColor = System.Drawing.Color.Red;
            this.IncoretPrice.Location = new System.Drawing.Point(310, 69);
            this.IncoretPrice.Name = "IncoretPrice";
            this.IncoretPrice.Size = new System.Drawing.Size(46, 13);
            this.IncoretPrice.TabIndex = 12;
            this.IncoretPrice.Text = "Incorect";
            this.IncoretPrice.Visible = false;
            // 
            // IncoretDescription
            // 
            this.IncoretDescription.AutoSize = true;
            this.IncoretDescription.ForeColor = System.Drawing.Color.Red;
            this.IncoretDescription.Location = new System.Drawing.Point(310, 101);
            this.IncoretDescription.Name = "IncoretDescription";
            this.IncoretDescription.Size = new System.Drawing.Size(46, 13);
            this.IncoretDescription.TabIndex = 13;
            this.IncoretDescription.Text = "Incorect";
            this.IncoretDescription.Visible = false;
            // 
            // IncoretRate
            // 
            this.IncoretRate.AutoSize = true;
            this.IncoretRate.ForeColor = System.Drawing.Color.Red;
            this.IncoretRate.Location = new System.Drawing.Point(310, 169);
            this.IncoretRate.Name = "IncoretRate";
            this.IncoretRate.Size = new System.Drawing.Size(46, 13);
            this.IncoretRate.TabIndex = 14;
            this.IncoretRate.Text = "Incorect";
            this.IncoretRate.Visible = false;
            // 
            // PriceTb
            // 
            this.PriceTb.Location = new System.Drawing.Point(123, 64);
            this.PriceTb.Name = "PriceTb";
            this.PriceTb.Size = new System.Drawing.Size(172, 20);
            this.PriceTb.TabIndex = 2;
            // 
            // ManageMovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 252);
            this.Controls.Add(this.PriceTb);
            this.Controls.Add(this.IncoretRate);
            this.Controls.Add(this.IncoretDescription);
            this.Controls.Add(this.IncoretPrice);
            this.Controls.Add(this.IncoretName);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.AddMovieBtn);
            this.Controls.Add(this.RateTb);
            this.Controls.Add(this.DescriptionTb);
            this.Controls.Add(this.NameTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "ManageMovieForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add movie to database";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ManageMovieForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NameTb;
        private System.Windows.Forms.TextBox DescriptionTb;
        private System.Windows.Forms.TextBox RateTb;
        private System.Windows.Forms.Button AddMovieBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Label IncoretName;
        private System.Windows.Forms.Label IncoretPrice;
        private System.Windows.Forms.Label IncoretDescription;
        private System.Windows.Forms.Label IncoretRate;
        private System.Windows.Forms.TextBox PriceTb;
    }
}