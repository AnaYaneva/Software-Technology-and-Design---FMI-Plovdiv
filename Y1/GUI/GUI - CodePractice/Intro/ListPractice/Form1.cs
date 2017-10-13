using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox_add.Text.Trim()))
            {
                MessageBox.Show("Enter value");
                return;
            }

            listBox_items.Items.Add(textBox_add.Text.Trim());
            textBox_add.Clear();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            //listBox_items.Items.Remove(listBox_items.SelectedItem);

            // delete item ne by one
            if (listBox_items.SelectedIndex >= 0)
            {
                listBox_items.Items.RemoveAt(listBox_items.SelectedIndex);
            }
        }

        private void button_deleteMultiselect_Click(object sender, EventArgs e)
        {
            // multiselect deleting
            for (int i = listBox_items.SelectedItems.Count - 1; i >= 0; i--)
            {
                listBox_items.Items.Remove(listBox_items.Items[i]);
            }
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if (textBox_update.Text != string.Empty)
            {
                int index = listBox_items.SelectedIndex;
                listBox_items.Items.RemoveAt(index);
                listBox_items.Items.Insert(index, textBox_update.Text);

            }
            else
            {
                MessageBox.Show("Enter some value");
            }

            textBox_update.Clear();
        }

        private void listBox_items_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
