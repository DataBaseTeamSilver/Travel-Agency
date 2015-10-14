namespace TravelAgency.Model
{
    public class Destination
    {
        public int DestinationId { get; set; }

        public string Country { get; set; }

        public double Distance { get; set; }

        // Add A relation for the costs
    }
}
