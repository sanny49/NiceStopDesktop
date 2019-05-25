using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Traffic_Enforcement_System;

namespace NiceStop
{
    public partial class Menu : UserControl
    {
        private static Menu _instance;
        public static Menu Instance{
            get {
                if (_instance == null)
                    _instance = new Menu();
                return _instance;
            }
        }
        public Panel pnlContainer
        {
            get { return panel2; }
            set { panel2 = value; }
        }

        public Menu()
        {
            InitializeComponent();
        }

        private void enforcers1_Load(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {


        }

        private void Menu_Load(object sender, EventArgs e)
        {
            violators1.Show();
            violators1.BringToFront();
            enforcerRegistration1.Hide();
            enforcers1.Hide();
        }

        private void buttonVL_Click(object sender, EventArgs e)
        {
            buttonVL.BackColor = Color.LightGreen;
            violators1.Show();
            violators1.BringToFront();
            enforcerRegistration1.Hide();
            enforcers1.Hide();

        }

        private void buttonEL_Click(object sender, EventArgs e)
        {
            buttonEL.BackColor = Color.LightGreen;
            enforcers1.Show();
            enforcers1.BringToFront();
            enforcerRegistration1.Hide();
            violators1.Hide();
        }

        private void buttonER_Click(object sender, EventArgs e)
        {
            buttonER.BackColor = Color.LightGreen;
            enforcerRegistration1.Show();
            enforcerRegistration1.BringToFront();
            violators1.Hide();
            enforcers1.Hide();
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

        private void buttonL_MouseEnter(object sender, EventArgs e)
        {
            buttonL.BackColor = Color.LightGreen;
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
            buttonER.BackColor = Color.DodgerBlue;
        }

        private void buttonL_MouseLeave(object sender, EventArgs e)
        {
            buttonL.BackColor = Color.DodgerBlue;
        }

        private void buttonL_Click(object sender, EventArgs e)
        {
            buttonL.BackColor = Color.LightGreen;
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

        private void enforcers1_Load_1(object sender, EventArgs e)
        {

        }

        private void violators1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
