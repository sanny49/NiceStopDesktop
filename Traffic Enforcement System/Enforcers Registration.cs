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
    public partial class EnforcersRegistration : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "z15DoI4aCcubYQK1g8kNrmyqS8MGvV3u3fiisjRs",
            BasePath = "https://nicestop-b3985.firebaseio.com/"
        };

        IFirebaseClient client;
        public EnforcersRegistration()
        {
            InitializeComponent();
        }
        //SystemClass2 c = new SystemClass2();

        private void buttonBack_Click(object sender, EventArgs e)
        {
            
        }

        private async void buttonSubmit_Click(object sender, EventArgs e)
        {
            FirebaseResponse resp = await client.GetTaskAsync("Counter/count");
            Counter get = resp.ResultAs<Counter>();
            String Id = (Convert.ToUInt32(get.cnt) + 1).ToString();
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
        };
            if (metroTextBoxFirstname.Text == "") {
                MessageBox.Show("Failed to Register! Firstname is Empty!");
            }
            else if (metroTextBoxLastname.Text == "" )
            {
                MessageBox.Show("Failed to Register! LastName is Empty!");
            }
            else if (metroTextBoxAddress.Text == "")
            {
                MessageBox.Show("Failed to Register! Address is Empty!");
            }
            else if (metroComboBoxGender.Text == "" )
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
            else if (metroTextBoxCode.Text == "")
            {
                MessageBox.Show("Failed to Register! Code is Empty!");
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
                    this.Hide();
                    EnforcersList enforcerslist = new EnforcersList();
                    enforcerslist.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Failed to Create Account. Try Again.");
                }
            }
            
           /* if (success == true)
            {
                MessageBox.Show("Enforcer's Account Successfully Created");
                this.Hide();
                EnforcersList enforcerslist = new EnforcersList();
                enforcerslist.ShowDialog();

            }
            else
            {
                MessageBox.Show("Failed to Create Account. Try Again.");
            }*/
            
        }

        private void textBoxBirthDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerBirthDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void EnforcersRegistration_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
        }

        private void textBoxCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            EnforcersList enforcerslist = new EnforcersList();
            enforcerslist.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            ViolatorsList systemMenu = new ViolatorsList();
            systemMenu.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            EnforcersList systemMenu = new EnforcersList();
            systemMenu.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login systemMenu = new Login();
            systemMenu.ShowDialog();
        }

        private void buttonVL_MouseEnter(object sender, EventArgs e)
        {
            buttonVL.BackColor = Color.LightGreen;
            
        }

        private void buttonEL_MouseEnter(object sender, EventArgs e)
        {
            buttonEL.BackColor = Color.LightGreen;
        }

        private void buttonER_MouseEnter(object sender, EventArgs e)
        {
            buttonER.BackColor = Color.LightGreen;
        }

        private void buttonP_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void buttonP_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void buttonR_MouseEnter(object sender, EventArgs e)
        {
            buttonR.BackColor = Color.LightGreen;
        }

        private void buttonVL_MouseLeave(object sender, EventArgs e)
        {
            buttonVL.BackColor = Color.DodgerBlue;
        }

        private void buttonEL_MouseLeave(object sender, EventArgs e)
        {
            buttonEL.BackColor = Color.DodgerBlue;
        }

        private void buttonER_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void buttonP_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void buttonR_MouseLeave(object sender, EventArgs e)
        {
            buttonR.BackColor = Color.DodgerBlue;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
