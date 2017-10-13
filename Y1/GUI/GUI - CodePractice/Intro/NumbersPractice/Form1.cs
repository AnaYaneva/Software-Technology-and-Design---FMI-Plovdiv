using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumbersPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<int> numbers = new List<int>();

        public void FillListBox(List<int> items)
        {
            listBox_numbers.Items.Clear();

            foreach (int num in items)
            {
                listBox_numbers.Items.Add(num);
            }
        }

        private void button_generate_Click(object sender, EventArgs e)
        {
            numbers.Clear();

            Random rand = new Random();
            int numbersCount = int.Parse(textBox_count.Text);

            for (int i = 0; i < numbersCount; i++)
            {
                int generatedNumber = rand.Next(1, 21);
                numbers.Add(generatedNumber);
            }

            FillListBox(numbers);
        }

        private void button_sum_Click(object sender, EventArgs e)
        {
            double sum = numbers.Sum();
            textBox_sum.Text = sum.ToString();
        }

        private void button_average_Click(object sender, EventArgs e)
        {
            textBox_average.Text = numbers.Average().ToString();
        }

        private void button_min_Click(object sender, EventArgs e)
        {
            textBox_min.Text = numbers.Min().ToString();
        }

        private void button_max_Click(object sender, EventArgs e)
        {
            textBox_max.Text = numbers.Max().ToString();
        }

        private void button_sort_Click(object sender, EventArgs e)
        {
            numbers.Sort();
            FillListBox(numbers);
        }

        private void button_reverse_Click(object sender, EventArgs e)
        {
            numbers.Reverse();
            FillListBox(numbers);
        }

        private void sumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button_sum_Click(sender, e);
        }

        private void averageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button_average_Click(sender, e);
        }

        private void minToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button_min_Click(sender, e);
        }

        private void maxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button_max_Click(sender, e);
        }

        private void sortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button_sort_Click(sender, e);
        }

        private void reverseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button_reverse_Click(sender, e);
        }

        private void textBox_count_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Form closing...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
