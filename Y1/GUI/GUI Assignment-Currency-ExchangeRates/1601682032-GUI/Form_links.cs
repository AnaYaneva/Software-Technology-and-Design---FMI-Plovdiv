using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1601682032_GUI
{
    public partial class Form_links : Form
    {
        public Form_links()
        {
            InitializeComponent();
        }

        private void linkLabel_bnb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData as string);
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_links_Load(object sender, EventArgs e)
        {
            LinkLabel.Link link = new LinkLabel.Link();
            link.LinkData = "http://www.bnb.bg/";
            linkLabel_bnb.Links.Add(link);
        }
    }
}
