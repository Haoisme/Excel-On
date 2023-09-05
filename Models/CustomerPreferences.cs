using System.ComponentModel.DataAnnotations;

namespace Excel_On.Models
{
    public class CustomerPreferences : Base
    {
        [Key]
        public int Id { get; set; }
        public int? CustomerId { get; set; }
        public int? ServiceId { get; set; }
    }
}
