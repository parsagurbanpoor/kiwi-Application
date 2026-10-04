namespace kiwi
{
    partial class Add_loans
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
            this.lblloanID = new System.Windows.Forms.Label();
            this.lblloanbookname = new System.Windows.Forms.Label();
            this.lblloanusername = new System.Windows.Forms.Label();
            this.lblISBNloan = new System.Windows.Forms.Label();
            this.txtboxloanID = new System.Windows.Forms.TextBox();
            this.comboboxloanbookname = new System.Windows.Forms.ComboBox();
            this.lblISBN = new System.Windows.Forms.Label();
            this.comboboxusernameloan = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblcurrenttime = new System.Windows.Forms.Label();
            this.lblcurrentdate = new System.Windows.Forms.Label();
            this.lbldateofdeposit = new System.Windows.Forms.Label();
            this.lblreturn = new System.Windows.Forms.Label();
            this.saveloanbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.comboboxdayforloans = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblloanID
            // 
            this.lblloanID.AutoSize = true;
            this.lblloanID.Location = new System.Drawing.Point(5, 9);
            this.lblloanID.Name = "lblloanID";
            this.lblloanID.Size = new System.Drawing.Size(68, 17);
            this.lblloanID.TabIndex = 6;
            this.lblloanID.Text = "Loans ID:";
            // 
            // lblloanbookname
            // 
            this.lblloanbookname.AutoSize = true;
            this.lblloanbookname.Location = new System.Drawing.Point(3, 41);
            this.lblloanbookname.Name = "lblloanbookname";
            this.lblloanbookname.Size = new System.Drawing.Size(79, 17);
            this.lblloanbookname.TabIndex = 6;
            this.lblloanbookname.Text = "Bookname:";
            // 
            // lblloanusername
            // 
            this.lblloanusername.AutoSize = true;
            this.lblloanusername.Location = new System.Drawing.Point(5, 100);
            this.lblloanusername.Name = "lblloanusername";
            this.lblloanusername.Size = new System.Drawing.Size(77, 17);
            this.lblloanusername.TabIndex = 6;
            this.lblloanusername.Text = "Username:";
            // 
            // lblISBNloan
            // 
            this.lblISBNloan.AutoSize = true;
            this.lblISBNloan.Location = new System.Drawing.Point(415, 44);
            this.lblISBNloan.Name = "lblISBNloan";
            this.lblISBNloan.Size = new System.Drawing.Size(43, 17);
            this.lblISBNloan.TabIndex = 6;
            this.lblISBNloan.Text = "ISBN:";
            // 
            // txtboxloanID
            // 
            this.txtboxloanID.Location = new System.Drawing.Point(79, 6);
            this.txtboxloanID.Name = "txtboxloanID";
            this.txtboxloanID.Size = new System.Drawing.Size(40, 22);
            this.txtboxloanID.TabIndex = 7;
            // 
            // comboboxloanbookname
            // 
            this.comboboxloanbookname.FormattingEnabled = true;
            this.comboboxloanbookname.Location = new System.Drawing.Point(88, 41);
            this.comboboxloanbookname.Name = "comboboxloanbookname";
            this.comboboxloanbookname.Size = new System.Drawing.Size(321, 24);
            this.comboboxloanbookname.TabIndex = 8;
            this.comboboxloanbookname.SelectedIndexChanged += new System.EventHandler(this.comboboxloanbookname_SelectedIndexChanged);
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(464, 44);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(24, 17);
            this.lblISBN.TabIndex = 6;
            this.lblISBN.Text = "....";
            // 
            // comboboxusernameloan
            // 
            this.comboboxusernameloan.FormattingEnabled = true;
            this.comboboxusernameloan.Location = new System.Drawing.Point(88, 97);
            this.comboboxusernameloan.Name = "comboboxusernameloan";
            this.comboboxusernameloan.Size = new System.Drawing.Size(321, 24);
            this.comboboxusernameloan.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblcurrenttime);
            this.groupBox1.Controls.Add(this.lblcurrentdate);
            this.groupBox1.Location = new System.Drawing.Point(8, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 131);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current date and time";
            // 
            // lblcurrenttime
            // 
            this.lblcurrenttime.AutoSize = true;
            this.lblcurrenttime.Location = new System.Drawing.Point(68, 91);
            this.lblcurrenttime.Name = "lblcurrenttime";
            this.lblcurrenttime.Size = new System.Drawing.Size(20, 17);
            this.lblcurrenttime.TabIndex = 11;
            this.lblcurrenttime.Text = "...";
            // 
            // lblcurrentdate
            // 
            this.lblcurrentdate.AutoSize = true;
            this.lblcurrentdate.Location = new System.Drawing.Point(68, 31);
            this.lblcurrentdate.Name = "lblcurrentdate";
            this.lblcurrentdate.Size = new System.Drawing.Size(20, 17);
            this.lblcurrentdate.TabIndex = 11;
            this.lblcurrentdate.Text = "...";
            // 
            // lbldateofdeposit
            // 
            this.lbldateofdeposit.AutoSize = true;
            this.lbldateofdeposit.Location = new System.Drawing.Point(232, 157);
            this.lbldateofdeposit.Name = "lbldateofdeposit";
            this.lbldateofdeposit.Size = new System.Drawing.Size(108, 17);
            this.lbldateofdeposit.TabIndex = 6;
            this.lbldateofdeposit.Text = "Date of deposit:";
            // 
            // lblreturn
            // 
            this.lblreturn.AutoSize = true;
            this.lblreturn.Location = new System.Drawing.Point(232, 209);
            this.lblreturn.Name = "lblreturn";
            this.lblreturn.Size = new System.Drawing.Size(99, 17);
            this.lblreturn.TabIndex = 6;
            this.lblreturn.Text = "Return period:";
            // 
            // saveloanbtn
            // 
            this.saveloanbtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.saveloanbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveloanbtn.Location = new System.Drawing.Point(427, 294);
            this.saveloanbtn.Name = "saveloanbtn";
            this.saveloanbtn.Size = new System.Drawing.Size(126, 57);
            this.saveloanbtn.TabIndex = 10;
            this.saveloanbtn.Text = "Save";
            this.saveloanbtn.UseVisualStyleBackColor = false;
            this.saveloanbtn.Click += new System.EventHandler(this.saveloanbtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(12, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 57);
            this.button1.TabIndex = 10;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(346, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "....";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "....";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // comboboxdayforloans
            // 
            this.comboboxdayforloans.FormattingEnabled = true;
            this.comboboxdayforloans.Items.AddRange(new object[] {
            "7",
            "10",
            "15",
            "20",
            "30"});
            this.comboboxdayforloans.Location = new System.Drawing.Point(447, 206);
            this.comboboxdayforloans.Name = "comboboxdayforloans";
            this.comboboxdayforloans.Size = new System.Drawing.Size(63, 24);
            this.comboboxdayforloans.TabIndex = 8;
            this.comboboxdayforloans.SelectedIndexChanged += new System.EventHandler(this.comboboxdayforloans_SelectedIndexChanged);
            // 
            // Add_loans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 363);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.saveloanbtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboboxusernameloan);
            this.Controls.Add(this.comboboxdayforloans);
            this.Controls.Add(this.comboboxloanbookname);
            this.Controls.Add(this.txtboxloanID);
            this.Controls.Add(this.lblloanusername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.lblISBNloan);
            this.Controls.Add(this.lblreturn);
            this.Controls.Add(this.lbldateofdeposit);
            this.Controls.Add(this.lblloanbookname);
            this.Controls.Add(this.lblloanID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Add_loans";
            this.Text = "Add loans";
            this.Load += new System.EventHandler(this.Add_loans_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblloanID;
        private System.Windows.Forms.Label lblloanbookname;
        private System.Windows.Forms.Label lblloanusername;
        private System.Windows.Forms.Label lblISBNloan;
        private System.Windows.Forms.TextBox txtboxloanID;
        private System.Windows.Forms.ComboBox comboboxloanbookname;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.ComboBox comboboxusernameloan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbldateofdeposit;
        private System.Windows.Forms.Label lblreturn;
        private System.Windows.Forms.Button saveloanbtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblcurrenttime;
        private System.Windows.Forms.Label lblcurrentdate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox comboboxdayforloans;
    }
}