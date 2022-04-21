namespace PildorasInformaticas
{
    class Video36 
    {
        public const string URL = "https://www.youtube.com/watch?v=I1ADyLMTAwo";
        public const string TITULO = "Curso C#. Arrays I. Vídeo 36";

        public Video36()
        {
            int[] edades;

            edades = new int[4];

            edades[0] = 8;
            edades[1] = 15;
            edades[2] = 18;
            edades[3] = 45;

            foreach(var e in edades)
            {
                Console.WriteLine(e);
            }

            // int[] matriz = new int[4] { 3, 6, 9, 18 };


            Console.WriteLine("Matriz");
            int[] matriz = { 3, 6, 9, 18 };

            foreach(var m in matriz)
            {
                Console.WriteLine(m);
            }
        }
    }
}