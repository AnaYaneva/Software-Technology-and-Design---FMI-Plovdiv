using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace _1601682032_GUI
{
    public partial class Form_main : Form
    {
        public Form_main()
        {
            InitializeComponent();
        }

        public void FillComboBox(List<string> items)//
        {
            comboBox_currency.Items.Clear();
            items.Sort();
            foreach (var item in items)
            {
                comboBox_currency.Items.Add(item);
            }
        }

        private void Reader()
        {
            Vars.currencyList.Clear();

            using (FileStream stream = new FileStream(Vars.fileNameCurrecyList, FileMode.OpenOrCreate))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    while (!reader.EndOfStream)
                    {
                        Vars.currencyList.Add(reader.ReadLine());
                    }
                }
            }

            FillComboBox(Vars.currencyList);
        }

        private void Form_main_Load(object sender, EventArgs e)//
        {
            Reader();
            Vars.curentData.date = dateTimePicker_main.Value;

            Methods.ReadData();
        }

        private void button_addC_Click(object sender, EventArgs e)
        {
            Form_addCurrency formAdd = new Form_addCurrency();


            if (formAdd.ShowDialog() == DialogResult.OK)
            {
                Reader();
            }
        }

        private void button_enter_Click(object sender, EventArgs e)
        {
            Form_enter formEnter = new Form_enter();
            formEnter.ShowDialog();
        }

        private void button_details_Click(object sender, EventArgs e)
        {
            Form_details formDetails = new Form_details();
            formDetails.ShowDialog();
            
        }
        
        public void comboBox_currency_SelectedIndexChanged(object sender, EventArgs e)
        {
            Vars.curentData.currency =comboBox_currency.GetItemText(comboBox_currency.SelectedItem);
            button_enter.Enabled = true;
            button_details.Enabled = true;
        }

        private void dateTimePicker_main_ValueChanged(object sender, EventArgs e)
        {
            Vars.curentData.date = dateTimePicker_main.Value;     
        }

        private void button_openFile_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.Title = "Opening";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog.FileName;
                //string name = openFileDialog.SafeFileName;

                Methods.ReadData(path);
            }
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       private void Form_main_FormClosing(object sender, FormClosingEventArgs e)
       {
           DialogResult result = MessageBox.Show("Are you sure?", "Form closing...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
       
           if (result == DialogResult.No)
           {
               e.Cancel = true;
           }
       }

        private void добавиизтрийВалутаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button_addCurr_Click(sender, e);
        }

        private void относноАвтораToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_aboutAuthor formAbout = new Form_aboutAuthor();
            formAbout.ShowDialog();
        }

        private void полезниЛинковеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_links formlinks = new Form_links();
            formlinks.ShowDialog();
        }

        private void въведиКурсЗаДеняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button_enter_Click( sender,  e);
        }

        private void покажиДетайлиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button_details_Click(sender, e);
        }

        private void въведиОтФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button_openFile_Click( sender,  e);
        }

        private void comboBox_currency_Click(object sender, EventArgs e)
        {
            comboBox_currency.DroppedDown = true;
        }

        private void button_addCurr_Click(object sender, EventArgs e)
        {
            Form_addCurrency formAdd = new Form_addCurrency();


            if (formAdd.ShowDialog() == DialogResult.OK)
            {
                Reader();
            }
        }
    }
}
