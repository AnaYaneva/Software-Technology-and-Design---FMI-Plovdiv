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
    public partial class FormEdit : Form
    {
        private string updatedItem = string.Empty;

        public string UpdatedItem
        { get
            {
                return updatedItem;
            }
            set
            {
                updatedItem = value;
            }
        }

        public FormEdit()
        {
            InitializeComponent();
        }

        public FormEdit(string name)
        {
            InitializeComponent();
            updatedItem = name;
        }

        private void FormEdit_Load(object sender, EventArgs e)
        {
            string[] data = updatedItem.Split('-');
            textBox_firstName.Text = data[0];
            textBox_middleName.Text = data[1];
            textBox_lastName.Text = data[2];
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            UpdatedItem = string.Format("{0}-{1}-{2}", textBox_firstName.Text.Trim(), textBox_middleName.Text.Trim(), textBox_lastName.Text.Trim());
            this.DialogResult = DialogResult.OK;

        }
    }
}
