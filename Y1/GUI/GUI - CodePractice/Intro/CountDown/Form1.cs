using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountDown
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int seconds = 0;

        private void button_start_Click(object sender, EventArgs e)
        {
            seconds = int.Parse(textBox_time.Text);
            label_seconds.Text = seconds.ToString();
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            seconds--;
            label_seconds.Text = seconds.ToString();

            if (seconds == 0)
            {
                timer.Stop();
                label_timesUp.Visible = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label_timesUp.Visible = false;
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            label_timesUp.Visible = false;
            label_seconds.Text = "...";

            //textBox_time.Text = "";
            textBox_time.Clear();
        }

        private void textBox_time_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_start_Click(sender, e);
            }
        }
    }
}
