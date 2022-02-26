namespace Movies 
{
    class Pelicula 
    {
        public int id { get; set; }
        public string? titulo { get; set; }    
        public int anio { get; set; }

        public override string ToString()
        {
            return $"{titulo} ({anio})";
        }
    }
}