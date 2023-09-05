using System.ComponentModel.DataAnnotations;

namespace Excel_On.Models
{
    public class Employees : Base
    {
        [Key]
        public int Id { get; set; }
        public int? DepartmentId { get; set; }
        public int? ServiceId { get; set; }
    }
}
