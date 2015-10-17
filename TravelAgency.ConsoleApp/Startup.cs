namespace TravelAgency.ConsoleApp
{
    using System.Data.Entity;
    using Data;
    using Data.Migrations;
    using Model;

    public class Startup
    {
        public static void Main()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<TravelAgencyDbContext, Configuration>());
            var db = new TravelAgencyDbContext();

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
