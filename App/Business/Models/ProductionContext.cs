using Microsoft.EntityFrameworkCore;

namespace FactoryWebApi.App.Business.Models
{
    public class ProductionContext : DbContext
    {
        public ProductionContext(DbContextOptions<ProductionContext> options) : base(options)
        {

        }

        public DbSet<Production> Productions { get; set; }
        public DbSet<ProductionProcedure> ProductionProcedure { get; set; }
    }
}