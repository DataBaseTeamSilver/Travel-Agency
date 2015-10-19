namespace TravelAgency.Logic
{
    using System.Data.Entity;
    using Data;
    using Data.Migrations;

    public class CreateTravelAgencyDb
    {
        private const string SuccessMessage = "Database Travel Agency is created!";
        private const string FailMessage = "Database Travel Agency is already existing!";

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
