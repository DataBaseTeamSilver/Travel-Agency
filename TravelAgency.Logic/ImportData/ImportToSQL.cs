namespace TravelAgency.Logic.ImportData
{
    using System.Collections.Generic;
    using TravelAgency.Data;
    using TravelAgency.Model;

    public abstract class ImportToSQL
    {
        protected TravelAgencyDbContext db = new TravelAgencyDbContext();

        public abstract void ImportDataToSQL(IEnumerable<object> dataType);
    }
}
