using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantApp
{
    public partial class ContactControl : UserControl
    {
        public ContactControl()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/JakubRZE");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/jakub-m-rzepka/");
        }

        private void linkLabel1_MouseEnter(object sender, EventArgs e)
        {
            linkLabel1.LinkColor = Color.Gold;
        }

        private void linkLabel1_MouseLeave(object sender, EventArgs e)
        {
            linkLabel1.LinkColor = Color.DarkOliveGreen;
        }

        private void linkLabel2_MouseEnter(object sender, EventArgs e)
        {
            linkLabel2.LinkColor = Color.Gold;
        }

        private void linkLabel2_MouseLeave(object sender, EventArgs e)
        {
            linkLabel2.LinkColor = Color.DarkOliveGreen;
        }
    }
}
