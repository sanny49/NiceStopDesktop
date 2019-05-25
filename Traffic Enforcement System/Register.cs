using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Traffic_Enforcement_System.Classes;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
namespace Traffic_Enforcement_System
{
    public partial class Register : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "z15DoI4aCcubYQK1g8kNrmyqS8MGvV3u3fiisjRs",
            BasePath = "https://nicestop-b3985.firebaseio.com/"
        };

        IFirebaseClient client;

        public Register()
        {
            InitializeComponent();
        }
        SystemClass c = new SystemClass();
        private void labelUsername_Click(object sender, EventArgs e)
        {

        }

        private void labelPassword_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void labelAddress_Click(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            else {
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
                        this.Hide();
                        Login login = new Login();
                        login.ShowDialog();
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

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }

        private void dateTimePickerBirthDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void checkBoxPassword_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxConfirmPassword_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void comboBoxGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void metroTextBox5_Click(object sender, EventArgs e)
        {
            metroTextBoxPassword.UseSystemPasswordChar = true;
        }

        private void metroTextBoxRePassword_Click(object sender, EventArgs e)
        {
            metroTextBoxRePassword.UseSystemPasswordChar = true;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void metroTextBoxUsername_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBoxContactNo_Click(object sender, EventArgs e)
        {

        }

        private void metroDateTimeBirthDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void metroTextBox6_Click(object sender, EventArgs e)
        {

        }

        private void metroComboBoxGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroTextBox7_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBoxAddress_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBoxLastname_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBoxFirstname_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
