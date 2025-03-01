using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using BaseballEcommerce.Core.Domain.Entities;

namespace BaseballECommerce.Infrastructure.Persistence;

public class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.HasData
        (
            new Category
            {
                Id = new Guid("a1d4c053-49b6-410c-bc78-2d54a9991871"),
                Name = "Baseball Caps"
            },
            new Category
            {
                Id = new Guid("b2e5a070-94ce-4d15-9494-5248280c2ce4"),
                Name = "Memorabilia"
            },
            new Category
            {
                Id = new Guid("c3f6b090-24de-4f25-9895-1234567a2bc5"),
                Name = "Baseball Jerseys"
            }
        );
    }
}

