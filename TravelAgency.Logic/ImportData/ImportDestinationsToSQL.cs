namespace TravelAgency.Logic.ImportData
{
    using System.Collections.Generic;

    using Data;
    using Model;

    public class ImportDestinationsToSQL : ImportToSQL
    {
        public override void ImportDataToSQL(IEnumerable<object> dataType)
        {
            foreach (var destination in dataType)
            {
                this.db.Destinations.Add((Destination)destination);
            }

            db.SaveChanges();
        }
    }
}
