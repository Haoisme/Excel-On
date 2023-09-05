using System.ComponentModel.DataAnnotations;

namespace Excel_On.Models
{
    public class Payments : Base
    {
        [Key]
        public int Id { get; set; }
        public int? CustomerId { get; set; }
        public decimal? Amount { get; set; }
    }
}
