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
    }
}
