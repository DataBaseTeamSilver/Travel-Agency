namespace TravelAgency.Model
{
    public class Transport
    {
        public int TransportId { get; set; }

        public string CompanyName { get; set; }

        public TransportType Type { get; set; }

        public int MaxCapacity { get; set; }
    }
}
