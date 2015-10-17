namespace TravelAgency.Data
{
    using System.Data.Entity;

    using Model;

    public class TarvelAgencyDbContext : DbContext
    {
        public TarvelAgencyDbContext()
            : base("TarvelAgencyDbContext")
        {
        }

        public virtual IDbSet<Excursion> Excursions { get; set; }

        public virtual IDbSet<Destination> Destinations { get; set; }

        public virtual IDbSet<Expense> Expenses { get; set; }

        public virtual IDbSet<Guide> Guides { get; set; }

        public virtual IDbSet<Transport> Transports { get; set; }
    }
}
