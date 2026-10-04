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
    public partial class Loans : UserControl
    {
        public Loans()
        {
            InitializeComponent();
        }

        private void btnNewloan_Click(object sender, EventArgs e)
        {
            Add_loans frm = new Add_loans();

            frm.Show();

            this.Hide();
        }
    }
}
