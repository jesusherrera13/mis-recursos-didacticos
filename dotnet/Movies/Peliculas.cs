namespace Movies
{
    class Peliculas
    {
        List<Pelicula> peliculas = new List<Pelicula>() {
            new Pelicula() { id = 1, titulo = "Sexto Sentido", anio = 1999 }
        };

        public void impresion()
        {
            foreach(Pelicula pelicula in peliculas)
            {
                // Console.WriteLine($"Id: {pelicula.id}");
                // Console.WriteLine($"   Título: {pelicula.titulo}");
                // Console.WriteLine($"   Año: {pelicula.anio}");
                Console.WriteLine("... " + pelicula.ToString());
            }

            Console.WriteLine();
            Console.WriteLine($"Total de películas: {peliculas.Count()}");
        }

        public void agregar(string titulo, int anio)
        {
            peliculas.Add(new Pelicula() { id = getId(), titulo = titulo, anio = anio });
        }

        public int getId()
        {
            List<int> ids = new List<int>();

            foreach(Pelicula pelicula in peliculas)
            {
                ids.Add(pelicula.id);
            }

            return ids.Max() + 1;
        }
    }
}