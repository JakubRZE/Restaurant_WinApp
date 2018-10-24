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
    public partial class LoginControl : UserControl
    {
        public LoginControl()
        {
            InitializeComponent();
        }

        private void noAccountlinkLabel_MouseEnter(object sender, EventArgs e)
        {
            noAccountlinkLabel.LinkColor = Color.DarkOliveGreen;
        }

        private void noAccountlinkLabel_MouseLeave(object sender, EventArgs e)
        {
            noAccountlinkLabel.LinkColor = Color.Olive;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void haveAccountlinkLabel_MouseEnter(object sender, EventArgs e)
        {
            haveAccountlinkLabel.LinkColor = Color.DarkOliveGreen;
        }

        private void haveAccountlinkLabel_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void haveAccountlinkLabel_MouseLeave(object sender, EventArgs e)
        {
            haveAccountlinkLabel.LinkColor = Color.Olive;
        }
    }
}
