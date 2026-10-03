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

            usersTableAdapter.FillBy(kiwidbDataSet2.Users);
        }
        
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            addusers frm = new addusers();

            frm.ShowDialog();
            usersTableAdapter.FillBy(kiwidbDataSet2.Users);
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            edit_user frm = new edit_user();
            //fname
            frm.txtboxEditFname.Text = dgvUsers.CurrentRow.Cells["firstnameDataGridViewTextBoxColumn"].Value.ToString();
            //lname
            frm.txtboxEditLname.Text = dgvUsers.CurrentRow.Cells["lastnameDataGridViewTextBoxColumn"].Value.ToString();
            //username
            frm.txtboxEditUsername.Text = dgvUsers.CurrentRow.Cells["usernameDataGridViewTextBoxColumn"].Value.ToString();
            //Password
            frm.txtboxEditPassword.Text = dgvUsers.CurrentRow.Cells["passwordDataGridViewTextBoxColumn"].Value.ToString();
            //type
            frm.comboboxEditType.Text = dgvUsers.CurrentRow.Cells["typeDataGridViewTextBoxColumn"].Value.ToString();
            //age
            frm.txtboxEditage.Text = dgvUsers.CurrentRow.Cells["ageDataGridViewTextBoxColumn"].Value.ToString();
            //edu
            frm.comboBox2Edit.Text = dgvUsers.CurrentRow.Cells["educationDataGridViewTextBoxColumn"].Value.ToString();
            //gender
            frm.comboboxEditGender.Text = dgvUsers.CurrentRow.Cells["GenderDataGridViewTextBoxColumn"].Value.ToString();

            frm.ShowDialog();

            frm.Hide();
        }
    }
}
