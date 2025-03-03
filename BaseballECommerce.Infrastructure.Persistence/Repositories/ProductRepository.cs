using BaseballEcommerce.Core.Domain.Entities;
using BaseballEcommerce.Core.Domain.Repositories;

namespace BaseballECommerce.Infrastructure.Persistence.Repositories;

public class ProductRepository : RepositoryBase<Product>, IProductRepository
{
    public ProductRepository(RepositoryContext repositoryContext)
        : base(repositoryContext)
    { 
    }

    public IEnumerable<Product> GetProducts(Guid categoryId, bool trackChanges) =>
        FindByCondition(p => p.CategoryId.Equals(categoryId), trackChanges)
        .OrderBy(p => p.Name)
        .ToList();
}
