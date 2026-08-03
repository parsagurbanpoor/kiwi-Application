namespace kiwi
{
    partial class profile
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
            this.profileBox = new System.Windows.Forms.PictureBox();
            this.lblusertitle = new System.Windows.Forms.Label();
            this.groupBoxinfo = new System.Windows.Forms.GroupBox();
            this.lblfirstname = new System.Windows.Forms.Label();
            this.lbllastname = new System.Windows.Forms.Label();
            this.lblage = new System.Windows.Forms.Label();
            this.lbltype = new System.Windows.Forms.Label();
            this.lblgender = new System.Windows.Forms.Label();
            this.lbleducation = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.profileBox)).BeginInit();
            this.groupBoxinfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // profileBox
            // 
            this.profileBox.Image = global::kiwi.Properties.Resources.waves_deep_blue_3840x2160_12119;
            this.profileBox.Location = new System.Drawing.Point(329, 43);
            this.profileBox.Name = "profileBox";
            this.profileBox.Size = new System.Drawing.Size(125, 133);
            this.profileBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profileBox.TabIndex = 0;
            this.profileBox.TabStop = false;
            // 
            // lblusertitle
            // 
            this.lblusertitle.AutoSize = true;
            this.lblusertitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusertitle.Location = new System.Drawing.Point(364, 196);
            this.lblusertitle.Name = "lblusertitle";
            this.lblusertitle.Size = new System.Drawing.Size(54, 25);
            this.lblusertitle.TabIndex = 1;
            this.lblusertitle.Text = "user";
            // 
            // groupBoxinfo
            // 
            this.groupBoxinfo.Controls.Add(this.lbleducation);
            this.groupBoxinfo.Controls.Add(this.lblgender);
            this.groupBoxinfo.Controls.Add(this.lbltype);
            this.groupBoxinfo.Controls.Add(this.lblage);
            this.groupBoxinfo.Controls.Add(this.lbllastname);
            this.groupBoxinfo.Controls.Add(this.lblfirstname);
            this.groupBoxinfo.Location = new System.Drawing.Point(291, 241);
            this.groupBoxinfo.Name = "groupBoxinfo";
            this.groupBoxinfo.Size = new System.Drawing.Size(200, 184);
            this.groupBoxinfo.TabIndex = 2;
            this.groupBoxinfo.TabStop = false;
            this.groupBoxinfo.Text = "information";
            // 
            // lblfirstname
            // 
            this.lblfirstname.AutoSize = true;
            this.lblfirstname.Location = new System.Drawing.Point(7, 22);
            this.lblfirstname.Name = "lblfirstname";
            this.lblfirstname.Size = new System.Drawing.Size(70, 17);
            this.lblfirstname.TabIndex = 0;
            this.lblfirstname.Text = "firstname:";
            // 
            // lbllastname
            // 
            this.lbllastname.AutoSize = true;
            this.lbllastname.Location = new System.Drawing.Point(7, 48);
            this.lbllastname.Name = "lbllastname";
            this.lbllastname.Size = new System.Drawing.Size(69, 17);
            this.lbllastname.TabIndex = 0;
            this.lbllastname.Text = "lastname:";
            // 
            // lblage
            // 
            this.lblage.AutoSize = true;
            this.lblage.Location = new System.Drawing.Point(6, 73);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(36, 17);
            this.lblage.TabIndex = 0;
            this.lblage.Text = "age:";
            // 
            // lbltype
            // 
            this.lbltype.AutoSize = true;
            this.lbltype.Location = new System.Drawing.Point(7, 100);
            this.lbltype.Name = "lbltype";
            this.lbltype.Size = new System.Drawing.Size(39, 17);
            this.lbltype.TabIndex = 0;
            this.lbltype.Text = "type:";
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Location = new System.Drawing.Point(6, 129);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(57, 17);
            this.lblgender.TabIndex = 0;
            this.lblgender.Text = "gender:";
            // 
            // lbleducation
            // 
            this.lbleducation.AutoSize = true;
            this.lbleducation.Location = new System.Drawing.Point(6, 155);
            this.lbleducation.Name = "lbleducation";
            this.lbleducation.Size = new System.Drawing.Size(74, 17);
            this.lbleducation.TabIndex = 0;
            this.lbleducation.Text = "education:";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Red;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Location = new System.Drawing.Point(348, 447);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(74, 34);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.groupBoxinfo);
            this.Controls.Add(this.lblusertitle);
            this.Controls.Add(this.profileBox);
            this.Name = "profile";
            this.Size = new System.Drawing.Size(782, 553);
            ((System.ComponentModel.ISupportInitialize)(this.profileBox)).EndInit();
            this.groupBoxinfo.ResumeLayout(false);
            this.groupBoxinfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox profileBox;
        private System.Windows.Forms.Label lblusertitle;
        private System.Windows.Forms.GroupBox groupBoxinfo;
        private System.Windows.Forms.Label lblfirstname;
        private System.Windows.Forms.Label lbllastname;
        private System.Windows.Forms.Label lbleducation;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.Label lbltype;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.Button btnLogout;
    }
}
