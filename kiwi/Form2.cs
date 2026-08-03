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
    public partial class DashBoredpage : Form
    {
        public DashBoredpage()
        {
            InitializeComponent();
        }
        private void ShowPage(UserControl page)
        {
            panelmain.Controls.Clear();  // پاک کردن صفحه قبلی
            page.Dock = DockStyle.Fill;  // پر کردن کل پنل اصلی
            panelmain.Controls.Add(page); // اضافه کردن صفحه جدید
        }
        private void DashBoredpage_Load(object sender, EventArgs e)
        {
            ShowPage(new Dashboard());
        }

        private void btndashbored_Click(object sender, EventArgs e)
        {
            ShowPage(new Dashboard()); // فراخوانی UserControl داشبورد
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowPage(new Books());
        }

        private void btnusermanegment_Click(object sender, EventArgs e)
        {
            ShowPage(new Users());
        }

        private void btnloan_Click(object sender, EventArgs e)
        {
            ShowPage(new Loans());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowPage(new profile());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Are you sure you want to close the program?", "Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            DialogResult res = MessageBox.Show("Are you sure you want to close the program?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res== DialogResult.Yes)
            {
            Application.Exit();
            }
        }
    }
}
