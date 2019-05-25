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
    class SystemClass2
    {
        public String Id { get; set; }

        public String FirstName { get; set; }

        public String LastName { get; set; }

        public String Address { get; set; }

        public String Gender { get; set; }

        public String BirthDate { get; set; }

        public String ContactNo { get; set; }

        public String Code { get; set; }


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
                string sql = "SELECT * FROM enforcer";
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

        public bool Insert(SystemClass2 c)
        {
            //Creatinga default return type and setting its value to false
            bool isSuccess = false;
            MySqlConnection conn = new MySqlConnection(myconnString);
            try
            {
                //Create a SQL Query to insert Data
                string sql = "INSERT INTO enforcer(FirstName, LastName, Address, Gender, BirthDate, ContactNo,Code) VALUES (@FirstName, @LastName, @Address, @Gender, @BirthDate, @ContactNo,@Code)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                //Create Parameters to add data
                cmd.Parameters.AddWithValue("@FirstName", c.FirstName);
                cmd.Parameters.AddWithValue("@LastName", c.LastName);
                cmd.Parameters.AddWithValue("@Address", c.Address);
                cmd.Parameters.AddWithValue("@Gender", c.Gender);
                cmd.Parameters.AddWithValue("@BirthDate", c.BirthDate);
                cmd.Parameters.AddWithValue("@ContactNo", c.ContactNo);
                cmd.Parameters.AddWithValue("@Code", c.Code);
                

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
        public bool Delete(SystemClass2 c)
        {
            //Create a default return value and set it's value to false
            bool isSuccess = false;
            //Sql connection
            MySqlConnection conn = new MySqlConnection(myconnString);

            try
            {
                //Sql to Delete Command
                string sql = "DELETE FROM enforcer WHERE Id=@Id";

                //Sql Command
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", c.Id);

                //Open Connection
                int rows = cmd.ExecuteNonQuery();
                //if the query run sucessfully then the value of rows is greater than 0 else its value is 0
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
