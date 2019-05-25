using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Traffic_Enforcement_System;

namespace NiceStop
{
    public partial class UserLogin : UserControl
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "z15DoI4aCcubYQK1g8kNrmyqS8MGvV3u3fiisjRs",
            BasePath = "https://nicestop-b3985.firebaseio.com/"
        };

        IFirebaseClient client;
        public UserLogin()
        {
            InitializeComponent();
        }



        private void checkBoxPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPassword.Checked)
            {
                metroTextBoxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                metroTextBoxPassword.UseSystemPasswordChar = true;
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {

            /* 
              if (!Login.Instance.PnlContainer.Controls.ContainsKey("UserRegistration"))
              {
                  UserRegistration userRegistration = new UserRegistration();
                  userRegistration.Dock = DockStyle.Fill;
                  Login.Instance.PnlContainer.Controls.Add(userRegistration);

              }
              Login.Instance.PnlContainer.Controls["UserRegistration"].BringToFront();
              this.Hide();
              Register register = new Register();
              register.ShowDialog();*/

        }

        private void UserLogin_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
        }

        private async void buttonLogin_Click(object sender, EventArgs e)
        {
            if (metroTextBoxUsername.Text == "")
            {
                MessageBox.Show("Failed to Login! UserName is Empty!");
            }
            else if (metroTextBoxPassword.Text == "")
            {
                MessageBox.Show("Failed to Login! Password is Empty!");
            }
            else
            {
                int i = 0;

                FirebaseResponse response = await client.GetTaskAsync("Counter/node");
                Counter obj1 = response.ResultAs<Counter>();
                int cnt = Convert.ToInt32(obj1.cnt);



                while (true)
                {
                    if (i == cnt)
                    {
                        break;
                    }
                    i++;
                    try
                    {
                        FirebaseResponse response1 = await client.GetTaskAsync("Admin/" + i);
                        Data obj2 = response1.ResultAs<Data>();
                        if (metroTextBoxUsername.Text == obj2.UserName && metroTextBoxPassword.Text == obj2.Password)
                        {
                            MessageBox.Show("Login Successfully!");
                            if (!Login.Instance.PnlContainer.Controls.ContainsKey("Menu")) {
                                Menu menu = new Menu();
                                menu.Dock = DockStyle.Fill;
                                Login.Instance.PnlContainer.Controls.Add(menu);
                                     
                            }
                            Login.Instance.PnlContainer.Controls["Menu"].BringToFront();
                            /*this.Hide();
                            Menu menu = new Menu();
                            menu.ShowDialog();*/


                        }
                    }
                    catch { }



                }
            }
        }

        private void metroTextBoxPassword_Click(object sender, EventArgs e)
        {
            metroTextBoxPassword.UseSystemPasswordChar = true;
        }

        private void pictureBoxLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
/*if (metroTextBoxUsername.Text == "")
            {
                MessageBox.Show("Failed to Register! UserName is Empty!");
            }
            else if (metroTextBoxPassword.Text == "")
            {
                MessageBox.Show("Failed to Register! Password is Empty!");
            }
            else
            {
                int i = 0;

FirebaseResponse response = await client.GetTaskAsync("Counter/node");
Counter obj1 = response.ResultAs<Counter>();
int cnt = Convert.ToInt32(obj1.cnt);



                while (true)
                {
                    if (i == cnt)
                    {
                        break;
                    }
                    i++;
                    try
                    {
                        FirebaseResponse response1 = await client.GetTaskAsync("Admin/" + i);
Data obj2 = response1.ResultAs<Data>();
                        if (metroTextBoxUsername.Text == obj2.UserName && metroTextBoxPassword.Text == obj2.Password)
                        {
                            MessageBox.Show("Login Successfully!");
                            this.Hide();
                            Menu menu = new Menu();
                            menu.ShowDialog();


                        }
                    }
                    catch { }



                }
            }*/