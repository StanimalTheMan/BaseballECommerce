using BaseballEcommerce.Core.Domain.Entities;
using BaseballEcommerce.Core.Domain.Repositories;

namespace BaseballECommerce.Infrastructure.Persistence.Repositories;

internal sealed class CategoryRepository : RepositoryBase<Category>, ICategoryRepository
{
    public CategoryRepository(RepositoryContext repositoryContext)
        : base(repositoryContext)
    {
    }

    public IEnumerable<Category> GetAllCategories(bool trackChanges) =>
        FindAll(trackChanges)
            .OrderBy(c => c.Name)
            .ToList();

    public Category GetCategory(Guid categoryId, bool trackChanges) =>
        FindByCondition(c => c.Id.Equals(categoryId), trackChanges)
        .SingleOrDefault();
}
