using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            // label_gign.Text = "+"
            label_sign.Text = button_plus.Text;
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            label_sign.Text = button_minus.Text;
        }

        private void button_product_Click(object sender, EventArgs e)
        {
            label_sign.Text = button_product.Text;
        }

        private void button_division_Click(object sender, EventArgs e)
        {
            label_sign.Text = button_division.Text;
        }

        private void button_result_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox_a.Text) || textBox_b.Text == string.Empty)
            {
                MessageBox.Show("Empty fields");
                return;
            }

            double result = 0;

            try
            {
                double a = double.Parse(textBox_a.Text);
                double b = double.Parse(textBox_b.Text);

                if (label_sign.Text == "+")
                {
                    result = a + b;
                }
                else if (label_sign.Text == "-")
                {
                    result = a - b;
                }
                else if (label_sign.Text == "*")
                {
                    result = a * b;
                }
                else
                {
                    result = a / b;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Enter only numbers");
            }
            catch (OverflowException)
            {
                MessageBox.Show("Number is too big");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("You can'divide by zero");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                textBox_result.Text = result.ToString();
            }
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Form closing", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void textBox_a_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void textBox_b_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
