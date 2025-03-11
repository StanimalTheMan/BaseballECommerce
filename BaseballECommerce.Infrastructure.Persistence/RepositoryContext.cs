using BaseballEcommerce.Core.Domain.Entities;
using BaseballECommerce.Infrastructure.Persistence.Configurations;
using Microsoft.EntityFrameworkCore;

namespace BaseballECommerce.Infrastructure.Persistence;


public class RepositoryContext : DbContext
{
    public RepositoryContext(DbContextOptions options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new CategoryConfiguration());
        modelBuilder.ApplyConfiguration(new ProductConfiguration());
    }

    public DbSet<Category>? Categories { get; set; }
    public DbSet<Product>? Products { get; set; }
}
