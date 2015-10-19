namespace TravelAgency.Model
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Guide
    {
        private ICollection<Excursion> excursions;

        public Guide()
        {
            this.excursions = new HashSet<Excursion>();
        }

        [Key]
        public int GuideId { get; set; }

        [MaxLength(50)]
        [Required]
        public string Name { get; set; }

        [Range(1, 10)]
        [Required]
        public int Experience { get; set; }

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
