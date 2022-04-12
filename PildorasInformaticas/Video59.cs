namespace PildorasInformaticas
{
    class Video59
    {
        public const string URL = "https://www.youtube.com/watch?v=L-cQG9Ql_ew";
        public const string TITUlO = "Curso C#. Destructores. Vídeo 59";

        public Video59()
        {
            LectorDeArchivos lector_de_archivos = new LectorDeArchivos();
        }
    }

    class LectorDeArchivos
    {
        StreamReader archivo = null;

        int contador = 0;
        string linea;
        public LectorDeArchivos()
        {

            archivo = new StreamReader(@"movies.txt");
            while((linea = archivo.ReadLine()) != null)
            {
                Console.WriteLine(linea);
                contador++;
            }
        }
        public void Mensaje()
        {
            Console.WriteLine("Hay {0} líneas", contador);
        }

        ~LectorDeArchivos()
        {
            archivo.Close();
        }
    }

}