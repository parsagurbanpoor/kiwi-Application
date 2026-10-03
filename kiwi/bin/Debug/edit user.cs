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
    public partial class edit_user : Form
    {
        public edit_user()
        {
            InitializeComponent();
        }

        private void Adduserbtn_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to edit?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {

                Users frm = new Users();

                byte userType;

                switch (comboboxEditType.Text)
                {
                    case "Patron":
                        userType = 1;
                        break;

                    case "Circulation Clerk":
                        userType = 2;
                        break;

                    case "Librarian":
                        userType = 3;
                        break;

                    case "Administrator":
                        userType = 4;
                        break;

                    default:
                        userType = 0;
                        break;
                }


                frm.usersTableAdapter.UpdateUser(txtboxEditFname.Text, txtboxEditLname.Text, txtboxEditUsername.Text, txtboxEditPassword.Text, userType, "Null", byte.Parse(txtboxEditage.Text), comboBox2Edit.Text, comboboxEditGender.Text, int.Parse(txtboxEditRow.Text));
                
            }
           }

        private void cancelAdduserbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

