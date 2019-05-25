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
    public partial class Enforcers : UserControl
    {
        DataTable dt = new DataTable();
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "z15DoI4aCcubYQK1g8kNrmyqS8MGvV3u3fiisjRs",
            BasePath = "https://nicestop-b3985.firebaseio.com/"
        };

        IFirebaseClient client;

        public Enforcers()
        {
            InitializeComponent();
        }

        private void Enforcers_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
            dt.Columns.Add("FirstName");
            dt.Columns.Add("LastName");
            dt.Columns.Add("Address");
            dt.Columns.Add("Gender");
            dt.Columns.Add("Birth Date");
            dt.Columns.Add("Contact No");
            dt.Columns.Add("Code");
            dt.Columns.Add("Password");

            dataGridViewEnforcersList.DataSource = dt;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            export();
        }
        private async void export()
        {
            int i = 0;
            dt.Rows.Clear();
            FirebaseResponse response = await client.GetTaskAsync("Counter/count");
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
                    FirebaseResponse response1 = await client.GetTaskAsync("Enforcer/" + i);
                    Data obj2 = response1.ResultAs<Data>();

                    DataRow row = dt.NewRow();

                    row["FirstName"] = obj2.FirstName;
                    row["LastName"] = obj2.LastName;
                    row["Address"] = obj2.Address;
                    row["Gender"] = obj2.Gender;
                    row["Birth Date"] = obj2.BirthDate;
                    row["Contact No"] = obj2.ContactNo;
                    row["Code"] = obj2.Code;
                    row["Password"] = obj2.Password;
                    dt.Rows.Add(row);
                }
                catch { }

            }


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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewEnforcersList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
