using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace RestaurantApp
{
    public partial class NutritionControl : UserControl
    {
        public NutritionControl()
        {
            InitializeComponent();

            // @"App_data\pdf\nutritionfacts.pdf"

            webBrowser.Navigate("file:///" + Application.StartupPath  + "\\nutritionfacts.pdf");
            webBrowser.Show();

        }

    }
}
