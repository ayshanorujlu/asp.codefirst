using Microsoft.EntityFrameworkCore;
using WebApplication4.Entities;

namespace WebApplication4.Data
{
    public class ProductDbContext:DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext>
            contextOptions)
            : base(contextOptions)
        { }

        public DbSet<Product> Products { get; set; }
    }
}
