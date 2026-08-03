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
    public partial class Dashboard : UserControl
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // نمایش ساعت زنده
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");

            // نمایش تاریخ میلادی/شمسی
            lblDate.Text = DateTime.Now.ToShortDateString();
        }
    }
}
