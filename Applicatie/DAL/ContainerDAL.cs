using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Applicatie
{
    class ContainerDAL
    {
        // Connection String
        string connectionString = ConfigurationManager.ConnectionStrings["Myconnectionstring"].ConnectionString;

        // Methods	:

        // Insert
        public int Create(ContainerBO containerBO)
        {
            int restult = 0;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                // Cmd object
                SqlCommand cmd = new SqlCommand
                {
                    Connection = con, //De verbinding
                    CommandType = CommandType.Text, // Type 
                    CommandText = "INSERT INTO tblContainer values(@containerNaam)"
                };

                // vlu parameters
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@gebruikerNaam", containerBO.ContainerIdH204);
                cmd.Parameters.AddWithValue("@wachtwoord", containerBO.ContainerNaam);
                try
                {
                    con.Open();
                    restult = cmd.ExecuteNonQuery(); //Voer het commando uit op de database

                }
                catch
                {

                }
            }
            return restult;
        }


        // Get achternaam
        string lastname;
        public string ReadLastname(ProductBO productBO)
        {


            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {

                    string sql = "SELECT deelnemerAchternaam FROM Deelnemer WHERE deelnemerID = @deelnemerID";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    // creeer een nieuw cmd object


                    //Create Parameters to add value
                    cmd.Parameters.AddWithValue("@deelnemerID", productBO.SoortIdD203);
                    con.Open();

                    lastname = cmd.ExecuteScalar().ToString();
                }
                catch
                {
                    //throw
                }
            }
            return lastname;
        }


        // Read
        public DataSet Read()
        {
            DataSet ds = new DataSet();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    // SqlDataReader wanneer
                    SqlDataAdapter da = new SqlDataAdapter();


                    // creeer een nieuw cmd object
                    SqlCommand cmd = new SqlCommand()
                    {
                        Connection = con,
                        CommandType = CommandType.Text,
                        CommandText = "SELECT containerIdH204, containerNaam FROM tblContainer"
                    };
                    da.SelectCommand = cmd;

                    // vul de DataSet ds
                    da.Fill(ds, "tblContainer");
                }
                catch
                {
                    //throw
                }
            }
            return ds;
        }


        // Read Containernaam
        public DataSet ReadContainernaam()
        {
            DataSet ds = new DataSet();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    // SqlDataReader wanneer
                    SqlDataAdapter da = new SqlDataAdapter();

                    string sql = "SELECT containerNaam FROM tblContainer";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    // creeer een nieuw cmd object

                    con.Open();

                    da.SelectCommand = cmd;

                    // vul de DataSet ds
                    da.Fill(ds, "tblContainer");
                }
                catch
                {
                    //throw
                }
            }
            return ds;
        }



        // Update
        public bool Update(ContainerBO containerBO)
        {
            // Create a default return type and set its default value to false
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                // SQL to update data in my database
                string sql = "UPDATE tblContainer SET containerNaam=@containerNaam  Where containerIdH204=@containerIdH204";
                // Creating SQL Command
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Create Parameters to add value
                cmd.Parameters.AddWithValue("@containerIdH204", containerBO.ContainerIdH204);
                cmd.Parameters.AddWithValue("@containerNaam", containerBO.ContainerNaam);


                // Open database Connection
                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                // if the query runs sucessfully then the value of rows will be greater than zero else its value will be zero
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        // Verwijderen
        public bool Delete(ContainerBO containerBO)
        {
            // Create a default return value and set its value to false
            bool isSuccess = false;
            // Create SQL Connection
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                // SQL to Delete Data
                string sql = "DELETE FROM tblContainer WHERE containerIdH204=@containerIdH204";

                // Creating SQL Command 
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@containerIdH204", containerBO.ContainerIdH204);
                // Open Connection 
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                // If the query run sucessfully then the value of rows is greater than zero else its value is 0
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch
            {

            }
            finally
            {
                // Close Connection
                conn.Close();
            }
            return isSuccess;

        }
    }
}
