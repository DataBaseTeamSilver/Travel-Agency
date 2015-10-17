namespace TravelAgency.Data
{
    using System.Data.Entity;
    using Model;

    public class TravelAgencyDbContext : DbContext
    {
        public TravelAgencyDbContext()
            : base("TravelAgencyDb")
        {
        }

        public virtual IDbSet<Excursion> Excursions { get; set; }

        public virtual IDbSet<Destination> Destinations { get; set; }

        public virtual IDbSet<Expense> Expenses { get; set; }

        public virtual IDbSet<Guide> Guides { get; set; }

        public virtual IDbSet<Transport> Transports { get; set; }
    }
}
