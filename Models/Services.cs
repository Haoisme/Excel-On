using System.ComponentModel.DataAnnotations;

namespace Excel_On.Models
{
    public class Services : Base
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal? Fee { get; set; }
        public int? Rate { get; set; }
    }
}
