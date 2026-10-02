using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kiwi
{
    public partial class Books : UserControl
    {
        public Books()
        {
            InitializeComponent();

            BooksTableAdapter.Fill(kiwidbDataSet.Books);
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            Form_AddEditBook addeditform = new Form_AddEditBook();

            addeditform.ShowDialog();

            // دوباره اطلاعات کتاب‌ها را از دیتابیس می‌خوانیم
            BooksTableAdapter.Fill(kiwidbDataSet.Books);
        }

        private void dgvBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEditBook_Click(object sender, EventArgs e)
        {
            if (dgvBooks.CurrentRow == null)
            {
                MessageBox.Show("لطفاً یک کتاب را انتخاب کنید.");
                return;
            }

            edit_book frm = new edit_book();

            //book name
            frm.txtBooknameedit.Text = dgvBooks.CurrentRow.Cells["booknameDataGridViewTextBoxColumn"].Value.ToString();
            //Publications
            frm.txtPublicationedit.Text = dgvBooks.CurrentRow.Cells["PublicationsDataGridViewTextBoxColumn"].Value.ToString();
            //PublicationYear
            frm.txtpublicationyeaaredit.Text = dgvBooks.CurrentRow.Cells["PublicationYearDataGridViewTextBoxColumn"].Value.ToString();
            //ISBN
            frm.txtISBNedit.Text = dgvBooks.CurrentRow.Cells["ISBNDataGridViewTextBoxColumn"].Value.ToString();
            //Author
            frm.txtAuthoredit.Text = dgvBooks.CurrentRow.Cells["AuthorDataGridViewTextBoxColumn"].Value.ToString();
            //Translator
            frm.txtTranslatoredit.Text = dgvBooks.CurrentRow.Cells["TranslatorDataGridViewTextBoxColumn"].Value.ToString();
            //language
            frm.txtLanguageedit.Text = dgvBooks.CurrentRow.Cells["LanguageDataGridViewTextBoxColumn"].Value.ToString();
            //category
            frm.edittxtcategory.Text = dgvBooks.CurrentRow.Cells["categoryDataGridViewTextBoxColumn"].Value.ToString();
            //agegrup
            /*
            var value = dgvBooks.CurrentRow.Cells["agegroupDataGridViewTextBoxColumn"].Value;

            if (value != null)
            {
                frm.txtagegrupedit.Text = value.ToString();
            }
            */
            frm.RowID = Convert.ToInt32(
   dgvBooks.CurrentRow.Cells["rowDataGridViewTextBoxColumn"].Value);

            frm.txtBooknameedit.Text =
            dgvBooks.CurrentRow.Cells["booknameDataGridViewTextBoxColumn"].Value?.ToString();

            frm.ShowDialog();
            BooksTableAdapter.Fill(kiwidbDataSet.Books);
        }
    }
    }