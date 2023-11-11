using Microsoft.EntityFrameworkCore;

namespace CodeFirst.Models
{
    public class DemoContext : DbContext

    {

        public DemoContext(DbContextOptions<DemoContext>options) : base(options) 
        {}

        public DbSet<Products> Products { get; set; }
        public DbSet<Details> Details { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Invoices> Invoices { get; set; }


    }
}
