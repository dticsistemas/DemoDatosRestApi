namespace DemoDatosRest
{
    public class Passengers
    {
        public string id { get; set; }
        public string name { get; set; }
        public string lastName { get; set; }
        public string passport { get; set; }


        public Passengers(String Id, String Name, String LastName, String Passport)
        {
            this.id = Id;
            this.name = Name;
            this.lastName = LastName;
            this.passport = Passport;
        }
    }
}
