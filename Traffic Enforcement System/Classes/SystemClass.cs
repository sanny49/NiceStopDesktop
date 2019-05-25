using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Traffic_Enforcement_System.Classes
{
    class SystemClass
    {
        public String FirstName { get; set; }

        public String LastName { get; set; }

        public String Address { get; set; }

        public String Gender { get; set; }

        public String BirthDate { get; set; }

        public String ContactNumber { get; set; }

        public String UserName { get; set; }

        public String Password { get; set; }

        //static String myconnString = ConfigurationManager.ConnectionStrings
         //  ["connstring"].ConnectionString;
         static string myconnString = "datasource = 127.0.0.1; port = 3306; username = root; password=; database = system_db";
         //Selecting Data From Database

        public DataTable Select()
        {
            //Database Connection
            MySqlConnection conn = new MySqlConnection(myconnString);
            DataTable dt = new DataTable();
            try
            {
                //writing sql Query
                string sql = "SELECT * FROM admin";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        //Inserting Data into Database

        public bool Insert(SystemClass c)
        {
            //Creatinga default return type and setting its value to false
            bool isSuccess = false;
            MySqlConnection conn = new MySqlConnection(myconnString);
            try
            {
                //Create a SQL Query to insert Data
                string sql = "INSERT INTO admin(Admin_FirstName, Admin_LastName, Admin_Address, Admin_Gender, Admin_BirthDate, Admin_ContactNumber,Admin_UserName, Admin_Password) VALUES (@Admin_FirstName, @Admin_LastName, @Admin_Address, @Admin_Gender, @Admin_BirthDate, @Admin_ContactNumber,@Admin_UserName, @Admin_Password)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                //Create Parameters to add data
                cmd.Parameters.AddWithValue("@Admin_FirstName", c.FirstName);
                cmd.Parameters.AddWithValue("@Admin_LastName", c.LastName);
                cmd.Parameters.AddWithValue("@Admin_Address", c.Address);
                cmd.Parameters.AddWithValue("@Admin_Gender", c.Gender);
                cmd.Parameters.AddWithValue("@Admin_BirthDate", c.BirthDate);
                cmd.Parameters.AddWithValue("@Admin_ContactNumber", c.ContactNumber);
                cmd.Parameters.AddWithValue("@Admin_UserName", c.UserName);
                cmd.Parameters.AddWithValue("@Admin_Password", c.Password);

                //Connection Open
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                //if the query runs succesfully thn the value of the rows will greater than zero else its value will be Zero
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
    }
}
