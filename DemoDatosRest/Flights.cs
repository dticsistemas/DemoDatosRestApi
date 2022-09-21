namespace DemoDatosRest
{
    public class Flights
    {
        public string id { get; set; }
        public string source_airport_code { get; set; }
        public string destiny_airport_code { get; set; }


        public Flights(String Id, String origen, String destino)
        {
            this.id = Id;
            this.source_airport_code = origen;
            this.destiny_airport_code = destino;
        }
    }
}
