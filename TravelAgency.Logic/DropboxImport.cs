namespace TravelAgency.Logic
{
    using System.Collections.Generic;
    using System.Linq;
    using TravelAgency.Data;

    public class DropboxImport
    {
        private TravelAgencyDbContext dbContext;

        public DropboxImport(TravelAgencyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<string> GetDestination()
        {
            return this.dbContext.Destinations.Select(x => x.Country).ToList();
        }

        public List<string> GetGuides()
        {
            return this.dbContext.Guides.Select(x => x.Name).ToList();
        }

        public List<string> GetTransports()
        {
            var result = this.dbContext.Transports.Select(x => x.CompanyName).ToList();
            result.Insert(0, "*");
            return result;
        }
    }
}
