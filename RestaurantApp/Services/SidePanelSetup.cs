using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantApp.Services
{
    class SidePanelSetup
    {
        public static void Setup(Panel panel, Button sender)
        {
            panel.Height = sender.Height;
            panel.Top = sender.Top;
        }
    }
}
