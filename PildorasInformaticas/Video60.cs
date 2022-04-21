using System.Collections.Generic;

namespace PildorasInformaticas
{
    class Video60
    {
        public const string URL = "";
        public const string TITUlO = "";
        
        public Video60()
        {
            List<int> numeros = new List<int>();

            numeros.Add(3);
            numeros.Add(6);
            numeros.Add(9);

            int[] listaNumeros = new int[] { 18, 27, 36, 45, 54 };
            
            for(int i = 0; i < 5; i++)
            {
                numeros.Add(listaNumeros[i]);
            }

            for(int i = 0; i < numeros.Count; i++)
            {
                Console.WriteLine(numeros[i]);
            }
        }
    }
}