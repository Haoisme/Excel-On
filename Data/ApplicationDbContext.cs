using Excel_On.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Excel_On.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public virtual DbSet<CustomUser> CustomUsers { get; set; }
        public virtual DbSet<CustomerPreferences> CustomerPreferences { get; set; }
        public virtual DbSet<CustomerProducts> CustomerProducts { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<Departments> Departments { get; set; }
        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<Payments> Payments { get; set; }
        public virtual DbSet<Products>  Products { get; set; }
        public virtual DbSet<Services> Services { get; set; }
    }
}