using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies
{
    class Program
    {
        static void Main(string[] args)
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
                    String db = "Movies";
                    Console.WriteLine($"Setting up database `{db}`..."); 

                    String sql = "SELECT name FROM master.sys.databases WHERE name = '" + db + "'";
                    using(SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.ExecuteNonQuery();

                        object resultObj = command.ExecuteScalar();

                        if (resultObj == null)
                        {
                            Console.WriteLine($"Database '{db}' does not exists...");

                            sql = "CREATE DATABASE [" + db + "]";

                            using(SqlCommand command1 =  new SqlCommand(sql, connection)) 
                            {
                                command1.ExecuteNonQuery();
                                Console.WriteLine($"\t'{db}' created...");

                            }

                            String table = "Peliculas";

                            sql = @"CREATE TABLE " + db + ".dbo.Peliculas (
                                id int NOT NULL IDENTITY PRIMARY KEY, titulo VARCHAR(100) NOT NULL);";
                            
                            Console.WriteLine(sql);
                            using(SqlCommand command1 =  new SqlCommand(sql, connection)) 
                            {
                                command1.ExecuteNonQuery();
                                Console.WriteLine($"\t'{table}' created...");
                            }
                        }

                        connection.Close();
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            /* Peliculas peliculas = new();

            int op = 0;

            string? titulo;
            int anio = 0;

            do
            {

                Console.WriteLine("MOVIES");
                Console.WriteLine("1. Agregar");
                Console.WriteLine("2. Impresion");
                Console.WriteLine("3. Actualizar");
                Console.WriteLine("4. Eliminar");
                Console.WriteLine("9. Salir");
                Console.Write("Opción: ");

                op = Int32.Parse(Console.ReadLine());

                switch(op)
                {
                    case 1:
                        Console.Write("Titulo: ");
                        titulo = Console.ReadLine();

                        Console.Write("Año: ");
                        anio = Int32.Parse(Console.ReadLine());

                        peliculas.agregar(titulo, anio);

                        break;
                    
                    case 2:
                        peliculas.impresion();
                        break;

                    case 8:
                        peliculas.impresion();
                        break;
                }

            } while(op != 9);

            Console.WriteLine("Hasta la vista... baby"); */

            /* peliculas.impresion();

            peliculas.agregar("Interstellar", 2014);

            peliculas.impresion(); */
        }
    }
}