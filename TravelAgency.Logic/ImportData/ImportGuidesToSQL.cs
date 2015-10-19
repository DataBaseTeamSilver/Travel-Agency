namespace TravelAgency.Logic.ImportData
{
    using System.Collections.Generic;
    using TravelAgency.Model;

    public class ImportGuidesToSQL : ImportToSQL
    {
        public override void ImportDataToSQL(IEnumerable<object> dataType)
        {
            foreach (var guide in dataType)
            {
                this.db.Guides.Add((Guide)guide);
            }

            db.SaveChanges();
        }
    }
}
