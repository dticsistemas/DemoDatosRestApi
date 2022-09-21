using Microsoft.AspNetCore.Components.Server;
using Microsoft.Extensions.Options;

namespace DemoDatosRest
{
    public class Invoices
    {
        public string id { get; set; }
        public string reservationNumber { get; set; }
        public string passanger { get; set; }
        public string reservationStatus { get; set; }
        public string date { get; set; }
        public string value { get; set; }
        public string flight { get; set; }
        public Invoices(String Id, String NroReserva, String Pasajero, String Estado, String fecha, String Valor, String Vuelo)
        {
            this.id = Id;
            this.reservationNumber = NroReserva;
            this.passanger= Pasajero;
            this.reservationStatus = Estado;
            this.date = fecha;
            this.value = Valor;
            this.flight = Vuelo;
        }
    }
}
