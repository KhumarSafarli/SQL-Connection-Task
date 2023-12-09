using LOGIS.Models;
using Microsoft.EntityFrameworkCore;

namespace LOGIS.DAL
{
    public class ProductDbContext:DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> opt) : base(opt)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
