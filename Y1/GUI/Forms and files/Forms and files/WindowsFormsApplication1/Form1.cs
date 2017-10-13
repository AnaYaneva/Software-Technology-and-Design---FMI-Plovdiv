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

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string filename = "names.txt";
        List<string> names=new List<string>();

        public void FillListBox(List<string> items)
        {
            listBox1.Items.Clear();

            foreach (var item in items)
            {
                listBox1.Items.Add(item);
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            using (FileStream stream = new FileStream(filename, FileMode.Append))
            {
                using (StreamWriter writer=new StreamWriter(stream))
                {
                    writer.WriteLine(textBox_firstName.Text.Trim() + "," + textBox_lastName.Text.Trim());
                }
            }
        }

        private void button_viewAll_Click(object sender, EventArgs e)
        {
            names.Clear();

            using (FileStream stream=new FileStream(filename, FileMode.OpenOrCreate))
            {
                using (StreamReader reader=new StreamReader(stream))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        string[] data = line.Split(',');

                        string firstName=data[0];
                        string lastName = data[1];

                        names.Add(firstName + " - " + lastName);

                    }
                }
            }

            FillListBox(names);
        }
    }
}
