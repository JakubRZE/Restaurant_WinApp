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
    public partial class LoginControl : UserControl
    {
        public LoginControl()
        {
            InitializeComponent();
        }

        public void ShowLoginForm()
        {
            noAccountlinkLabel.Visible = true;
            registergroupBox.Visible = false;

            loginBox.Visible = true;
            haveAccountlinkLabel.Visible = false;
        }

        public void ShowRegisterForm()
        {
            noAccountlinkLabel.Visible = false;
            registergroupBox.Visible = true;

            loginBox.Visible = false;
            haveAccountlinkLabel.Visible = true;
        }

        private void noAccountlinkLabel_MouseEnter(object sender, EventArgs e)
        {
            noAccountlinkLabel.LinkColor = Color.DarkOliveGreen;
        }

        private void noAccountlinkLabel_MouseLeave(object sender, EventArgs e)
        {
            noAccountlinkLabel.LinkColor = Color.Olive;
        }

        private void haveAccountlinkLabel_MouseEnter(object sender, EventArgs e)
        {
            haveAccountlinkLabel.LinkColor = Color.DarkOliveGreen;
        }

        private void haveAccountlinkLabel_MouseLeave(object sender, EventArgs e)
        {
            haveAccountlinkLabel.LinkColor = Color.Olive;
        }

        private void haveAccountlinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowLoginForm();
        }

        private void noAccountlinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowRegisterForm();
        }

        private void regSubButton_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nametextBox.Text != "" && pswtextBox.Text != "")
            {
                try
                {
                    Connect obj = new Connect();
                    obj.con.ConnectionString = obj.connectionString;
                    obj.con.Open();

                    obj.con.Close();
                    MessageBox.Show("All good in da hood");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
            }
            else
            {
                MessageBox.Show("Invalid user name or password");
            }
        }
    }
}
