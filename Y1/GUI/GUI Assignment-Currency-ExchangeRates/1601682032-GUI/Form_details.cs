using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace _1601682032_GUI
{
    public partial class Form_details : Form
    {
        public Form_details()
        {
            InitializeComponent();
        }

        public void FillListExchRates()
        {
            listBox_exchangeRates.Items.Clear();

            foreach (var item in Vars.data
                                        .Where(d=>d.currency.Equals(Vars.curentData.currency)))
            {
                listBox_exchangeRates.Items.Add($"{item.date.ToString("dd/MM/yyyy")} - {item.exchangeRate:N3}");
            }
        }

        public void FillDataList()
        {
            List<Data> temp = Vars.data
                .Where(d => d.currency != Vars.curentData.currency)
                .ToList();
            Vars.data.Clear();

            foreach (var item in listBox_exchangeRates.Items)
            {
                string[] tokens = item.ToString().Split('-');
                string currency = Vars.curentData.currency;
                DateTime date = DateTime.Parse(tokens[0]);
                double exRate = double.Parse(tokens[1]);

                Vars.data.Add(new Data(currency, date, exRate));
            }
            Vars.data.AddRange(temp);
        }

        private void Form_details_Load(object sender, EventArgs e)
        {
            label_currencyEnter.Text = Vars.curentData.currency;
            FillListExchRates();
        }

        private void button_edit_Click(object sender, EventArgs e)
        {

            if (listBox_exchangeRates.SelectedIndex >= 0 && listBox_exchangeRates.SelectedIndex >= 0)
            {
                Vars.selectedData.currency = Vars.curentData.currency;

                string[] tokens = listBox_exchangeRates
                                                      .SelectedItem
                                                      .ToString()
                                                      .Split('-');
                Vars.selectedData.date = DateTime.Parse(tokens[0]);
                Vars.selectedData.exchangeRate = double.Parse(tokens[1]);

                

                Form_edit formEdit = new Form_edit();
                if (formEdit.ShowDialog() == DialogResult.OK)
                {
                    listBox_exchangeRates.Items.RemoveAt(listBox_exchangeRates.SelectedIndex);
                    listBox_exchangeRates.Items.Add($"{Vars.selectedData.date.ToString("dd/MM/yyyy")} - {Vars.selectedData.exchangeRate:N3}");
                    FillDataList();
                }
               
            }
            else
            {
                MessageBox.Show("Моля изберете данни за промяна!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button_mainPage_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_sort_Click(object sender, EventArgs e)
        {
            if (radioButton_exRate.Checked)
            {
                if (radioButton_ascending.Checked)
                {
                    Vars.data = Vars.data
                                    .OrderBy(d => d.exchangeRate)
                                    .ThenBy(d=>d.date)
                                    .ToList();
                }
                if (radioButton_descending.Checked)
                {
                    Vars.data = Vars.data
                                    .OrderByDescending(d => d.exchangeRate)
                                    .ThenByDescending(d => d.date)
                                    .ToList();
                }
            }
            if (radioButton_date.Checked)
            {
                if (radioButton_ascending.Checked)
                {
                    Vars.data = Vars.data
                                    .OrderBy(d => d.date)
                                    .ToList();
                }
                if (radioButton_descending.Checked)
                {
                    Vars.data = Vars.data
                                    .OrderByDescending(d => d.date)
                                    .ToList();
                }
            }
            FillListExchRates();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (listBox_exchangeRates.SelectedIndex >= 0 && listBox_exchangeRates.SelectedIndex >= 0)
               {
                listBox_exchangeRates.Items.RemoveAt(listBox_exchangeRates.SelectedIndex);
               }
            else
            {
                MessageBox.Show("Моля изберете данни за промяна!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            FillDataList();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            FillDataList();
            Methods.SaveData();

            Methods.MessageSaved();
        }

        private void button_saveToFile_Click(object sender, EventArgs e)
        {
           saveFileDialog.Filter = "Text files | *txt | Doc file | *doc";
           saveFileDialog.DefaultExt = ".txt";
           saveFileDialog.Title = "Saving...";
           
           if (saveFileDialog.ShowDialog() == DialogResult.OK)
           {
               string filename = saveFileDialog.FileName; // exact file path

                Methods.SaveData(filename);

           }
        }

        private void button_openFile_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.Title = "Opening";
            
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog.FileName;
                string name = openFileDialog.SafeFileName;

                Methods.ReadData(path);
            }
            FillListExchRates();
        }

        private void Form_details_FormClosing(object sender, FormClosingEventArgs e)
        {
           // DialogResult result = MessageBox.Show("Are you sure?", "Form closing...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
           //
           // if (result == DialogResult.No)
           // {
           //     e.Cancel = true;
           // }
        }

        private void listBox_exchangeRates_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                button_delete_Click(sender, e);
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            Form_enter_details formEnter = new Form_enter_details();
            
            if (formEnter.ShowDialog() == DialogResult.OK)
            {
                FillListExchRates();
            }
        }

        private void добавиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button_add_Click(sender, e);
        }

        private void промениToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button_edit_Click(sender, e);
        }

        private void изтрийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button_delete_Click(sender, e);
        }

        private void запишиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button_save_Click(sender, e);
        }

        private void запишиВъвФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button_saveToFile_Click(sender, e);
        }

        private void отвориФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button_openFile_Click(sender, e);
        }

    }
}
