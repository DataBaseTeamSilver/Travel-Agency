﻿namespace TravelAgency.Model
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

        public int DestinationId { get; set; }

        [MaxLength(75)]
        public string Country { get; set; }

        public double Distance { get; set; }

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
