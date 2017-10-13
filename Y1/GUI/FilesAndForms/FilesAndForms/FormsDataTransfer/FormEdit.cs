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
    public partial class FormEdit : Form
    {
        private string name = string.Empty;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public FormEdit()
        {
            InitializeComponent();
        }

        // 2. through the form constructor
        public FormEdit(string updatedItem)
        {
            InitializeComponent();
            name = updatedItem;
        }



        private void button_save_Click(object sender, EventArgs e)
        {
            Name = textBox_firstname.Text + "-" + textBox_lastname.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void FormEdit_Load(object sender, EventArgs e)
        {
            string[] data = name.Split('-');

            textBox_firstname.Text = data[0];
            textBox_lastname.Text = data[1];
        }
    }
}
