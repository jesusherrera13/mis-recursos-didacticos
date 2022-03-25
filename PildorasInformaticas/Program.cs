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

            // Video34 video34_1 = new Video34();
            // Video34 video34_2 = new Video34(3, 6);
            // Console.WriteLine(Video34.ContadorDeObjetos());

            // Video35 video35 = new Video35();

            // Console.WriteLine(Video35.URL); 
            // Video36 video36 = new Video36();
            Video37.GetArray();
        }
    }
}