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

namespace FormDataTransfer
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            FormAdd formAdd = new FormAdd();
            if (formAdd.ShowDialog()==DialogResult.OK)
            {
                listBox_names.Items.Add(FormAdd.fullName);
            }
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            string item = listBox_names.SelectedItem.ToString();
            int index = listBox_names.SelectedIndex;

            FormEdit formEdit = new FormEdit(item);

            if (formEdit.ShowDialog()==DialogResult.OK)
            {
                listBox_names.Items.RemoveAt(index);
                listBox_names.Items.Insert(index,formEdit.UpdatedItem);
            }

            
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button_safeFile_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text files (*.txt) |*.txt";
            saveFileDialog1.Title = "Saving...";
            saveFileDialog1.DefaultExt = ".txt";

            
            if(saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                string filename = saveFileDialog1.FileName;

                using (FileStream stream = new FileStream(filename, FileMode.Append))
                {
                    using (StreamWriter writer=new StreamWriter(stream))
                    {
                        foreach (var item in listBox_names.Items)
                        {
                            writer.WriteLine(item);
                        }
                    }
                }

                MessageBox.Show("Successffuly saved");
            }
        }

        private void button_openFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text files (*.txt) |*.txt";
            openFileDialog1.Title = "Opening...";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;// imeto i pytq do nego
                string name = openFileDialog1.SafeFileName;//samo imeto

                using (FileStream stream = new FileStream(path, FileMode.OpenOrCreate))
                {
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        while (!reader.EndOfStream)
                        {
                            listBox_names.Items.Add(reader.ReadLine());
                        }
                    }
                }

                MessageBox.Show("Successffuly saved");
            }
        }

        private void button_font_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog()==DialogResult.OK)
            {
                this.Font = fontDialog1.Font;
            }
        }

        private void button_color_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                button_add.BackColor = colorDialog1.Color;
                this.BackColor = colorDialog1.Color;
            }

        }
    }
    }

