namespace PildorasInformaticas
{
    class Video68
    {
        public const string URL = "https://www.youtube.com/watch?v=OpmDpE_wjGs";
        public const string TITLE = "Curso C#. Delegados predicados y lambdas II. Vídeo 68";
        List<int> numeros = new List<int>();
        Predicate<int> delegado = new Predicate<int>(Pares);
        static bool ExisteNombre(Persona persona) {
            return persona.Nombre == "Juan" ? true : false;
        }
        public Video68()
        {
            numeros.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });

            List<int> pares = numeros.FindAll(delegado);

            foreach(int par in pares)
            {
                Console.WriteLine(par);
            }

            List<Persona> gente = new List<Persona>();
            Persona p1 = new Persona() { Nombre = "Juan", Edad = 40 };
            Persona p2 = new Persona() { Nombre = "María", Edad = 28 };
            Persona p3 = new Persona() { Nombre = "José", Edad = 45 };

            gente.AddRange(new Persona[] { p1, p2, p3 });

            Predicate<Persona> predicado = new Predicate<Persona>(ExisteNombre);

            bool existe = gente.Exists(predicado);

            if(existe) Console.WriteLine("Hay personas que se llaman Juan");
            else Console.WriteLine("No hay personas que se llaman Juan");
        }

        static bool Pares(int numero)
        {
            return numero % 2 == 0 ? true : false;
        }
    }

    class Persona
    {
        private string? nombre;
        private int edad;

        public string? Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
    }
}