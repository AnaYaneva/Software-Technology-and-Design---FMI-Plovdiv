using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsDataTransfer
{
    public partial class FormAdd : Form
    {
        public FormAdd()
        {
            InitializeComponent();
        }

        // 1. static variable
        public static string fullName = string.Empty;

        private void button_save_Click(object sender, EventArgs e)
        {
            string firstName = textBox_firstname.Text;
            string lastName = textBox_lastname.Text;

            fullName = firstName + "-" + lastName;

            this.DialogResult = DialogResult.OK;
        }
    }
}
