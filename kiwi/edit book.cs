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
using kiwi.kiwidbDataSetTableAdapters;

namespace kiwi
{
    public partial class edit_book : Form
    {
        public edit_book()
        {
            InitializeComponent();
        }
        public int RowID;
        private void edit_book_Load(object sender, EventArgs e)
        {

        }

        private void editbookbtn_Click(object sender, EventArgs e)
        {
          DialogResult res= MessageBox.Show("Are you sure you want to edit?", "edit alert",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                
                BooksTableAdapter adapter = new BooksTableAdapter();
                adapter.Updatebook(txtBooknameedit.Text, txtPublicationedit.Text,txtpublicationyeaaredit.Text,int.Parse(txtISBNedit.Text),txtTranslatoredit.Text, txtLanguageedit.Text,"null", edittxtcategory.Text,txtagegrupedit.Text,"null",txtAuthoredit.Text,RowID);
                DialogResult ress = MessageBox.Show("The edit was successful.", "successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (ress == DialogResult.OK)
                {
                    this.Close();
                } 

            }
        }

        private void cancelbookbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
