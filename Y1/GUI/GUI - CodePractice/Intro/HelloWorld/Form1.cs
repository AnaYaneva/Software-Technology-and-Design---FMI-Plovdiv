using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_hello_Click(object sender, EventArgs e)
        {
            string name = textBox_name.Text;
            MessageBox.Show("Hello, " + textBox_name.Text);
        }

        private void button_getDate_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            MessageBox.Show(date.ToString(), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
