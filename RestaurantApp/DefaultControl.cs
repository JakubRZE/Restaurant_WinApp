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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SignInLabel_Click(object sender, EventArgs e)
        {
            SignInLabel.ForeColor = Color.Red;
        }

        private void SignInLabel_MouseHover(object sender, System.EventArgs e)
        {
            // Update the mouse event label to indicate the MouseHover event occurred.
            SignInLabel.ForeColor = Color.Red;
        }

    }
}
