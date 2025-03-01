namespace BaseballECommerce.Infrastructure.Persistence;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using BaseballEcommerce.Core.Domain.Entities;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasData
        (
            new Product
            {
                Id = new Guid("c3f6b090-24de-4f25-9895-1234567a2bc5"),
                Name = "Stanimal Giants Jersey",
                Description = "Stanimal wore this jersey when he played for NYCSummerBaseball Giants in 2022.",
                ListPrice = 50.00,
                CategoryId = new Guid("c3f6b090-24de-4f25-9895-1234567a2bc5"),
                ImageUrl = "https://example.com/images/stamimal-giants-jersey.jpg",
                StockQuantity = 50
            },
            new Product
            {
                Id = new Guid("b2e5a070-94ce-4d15-9494-5248280c2ce4"),
                Name = "Francisco Lindor Garden Gnome",
                Description = "This gnome was given out as part of a Mets game giveaway.",
                ListPrice = 50.00,
                CategoryId = new Guid("b2e5a070-94ce-4d15-9494-5248280c2ce4"),
                ImageUrl = "https://example.com/images/lindor-garden-gnome-2023.jpg",
                StockQuantity = 30
            }
        );
    }
}

