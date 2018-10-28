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
using System.Data.SqlClient;

namespace RestaurantApp
{
    public partial class AccountControl : UserControl
    {

        public AccountControl()
        {
            InitializeComponent();
        }

        public void ChangeUserLabel()
        {
            userLabel.Text = UserInfo.userName;
            userMailLabel.Text = UserInfo.userMail;
        }

        public void hideChangePanel()
        {
            pswGroupBox.Visible = false;
            mailGroupBox.Visible = false;
        }

        private void changeMailLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mailGroupBox.Visible = true;
        }

        private void changePswLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pswGroupBox.Visible = true;
        }

        //CHANGE PSW
        private void changePswBtn_Click(object sender, EventArgs e)
        {
            if (oldPswtextBox.Text != "")
            {
                if (newPswtextBox.Text != "" && newPswtextBox.Text == confNewPswtextBox.Text)
                {
                    Connect obj = new Connect();
                    obj.con.ConnectionString = obj.connectionString;
                    obj.cmd = new SqlCommand("SELECT UserName FROM userTable WHERE UserName = @username AND Password =@oldpsw", obj.con);
                    obj.cmd.Parameters.AddWithValue("@username", UserInfo.userName);
                    obj.cmd.Parameters.AddWithValue("@oldpsw", oldPswtextBox.Text);
                    obj.con.Open();
                    SqlDataAdapter adapt = new SqlDataAdapter(obj.cmd);
                    DataSet ds = new DataSet();
                    adapt.Fill(ds);
                    int count = ds.Tables[0].Rows.Count;
                    obj.con.Close();

                    if (count == 1)
                    {
                        obj.cmd = new SqlCommand("UPDATE userTable SET Password =@newPsw WHERE UserName =@userName", obj.con);
                        obj.cmd.Parameters.AddWithValue("@newPsw", newPswtextBox.Text);
                        obj.cmd.Parameters.AddWithValue("@userName", UserInfo.userName);
                        try
                        {
                            obj.con.Open();
                            obj.cmd.ExecuteNonQuery();
                            obj.con.Close();
                            ChangeUserLabel();
                            hideChangePanel();
                            MessageBox.Show("Your password has been changed successfully!");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Wrong password!");
                    }
                }
                else
                {
                    MessageBox.Show("Passwords do not match!");
                }
            }
            else
            {
                MessageBox.Show("Enter old password");
            }

            oldPswtextBox.Text = "";
        }

        //CHANGE MAIL
        private void changeEmialBtn_Click(object sender, EventArgs e)
        {

            if (Validation.emailValidating(newEmailtextBox))
            {
                if (newEmailtextBox.Text == repNewEmialtextBox.Text)
                {
                    Connect obj = new Connect();
                    obj.con.ConnectionString = obj.connectionString;
                    obj.cmd = new SqlCommand("UPDATE userTable SET Mail =@newEmial WHERE UserName =@userName", obj.con);
                    obj.cmd.Parameters.AddWithValue("@newEmial", newEmailtextBox.Text);
                    obj.cmd.Parameters.AddWithValue("@userName", UserInfo.userName);
                    try
                    {
                        obj.con.Open();
                        obj.cmd.ExecuteNonQuery();
                        obj.con.Close();
                        hideChangePanel();
                        UserInfo.userMail = newEmailtextBox.Text;
                        ChangeUserLabel();
                        MessageBox.Show("Your adress email has been changed successfully!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Emails do not match!");
                }
            }
            else
            {
                MessageBox.Show("Invalid email adress");
            }

        }

        private void exitPswPictureBox_Click(object sender, EventArgs e)
        {
            pswGroupBox.Visible = false;

        }

        private void exitMailPictureBox_Click(object sender, EventArgs e)
        {
            mailGroupBox.Visible = false;
        }
    }
}
