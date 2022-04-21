namespace PildorasInformaticas
{
    class Video38
    {
        public const string URL = "https://www.youtube.com/watch?v=Cx0UW5PQJG0";
        public const string TITULO = "Curso C#. Arrays III y bucle FOR. Vídeo 38";
        public List<Planeta> planetas = new List<Planeta>() {
            new Planeta { nombre = "Mercurio" },
            new Planeta { nombre = "Venus" },
            new Planeta { nombre = "Tierra" },
            new Planeta { nombre = "Marte" },
            new Planeta { nombre = "Júpiter" },
            new Planeta { nombre = "Saturno" },
            new Planeta { nombre = "Urano" },
            new Planeta { nombre = "Neptuno" },
            new Planeta { nombre = "Plutón" }
        };
        
        public Video38()
        {
            var planetas = new[] {
                new { nombre = "Mercurio" },
                new { nombre = "Venus" },
                new { nombre = "Tierra" },
                new { nombre = "Marte" },
                new { nombre = "Júpiter" },
                new { nombre = "Saturno" },
                new { nombre = "Urano" },
                new { nombre = "Neptuno" },
                new { nombre = "Plutón" }
            };
        }
    }
    class Planeta
    {
        public string? nombre { get; set; }
    }
}