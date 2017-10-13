using System;
using System.Linq;
using System.Windows.Forms;

namespace _1601682032_GUI
{
    public partial class Form_enter_details : Form
    {
        public Form_enter_details()
        {
            InitializeComponent();
        }

        private void Form_enter_Load(object sender, EventArgs e)
        {
            label_.Text = Vars.curentData.currency + " / BGN";
            dateTimePicker1.Text = Vars.curentData.date.ToString();
        }

        private void button_saveToFile_Click(object sender, EventArgs e)
        {
            try
            {
                Vars.curentData.exchangeRate = double.Parse(textBox_exchangeRate.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Въведете валидни данни", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_exchangeRate.Text = "";
                return;
            }

            bool isEntryExisting = true;
            bool replace = false;
            Data dublicate = new Data("", new DateTime(), 0);

            foreach (var item in Vars.data.Where(d => d.currency.Equals(Vars.curentData.currency)))
            {
                if (item.date.ToString("dd/MM/yyyy").Equals(Vars.curentData.date.ToString("dd/MM/yyyy")))
                {
                    DialogResult result = MessageBox.Show("Презаписване на съществуващ запис?", "Запис...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.No)
                    {
                        return;
                    }
                    else if (result == DialogResult.Yes)
                    {
                        dublicate = item;
                        replace = true;
                        isEntryExisting = false;
                    }
                }
                else
                {
                    isEntryExisting = false;
                }
            }

            if (replace)
            {
                Vars.data.Remove(dublicate);
            }

            if (Vars.data.Where(d => d.currency.Equals(Vars.curentData.currency)).ToList().Count() == 0)
            {
                isEntryExisting = false;
            }

            if ((!isEntryExisting) && (Vars.curentData.exchangeRate != 0))
            {
                Vars.data.Add(Vars.curentData);
            }

            textBox_exchangeRate.Text = "";
            Methods.MessageSaved();
            this.DialogResult = DialogResult.OK;
        }

        private void button_details_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void textBox_exchangeRate_TextChanged(object sender, EventArgs e)
        {
            button_saveToFile.Enabled = true;
        }

        private void textBox_exchangeRate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_saveToFile_Click(sender, e);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Vars.curentData.date = dateTimePicker1.Value;
        }

    }
}
