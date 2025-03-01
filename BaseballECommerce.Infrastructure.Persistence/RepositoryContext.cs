using BaseballEcommerce.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BaseballECommerce.Infrastructure.Persistence;


public class RepositoryContext : DbContext
{
    public RepositoryContext(DbContextOptions options)
        : base(options)
    {
    }

    public DbSet<Category>? Categories { get; set; }
    public DbSet<Product>? Products { get; set; }
}
