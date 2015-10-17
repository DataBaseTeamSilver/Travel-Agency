namespace TravelAgency.Model
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Transport
    {
        private ICollection<Excursion> excursions;

        public Transport()
        {
            this.excursions = new List<Excursion>();
        }

        public int TransportId { get; set; }

        [Required]
        [MaxLength(50)]
        public string CompanyName { get; set; }

        public TransportType Type { get; set; }

        public virtual ICollection<Excursion> Excursions
        {
            get
            {
                return this.excursions;
            }

            set
            {
                this.excursions = value;
            }
        }
    }
}
