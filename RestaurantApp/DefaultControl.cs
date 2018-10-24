using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestaurantApp.Services;

namespace RestaurantApp
{
    public partial class DefaultControl : UserControl
    {
        public UserControl control { get; set; }
        public Panel panel { get; set; }
        public Button button { get; set; }

        public DefaultControl()
        {
            InitializeComponent();
        }

        private void SignInLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SidePanelSetup.Setup(panel, button);
            control.BringToFront();
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

        private void newAccountLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SidePanelSetup.Setup(panel, button);
            control.BringToFront();
        }
    }
}
