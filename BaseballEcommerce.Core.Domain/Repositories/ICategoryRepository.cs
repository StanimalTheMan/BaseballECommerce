using BaseballEcommerce.Core.Domain.Entities;

namespace BaseballEcommerce.Core.Domain.Repositories;

public interface ICategoryRepository
{
    IEnumerable<Category> GetAllCategories(bool trackChanges);
    Category GetCategory(Guid categoryId, bool trackChanges);
}
