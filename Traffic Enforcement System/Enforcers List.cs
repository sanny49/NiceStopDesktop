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
namespace Traffic_Enforcement_System
{
    public partial class EnforcersList : Form
    {
        DataTable dt = new DataTable();
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "z15DoI4aCcubYQK1g8kNrmyqS8MGvV3u3fiisjRs",
            BasePath = "https://nicestop-b3985.firebaseio.com/"
        };

        IFirebaseClient client;

        public EnforcersList()
        {
            InitializeComponent();
        }
        SystemClass2 c = new SystemClass2();
        private Button onClick;

        private void FormEnforcersList_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
            dt.Columns.Add("FirstName");
            dt.Columns.Add("LastName");
            dt.Columns.Add("Address");
            dt.Columns.Add("Gender");
            dt.Columns.Add("Birth Date");
            dt.Columns.Add("Contact No");
            dt.Columns.Add("Code");

            dataGridViewEnforcersList.DataSource = dt;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            
        }

        private async void buttonSubmit_Click(object sender, EventArgs e)
        {

            export();
        }
        private async void export() {
            int i = 0;
            dt.Rows.Clear();
            FirebaseResponse response = await client.GetTaskAsync("Counter/count");
            Counter obj1 = response.ResultAs<Counter>();
            int cnt = Convert.ToInt32(obj1.cnt);

            while (true)
            {
                if (i == cnt) {
                    break;
                }
                i++;
                try {
                    FirebaseResponse response1 = await client.GetTaskAsync("Enforcer/"+i);
                    Data obj2 = response1.ResultAs<Data>();

                    DataRow row = dt.NewRow();

                    row["FirstName"] = obj2.FirstName;
                    row["LastName"] = obj2.LastName;
                    row["Address"] = obj2.Address;
                    row["Gender"] = obj2.Gender;
                    row["Birth Date"] = obj2.BirthDate;
                    row["Contact No"] = obj2.ContactNo;
                    row["Code"] = obj2.Code;
                    dt.Rows.Add(row);
                } catch { }

            }


        }

        private async void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            /*FirebaseResponse response = await client.GetTaskAsync("Enforcer");
            Data obj = response.ResultAs<Data>();
            DataRow row = dt.NewRow();
            string keyword = textBoxSearch.Text;
            if (keyword == obj.FirstName|| keyword == obj.LastName || keyword == obj.Address || keyword == obj.Gender ||
                keyword == obj.BirthDate || keyword == obj.ContactNo || keyword == obj.Code) {

                DataTable dt = new DataTable();
               // keyword.Fill(dt);
                dataGridViewEnforcersList.DataSource = dt;
            }*/
            

            /*/MySqlConnection cs = new MySqlConnection("datasource = 127.0.0.1; port = 3306; username = root; password=; database = system_db");
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM enforcer WHERE FirstName LIKE '%"+keyword+"%' OR LastName LIKE '&"+keyword+"&' OR Address LIKE '&"+keyword+"&'", cs);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewEnforcersList.DataSource = dt;/*/

        }

        private void labelSearch_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            EnforcersRegistration enforReg = new EnforcersRegistration();
            enforReg.ShowDialog();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login systemMenu = new Login();
            systemMenu.ShowDialog();
        }

        private void buttonRegister_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            ViolatorsList systemMenu = new ViolatorsList();
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

        private void buttonL_MouseEnter(object sender, EventArgs e)
        {
            buttonL.BackColor = Color.LightGreen;
        }

        private void buttonEL_Click(object sender, EventArgs e)
        {

        }

        private void buttonER_Click(object sender, EventArgs e)
        {
            this.Hide();
            EnforcersRegistration systemMenu = new EnforcersRegistration();
            systemMenu.ShowDialog();
        }

        private void buttonVL_MouseEnter_1(object sender, EventArgs e)
        {
            buttonVL.BackColor = Color.LightGreen;
        }

        private void buttonEL_MouseEnter_1(object sender, EventArgs e)
        {
            buttonEL.BackColor = Color.LightGreen;
        }

        private void buttonER_MouseEnter_1(object sender, EventArgs e)
        {
            buttonER.BackColor = Color.LightGreen;

        }

        private void buttonP_MouseEnter_1(object sender, EventArgs e)
        {
            
        }

        private void buttonL_MouseEnter_1(object sender, EventArgs e)
        {
            buttonL.BackColor = Color.LightGreen;
        }

        private void buttonVL_MouseLeave(object sender, EventArgs e)
        {
            buttonVL.BackColor = Color.DodgerBlue;
        }

        private void buttonEL_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void buttonER_MouseLeave(object sender, EventArgs e)
        {
            buttonER.BackColor = Color.DodgerBlue;
        }

        private void buttonP_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void buttonL_MouseLeave(object sender, EventArgs e)
        {
            buttonL.BackColor = Color.DodgerBlue;
        }

        private void textBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = String.Format("FirstName like '%{0}%'", textBoxSearch.Text);
                dataGridViewEnforcersList.DataSource = dv.ToTable();
            }
        }
    }
}
