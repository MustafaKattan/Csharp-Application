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
    class ProductDAL
    {
        // Connection String
        string connectionString = ConfigurationManager.ConnectionStrings["Myconnectionstring"].ConnectionString;

        // Methods	:
    
        // Insert
        public int Create(ProductBO productBO)
        {
            int restult = 0;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                // Cmd object
                SqlCommand cmd = new SqlCommand
                {
                    Connection = con, //De verbinding
                    CommandType = CommandType.Text, // Type 
                    CommandText = "INSERT INTO tblProduct values(@productNaam, @soortIdD203, @gebruikerIdD201, @productBarcode)"
                };

                // vlu parameters
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@productNaam", productBO.ProductNaam);
                cmd.Parameters.AddWithValue("@soortIdD203", productBO.SoortIdD203);
                cmd.Parameters.AddWithValue("@gebruikerIdD201", productBO.GebruikerIdD201);
                cmd.Parameters.AddWithValue("@productBarcode", productBO.ProductBarcode);
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


        // Get Product
        int productID;
        public int ReadproductID(ProductBO productBO)
        {


            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {

                    string sql = "SELECT productIdH202 FROM tblProduct WHERE productBarcode=@productBarcode";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    // creeer een nieuw cmd object


                    //Create Parameters to add value
                    cmd.Parameters.AddWithValue("@productBarcode", productBO.ProductBarcode);
                    con.Open();

                    Int32.TryParse(cmd.ExecuteScalar().ToString(), out int productID);
                }
                catch
                {
                    //throw
                }
            }
            return productID;
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
                        CommandText = "SELECT ProductNaam, soortNaam, containerNaam, productBarcode, gebruikerNaam FROM tblProduct JOIN tblSoort ON tblProduct.soortIdD203 = tblSoort.soortIdH203 JOIN tblContainer ON tblSoort.containerIdD204 = tblContainer.containerIdH204 JOIN tblGebruiker ON tblGebruiker.gebruikerIdH201 = tblProduct.gebruikerIdD201",
                    };
                    da.SelectCommand = cmd;

                    // vul de DataSet ds
                    da.Fill(ds, "tblProduct");
                }
                catch
                {
                    //throw
                }
            }
            return ds;
        }





        // Read
        public DataTable ReadProducten()
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    // SqlDataReader wanneer
                    SqlDataAdapter da = new SqlDataAdapter();

                    string sql = "SELECT productIdH202, ProductNaam, soortNaam, containerNaam, productBarcode, gebruikerNaam FROM tblProduct JOIN tblSoort ON tblProduct.soortIdD203 = tblSoort.soortIdH203 JOIN tblContainer ON tblSoort.containerIdD204 = tblContainer.containerIdH204 JOIN tblGebruiker ON tblGebruiker.gebruikerIdH201 = tblProduct.gebruikerIdD201";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    // creeer een nieuw cmd object

                    con.Open();

                    da.SelectCommand = cmd;

                    da.Fill(dt);

                }
                catch
                {
                    //throw
                }
            }
            return dt;
        }

        // Check of de Product al bestaat
        public bool BestaatProduct = false;
        public bool ProductBarcode(ProductBO productBO)
        {

            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(connectionString))
            {

                try
                {
                    // SqlDataReader wanneer
                    SqlDataAdapter da = new SqlDataAdapter();

                    string sql = "SELECT productBarcode FROM tblProduct WHERE productBarcode=@productBarcode;";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    // creeer een nieuw cmd object


                    //Create Parameters to add value
                    cmd.Parameters.AddWithValue("@productBarcode", productBO.ProductBarcode);

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
                        BestaatProduct = true;

                    }
                }
                catch
                {
                    //throw
                }
            }
            return BestaatProduct;
        }

        // Read eigen product
        public DataSet ReadEigeneProduct(ProductBO productBO)
        {
            DataSet ds = new DataSet();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    // SqlDataReader wanneer
                    SqlDataAdapter da = new SqlDataAdapter();

                    string sql = "SELECT productIdH202, ProductNaam, soortNaam, containerNaam, productBarcode FROM tblProduct JOIN tblSoort ON tblProduct.soortIdD203 = tblSoort.soortIdH203 JOIN tblContainer ON tblSoort.containerIdD204 = tblContainer.containerIdH204 WHERE gebruikerIdD201 = @gebruikerIdD201;";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    // creeer een nieuw cmd object


                    //Create Parameters to add value
                    cmd.Parameters.AddWithValue("@gebruikerIdD201", productBO.GebruikerIdD201);
                    con.Open();

                    da.SelectCommand = cmd;

                    // vul de DataSet ds
                    da.Fill(ds, "tblProduct");
                }
                catch
                {
                    //throw
                }
            }
            return ds;
        }

        // Read één product
        public DataTable ReadOneProduct(ProductBO productBO)
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    // SqlDataReader wanneer
                    SqlDataAdapter da = new SqlDataAdapter();

                    string sql = "SELECT productIdH202, ProductNaam, soortNaam, containerNaam, productBarcode, gebruikerNaam FROM tblProduct JOIN tblSoort ON tblProduct.soortIdD203 = tblSoort.soortIdH203 JOIN tblContainer ON tblSoort.containerIdD204 = tblContainer.containerIdH204 JOIN tblGebruiker ON tblGebruiker.gebruikerIdH201 = tblProduct.gebruikerIdD201  WHERE productBarcode = @productBarcode;";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    // creeer een nieuw cmd object


                    //Create Parameters to add value
                    cmd.Parameters.AddWithValue("@productBarcode", productBO.ProductBarcode);
                    con.Open();

                    da.SelectCommand = cmd;

                    // vul de DataSet ds
                    da.Fill(dt);
                }
                catch
                {
                    //throw
                }
            }
            return dt;
        }

        // Update
        public bool Update(ProductBO productBO)
        {
            // Create a default return type and set its default value to false
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                // SQL to update data in my database
                string sql = "UPDATE tblProduct SET productNaam=@productNaam, soortIdD203=@soortIdD203, gebruikerIdD201=@gebruikerIdD201, productBarcode=@productBarcode Where productIdH202=@productIdH202";
                // Creating SQL Command
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Create Parameters to add value
                cmd.Parameters.AddWithValue("@productIdH202", productBO.ProductIdH202);
                cmd.Parameters.AddWithValue("@productNaam", productBO.ProductNaam);
                cmd.Parameters.AddWithValue("@soortIdD203", productBO.SoortIdD203);
                cmd.Parameters.AddWithValue("@gebruikerIdD201", productBO.GebruikerIdD201);
                cmd.Parameters.AddWithValue("@productBarcode", productBO.ProductBarcode);


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
        public bool Delete(ProductBO productBO)
        {
            // Create a default return value and set its value to false
            bool isSuccess = false;
            // Create SQL Connection
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                // SQL to Delete Data
                string sql = "DELETE FROM tblProduct WHERE productIdH202=@productIdH202";

                // Creating SQL Command 
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@productIdH202", productBO.ProductIdH202);
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
