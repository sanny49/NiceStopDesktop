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
    public partial class EnforcerRegistration : UserControl
    {
        int i = 0;
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "z15DoI4aCcubYQK1g8kNrmyqS8MGvV3u3fiisjRs",
            BasePath = "https://nicestop-b3985.firebaseio.com/"
        };

        IFirebaseClient client;
        public EnforcerRegistration()
        {
            InitializeComponent();
        }

        private void EnforcerRegistration_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
            
            while (i == 0)
            {
                i++;


            }
        }

       

        private async Task button1_ClickAsync(object sender, EventArgs e)
        {
            
        }

        private async void button1_Click(object sender, EventArgs e)
        {
           
           
            
            FirebaseResponse resp = await client.GetTaskAsync("Counter/count");
            Counter get = resp.ResultAs<Counter>();
            String Id = (Convert.ToUInt32(get.cnt) + 1).ToString();
            metroTextBoxCode.Text = "2019" + Id;
            /*/Get The Value From Input Field
            c.FirstName = metroTextBoxFirstname.Text;
            c.LastName = metroTextBoxLastname.Text;
            c.Address = metroTextBoxAddress.Text;
            c.Gender = metroComboBoxGender.Text;
            c.BirthDate = metroDateTimeBirthDate.Text;
            c.ContactNo = metroTextBoxContactNo.Text;
            c.Code = metroTextBoxCode.Text;
            inserting Data into Database/*/
            var data = new Data
            {
               
            FirstName = metroTextBoxFirstname.Text,
                LastName = metroTextBoxLastname.Text,
                Address = metroTextBoxAddress.Text,
                Gender = metroComboBoxGender.Text,
                BirthDate = metroDateTimeBirthDate.Text,
                ContactNo = metroTextBoxContactNo.Text,
                Code = metroTextBoxCode.Text,
                Password = metroTextBoxPassword.Text,
            };
            if (metroTextBoxFirstname.Text == "")
            {
                MessageBox.Show("Failed to Register! Firstname is Empty!");
                i--;
            }
            else if (metroTextBoxLastname.Text == "")
            {
                MessageBox.Show("Failed to Register! LastName is Empty!");
                i--;
            }
            else if (metroTextBoxAddress.Text == "")
            {
                MessageBox.Show("Failed to Register! Address is Empty!");
                i--;
            }
            else if (metroComboBoxGender.Text == "")
            {
                MessageBox.Show("Failed to Register! Gender is Empty!");
                i--;
            }
            else if (metroDateTimeBirthDate.Text == "")
            {
                MessageBox.Show("Failed to Register! BirthDate is Empty!");
                i--;
            }
            else if (metroTextBoxContactNo.Text == "")
            {
                MessageBox.Show("Failed to Register! ContactNo. is Empty!");
                i--;
            }
            else if (metroTextBoxCode.Text == "")
            {
                MessageBox.Show("Failed to Register! Code is Empty!");
                i--;
            }
            else if (metroTextBoxPassword.Text == "")
            {
                MessageBox.Show("Failed to Register! Password is Empty!");
                i--;
            }
            else
            {
                SetResponse response = await client.SetTaskAsync("Enforcer/" + Id, data);
                Data result = response.ResultAs<Data>();
                var data2 = new Counter
                {
                    cnt = Id
                };
                SetResponse response1 = await client.SetTaskAsync("Counter/count", data2);
                if (result == result)
                {
                    MessageBox.Show("Enforcer's Account Successfully Created");
                   
                }
                else
                {
                    MessageBox.Show("Failed to Create Account. Try Again.");
                }
            }
        }

        private void metroTextBoxCode_Click(object sender, EventArgs e)
        {
            metroTextBoxCode.Text = "2019" + 0;
        }

        private void metroDateTimeBirthDate_ValueChanged(object sender, EventArgs e)
        {
            if (metroDateTimeBirthDate.Value > DateTime.Now) {
                MessageBox.Show("Invalid Date!");
                metroDateTimeBirthDate.Value = DateTime.Now;
            }
        }

        private void metroTextBoxPassword_Click(object sender, EventArgs e)
        {
            metroTextBoxPassword.UseSystemPasswordChar = true;
        }
    }
}
