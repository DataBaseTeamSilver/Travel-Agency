namespace TravelAgency.Logic.Dropbox
{
    using System.Collections.Generic;
    using System.Linq;
    using Data;

    public class DropboxImport
    {
        private TravelAgencyDbContext dbContext;

        public DropboxImport(TravelAgencyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        
        public List<string> GetDestination()
        {
            var result = this.dbContext.Destinations.Select(x => x.Country).ToList();
            result.Insert(0, "*");
            return result;
        }

        public List<string> GetGuides()
        {
            var result = this.dbContext.Guides.Select(x => x.Name).ToList();
            result.Insert(0, "*");
            return result;
        }

        public List<string> GetTransports()
        {
            var result = this.dbContext.Transports.Select(x => x.CompanyName).ToList();
            result.Insert(0, "*");
            return result;
        }
    }
}
