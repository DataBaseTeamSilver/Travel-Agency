namespace TravelAgency.Model
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Destination
    {
        private ICollection<Excursion> excursions;

        public Destination()
        {
            this.excursions = new List<Excursion>();
        }

        [Key]
        public int DestinationId { get; set; }

        [MaxLength(75)]
        [Required]
        public string Country { get; set; }

        [Required]
        public double Distance { get; set; }

        [Range(1, 10)]
        [Required]
        public int LuxuryFactor { get; set; }

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
