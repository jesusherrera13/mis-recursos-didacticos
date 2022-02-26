namespace Movies
{
    class Program
    {
        static void Main(string[] args)
        {
            Peliculas peliculas = new();

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

            Console.WriteLine("Hasta la vista... baby");

            /* peliculas.impresion();

            peliculas.agregar("Interstellar", 2014);

            peliculas.impresion(); */
        }
    }
}