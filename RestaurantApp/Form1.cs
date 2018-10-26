using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestaurantApp.Services;

namespace RestaurantApp
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            defaultControl1.control = loginControl1;
            defaultControl1.panel =SidePanel;
            defaultControl1.button = accountBtn;

            loginControl1.control = welcomeControl1;
            loginControl1.panel = SidePanel;
            loginControl1.button = homeBtn;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SidePanelSetup.Setup(SidePanel,homeBtn);
            defaultControl1.BringToFront();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            SidePanelSetup.Setup(SidePanel, homeBtn);
            if (UserInfo.userName == null || UserInfo.userName == "")
            {
               defaultControl1.BringToFront();
            }
            else
            {
               welcomeControl1.BringToFront();
            }
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            SidePanelSetup.Setup(SidePanel, menuBtn);
            menuControl1.BringToFront();
        }

        private void restaurBtn_Click(object sender, EventArgs e)
        {
            SidePanelSetup.Setup(SidePanel, restaurBtn);
            restaurantControl1.BringToFront();
        }

        private void nutBtn_Click(object sender, EventArgs e)
        {
            SidePanelSetup.Setup(SidePanel, nutBtn);
            nutritionControl1.BringToFront();
        }

        private void accountBtn_Click(object sender, EventArgs e)
        {
            SidePanelSetup.Setup(SidePanel, accountBtn);
            if (UserInfo.userName == null || UserInfo.userName == "")
            {
                loginControl1.ShowLoginForm();
                loginControl1.BringToFront();
            }
            else
            {
                accountControl1.ChangeUserLabel();
                accountControl1.BringToFront();
            }
        }

        private void contactBtn_Click(object sender, EventArgs e)
        {
            SidePanelSetup.Setup(SidePanel, contactBtn);
            contactControl1.BringToFront();
        }

        private void ExitpictureBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
