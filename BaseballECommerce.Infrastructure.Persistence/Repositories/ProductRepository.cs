using BaseballEcommerce.Core.Domain.Entities;
using BaseballEcommerce.Core.Domain.Repositories;

namespace BaseballECommerce.Infrastructure.Persistence.Repositories;

public class ProductRepository : RepositoryBase<Product>, IProductRepository
{
    public ProductRepository(RepositoryContext repositoryContext)
        : base(repositoryContext)
    { 
    }
}
