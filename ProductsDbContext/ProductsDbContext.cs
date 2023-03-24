using Microsoft.EntityFrameworkCore;
using ProductInventoryMgt.Model.Domain;

namespace ProductInventoryMgt.ProductDbContext
{
    public class ProductsDbContext : DbContext
    {
        public ProductsDbContext(DbContextOptions<ProductsDbContext> options)
            :base(options)
        {
        }

        public DbSet<Products> ProductsInventory { get; set; }
    }
}
