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
    class SoortDAL
    {
        // Connection String
        string connectionString = ConfigurationManager.ConnectionStrings["Myconnectionstring"].ConnectionString;

        // Methods	:

        // Insert
        public int Create(SoortBO soortBO)
        {
            int restult = 0;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                // Cmd object
                SqlCommand cmd = new SqlCommand
                {
                    Connection = con, //De verbinding
                    CommandType = CommandType.Text, // Type 
                    CommandText = "INSERT INTO tblSoort values(@soortNaam, containerIdD204)"
                };

                // vlu parameters
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@soortNaam", soortBO.SoortNaam);
                cmd.Parameters.AddWithValue("@containerIdD204", soortBO.ContainerIdD204);
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


        // Get SoortID op basis van een soorNaam
        int soortID;
        public int ReadSoortID(SoortBO  soortBO)
        {


            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {

                    string sql = "SELECT soortIdH203 FROM tblSoort WHERE soortNaam=@soortNaam";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    // creeer een nieuw cmd object


                    //Create Parameters to add value
                    cmd.Parameters.AddWithValue("@soortNaam", soortBO.SoortNaam);
                    con.Open();

                    soortID = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                }
                catch
                {
                    //throw
                }
            }
            return soortID;
        }


        // Read
        public DataSet ReadProductenSoorten(SoortBO soortBO)
        {
            DataSet ds = new DataSet();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    // SqlDataReader wanneer
                    SqlDataAdapter da = new SqlDataAdapter();

                    string sql = "SELECT productNaam, soortNaam, containerNaam, gebruikerNaam FROM tblSoort INNER JOIN tblProduct ON tblSoort.soortIdH203 = tblProduct.soortIdD203 INNER JOIN tblGebruiker ON tblGebruiker.gebruikerIdH201 = tblProduct.gebruikerIdD201 INNER JOIN tblContainer ON tblSoort.containerIdD204 = tblContainer.containerIdH204 WHERE soortIdH203 = @soortIdH203";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    // creeer een nieuw cmd object


                    //Create Parameters to add value
                    cmd.Parameters.AddWithValue("@soortIdH203", soortBO.SoortIdH203);
                    con.Open();

                    da.SelectCommand = cmd;

                    // vul de DataSet ds
                    da.Fill(ds, "tblSoort");
                }
                catch
                {
                    //throw
                }
            }
            return ds;
        }

        // Read
        public DataSet Read(SoortBO soortBO)
        {
            DataSet ds = new DataSet();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    // SqlDataReader wanneer
                    SqlDataAdapter da = new SqlDataAdapter();

                    string sql = "SELECT soortNaam, containerIdD204, productNaam, gebruikerNaam FROM tblSoort INNER JOIN tblProduct ON tblSoort.soortIdH203 = tblProduct.soortIdD203 INNER JOIN tblGebruiker ON tblGebruiker.gebruikerIdH201 = tblProduct.gebruikerIdD201 WHERE soortIdH203=@soortIdH203";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    // creeer een nieuw cmd object


                    //Create Parameters to add value
                    cmd.Parameters.AddWithValue("@soortIdH203", soortBO.SoortIdH203);
                    con.Open();

                    da.SelectCommand = cmd;

                    // vul de DataSet ds
                    da.Fill(ds, "tblSoort");
                }
                catch
                {
                    //throw
                }
            }
            return ds;
        }

        // Read soortnaam
        public DataSet ReadSoortNaam()
        {
            DataSet ds = new DataSet();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    // SqlDataReader wanneer
                    SqlDataAdapter da = new SqlDataAdapter();

                    string sql = "SELECT soortNaam FROM tblSoort";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    // creeer een nieuw cmd object

                    con.Open();

                    da.SelectCommand = cmd;

                    // vul de DataSet ds
                    da.Fill(ds, "tblSoort");
                }
                catch
                {
                    //throw
                }
            }
            return ds;
        }




        // Update
        public bool Update(SoortBO  soortBO)
        {
            // Create a default return type and set its default value to false
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                // SQL to update data in my database
                string sql = "UPDATE tblSoort SET soortNaam=@soortNaam, containerIdD204=@containerIdD204  Where soortIdH203=@soortIdH203";
                // Creating SQL Command
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Create Parameters to add value
                cmd.Parameters.AddWithValue("@soortIdH203", soortBO.SoortIdH203);
                cmd.Parameters.AddWithValue("@soortNaam", soortBO.SoortNaam);
                cmd.Parameters.AddWithValue("@containerIdD204", soortBO.ContainerIdD204);

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
        public bool Delete(SoortBO soortBO)
        {
            // Create a default return value and set its value to false
            bool isSuccess = false;
            // Create SQL Connection
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                // SQL to Delete Data
                string sql = "DELETE FROM tblSoort WHERE soortIdH203=@soortIdH203";

                // Creating SQL Command 
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@soortIdH203", soortBO.SoortIdH203);
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
