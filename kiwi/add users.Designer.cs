namespace kiwi
{
    partial class addusers
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
            this.lblrow = new System.Windows.Forms.Label();
            this.lblfname = new System.Windows.Forms.Label();
            this.lblLname = new System.Windows.Forms.Label();
            this.lblusername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblage = new System.Windows.Forms.Label();
            this.lbleducation = new System.Windows.Forms.Label();
            this.lblgender = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblrow
            // 
            this.lblrow.AutoSize = true;
            this.lblrow.Location = new System.Drawing.Point(12, 9);
            this.lblrow.Name = "lblrow";
            this.lblrow.Size = new System.Drawing.Size(39, 17);
            this.lblrow.TabIndex = 0;
            this.lblrow.Text = "Row:";
            // 
            // lblfname
            // 
            this.lblfname.AutoSize = true;
            this.lblfname.Location = new System.Drawing.Point(12, 47);
            this.lblfname.Name = "lblfname";
            this.lblfname.Size = new System.Drawing.Size(74, 17);
            this.lblfname.TabIndex = 0;
            this.lblfname.Text = "Firstname:";
            // 
            // lblLname
            // 
            this.lblLname.AutoSize = true;
            this.lblLname.Location = new System.Drawing.Point(12, 85);
            this.lblLname.Name = "lblLname";
            this.lblLname.Size = new System.Drawing.Size(74, 17);
            this.lblLname.TabIndex = 0;
            this.lblLname.Text = "Lastname:";
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Location = new System.Drawing.Point(12, 123);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(77, 17);
            this.lblusername.TabIndex = 0;
            this.lblusername.Text = "Username:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(12, 161);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(73, 17);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.Text = "Password:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(12, 199);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(44, 17);
            this.lblType.TabIndex = 0;
            this.lblType.Text = "Type:";
            // 
            // lblage
            // 
            this.lblage.AutoSize = true;
            this.lblage.Location = new System.Drawing.Point(12, 237);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(37, 17);
            this.lblage.TabIndex = 0;
            this.lblage.Text = "Age:";
            // 
            // lbleducation
            // 
            this.lbleducation.AutoSize = true;
            this.lbleducation.Location = new System.Drawing.Point(12, 275);
            this.lbleducation.Name = "lbleducation";
            this.lbleducation.Size = new System.Drawing.Size(75, 17);
            this.lbleducation.TabIndex = 0;
            this.lbleducation.Text = "Education:";
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Location = new System.Drawing.Point(12, 313);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(60, 17);
            this.lblgender.TabIndex = 0;
            this.lblgender.Text = "Gender:";
            // 
            // addusers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 433);
            this.Controls.Add(this.lblgender);
            this.Controls.Add(this.lbleducation);
            this.Controls.Add(this.lblage);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.lblLname);
            this.Controls.Add(this.lblfname);
            this.Controls.Add(this.lblrow);
            this.Name = "addusers";
            this.Text = "addusers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblrow;
        private System.Windows.Forms.Label lblfname;
        private System.Windows.Forms.Label lblLname;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.Label lbleducation;
        private System.Windows.Forms.Label lblgender;
    }
}