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
            if (regUserNtextBox.Text != "" && regPasstextBox.Text != "")
            {
                if (mail_Validating(mailTextBox))
                {
                    if (regPasstextBox.Text == regConfPassTextBoc.Text)
                    {
                        try
                        {
                            Connect obj = new Connect();
                            obj.con.ConnectionString = obj.connectionString;
                            obj.con.Open();

                            /// DB

                            obj.con.Close();
                            MessageBox.Show("All good in da hood");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error" + ex);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Passwords do not match!");
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect e-mial adress!");
                }
            }
            else
            {
                MessageBox.Show("Invalid user name or password!");
            }
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

                    //DB

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

        private void nametextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        public bool mail_Validating(TextBox tekstbox)
        {
            System.Text.RegularExpressions.Regex mail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            return mail.IsMatch(tekstbox.Text) ? true : false;
         
        }

        private void regUserNtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
    }
}
