using BaseballEcommerce.Core.Domain.Entities;
using BaseballEcommerce.Core.Domain.Repositories;
using BaseballECommerce.Core.Services.Abstractions;
using LoggingService;

namespace BaseballECommerce.Core.Services;

internal class CategoryService : ICategoryService
{
    private readonly IRepositoryManager _repository;
    private readonly ILoggerManager _logger;

    public CategoryService(IRepositoryManager repository, ILoggerManager logger)
    {
        _repository = repository;
        _logger = logger;
    }

    public IEnumerable<Category> GetAllCategories(bool trackChanges)
    {
        try
        {
            var categories = _repository.Category.GetAllCategories(trackChanges);

            return categories;
        }
        catch (Exception ex)
        {
            _logger.LogError($"Something went wrong in the {nameof(GetAllCategories)} service method {ex}");
            throw;
        }
    }
}
