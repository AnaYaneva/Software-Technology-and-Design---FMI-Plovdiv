using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace _1601682032_GUI
{
    public partial class Form_addCurrency : Form
    {
        public Form_addCurrency()
        {
            InitializeComponent();

        }
        string selected = "";

        private void Form_addCurrency_Load(object sender, EventArgs e)//
        {
            foreach (var item in Vars.currencyList)
            {
                listBox_currency.Items.Add(item);
            }
        }

        private void button_add_Click(object sender, EventArgs e)//
        {
            if (String.IsNullOrEmpty(textBox_add.Text.Trim()))
            {
                MessageBox.Show("Въведете валута","",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            bool isAllLetters = true;

            textBox_add.Text.Trim().ToCharArray().ToList()
            .ForEach(ch =>
            {
                if (!char.IsLetter(ch))
                    isAllLetters = false;
            });

            if (!isAllLetters)
            {
                MessageBox.Show("Въведеният текст не е име на валута.\nВъведете само букви!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            listBox_currency.Items.Add(textBox_add.Text.Trim().ToUpper());
          
            textBox_add.Clear();
            
        }

        private void textBox_add_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_add_Click(sender, e);
            }
        }

        private void button_delete_Click(object sender, EventArgs e)//
        {
            
            if (listBox_currency.SelectedIndex>=0&& listBox_currency.SelectedIndex >= 0)
            {
                DialogResult result = MessageBox.Show("Изтриване на валутата и всички записи, свързани с нея?", "Изтриване...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    return;
                }
                else if (result == DialogResult.Yes)
                {
                    selected = listBox_currency.SelectedItem.ToString();
                    listBox_currency.Items.RemoveAt(listBox_currency.SelectedIndex);
                }
               
            }
        }

        private void button_saveC_Click(object sender, EventArgs e)
        {
            Vars.currencyList.Clear();
            foreach (var item in listBox_currency.Items)
            {
                Vars.currencyList.Add(item.ToString());
            }

            using (FileStream stream = new FileStream(Vars.fileNameCurrecyList, FileMode.Truncate))//
            {

            }

            using (FileStream stream = new FileStream(Vars.fileNameCurrecyList, FileMode.Append))//
            {
                using (StreamWriter writer = new StreamWriter(stream))//
                {
                    foreach (var item in Vars.currencyList)
                    {
                        writer.WriteLine(item);
                    }
                }
            }
            Vars.data = Vars.data.Where(d => !d.currency.Equals(selected)).ToList();
            Methods.SaveData();

            Methods.MessageSaved();

            this.DialogResult = DialogResult.OK;
        }

        private void button_cancel_Click(object sender, EventArgs e)//
        {
            this.Close();
        }

       //private void Form_addCurrency_FormClosing(object sender, FormClosingEventArgs e)
       //{
       //    DialogResult result = MessageBox.Show("Are you sure?", "Form closing...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
       //
       //    if (result == DialogResult.No)
       //    {
       //        e.Cancel = true;
       //    }
       //}

        private void listBox_currency_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                button_delete_Click(sender, e);
            }
        }

       //private void изтрийВалутатаToolStripMenuItem_Click(object sender, EventArgs e)
       //{
       //    button_delete_Click(sender, e);
       //}

    }
}
