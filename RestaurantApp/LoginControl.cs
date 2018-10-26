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
    public partial class LoginControl : UserControl
    {
        public AccountControl control { get; set; }
        public Panel panel { get; set; }
        public Button button { get; set; }

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


        //REGISTER
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

                            ////
                            obj.cmd = new SqlCommand("SELECT UserName FROM userTable WHERE UserName = @username", obj.con);
                            obj.cmd.Parameters.AddWithValue("@username", regUserNtextBox.Text);
                            obj.con.Open();
                            SqlDataAdapter adapt = new SqlDataAdapter(obj.cmd);
                            DataSet ds = new DataSet();
                            adapt.Fill(ds);
                            int count = ds.Tables[0].Rows.Count;
                            if (count == 0)
                            {
                                string insertUser = "INSERT INTO [dbo].[userTable] VALUES ('" + regUserNtextBox.Text + "', '" + regPasstextBox.Text + "', '" + mailTextBox.Text + "')";
                                obj.cmd.Connection = obj.con;
                                obj.cmd.CommandText = insertUser;
                                obj.cmd.ExecuteNonQuery();
                                obj.con.Close();

                                MessageBox.Show("Registered successfully! Now you can log in.");
                                ShowLoginForm();
                            }
                            else
                            {
                                obj.con.Close();
                                MessageBox.Show("User already exist");
                            }  
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


        // LOGIN
        private void button1_Click(object sender, EventArgs e)
        {
            if (nametextBox.Text != "" && pswtextBox.Text != "")
            {
                try
                {
                    Connect obj = new Connect();
                    obj.con.ConnectionString = obj.connectionString;
                    obj.cmd = new SqlCommand("SELECT * FROM userTable WHERE userName = @username and Password = @password", obj.con);
                    obj.cmd.Parameters.AddWithValue("@username", nametextBox.Text);
                    obj.cmd.Parameters.AddWithValue("@password", pswtextBox.Text);
                    obj.con.Open();
                    SqlDataAdapter adapt = new SqlDataAdapter(obj.cmd);
                    DataSet ds = new DataSet();
                    adapt.Fill(ds);
                    obj.con.Close();
                    int count = ds.Tables[0].Rows.Count;

                    if (count == 1)
                    {
                        UserInfo.userName = nametextBox.Text;
                        control.ChangeUserLabel();
                        control.BringToFront();
                        
                    }
                    else
                    {
                        MessageBox.Show("Invalid user name or password");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
            }
            else
            {
                MessageBox.Show("Enter user name or password");
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
