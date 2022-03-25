using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies
{
    class DBConnection
    {
        public DBConnection()
        {
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

                builder.DataSource = "localhost";
                builder.UserID = "sa";
                builder.Password = "A1b2C3d4E5";
                builder.InitialCatalog = "master";

                Console.WriteLine("Connecting to Linux SQL Server");

                using(SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();

                    Console.WriteLine("Done."); 

                    String db = "Movies";

                    Console.Write($"Setting up database {db}..."); 

                    String sql = "IF NOT EXISTS (SELECT name FROM master.sys.databases WHERE name = N'" + db + "')";
                    Console.WriteLine(sql);

                    // String sql = "IF (EXISTS (SELECT name FROM master.dbo.databases WHERE ([ " + db + "] = " + db + " OR name = " + db + ")))";
                    using(SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.ExecuteNonQuery();
                        Console.WriteLine($"Database '{db}'");
                    }
                }

            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}