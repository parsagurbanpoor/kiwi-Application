using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace kiwi
{
    public partial class Form_AddEditBook : Form
    {
        public Form_AddEditBook()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png";
            open.ShowDialog();
            pictureBox.ImageLocation = open.FileName;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.booksBindingSource.CancelEdit();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            booksTableAdapter.insertbook(txtBookname.Text, txtPublication.Text, txtpublicationyeaar.Text, int.Parse(txtISBN.Text), txtTranslator.Text, txtlanguage.Text,"null", txtcategory.Text, txtAgegroup.Text,"null", txtAuthor.Text);
            MessageBox.Show("Saving completed successfully.", "successful");
        }

        private void Form_AddEditBook_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kiwidbDataSet.Books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.kiwidbDataSet.Books);
        }

        private void booksBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
