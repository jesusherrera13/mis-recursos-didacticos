namespace PildorasInformaticas
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = int.MaxValue;
            int resultado = unchecked(numero + 20);

            Console.WriteLine(resultado);

            Console.WriteLine("Introduce el número de mes: ");

            int mes  = Int32.Parse(Console.ReadLine());

            try
            {

                Console.WriteLine(Video25.NombreDelMes(mes));
            }
            catch(Exception ex)
            {
                Console.WriteLine("Mensaje de la excepción: " + ex.Message);
            }
        }
    }
}
