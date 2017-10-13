using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadWriteFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string filename = "names.txt";
        List<string> names = new List<string>();

        public void FillListBox(List<string> items)
        {
            listBox_users.Items.Clear();
            foreach (string item in items)
            {
                listBox_users.Items.Add(item);
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            using (FileStream stream = new FileStream(filename, FileMode.Append))
            {
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    writer.WriteLine(textBox_firstName.Text.Trim() + "," + textBox_lastName.Text.Trim());
                }
            }
        }

        private void button_view_Click(object sender, EventArgs e)
        {
            names.Clear();

            using (FileStream stream = new FileStream(filename, FileMode.OpenOrCreate))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        string[] data = line.Split(',');

                        string firstName = data[0];
                        string lastName = data[1];

                        names.Add(firstName);
                        names.Add(lastName);
                    }
                }
            }

            FillListBox(names);
        }

        private void listBox_users_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
