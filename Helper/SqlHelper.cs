using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.Sql;
using Microsoft.Data.SqlClient;
using Microsoft.Data.SqlTypes;

namespace CSharp_Fundamentals.Helper
{
    internal class SqlHelper
    {
        public static bool IsConnected()
        {
            bool result = false;
            //logic : result is true if connected to mssql 

            SqlConnection connection = null;
            try {
                string connectionString = "Data source = DESKTOP-O6ON641; Initial Catalog = AdventureWorks2019; User Id = sa; Password = sql; TrustServerCertificate = True";
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
    }
}
