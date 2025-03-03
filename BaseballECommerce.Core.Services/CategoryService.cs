using AutoMapper;
using BaseballEcommerce.Core.Domain.Exceptions;
using BaseballEcommerce.Core.Domain.Repositories;
using BaseballECommerce.Core.Services.Abstractions;
using LoggingService;
using Shared.DataTransferObjects;

namespace BaseballECommerce.Core.Services;

internal class CategoryService : ICategoryService
{
    private readonly IRepositoryManager _repository;
    private readonly ILoggerManager _logger;
    private readonly IMapper _mapper;

    public CategoryService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
    {
        _repository = repository;
        _logger = logger;
        _mapper = mapper;
    }

    public IEnumerable<CategoryDto> GetAllCategories(bool trackChanges)
    {
        var categories = _repository.Category.GetAllCategories(trackChanges);

        var categoriesDto = _mapper.Map<IEnumerable<CategoryDto>>(categories);

        return categoriesDto;
    }

    public CategoryDto GetCategory(Guid id, bool trackChanges)
    {
        var category = _repository.Category.GetCategory(id, trackChanges);
        if (category is null)
            throw new CategoryNotFoundException(id);

        var categoryDto = _mapper.Map<CategoryDto>(category);

        return categoryDto;
    }
}
