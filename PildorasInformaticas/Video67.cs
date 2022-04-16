namespace PildorasInformaticas
{
    class Video67
    {
        public static string URL = "https://www.youtube.com/watch?v=NBZN0Ktv6AU";
        public static string TITUlO = "Curso C#. Delegados predicados y lambdas I. Vídeo 67";
        delegate void ObjetoDelegado(string texto);

        public Video67()
        {
            ObjetoDelegado delegado = new ObjetoDelegado(ClaseOrigen.SaludoBienvenida);
            delegado("Hola Mundo");

            delegado = new ObjetoDelegado(ClaseDestino.SaludoDespedida);
            delegado("Hasta la vista...");
        }
    }


    class ClaseOrigen
    {
        public static void SaludoBienvenida(string texto)
        {
            Console.WriteLine(texto);
        }
    }

    class ClaseDestino
    {
        public static void SaludoDespedida(string texto)
        {
            Console.WriteLine(texto);
        }
    }
}