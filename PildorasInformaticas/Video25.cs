// Curso C#. Excepciones IV. Lanzamiento de excepciones con throw. Vídeo 25
namespace PildorasInformaticas
{
    class Video25 {

        public static string NombreDelMes(int mes)
        {
            switch(mes)
            {
                case 1:
                    return "Enero";

                case 2:
                    return "Febrero";
                
                case 3:
                    return "Marzo";

                case 4:
                    return "Abril";

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}