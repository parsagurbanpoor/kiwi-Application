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

            booksTableAdapter1.Fill(kiwidbDataSet1.Books);
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            Form_AddEditBook addeditform = new Form_AddEditBook();

            addeditform.ShowDialog();

            // دوباره اطلاعات کتاب‌ها را از دیتابیس می‌خوانیم
            booksTableAdapter1.Fill(kiwidbDataSet1.Books);
        }

        private void dgvBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}