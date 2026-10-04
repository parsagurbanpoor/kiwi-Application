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

            MessageBox.Show(today);
        }
    }
}
