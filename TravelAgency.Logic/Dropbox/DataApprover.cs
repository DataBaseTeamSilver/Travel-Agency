namespace TravelAgency.Logic.Dropbox
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using TravelAgency.Data;

    internal class DataApprover : DropboxApprover
    {
        public override IEnumerable<ReportTransport> ProcessRequest(TravelAgencyDbContext dbContext, string destination, string guide, string transport)
        {
            if (destination == "*" && guide == "*" && transport == "*")
            {
                var excursions = dbContext
                .Excursions
                .Select(x => new ReportTransport()
                {
                    ExcName = x.Name,
                    StartDate = x.StartDate,
                    EndDate = x.EndDate,
                    CompanyName = x.Transport.CompanyName,
                    TransportType = x.Transport.Type,
                    County = x.Destination.Country
                })
                .ToList();

                return excursions;
            }
            else
            {
                return this.Successor.ProcessRequest(dbContext, destination, guide, transport);
            }
        }
    }
}
