namespace TravelAgency.Logic
{
    using Data;
    using Data.Migrations;
    using System.Data.Entity;

    public class CreateTravelAgencyDb
    {
        private const string SuccessMessage = "Database Travel Agency is created!";
        private const string FailMessage = "Database Travel Agency is already existing!";

        public CreateTravelAgencyDb()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<TravelAgencyDbContext, Configuration>());
        }

        public string CreateTravelAgencyDbFromModel()
        {
            using (var db = new TravelAgencyDbContext())
            {
                var result = db.Database.CreateIfNotExists();

                return result ? SuccessMessage : FailMessage;
            }
        }
    }
}
