namespace TravelAgency.Logic.MySQL
{
    public class Report
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }
        public int ClientsCount { get; set; }
        public decimal TotalIncome { get; set; }
        public string TransportCompany { get; set; }
        public string TransportType { get; set; }
        public string GuideName { get; set; }

    }
}
