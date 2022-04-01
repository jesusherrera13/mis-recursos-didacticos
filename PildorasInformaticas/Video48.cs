namespace PildorasInformaticas
{
    class Video48 : IMetodos
    {
        public const string URL = "https://www.youtube.com/watch?v=K4JUqONrb8E"; 
        public const string TITULO = "Curso C#. Interfaces I. Vídeo 48"; 
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

    interface IMetodos
    {
        void setURL(); 
        string getURL(); 
        void setTitulo(); 
        string getTitulo(); 
    }
}