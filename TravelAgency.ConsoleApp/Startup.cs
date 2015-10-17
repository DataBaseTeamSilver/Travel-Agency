namespace TravelAgency.ConsoleApp
{
    using Data;
    using Model;

    public class Startup
    {
        public static void Main()
        {
            var db = new TarvelAgencyDbContext();

            var transport = new Transport
            {
                CompanyName = "Lufthansa",
                Type = TransportType.Airplane
            };

            db.Transports.Add(transport);
            db.SaveChanges();
        }
    }
}
