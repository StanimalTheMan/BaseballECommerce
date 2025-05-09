﻿using Microsoft.EntityFrameworkCore.Design;
using BaseballECommerce.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace BaseballECommerce.ContextFactory;

public class RepositoryContextFactory : IDesignTimeDbContextFactory<RepositoryContext>
{
    public RepositoryContext CreateDbContext(string[] args)
    {
        var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();
        
        var builder = new DbContextOptionsBuilder<RepositoryContext>()
            .UseSqlServer(configuration.GetConnectionString("sqlConnection"),
                b => b.MigrationsAssembly("BaseballECommerce.Infrastructure.Persistence"));

        return new RepositoryContext(builder.Options);
    }
}