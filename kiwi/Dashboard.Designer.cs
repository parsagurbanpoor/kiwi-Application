namespace kiwi
{
    partial class Dashboard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelCard1 = new System.Windows.Forms.Panel();
            this.lbltitleofcard1 = new System.Windows.Forms.Label();
            this.lblTotalBooks = new System.Windows.Forms.Label();
            this.panelCard2 = new System.Windows.Forms.Panel();
            this.lblActiveLoans = new System.Windows.Forms.Label();
            this.lbltitleofcard2 = new System.Windows.Forms.Label();
            this.panelCard3 = new System.Windows.Forms.Panel();
            this.lblDelayedLoans = new System.Windows.Forms.Label();
            this.lbltitleofcard3 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelCard1.SuspendLayout();
            this.panelCard2.SuspendLayout();
            this.panelCard3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::kiwi.Properties.Resources.Gemini_Generated_Image_sugg3lsugg3lsugg;
            this.pictureBox1.Location = new System.Drawing.Point(127, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(504, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelCard1
            // 
            this.panelCard1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panelCard1.Controls.Add(this.lblTotalBooks);
            this.panelCard1.Controls.Add(this.lbltitleofcard1);
            this.panelCard1.Location = new System.Drawing.Point(117, 290);
            this.panelCard1.Name = "panelCard1";
            this.panelCard1.Size = new System.Drawing.Size(166, 144);
            this.panelCard1.TabIndex = 1;
            // 
            // lbltitleofcard1
            // 
            this.lbltitleofcard1.AutoSize = true;
            this.lbltitleofcard1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbltitleofcard1.Location = new System.Drawing.Point(8, 14);
            this.lbltitleofcard1.Name = "lbltitleofcard1";
            this.lbltitleofcard1.Size = new System.Drawing.Size(150, 17);
            this.lbltitleofcard1.TabIndex = 0;
            this.lbltitleofcard1.Text = "Total number of books";
            // 
            // lblTotalBooks
            // 
            this.lblTotalBooks.AutoSize = true;
            this.lblTotalBooks.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBooks.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTotalBooks.Location = new System.Drawing.Point(69, 62);
            this.lblTotalBooks.Name = "lblTotalBooks";
            this.lblTotalBooks.Size = new System.Drawing.Size(28, 33);
            this.lblTotalBooks.TabIndex = 0;
            this.lblTotalBooks.Text = "0";
            // 
            // panelCard2
            // 
            this.panelCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(200)))), ((int)(((byte)(126)))));
            this.panelCard2.Controls.Add(this.lblActiveLoans);
            this.panelCard2.Controls.Add(this.lbltitleofcard2);
            this.panelCard2.Location = new System.Drawing.Point(289, 290);
            this.panelCard2.Name = "panelCard2";
            this.panelCard2.Size = new System.Drawing.Size(166, 144);
            this.panelCard2.TabIndex = 2;
            // 
            // lblActiveLoans
            // 
            this.lblActiveLoans.AutoSize = true;
            this.lblActiveLoans.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveLoans.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblActiveLoans.Location = new System.Drawing.Point(69, 62);
            this.lblActiveLoans.Name = "lblActiveLoans";
            this.lblActiveLoans.Size = new System.Drawing.Size(28, 33);
            this.lblActiveLoans.TabIndex = 0;
            this.lblActiveLoans.Text = "0";
            // 
            // lbltitleofcard2
            // 
            this.lbltitleofcard2.AutoSize = true;
            this.lbltitleofcard2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbltitleofcard2.Location = new System.Drawing.Point(8, 14);
            this.lbltitleofcard2.Name = "lbltitleofcard2";
            this.lbltitleofcard2.Size = new System.Drawing.Size(103, 17);
            this.lbltitleofcard2.TabIndex = 0;
            this.lbltitleofcard2.Text = "Active deposits";
            // 
            // panelCard3
            // 
            this.panelCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(49)))), ((int)(((byte)(45)))));
            this.panelCard3.Controls.Add(this.lblDelayedLoans);
            this.panelCard3.Controls.Add(this.lbltitleofcard3);
            this.panelCard3.Location = new System.Drawing.Point(461, 290);
            this.panelCard3.Name = "panelCard3";
            this.panelCard3.Size = new System.Drawing.Size(166, 144);
            this.panelCard3.TabIndex = 3;
            // 
            // lblDelayedLoans
            // 
            this.lblDelayedLoans.AutoSize = true;
            this.lblDelayedLoans.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelayedLoans.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDelayedLoans.Location = new System.Drawing.Point(69, 62);
            this.lblDelayedLoans.Name = "lblDelayedLoans";
            this.lblDelayedLoans.Size = new System.Drawing.Size(28, 33);
            this.lblDelayedLoans.TabIndex = 0;
            this.lblDelayedLoans.Text = "0";
            // 
            // lbltitleofcard3
            // 
            this.lbltitleofcard3.AutoSize = true;
            this.lbltitleofcard3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbltitleofcard3.Location = new System.Drawing.Point(8, 14);
            this.lbltitleofcard3.Name = "lbltitleofcard3";
            this.lbltitleofcard3.Size = new System.Drawing.Size(150, 17);
            this.lbltitleofcard3.TabIndex = 0;
            this.lbltitleofcard3.Text = "Total number of books";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(241, 201);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(64, 17);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "12:00:00";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(361, 201);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(80, 17);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "1403/05/13";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.panelCard3);
            this.Controls.Add(this.panelCard2);
            this.Controls.Add(this.panelCard1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(745, 541);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelCard1.ResumeLayout(false);
            this.panelCard1.PerformLayout();
            this.panelCard2.ResumeLayout(false);
            this.panelCard2.PerformLayout();
            this.panelCard3.ResumeLayout(false);
            this.panelCard3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelCard1;
        private System.Windows.Forms.Label lblTotalBooks;
        private System.Windows.Forms.Label lbltitleofcard1;
        private System.Windows.Forms.Panel panelCard2;
        private System.Windows.Forms.Label lblActiveLoans;
        private System.Windows.Forms.Label lbltitleofcard2;
        private System.Windows.Forms.Panel panelCard3;
        private System.Windows.Forms.Label lblDelayedLoans;
        private System.Windows.Forms.Label lbltitleofcard3;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Timer timer1;
    }
}
