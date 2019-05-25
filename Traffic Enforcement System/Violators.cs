using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
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
using Traffic_Enforcement_System;

namespace NiceStop
{
    public partial class Violators : UserControl
    {
        DataTable dt = new DataTable();
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "z15DoI4aCcubYQK1g8kNrmyqS8MGvV3u3fiisjRs",
            BasePath = "https://nicestop-b3985.firebaseio.com/"
        };
        IFirebaseClient client;
        public Violators()
        {
            InitializeComponent();
        }

        private void Violators_Load(object sender, EventArgs e)
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
            dt.Columns.Add("Price");
            dt.Columns.Add("Location");
            dt.Columns.Add("Enforcer");

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
                    FirebaseResponse response1 = await client.GetTaskAsync("Violator/" + i);
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
                    row["Fine"] = obj2.Price;
                    row["Location"] = obj2.Location;
                    row["Enforcer"] = obj2.Enforcer;
                    dt.Rows.Add(row);
                }
                catch { }

            }


        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = String.Format("To like '%{0}%'", textBoxSearch.Text);
                dataGridViewEnforcersList.DataSource = dv.ToTable();
            }
        }
    }
}
