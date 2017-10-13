using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlideShow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool isStopped = true;

        private void button_slide_Click(object sender, EventArgs e)
        {
            //if (button_slide.Text == "Start slide show")
            //{
            //    timer.Start();
            //    button_slide.Text = "Stop slide show";
            //}
            //else
            //{
            //    timer.Stop();
            //    button_slide.Text = "Start slide show";
            //}
            
            if (isStopped)
            {
                timer.Start();
                isStopped = false;
                button_slide.Text = "Stop slide show";
            }
            else
            {
                timer.Stop();
                isStopped = true;
                button_slide.Text = "Start slide show";
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            int number = rand.Next(0, 10);

            switch (number)
            {
                case 0:
                case 4:
                case 7:
                    pictureBox.Image = Properties.Resources.Jellyfish;
                    break;
                case 1:
                case 3:
                case 9:
                    pictureBox.Image = Properties.Resources.Penguins;
                    break;
                default:
                    pictureBox.Image = Properties.Resources.Koala;
                    break;
            }
        }
    }
}
