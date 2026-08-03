namespace kiwi
{
    partial class Form_AddEditBook
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtBookname = new System.Windows.Forms.TextBox();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kiwidbDataSet = new kiwi.kiwidbDataSet();
            this.txtpublicationyeaar = new System.Windows.Forms.TextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtlanguage = new System.Windows.Forms.TextBox();
            this.txtTranslator = new System.Windows.Forms.TextBox();
            this.txtcategory = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtAgegroup = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPublication = new System.Windows.Forms.TextBox();
            this.booksTableAdapter = new kiwi.kiwidbDataSetTableAdapters.BooksTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiwidbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bookname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Author:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "ISBN:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Translator:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Language:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "category:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 330);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "age group:";
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::kiwi.Properties.Resources.download;
            this.pictureBox.Location = new System.Drawing.Point(501, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(119, 129);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(518, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBookname
            // 
            this.txtBookname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "bookname", true));
            this.txtBookname.Location = new System.Drawing.Point(97, 14);
            this.txtBookname.Name = "txtBookname";
            this.txtBookname.Size = new System.Drawing.Size(366, 22);
            this.txtBookname.TabIndex = 3;
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "Books";
            this.booksBindingSource.DataSource = this.kiwidbDataSet;
            this.booksBindingSource.CurrentChanged += new System.EventHandler(this.booksBindingSource_CurrentChanged);
            // 
            // kiwidbDataSet
            // 
            this.kiwidbDataSet.DataSetName = "kiwidbDataSet";
            this.kiwidbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtpublicationyeaar
            // 
            this.txtpublicationyeaar.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "Publication Year", true));
            this.txtpublicationyeaar.Location = new System.Drawing.Point(125, 121);
            this.txtpublicationyeaar.Name = "txtpublicationyeaar";
            this.txtpublicationyeaar.Size = new System.Drawing.Size(61, 22);
            this.txtpublicationyeaar.TabIndex = 3;
            // 
            // txtISBN
            // 
            this.txtISBN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "ISBN", true));
            this.txtISBN.Location = new System.Drawing.Point(55, 159);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(285, 22);
            this.txtISBN.TabIndex = 4;
            // 
            // txtlanguage
            // 
            this.txtlanguage.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "Language", true));
            this.txtlanguage.Location = new System.Drawing.Point(79, 238);
            this.txtlanguage.Name = "txtlanguage";
            this.txtlanguage.Size = new System.Drawing.Size(206, 22);
            this.txtlanguage.TabIndex = 5;
            // 
            // txtTranslator
            // 
            this.txtTranslator.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "Translator", true));
            this.txtTranslator.Location = new System.Drawing.Point(88, 194);
            this.txtTranslator.Name = "txtTranslator";
            this.txtTranslator.Size = new System.Drawing.Size(254, 22);
            this.txtTranslator.TabIndex = 4;
            // 
            // txtcategory
            // 
            this.txtcategory.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "Category", true));
            this.txtcategory.Location = new System.Drawing.Point(79, 282);
            this.txtcategory.Name = "txtcategory";
            this.txtcategory.Size = new System.Drawing.Size(206, 22);
            this.txtcategory.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Publication year:";
            // 
            // txtAuthor
            // 
            this.txtAuthor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "Author", true));
            this.txtAuthor.Location = new System.Drawing.Point(72, 54);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(254, 22);
            this.txtAuthor.TabIndex = 6;
            // 
            // txtAgegroup
            // 
            this.txtAgegroup.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "age group", true));
            this.txtAgegroup.Location = new System.Drawing.Point(88, 327);
            this.txtAgegroup.Name = "txtAgegroup";
            this.txtAgegroup.Size = new System.Drawing.Size(98, 22);
            this.txtAgegroup.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Lime;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(434, 364);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 57);
            this.button2.TabIndex = 2;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(85, 364);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 57);
            this.button3.TabIndex = 2;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Publication:";
            // 
            // txtPublication
            // 
            this.txtPublication.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "Publications", true));
            this.txtPublication.Location = new System.Drawing.Point(93, 87);
            this.txtPublication.Name = "txtPublication";
            this.txtPublication.Size = new System.Drawing.Size(138, 22);
            this.txtPublication.TabIndex = 3;
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // Form_AddEditBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 433);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtAgegroup);
            this.Controls.Add(this.txtcategory);
            this.Controls.Add(this.txtlanguage);
            this.Controls.Add(this.txtTranslator);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.txtPublication);
            this.Controls.Add(this.txtpublicationyeaar);
            this.Controls.Add(this.txtBookname);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_AddEditBook";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Add Edit Book";
            this.Load += new System.EventHandler(this.Form_AddEditBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kiwidbDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBookname;
        private System.Windows.Forms.TextBox txtpublicationyeaar;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtlanguage;
        private System.Windows.Forms.TextBox txtTranslator;
        private System.Windows.Forms.TextBox txtcategory;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtAgegroup;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPublication;
        private kiwidbDataSet kiwidbDataSet;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private kiwidbDataSetTableAdapters.BooksTableAdapter booksTableAdapter;
    }
}