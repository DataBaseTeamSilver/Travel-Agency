namespace TravelAgency.Logic
{
    using System.Collections.Generic;
    using Data;
    using Model;

    public class ImportToSQL
    {
        public void ImportFromExcelToSQL(List<Destination> destinations)
        {
            var db = new TravelAgencyDbContext();
            foreach (var destination in destinations)
            {
                db.Destinations.Add(destination);
            }

            db.SaveChanges();
        }
    }
}
