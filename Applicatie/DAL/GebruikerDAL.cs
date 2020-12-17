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
    class GebruikerDAL
    {
        // Connection String
        string connectionString = ConfigurationManager.ConnectionStrings["Myconnectionstring"].ConnectionString;

        // Methods	:

        // Insert
        public int Create(GebruikerBO gebruikerBO)
        {
            int restult = 0;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                // Cmd object
                SqlCommand cmd = new SqlCommand
                {
                    Connection = con, //De verbinding
                    CommandType = CommandType.Text, // Type 
                    CommandText = "INSERT INTO tblGebruiker values(@gebruikerNaam, @wachtwoord, @gebruikerRol)"
                };

                // vlu parameters
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@gebruikerNaam", gebruikerBO.GebruikerNaam);
                cmd.Parameters.AddWithValue("@wachtwoord", gebruikerBO.Wachtwoord);
                cmd.Parameters.AddWithValue("@gebruikerRol", gebruikerBO.GebruikerRol);
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
        // Check of de gebruiksnaam al bestaat
        public bool BestaatGebruikersgegevens = false;
        public bool GebruikersNaam(GebruikerBO gebruikerBO)
        {

            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(connectionString))
            {

                try
                {
                    // SqlDataReader wanneer
                    SqlDataAdapter da = new SqlDataAdapter();

                    string sql = "SELECT gebruikerNaam FROM tblGebruiker WHERE gebruikerNaam=@gebruikerNaam";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    // creeer een nieuw cmd object


                    //Create Parameters to add value
                    cmd.Parameters.AddWithValue("@gebruikerNaam", gebruikerBO.GebruikerNaam);

                    con.Open();
                    da.SelectCommand = cmd;

                    // vul de DataSet ds
                    da.Fill(dt);
                    int totalRows = dt.Rows.Count;
                    if (totalRows == 1)
                    {
                        
                    }
                    else
                    {
                        BestaatGebruikersgegevens = true;

                    }
                }
                catch
                {
                    //throw
                }
            }
            return BestaatGebruikersgegevens;
        }

        // Check Gebruiksnaam en wachtwoord
        public bool successGebruikersgegevens = false;
        public bool Gebruikersgegevens(GebruikerBO gebruikerBO)
        {
            
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(connectionString))
            {

                try
                {
                    // SqlDataReader wanneer
                    SqlDataAdapter da = new SqlDataAdapter();

                    string sql = "SELECT Count(*) FROM tblGebruiker WHERE gebruikerNaam =@gebruikerNaam AND wachtwoord=@wachtwoord ";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    // creeer een nieuw cmd object


                    //Create Parameters to add value
                    cmd.Parameters.AddWithValue("@gebruikerNaam", gebruikerBO.GebruikerNaam);
                    cmd.Parameters.AddWithValue("@wachtwoord", gebruikerBO.Wachtwoord);


                    con.Open();
                    da.SelectCommand = cmd;

                    // vul de DataSet ds
                    da.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        successGebruikersgegevens = true;
                    }
                    else
                    {

                    }
                }
                catch
                {
                    //throw
                }
            }
            return successGebruikersgegevens;
        }


        // Get ID
        public int ID;
        public int GetID(GebruikerBO gebruikerBO)
        {
           using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {

                    string sql = "SELECT gebruikerIdH201 FROM tblGebruiker WHERE gebruikerNaam=@gebruikerNaam";
                    SqlCommand cmd = new SqlCommand(sql, con);


                    //Create Parameters to add value
                    cmd.Parameters.AddWithValue("@gebruikerNaam", gebruikerBO.GebruikerNaam);
                    con.Open();

                    ID = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                }
                catch
                {
                    //throw
                }
            }
            return ID;
        }

        // Get Rol
        public string Rol;
        public string GetRol(GebruikerBO gebruikerBO)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {

                    string sql = "SELECT gebruikerRol FROM tblGebruiker WHERE gebruikerNaam = @gebruikerNaam";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    // creeer een nieuw cmd object


                    //Create Parameters to add value
                    cmd.Parameters.AddWithValue("@gebruikerNaam", gebruikerBO.GebruikerNaam);
                    con.Open();

                    Rol = cmd.ExecuteScalar().ToString();
                }
                catch
                {
                    //throw
                }
            }
            return Rol;
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
                        CommandText = "SELECT gebruikerIdH201, gebruikerNaam, wachtwoord, gebruikerRol FROM tblGebruiker"
                    };
                    da.SelectCommand = cmd;

                    // vul de DataSet ds
                    da.Fill(ds, "tblGebruiker");
                }
                catch
                {
                    //throw
                }
            }
            return ds;
        }

        // Read vanuit één gebruiker
        public DataSet ReadGebruiker(GebruikerBO gebruikerBO)
        {
            DataSet ds = new DataSet();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    // SqlDataReader wanneer
                    SqlDataAdapter da = new SqlDataAdapter();

                    string sql = "SELECT * FROM tblGebruiker WHERE gebruikerNaam=@gebruikerNaam";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    // creeer een nieuw cmd object


                    //Create Parameters to add value
                    cmd.Parameters.AddWithValue("@gebruikerNaam", gebruikerBO.GebruikerIdH201);
                    con.Open();

                    da.SelectCommand = cmd;

                    // vul de DataSet ds
                    da.Fill(ds, "tblGebruiker");
                }
                catch
                {
                    //throw
                }
            }
            return ds;
        }


        // Update
        public bool Update(GebruikerBO gebruikerBO)
        {
            // Create a default return type and set its default value to false
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                // SQL to update data in my database
                string sql = "UPDATE tblGebruiker SET gebruikerNaam=@gebruikerNaam, wachtwoord=@wachtwoord, gebruikerRol=@gebruikerRol Where gebruikerIdH201=@gebruikerIdH201";
                // Creating SQL Command
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Create Parameters to add value
                cmd.Parameters.AddWithValue("@gebruikerIdH201", gebruikerBO.GebruikerIdH201);
                cmd.Parameters.AddWithValue("@gebruikerNaam", gebruikerBO.GebruikerNaam);
                cmd.Parameters.AddWithValue("@wachtwoord", gebruikerBO.Wachtwoord);
                cmd.Parameters.AddWithValue("@gebruikerRol", gebruikerBO.GebruikerRol);


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
        public bool Delete(GebruikerBO gebruikerBO)
        {
            // Create a default return value and set its value to false
            bool isSuccess = false;
            // Create SQL Connection
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                // SQL to Delete Data
                string sql = "DELETE FROM tblGebruiker WHERE gebruikerIdH201=@gebruikerIdH201";

                // Creating SQL Command 
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@gebruikerIdH201", gebruikerBO.GebruikerIdH201);
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
