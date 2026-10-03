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
    public partial class addusers : Form
    {
        public addusers()
        {
            InitializeComponent();
        }
        //Contact the user page
        Users frm = new Users();
        private void cancelAdduserbtn_Click(object sender, EventArgs e)
        {
            //Cancellation of operation
            this.Close();
        }

        private void Adduserbtn_Click(object sender, EventArgs e)
        {
            //Inquiring about the propriety of the library staff's conduct
            DialogResult res = MessageBox.Show("You are saving a user. Are you sure you want to proceed?", "Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            
            //Result of the inquiry
            if (res == DialogResult.Yes)
            {
            //Data Entry
            frm.usersTableAdapter.InsertUser(txtboxFname.Text,txtboxLname.Text,txtboxUsername.Text,txtboxPassword.Text,Byte.Parse(comboboxType.Text),"Null",Byte.Parse(txtboxage.Text),comboBox2.Text, comboboxGender.Text);
            MessageBox.Show("Saving completed successfully.", "successful",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                //Cancellation of operation
                this.Close();
            }
        }
    }
}
