using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Traffic_Enforcement_System.Classes;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Traffic_Enforcement_System;

namespace NiceStop
{
    public partial class UserRegistration : UserControl
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "z15DoI4aCcubYQK1g8kNrmyqS8MGvV3u3fiisjRs",
            BasePath = "https://nicestop-b3985.firebaseio.com/"
        };

        IFirebaseClient client;
        public UserRegistration()
        {
            InitializeComponent();
        }

        private async void buttonSubmit_Click(object sender, EventArgs e)
        {
            FirebaseResponse resp = await client.GetTaskAsync("Counter/node");
            Counter get = resp.ResultAs<Counter>();
            String Id = (Convert.ToUInt32(get.cnt) + 1).ToString();
            //Get The Value From Input Field
            /*c.FirstName = metroTextBoxFirstname.Text;
            c.LastName = metroTextBoxLastname.Text;
            c.Address = metroTextBoxAddress.Text;
            c.Gender = metroComboBoxGender.Text;
            c.BirthDate = metroDateTimeBirthDate.Text;
            c.ContactNumber = metroTextBoxContactNo.Text;
            c.UserName = metroTextBoxUsername.Text;
            c.Password = metroTextBoxPassword.Text;*/
            //inserting Data into Database
            var data = new Data
            {

                FirstName = metroTextBoxFirstname.Text,
                LastName = metroTextBoxLastname.Text,
                Address = metroTextBoxAddress.Text,
                Gender = metroComboBoxGender.Text,
                BirthDate = metroDateTimeBirthDate.Text,
                ContactNumber = metroTextBoxContactNo.Text,
                UserName = metroTextBoxUsername.Text,
                Password = metroTextBoxPassword.Text,
            };
            if (metroTextBoxFirstname.Text == "")
            {
                MessageBox.Show("Failed to Register! Firstname is Empty!");
            }
            else if (metroTextBoxLastname.Text == "")
            {
                MessageBox.Show("Failed to Register! LastName is Empty!");
            }
            else if (metroTextBoxAddress.Text == "")
            {
                MessageBox.Show("Failed to Register! Address is Empty!");
            }
            else if (metroComboBoxGender.Text == "")
            {
                MessageBox.Show("Failed to Register! Gender is Empty!");
            }
            else if (metroDateTimeBirthDate.Text == "")
            {
                MessageBox.Show("Failed to Register! BirthDate is Empty!");
            }
            else if (metroTextBoxContactNo.Text == "")
            {
                MessageBox.Show("Failed to Register! ContactNo. is Empty!");
            }
            else if (metroTextBoxUsername.Text == "")
            {
                MessageBox.Show("Failed to Register! UserName is Empty!");
            }
            else if (metroTextBoxPassword.Text == "")
            {
                MessageBox.Show("Failed to Register! Password is Empty!");
            }
            else
            {
                SetResponse response = await client.SetTaskAsync("Admin/" + Id, data);
                Data result = response.ResultAs<Data>();
                var data2 = new Counter
                {
                    cnt = Id
                };
                SetResponse response1 = await client.SetTaskAsync("Counter/node", data2);


                if (metroTextBoxPassword.Text == metroTextBoxRePassword.Text)
                {

                    if (result == result)
                    {
                        MessageBox.Show("Account Successfully Created");
                        if (!Login.Instance.PnlContainer.Controls.ContainsKey("UserLogin"))
                        {
                            UserLogin userLogin = new UserLogin();
                            userLogin.Dock = DockStyle.Fill;
                            Login.Instance.PnlContainer.Controls.Add(userLogin);

                        }
                        Login.Instance.PnlContainer.Controls["UserLogin"].BringToFront();
                        /*this.Hide();
                        Register register = new Register();
                        register.ShowDialog();*/
                    }
                    else
                    {
                        MessageBox.Show("Failed to Create Account. Try Again.");
                    }
                }
                else
                {
                    MessageBox.Show("Confirm Your Password!!!");
                }
            }
        }

        private void UserRegistration_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (!Login.Instance.PnlContainer.Controls.ContainsKey("UserLogin"))
            {
                UserLogin userLogin = new UserLogin();
                userLogin.Dock = DockStyle.Fill;
                Login.Instance.PnlContainer.Controls.Add(userLogin);

            }
            Login.Instance.PnlContainer.Controls["UserLogin"].BringToFront();
            /*this.Hide();
            Register register = new Register();
            register.ShowDialog();*/
        }

        private void metroTextBoxPassword_Click(object sender, EventArgs e)
        {
            metroTextBoxPassword.UseSystemPasswordChar = true;
        }

        private void metroTextBoxRePassword_Click(object sender, EventArgs e)
        {
            metroTextBoxRePassword.UseSystemPasswordChar = true;
        }

        private void pictureBoxLogin_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBoxFirstname_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBoxLastname_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBoxAddress_Click(object sender, EventArgs e)
        {

        }

        private void metroComboBoxGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroTextBox7_Click(object sender, EventArgs e)
        {

        }

        private void metroDateTimeBirthDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void metroTextBox6_Click(object sender, EventArgs e)
        {

        }
    }
}
