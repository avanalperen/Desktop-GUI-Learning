using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Contact.E_ContactClasses
{
    internal class contactClass
    {
        //Getter and Setter properties for Applicaton
        //Acts as Data Carrier in Application
        public int contactID { get; set; }

        public string firstName { get; set; }

        public string lastName { get; set; }

        public string contactNo { get; set; }

        public string address { get; set; }

        public string gender { get; set; }

        static string myConnectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

        //Selecting data from Database
        public DataTable select()
        { 
            
            //Step 1 : Database Connection
            SqlConnection connection = new SqlConnection(myConnectionString);
            DataTable dataTable = new DataTable();
            try
            {
                //Step 2 : Writing SQL Query
                string sql = "SELECT * FROM tableContact";

                //Creating command using sql and connection
                SqlCommand command = new SqlCommand(sql, connection);

                //Creating SQL DataAdapter using cmd 
                SqlDataAdapter adapter = new SqlDataAdapter(command); 
                connection.Open();

                adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);  
            }
            finally
            {
                connection.Close();
            }
            return dataTable;

        }

        //Inserting Data into Database
        public bool insert(contactClass c)
        {
            //Creating a default return type and setting its value to false 
            bool isSuccess = false;

            //Step 1 : Connect Database 
            SqlConnection connection = new SqlConnection(myConnectionString);
            try
            {
                //Step 2 : Create a SQL Query to insert data
                string sql = "INSERT INTO tableContact (firstName, lastName, contactNo, address, gender) VALUES (@firstName, @lastName, @contactNo, @address, @gender)";
                
                //Creating SQL Command using sql and connection
                SqlCommand command = new SqlCommand(sql, connection);

                //Create parameters to add data
                command.Parameters.AddWithValue("@firstName", c.firstName);
                command.Parameters.AddWithValue("@lastName", c.lastName);
                command.Parameters.AddWithValue("@contactNo", c.contactNo);
                command.Parameters.AddWithValue("@address", c.address);
                command.Parameters.AddWithValue("@gender", c.gender);

                //Connection opening 
                connection.Open();
                int rows = command.ExecuteNonQuery();
                //If the query runs successfully then the value of rows will be greater than zero else its value will be 0

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

                MessageBox.Show("Error: " + ex.Message);

            }
            finally
            {
                connection.Close();
            }
            return isSuccess;
        }

        //Method to update data in database from application 
        public bool update(contactClass c)
        {
            //Create a default return type and set its default value to false 
            bool isSuccess = false;

            SqlConnection connection = new SqlConnection(myConnectionString);

            try
            {
                //SQL to update data in database
                string sql = "UPDATE tableContact SET firstName=@firstName, lastName=@lastName, contactNo=@contactNo, address=@address, gender=@gender WHERE contactID=@contactID";

                //Creating SQL Command using sql and connection
                SqlCommand command = new SqlCommand(sql, connection);

                //Create parameters to add data
                command.Parameters.AddWithValue("@firstName", c.firstName);
                command.Parameters.AddWithValue("@lastName", c.lastName);
                command.Parameters.AddWithValue("@contactNo", c.contactNo);
                command.Parameters.AddWithValue("@address", c.address);
                command.Parameters.AddWithValue("@gender", c.gender);
                command.Parameters.AddWithValue("@contactID", c.contactID);

                //Open database connection
                connection.Open();

                int rows = command.ExecuteNonQuery();
                //If the query runs successfully then the value of rows will be greater than zero else its value will be 0

                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
                
            }
            catch(Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);

            }
            finally
            {

            connection.Close(); 
            }

            return isSuccess;
        }

        //Method to delete data from database
        public bool delete(contactClass c)
        {
            //Create a default return value and set its value to false
            bool isSuccess = false;

            //Create sql connection
            SqlConnection connection = new SqlConnection(myConnectionString);
            try
            {
                //SQL delete data
                string sql = "DELETE FROM tableContact WHERE contactID=@contactID";
                
                //Creating SQL command
                SqlCommand command = new SqlCommand(sql,connection);
                command.Parameters.AddWithValue("@contactID", c.contactID);

                //Open connection
                connection.Open();
                int rows = command.ExecuteNonQuery();
                //If the query runs successfully then the value of rows will be greater than zero else its value will be 0
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

                MessageBox.Show("Error: " + ex.Message);

            }
            finally
            {
                //Close connection
                connection.Close();
            }
            return isSuccess;
        }
    }
}
