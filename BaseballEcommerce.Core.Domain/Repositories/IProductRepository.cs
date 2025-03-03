using BaseballEcommerce.Core.Domain.Entities;

namespace BaseballEcommerce.Core.Domain.Repositories;

public interface IProductRepository
{
    IEnumerable<Product> GetProducts(Guid categoryId, bool trackChanges);
}
