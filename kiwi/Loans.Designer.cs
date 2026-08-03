namespace kiwi
{
    partial class Loans
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblLoansearch = new System.Windows.Forms.Label();
            this.txtSearchLoan = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnReturnBook = new System.Windows.Forms.Button();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.btnExtendLoan = new System.Windows.Forms.Button();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.cmbFilterStatus = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbFilterStatus);
            this.panel1.Controls.Add(this.lblLoansearch);
            this.panel1.Controls.Add(this.txtSearchLoan);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(625, 70);
            this.panel1.TabIndex = 1;
            // 
            // lblLoansearch
            // 
            this.lblLoansearch.AutoSize = true;
            this.lblLoansearch.Location = new System.Drawing.Point(4, 25);
            this.lblLoansearch.Name = "lblLoansearch";
            this.lblLoansearch.Size = new System.Drawing.Size(91, 17);
            this.lblLoansearch.TabIndex = 1;
            this.lblLoansearch.Text = "Loan search:";
            // 
            // txtSearchLoan
            // 
            this.txtSearchLoan.Location = new System.Drawing.Point(97, 22);
            this.txtSearchLoan.Name = "txtSearchLoan";
            this.txtSearchLoan.Size = new System.Drawing.Size(223, 22);
            this.txtSearchLoan.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnReturnBook);
            this.panel2.Controls.Add(this.btnDeleteBook);
            this.panel2.Controls.Add(this.btnExtendLoan);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 460);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(625, 60);
            this.panel2.TabIndex = 3;
            // 
            // btnReturnBook
            // 
            this.btnReturnBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnReturnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnBook.ForeColor = System.Drawing.Color.White;
            this.btnReturnBook.Location = new System.Drawing.Point(269, 14);
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.Size = new System.Drawing.Size(97, 32);
            this.btnReturnBook.TabIndex = 2;
            this.btnReturnBook.Text = "ReturnBook";
            this.btnReturnBook.UseVisualStyleBackColor = false;
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnDeleteBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteBook.ForeColor = System.Drawing.Color.White;
            this.btnDeleteBook.Location = new System.Drawing.Point(372, 14);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(94, 32);
            this.btnDeleteBook.TabIndex = 2;
            this.btnDeleteBook.Text = "New Loan";
            this.btnDeleteBook.UseVisualStyleBackColor = false;
            // 
            // btnExtendLoan
            // 
            this.btnExtendLoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(110)))), ((int)(((byte)(42)))));
            this.btnExtendLoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExtendLoan.ForeColor = System.Drawing.Color.White;
            this.btnExtendLoan.Location = new System.Drawing.Point(158, 14);
            this.btnExtendLoan.Name = "btnExtendLoan";
            this.btnExtendLoan.Size = new System.Drawing.Size(96, 32);
            this.btnExtendLoan.TabIndex = 2;
            this.btnExtendLoan.Text = "ExtendLoan";
            this.btnExtendLoan.UseVisualStyleBackColor = false;
            // 
            // dgvBooks
            // 
            this.dgvBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBooks.Location = new System.Drawing.Point(0, 70);
            this.dgvBooks.MultiSelect = false;
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.ReadOnly = true;
            this.dgvBooks.RowTemplate.Height = 24;
            this.dgvBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBooks.Size = new System.Drawing.Size(625, 390);
            this.dgvBooks.TabIndex = 4;
            // 
            // cmbFilterStatus
            // 
            this.cmbFilterStatus.FormattingEnabled = true;
            this.cmbFilterStatus.Items.AddRange(new object[] {
            "All",
            "On Loan\t",
            "Returned",
            "Delayed"});
            this.cmbFilterStatus.Location = new System.Drawing.Point(491, 25);
            this.cmbFilterStatus.Name = "cmbFilterStatus";
            this.cmbFilterStatus.Size = new System.Drawing.Size(121, 24);
            this.cmbFilterStatus.TabIndex = 2;
            // 
            // Loans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvBooks);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Loans";
            this.Size = new System.Drawing.Size(625, 520);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblLoansearch;
        private System.Windows.Forms.TextBox txtSearchLoan;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnReturnBook;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.Button btnExtendLoan;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.ComboBox cmbFilterStatus;
    }
}
