// Curso C#. POO VIII. Variables y métodos static. Vídeo 34

namespace PildorasInformaticas
{
    class Video34
    {
        private int x, y;
        private static int contador = 0;
        public static int ContadorDeObjetos() => contador;
        public Video34(int x, int y)
        {
            this.x = x;
            this.y = y;
            contador++;
        }

        public Video34()
        {
            this.x = 0;
            this.y = 0;
            contador++;
        }

        public int getX()
        {
            return this.x;
        }

        public int getY()
        {
            return this.y;
        }
    }
}