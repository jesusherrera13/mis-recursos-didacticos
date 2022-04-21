namespace PildorasInformaticas
{
    class Video39
    {
        public const string URL = "https://www.youtube.com/watch?v=2ZvE6u4e4mo";
        public const string TITULO = "Curso C#. Bucle foreach. Arrays IV. Vídeo 39";
        public List<Lenguaje> lenguajes = new List<Lenguaje>();

        public Video39()
        {
            Data();
        }

        private void Data()
        {
            lenguajes = new List<Lenguaje> {
                new Lenguaje() { nombre = "C#" },
                new Lenguaje() { nombre = "PHP" },
                new Lenguaje() { nombre = "Java" },
                new Lenguaje() { nombre = "Javascript" },
            };
        }
    }

    class Lenguaje {
        public string? nombre { get; set; }
    } 
}