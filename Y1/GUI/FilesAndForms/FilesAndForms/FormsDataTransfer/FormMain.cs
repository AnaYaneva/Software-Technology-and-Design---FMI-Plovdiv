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

namespace FormsDataTransfer
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
            if(formAdd.ShowDialog() == DialogResult.OK)
            {
                listBox_names.Items.Add(FormAdd.fullName);
            }

        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            string item = listBox_names.SelectedItem.ToString();
            int index = listBox_names.SelectedIndex;

            FormEdit formEdit = new FormEdit(item);
            if (formEdit.ShowDialog() == DialogResult.OK)
            {
                listBox_names.Items.RemoveAt(index);
                listBox_names.Items.Insert(index, formEdit.Name);
            }
        }

        private void button_saveFile_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Text files | *txt | Doc file | *doc";
            saveFileDialog.DefaultExt = ".txt";
            saveFileDialog.Title = "Saving...";
            
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFileDialog.FileName; // exact file path

                using (FileStream stream = new FileStream(filename, FileMode.Append))
                {
                    using (StreamWriter writer = new StreamWriter(stream))
                    {
                        foreach (var item in listBox_names.Items)
                        {
                            writer.WriteLine(item);
                        }
                    }
                }
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

                using (FileStream stream = new FileStream(path, FileMode.OpenOrCreate))
                {
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        while (!reader.EndOfStream)
                        {
                            string line = reader.ReadLine();
                            listBox_names.Items.Add(line);
                        }
                    }
                }
            }
        }

        private void button_color_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog.Color;
            }
            
        }

        private void button_font_Click(object sender, EventArgs e)
        {
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                this.Font = fontDialog.Font;
            }
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
