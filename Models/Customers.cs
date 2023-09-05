using System.ComponentModel.DataAnnotations;

namespace Excel_On.Models
{
    public class Customers : Base
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}
