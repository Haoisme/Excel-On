using System.ComponentModel.DataAnnotations;

namespace Excel_On.Models
{
    public class CustomerProducts : Base
    {
        [Key]
        public int Id { get; set; }
        public int? CustomerId { get; set; }
        public int? ProductId { get; set; }
    }
}
