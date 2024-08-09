using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.Sql;
using Microsoft.Data.SqlClient;
using Microsoft.Data.SqlTypes;
using System.Runtime.CompilerServices;

namespace CSharp_Fundamentals.Helper
{
    internal class SqlHelper
    {
        private static string connectionString = "Data source = DESKTOP-O6ON641; Initial Catalog = AdventureWorks2019; " +
                    "User Id = sa; Password = sql; TrustServerCertificate = True";

        public static bool IsConnected()
        {
            bool result = false;
            //logic : result is true if connected to mssql 

            SqlConnection connection = null;
            try {
                //string connectionString = "Data source = DESKTOP-O6ON641; Initial Catalog = AdventureWorks2019; " +
                //    "User Id = sa; Password = sql; TrustServerCertificate = True";
                connection = new SqlConnection(connectionString);
                connection.Open();

                if (connection.State == ConnectionState.Open)
                {
                    result = true;
                } 
            }
            catch(Exception ex) {
                Console.WriteLine(ex.ToString());
            }
            finally {
                connection.Close();
                connection = null;
            }

            return result;
        }

        public static void Insert(string AddressLine1, string AddressLine2, string City, 
            string StateProvinceId, string PostalCode) {

            SqlConnection sqlConnection = null;
            SqlCommand cmd = null;
            int result = 0; 
            try {
                //create a connection 
                sqlConnection = new SqlConnection(connectionString); 
                sqlConnection.Open();

                if (sqlConnection.State == ConnectionState.Open) {
                    //write the insert query
                    string rowGuid = Guid.NewGuid().ToString();
                    string modifiedDate = DateTime.Now.ToString(); 

                    string insertQuery = "INSERT INTO [Person].[Address]([AddressLine1], [AddressLine2], [City], [StateProvinceID], [PostalCode], [rowguid], [ModifiedDate]) " +
                        "VALUES('"+AddressLine1+ "', '"+ AddressLine2 + "', '"+City+ "', '"+ StateProvinceId + "',  '"+PostalCode+ "', '"+rowGuid+ "', '"+modifiedDate+"')";
                    
                    //execute 
                    cmd = new SqlCommand(insertQuery, sqlConnection);
                    
                    //acknowledgement 
                    if (cmd.ExecuteNonQuery() == 1) {
                        result = 1;
                        Console.WriteLine("Successfully Inserted ... ");
                    } 
                }
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message.ToString());
            }
            finally {
                sqlConnection.Close();
                sqlConnection = null;
                cmd = null; 
            }
            
        }
    }
}
