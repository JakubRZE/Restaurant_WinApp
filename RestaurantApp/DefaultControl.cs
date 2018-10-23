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
    public partial class DefaultControl : UserControl
    {
        public DefaultControl()
        {
            InitializeComponent();
        }

        private void SignInLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Form1.loginControl1.BringToFront();
        }

        private void SignInLink_MouseEnter(object sender, EventArgs e)
        {
            SignInLink.LinkColor = Color.Olive;
        }

        private void SignInLink_MouseLeave(object sender, EventArgs e)
        {
            SignInLink.LinkColor = Color.Gold;
        }

        private void newAccountLabel_MouseEnter(object sender, EventArgs e)
        {
            newAccountLabel.LinkColor = Color.Olive;
        }

        private void newAccountLabel_MouseLeave(object sender, EventArgs e)
        {
            newAccountLabel.LinkColor = Color.Gold;
        }

    }
}
