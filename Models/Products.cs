using System.ComponentModel.DataAnnotations;

namespace Excel_On.Models
{
    public class Products : Base
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? ServiceId { get; set; }
        public string? Describes { get; set; }
    }
}
