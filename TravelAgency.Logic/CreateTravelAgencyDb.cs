namespace TravelAgency.Logic
{
    using Data;
    using Data.Migrations;
    using System.Data.Entity;

    public class CreateTravelAgencyDb
    {
        private const string FinalMethodMessgae = "Database TravelAgency is created {0}";

        public CreateTravelAgencyDb()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<TravelAgencyDbContext, Configuration>());
        }

        public string CreateTravelAgencyDbFromModel()
        {
            using (var db = new TravelAgencyDbContext())
            {
                var result = db.Database.CreateIfNotExists();

                return string.Format(FinalMethodMessgae, result ? "YES" : "NO");
            }
        }
    }
}
