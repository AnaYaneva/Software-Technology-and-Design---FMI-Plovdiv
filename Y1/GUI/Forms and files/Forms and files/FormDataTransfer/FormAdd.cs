using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormDataTransfer
{
    public partial class FormAdd : Form
    {
        public FormAdd()
        {
            InitializeComponent();
        }

        public static string fullName = string.Empty;

        private void button_save_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox_firstName.Text.Trim())||String.IsNullOrEmpty(textBox_middleName.Text.Trim())||String.IsNullOrEmpty(textBox_lastName.Text.Trim()))
            {
                MessageBox.Show("All fields required");
                return;
            }
            fullName=string.Format("{0}-{1}-{2}", textBox_firstName.Text.Trim(),textBox_middleName.Text.Trim(),textBox_lastName.Text.Trim());

            this.DialogResult = DialogResult.OK;
        }

        private void FormAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
