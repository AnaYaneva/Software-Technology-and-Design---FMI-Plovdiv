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

namespace FilesAndForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string filename = "users.txt";
        List<string> users = new List<string>();

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
                    writer.WriteLine(textBox_firstName.Text);
                    writer.WriteLine(textBox_lastName.Text);
                }
            }
        }

        private void button_view_Click(object sender, EventArgs e)
        {
            users.Clear();

            using (FileStream stream = new FileStream(filename, FileMode.OpenOrCreate))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    while (!reader.EndOfStream)
                    {
                        string firstName = reader.ReadLine();
                        string lastName = reader.ReadLine();

                        users.Add(firstName + " - " + lastName);
                    }
                }
            }
                        
            FillListBox(users);
        }
    }
}
