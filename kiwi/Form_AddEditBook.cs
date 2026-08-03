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
    public partial class Form_AddEditBook : Form
    {
        public Form_AddEditBook()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png";
            open.ShowDialog();
            pictureBox.ImageLocation = open.FileName;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
