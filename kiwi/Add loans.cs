using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace kiwi
{
    public partial class Add_loans : Form
    {
        public Add_loans()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveloanbtn_Click(object sender, EventArgs e)
        {
            
        }
        private void Add_loans_Load(object sender, EventArgs e)
        {
            //Get Persian calender
            PersianCalendar pc = new PersianCalendar();
            
            //obj crunnet Date
            DateTime now = DateTime.Now;

            string today = pc.GetYear(now).ToString("0000") + "/" + pc.GetMonth(now).ToString("00") + "/" + pc.GetDayOfMonth(now).ToString("00");

            //Displaying the Jalali date to the user
            lblcurrentdate.Text = today;
            label1.Text = today;

            //Show first element
            comboboxdayforloans.SelectedIndex = 0;


            Users frm = new Users();

            frm.usersTableAdapter.GetUsersForLoan();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Display live clock to the user
            lblcurrenttime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void comboboxdayforloans_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get Persian calender
            PersianCalendar pc = new PersianCalendar();

            //The amount of the day selected by the user
            int day = int.Parse(comboboxdayforloans.Text);

            //Calculating the date selected by the user after the current system date and time
            DateTime nextDate = DateTime.Now.AddDays(day);


            //Display Date format 
            string renewalDate = pc.GetYear(nextDate).ToString("0000") + "/" + pc.GetMonth(nextDate).ToString("00") + "/" + pc.GetDayOfMonth(nextDate).ToString("00");

            //Display time to the user
            label2.Text = renewalDate;
        }
    }
}
