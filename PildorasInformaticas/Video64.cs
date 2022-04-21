using System.Collections.Generic;

namespace PildorasInformaticas
{
    class Video64
    {
        public static string URL = "https://www.youtube.com/watch?v=SEOttevLWKA";
        public static string TITUlO = "Curso C#. Colecciones IV. Stacks y Dictionary. Vídeo 66";

        Stack<int> numeros = new Stack<int>();
        Dictionary<string, int> paises = new Dictionary<string, int>();
        public Video64()
        {

            foreach(int numero in new int[5] { 3, 6, 9, 12, 18 })
            {
                numeros.Push(numero);
            }
            
            Print();
            Pop();

            paises.Add("México", 1);
            paises.Add("Rusia", 2);

            paises["China"] = 3;
            paises["Argentina"] = 4;
            
            Print();
        }

        public void Print()
        {
            foreach(int numero in numeros)
            {
                Console.WriteLine(numero);
            }

            foreach(KeyValuePair<string, int> pais in paises)
            {
                Console.WriteLine(pais.Key + "\t" + pais.Value);
            }
        }

        public void Pop()
        {
            numeros.Pop();
        }
    }
}