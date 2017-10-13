using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Options
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            if (radioButton_informatics.Checked)
            {
                MessageBox.Show(radioButton_informatics.Text);
            }
            else if (radioButton_science.Checked)
            {
                MessageBox.Show(radioButton_science.Text);
            }
            else
            {
                MessageBox.Show(radioButton_math.Text);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Option form";
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;

            groupBox_city.Enabled = true;
        }

        private void button_submitCheckboxes_Click(object sender, EventArgs e)
        {
            if (checkBox_sofia.Checked && checkBox_plovdiv.Checked)
            {
                MessageBox.Show(checkBox_sofia.Text + ", " + checkBox_plovdiv.Text);
            }
            else if (checkBox_sofia.Checked)
            {
                MessageBox.Show(checkBox_sofia.Text);
            }
            else if (checkBox_plovdiv.Checked)
            {
                MessageBox.Show(checkBox_plovdiv.Text);
            }            
            else
            {
                MessageBox.Show("Nothing selected");
            }
        }
    }
}
