namespace PildorasInformaticas
{
    enum Estaciones { Primavera, Verano, Otoño, Invierno }
    enum Bonus { Bajo = 500, Normal = 1000, Bueno = 1500, Extra = 2000 }
    class Video58 
    {
        public const string URL = "https://www.youtube.com/watch?v=gj1AA7ZkuSc";
        public const string TITULO = "Curso C#. Enum. Vídeo 58";
        public Video58()
        {
            Estaciones alergia = Estaciones.Primavera;
            Console.WriteLine(alergia);

            Bonus bonus = Bonus.Bueno;
            double bono = (double) bonus;
            Console.WriteLine(bono);
        }
    }
}