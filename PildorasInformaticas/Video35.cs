
namespace PildorasInformaticas
{
    class Video35 {
        public const string URL = "https://www.youtube.com/watch?v=7JfBhGDmrws";
        public const string TITULO = "Curso C#. POO IX. Clases anónimas. Vídeo 35";

        public Video35()
        {
            var miVariable = new { Titulo = "Interestelar", Anio = 2014 };

            Console.WriteLine(miVariable.Titulo);
        }
    }
}