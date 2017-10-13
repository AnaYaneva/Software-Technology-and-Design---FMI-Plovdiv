using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Forms_and_files
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string filename = "users.txt";
        List<string> names = new List<string>();

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
            using (FileStream stream = new FileStream(filename, FileMode.Append)) ;
            {
                using (StreamWriter writer = new StreamWriter(filename, true))
                {
                    writer.WriteLine(textBox_firstName.Text.Trim());
                    writer.WriteLine(textBox_lastName.Text.Trim());
                }
            }
           
          /* StreamWriter writer = new StreamWriter(filename, true) ;//true za da addva, a ne da prezapisva
            {
                writer.WriteLine(textBox_firstName.Text.Trim());
                writer.WriteLine(textBox_lastName.Text.Trim());
            }

            writer.Close();//rychen metod*/


        }

        private void button_viewAll_Click(object sender, EventArgs e)
        {
            names.Clear();

            using (FileStream stream = new FileStream(filename, FileMode.OpenOrCreate))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    while (!reader.EndOfStream)
                    {
                        string firstName = reader.ReadLine();
                        string lastName = reader.ReadLine();

                        names.Add(firstName + " - " + lastName);
                    }
                }
            }

            FillListBox(names);
                
            

            /*names.Clear();

            if (!File.Exists(filename))
            {
                File.Create(filename).Close();
            }

            StreamReader reader= null;

            try
            {
                reader = new StreamReader(filename);

                while (!reader.EndOfStream)
                {
                    string firstName = reader.ReadLine();
                    string lastName = reader.ReadLine();

                    names.Add(firstName + " - " + lastName);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                reader.Close();
            }

            FillListBox(names);*/


        }
    }
}
