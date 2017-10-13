using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace _1601682032_GUI
{
    public partial class Form_edit : Form
    {
        public Form_edit()
        {
            InitializeComponent();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_edit_Load(object sender, EventArgs e)
        {
            textBox_exchangeRate.Text = Vars.selectedData.exchangeRate.ToString();
            //dateTimePicker_edit.Text = Vars.selectedData.date.ToString();
            label_Currency.Text = Vars.selectedData.currency;
            label_date.Text = "Дата - "+Vars.selectedData.date.ToString("dd.MM.yyyy");
            label_.Text = Vars.selectedData.currency + " / BGN";
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            try
            {
                Vars.selectedData.exchangeRate = double.Parse(textBox_exchangeRate.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Въведете валидни данни", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_exchangeRate.Text = "";
                return;
            }

            textBox_exchangeRate.Text = "";
            Methods.MessageSaved();

            this.DialogResult = DialogResult.OK;
        }

    }
}
