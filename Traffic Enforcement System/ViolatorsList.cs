using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
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

namespace Traffic_Enforcement_System
{
    public partial class ViolatorsList : Form
    {
        DataTable dt = new DataTable();
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "z15DoI4aCcubYQK1g8kNrmyqS8MGvV3u3fiisjRs",
            BasePath = "https://nicestop-b3985.firebaseio.com/"
        };

        IFirebaseClient client;
        public ViolatorsList()
        {
            InitializeComponent();
        }
        SystemClass2 c = new SystemClass2();
        private Button onClick;
        private void buttonEL_Click(object sender, EventArgs e)
        {
            this.Hide();
            EnforcersList systemMenu = new EnforcersList();
            systemMenu.ShowDialog();
        }

        private void buttonER_Click(object sender, EventArgs e)
        {
            this.Hide();
            EnforcersRegistration systemMenu = new EnforcersRegistration();
            systemMenu.ShowDialog();
        }

        private void buttonP_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonL_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login systemMenu = new Login();
            systemMenu.ShowDialog();
        }
        private void ViolatorsList_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
            dt.Columns.Add("TVBNo");
            dt.Columns.Add("Type");
            dt.Columns.Add("Date");
            dt.Columns.Add("Time");
            dt.Columns.Add("To");
            dt.Columns.Add("License No"); 
            dt.Columns.Add("Address");
            dt.Columns.Add("Vehicle Plate No");
            dt.Columns.Add("Vehicle Make");
            dt.Columns.Add("Vehicle Color");
            dt.Columns.Add("Vehicle Owner");
            dt.Columns.Add("Owner Address");
            dt.Columns.Add("Violation");
            

            dataGridViewEnforcersList.DataSource = dt;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            export();
        }
        private async void export()
        {
            int i = 0;
            dt.Rows.Clear();
            FirebaseResponse response = await client.GetTaskAsync("Counter/number");
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
                    FirebaseResponse response1 = await client.GetTaskAsync("Violator/"+i);
                    Violator obj2 = response1.ResultAs<Violator>();

                    DataRow row = dt.NewRow();
                    row["TVBNo"] = obj2.TVBNo;
                    row["Type"] = obj2.type;
                    row["Date"] = obj2.date;
                    row["Time"] = obj2.time;
                    row["To"] = obj2.to;
                    row["License No"] = obj2.licenseNo;
                    row["Address"] = obj2.address1;
                    row["Vehicle Plate No"] = obj2.plateNo;
                    row["Vehicle Make"] = obj2.make;
                    row["Vehicle Color"] = obj2.color;
                    row["Vehicle Owner"] = obj2.owner;
                    row["Owner Address"] = obj2.address1;
                    row["Violation"] = obj2.violation;
                    dt.Rows.Add(row);
                }
                catch { }

            }


        }

        

        private void dataGridViewEnforcersList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

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

        private void buttonP_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void buttonL_MouseEnter(object sender, EventArgs e)
        {
            buttonL.BackColor = Color.LightGreen;
        }

        private void buttonVL_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void buttonEL_MouseLeave(object sender, EventArgs e)
        {
            buttonEL.BackColor = Color.DodgerBlue;
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
            if (e.KeyChar==(char)13) {
                DataView dv = dt.DefaultView;
                dv.RowFilter = String.Format("To like '%{0}%'", textBoxSearch.Text);
                dataGridViewEnforcersList.DataSource = dv.ToTable();
            }
        }
    }
}
