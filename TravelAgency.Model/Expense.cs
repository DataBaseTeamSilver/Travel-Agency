namespace TravelAgency.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Expense
    {
        [Key, ForeignKey("Excursion")]
        public int ExpenseId { get; set; }

        [Column(TypeName = "Money")]
        public decimal HotelExpenses { get; set; }

        [Column(TypeName = "Money")]
        public decimal TransportExpenses { get; set; }

        public virtual Excursion Excursion { get; set; }
    }
}
