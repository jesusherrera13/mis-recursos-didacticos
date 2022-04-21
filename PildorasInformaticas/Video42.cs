namespace PildorasInformaticas
{
    class Vehiculo
    {
        public int no_ruedas { get; set; }
        public string? marca { get; set; }
    }
    class Auto : Vehiculo 
    {
        public int no_puertas { get; set; }

    }

    class Bicicleta : Vehiculo 
    {
        public Boolean pedales_acero { get; set; }
    }
}