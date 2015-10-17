namespace TravelAgency.ConsoleApp
{
    using Data;
    using Model;

    public class Startup
    {
        public static void Main()
        {
            var db = new TarvelAgencyDbContext();
            
            db.SaveChanges();
        }
    }
}
