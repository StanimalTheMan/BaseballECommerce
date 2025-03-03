using BaseballEcommerce.Core.Domain.Entities;

namespace BaseballECommerce.Core.Services.Abstractions;

public interface ICategoryService
{
    IEnumerable<Category> GetAllCategories(bool trackChanges);
}
