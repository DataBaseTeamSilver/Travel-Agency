namespace TravelAgency.Logic
{
    using System;
    using TravelAgency.Model;

    public class ReportTransport
    {
        public string ExcName { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public string CompanyName { get; set; }

        public TransportType TransportType { get; set; }

        public string County { get; set; }
    }
}
