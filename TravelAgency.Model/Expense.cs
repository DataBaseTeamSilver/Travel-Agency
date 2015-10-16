namespace TravelAgency.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Expense
    {
        [Key, ForeignKey("Excursion")]
        public int ExpenseId { get; set; }

        public decimal HotelExpenses { get; set; }

        public decimal TransportExpenses { get; set; }

        public virtual Excursion Excursion { get; set; }
    }
}
