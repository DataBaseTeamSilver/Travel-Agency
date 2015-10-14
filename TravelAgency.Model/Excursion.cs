namespace TravelAgency.Model
{
    using System;

    public class Excursion
    {
        public int ExcursionId { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string Name { get; set; }

        public int DestinationId { get; set; }

        public int Clients { get; set; }

        public decimal PricePerClient { get; set; }

        public int GuideId { get; set; }

        public int TransportId { get; set; }
    }
}
