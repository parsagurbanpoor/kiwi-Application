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
        public static class Global
        {
            public static byte UserType;
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

        private void btnsignup_Click(object sender, EventArgs e)
        {
            //Access to users

            Users frm = new Users();
            
            //Authentication

            var user = frm.usersTableAdapter.LoginUser(txtboxusername.Text, txtboxpassword.Text);
            
            //Presence or absence of the user in the database

            if (user.Count > 0)
            {
                //Get user role

                Global.UserType = Convert.ToByte(user[0]["Type"]);

                //Authentication success message

                MessageBox.Show("Login successful:)", "successful",MessageBoxButtons.OK,MessageBoxIcon.Information);

                //Access the dashboard

                DashBoredpage mainForm = new DashBoredpage();

                //Logging in and opening the dashboard page

                mainForm.Show();

                //Hiding the current page

                this.Hide();
            }
            else
            {
                //Authentication failure message

                MessageBox.Show("Login failed :(", "failed",MessageBoxButtons.RetryCancel,MessageBoxIcon.Error);
            }

        }
    }
}
