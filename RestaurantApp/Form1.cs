using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantApp
{
    public partial class Form1 : Form
    {
        public void SidePanelSetup(Button sender)
        {
            SidePanel.Height = sender.Height;
            SidePanel.Top = sender.Top;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SidePanelSetup(homeBtn);
            defaultControl1.BringToFront();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            SidePanelSetup(homeBtn);
            defaultControl1.BringToFront();

        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            SidePanelSetup(menuBtn);
            menuControl1.BringToFront();
        }

        private void restaurBtn_Click(object sender, EventArgs e)
        {
            SidePanelSetup(restaurBtn);
        }

        private void nutBtn_Click(object sender, EventArgs e)
        {
            SidePanelSetup(nutBtn);
        }

        private void accountBtn_Click(object sender, EventArgs e)
        {
            SidePanelSetup(accountBtn);
            loginControl1.BringToFront();
        }

        private void contactBtn_Click(object sender, EventArgs e)
        {
            SidePanelSetup(contactBtn);
        }

        private void ExitpictureBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
