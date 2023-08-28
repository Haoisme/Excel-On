using Microsoft.AspNetCore.Identity;

namespace Excel_On.Models
{
    public class CustomUser : IdentityUser
    {
        public string? Name { get; set; }
        public string? Address { get; set; }
        public bool? Genfer { get; set; }
    }
}
