namespace PildorasInformaticas
{
    class Video49 : IMetodos
    {
        public const string URL = "https://www.youtube.com/watch?v=cKJBHCFJWc8"; 
        public const string TITULO = "Curso C#. Interfaces II. Vídeo 49"; 
        public void setURL()
        {

        }

        public string getURL()
        {
            return URL;
        }

        public void setTitulo()
        {

        }

        public string getTitulo()
        {
            return TITULO;
        }
    }


    public class Vechicle : IGenerador
    {
        public void setGenerador()
        {
            
        }
    }
    public class Bicycle : Vechicle, ITerrestre, IElectrico
    {
        public void setNoRuedas()
        {
          
        }

        public void setTipoBateria()
        {

        }
    }

    interface IGenerador
    {
        void setGenerador();
    }

    interface ITerrestre
    {
        void setNoRuedas();
    }

    interface IElectrico
    {
        void setTipoBateria();
    }
}