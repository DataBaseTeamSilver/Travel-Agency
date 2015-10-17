namespace TravelAgency.ConsoleApp
{
    using System.Data.Entity;
    using Data;
    using Data.Migrations;

    public class Startup
    {
        public static void Main()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<TarvelAgencyDbContext, Configuration>());
            var db = new TarvelAgencyDbContext();
            
            db.SaveChanges();
        }
    }
}
