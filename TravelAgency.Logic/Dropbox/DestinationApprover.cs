namespace TravelAgency.Logic.Dropbox
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Data;

    internal class DestinationApprover : DropboxApprover
    {
        public override IEnumerable<ReportTransport> ProcessRequest(TravelAgencyDbContext dbContext, string destination, string guide, string transport)
        {
            if (destination != string.Empty)
            {
                var excursions = dbContext
                .Excursions
                .Where(y => y.Destination.Country == destination)
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
