using MySql.Data.MySqlClient;
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
using NiceStop;

namespace Traffic_Enforcement_System
{
    public partial class Login : Form
    {
        private static Login _instance;
        public static Login Instance
        {
            get
            {
                if (_instance == null) 
{
                    _instance = new Login();
                }
                   
                return _instance;
            }
        }
        public Panel PnlContainer
        {
            get { return panelLogin; }
            set { panelLogin = value; }
        }

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "z15DoI4aCcubYQK1g8kNrmyqS8MGvV3u3fiisjRs",
            BasePath= "https://nicestop-b3985.firebaseio.com/"
        };

        IFirebaseClient client;
        
        public Login()
        {
            InitializeComponent();
        }
       
        
        private void Form1_Load(object sender, EventArgs e)
        {
            _instance = this;
            UserLogin userLogin = new UserLogin();
            userLogin.Dock = DockStyle.Fill;
            PnlContainer.Controls.Add(userLogin);
            client = new FireSharp.FirebaseClient(config);
         
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void labelPassword_Click(object sender, EventArgs e)
        {

        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.ShowDialog();
        }

        private async void buttonLogin_Click(object sender, EventArgs e)
        {
            
            

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            /*if (checkBoxPassword.Checked)
            {
                metroTextBoxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                metroTextBoxPassword.UseSystemPasswordChar = true;
            }*/
        }

        private void metroTextBoxUserName_Click(object sender, EventArgs e)
        {

        }

        private void metroButtonRegister_Click(object sender, EventArgs e)
        {

        }

        private void textBoxUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void metroTextBoxPassword_Click(object sender, EventArgs e)
        {
            //metroTextBoxPassword.UseSystemPasswordChar = true;
        }

        private void metroTextBoxUsername_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBoxLogin_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBoxUsername_Click_2(object sender, EventArgs e)
        {

        }

        /*private async Task buttonLogin_Click_1Async(object sender, EventArgs e)
        {
           
        }*/

        private void buttonRegister_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.ShowDialog();
        }

        private void buttonLogin_Click_1Async(object sender, EventArgs e)
        {

        }

        private async void buttonLogin_Click_1(object sender, EventArgs e)
        {
           /* if (metroTextBoxUsername.Text == "")
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

                            if (!panelLogin.Controls.Contains(Menu.Instance))
                            {
                                panelLogin.Controls.Add(Menu);
                                Menu.Instance.Dock = DockStyle.Fill;
                                Menu.Instance.BringToFront();
                            }
                            else
                            {
                                Menu.Instance.BringToFront();
                            }



                        }
                    }
                    catch { }



                }
            }*/
        }

        private void checkBoxPassword_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panelLogin_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
