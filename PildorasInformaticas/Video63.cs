using System.Collections.Generic;

namespace PildorasInformaticas
{
    class Video63
    {
        public static string URL = "";
        public static string TITUlO = "";
        List<int> numeros = new List<int>();
        public Video63()
        {
            Agregar(3);
            Agregar(6);
            Agregar(9);
            Agregar(18);
            Agregar(36);
            Agregar(72);
            Agregar(72);
            
            Imprimir();

            numeros.Remove(72);
            Imprimir();
            numeros.Remove(4);
            Imprimir();
        }

        public void Agregar(int n)
        {
            numeros.Add(n);

        }

        public void Imprimir()
        {
            /* 
            for(int i = 0; i < numeros.Count(); i++)
            {
                Console.WriteLine(numeros[i]);
            } 
            */

            foreach(int i in numeros)
            {
                Console.WriteLine(i);
            }
        }
    }
}