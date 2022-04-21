// Curso C#. Excepciones V. Bloque finally. Vídeo 26
namespace PildorasInformaticas
{
    class Video26 {

        public Video26()
        {
            StreamReader archivo = null;

            try
            {
                string linea;

                int contador = 0;

                // string path = @"no_existe.txt";
                string path = @"movies.txt";

                archivo = new StreamReader(path);

                while((linea = archivo.ReadLine()) != null)
                {
                    Console.WriteLine($"{contador}\t{linea}");
                    contador++;
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine("Error en lectura");
            }
            finally
            {
                if(archivo != null) archivo.Close();
                Console.WriteLine("Archivo cerrado...");
            }
        }
    }
}