using System.ComponentModel.DataAnnotations;

namespace Excel_On.Models
{
    public class Departments : Base
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}
