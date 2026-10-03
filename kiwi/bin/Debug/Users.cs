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
    public partial class Users : UserControl
    {
        public Users()
        {
            InitializeComponent();

            usersTableAdapter.Fill(kiwidbDataSet2.Users);
        }
        
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            addusers frm = new addusers();

            frm.ShowDialog();
            usersTableAdapter.Fill(kiwidbDataSet2.Users);
        }
    }
}
