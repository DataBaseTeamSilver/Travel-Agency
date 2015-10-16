namespace TravelAgency.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Excursion
    {
        [Key]
        public int ExcursionId { get; set; }

        [MaxLength(50)]
        [Required]
        public string Name { get; set; }
                
        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        [Required]
        public int DestinationId { get; set; }

        public virtual Destination Destination { get; set; }

        [Required]
        public int Clients { get; set; }

        [Required]
        [Range(100, 10000)]
        public decimal PricePerClient { get; set; }

        [Required]
        public int TransportId { get; set; }

        public virtual Transport Transport { get; set; }

        [Required]
        public int GuideId { get; set; }
        
        public virtual Guide Guide { get; set; }

        public int ExpenseId { get; set; }

        public virtual Expense Expense { get; set; }

    }
}
