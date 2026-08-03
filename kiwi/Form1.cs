using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kiwi
{
    public partial class signuppage : Form
    {
        public signuppage()
        {
            InitializeComponent();
        }

        private void btnshow_Click(object sender, EventArgs e)
        {

        }

        private void checkpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkpassword.Checked==true)
            {
                txtboxpassword.PasswordChar ='\0';
            }
            else
            {
                txtboxpassword.PasswordChar = '*';
            }
        }
    }
}
