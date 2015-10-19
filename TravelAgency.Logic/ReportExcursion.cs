namespace TravelAgency.Logic
{
    using System;

    public class ReportExcursion
    {
        public string ExcName { get; set; }

        public string Destination { get; set; }

        public string Distance { get; set; }

        public int ClientCount { get; set; }

        public string Guide { get; set; }

        public int Experience { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }
    }
}
