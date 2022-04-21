namespace PildorasInformaticas
{
    class Video69
    {
        public const string URL = "https://youtu.be/mha1GbPT33o";
        public const string TITLE = "Curso C#. Delegados predicados y lambdas III. Vídeo 69";
        public delegate double DelegadoCuadrado(double numero);
        public delegate double DelegadoSuma(double numero1, double numero2);
        public delegate bool DelegadoCompania(double valor1, double valor2);

        DelegadoCuadrado operacion = new DelegadoCuadrado(num => Math.Pow(num, 2));
        DelegadoSuma operacion_suma = new DelegadoSuma((numero1, numero2) => numero1 + numero2);
        
        List<int> numeros = new List<int>();
        /* 
        Predicate<int> delegado = new Predicate<int>(Pares);
        static bool ExisteNombre(Persona persona) {
            return persona.Nombre == "Juan" ? true : false;
        } */
        public Video69()
        {

            numeros.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });

            numeros.ForEach(i => {
                if(i % 2 == 0) Console.WriteLine(i);
            });

            Console.WriteLine();

            List<int> pares = numeros.FindAll(i => i % 2 == 0);

            pares.ForEach(i => Console.WriteLine(i));
            Console.WriteLine();

            Compania c1 = new Compania() { nombre = "Microsoft", valor = 30 };
            Compania c2 = new Compania() { nombre = "Canonical", valor = 28 };
            Compania c3 = new Compania() { nombre = "El Juego Perfecto MX", valor = 45 };

            DelegadoCompania comparaValor = (valor1, valor2) => valor1 >= valor2;

            Console.WriteLine("Valores");
            Console.WriteLine(comparaValor(c1.valor, c2.valor));
            
            /* 

            List<Persona> gente = new List<Persona>();

            gente.AddRange(new Persona[] { p1, p2, p3 });

            Predicate<Persona> predicado = new Predicate<Persona>(ExisteNombre);

            bool existe = gente.Exists(predicado);

            if(existe) Console.WriteLine("Hay personas que se llaman Juan");
            else Console.WriteLine("No hay personas que se llaman Juan"); 
            */
            Console.WriteLine(operacion(4));
            Console.WriteLine(operacion_suma(4,5));
        }
    }

    class Compania
    {
        public string? nombre { get; set; }
        public double valor { get; set; }
    }
}