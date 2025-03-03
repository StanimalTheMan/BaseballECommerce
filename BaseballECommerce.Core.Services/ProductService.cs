using AutoMapper;
using BaseballEcommerce.Core.Domain.Exceptions;
using BaseballEcommerce.Core.Domain.Repositories;
using BaseballECommerce.Core.Services.Abstractions;
using LoggingService;
using Shared.DataTransferObjects;

namespace BaseballECommerce.Core.Services;
internal sealed class ProductService : IProductService
{
    private readonly IRepositoryManager _repository;
    private readonly ILoggerManager _logger;
    private readonly IMapper _mapper;

    public ProductService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
    {
        _repository = repository;
        _logger = logger;
        _mapper = mapper;
    }

    public IEnumerable<ProductDto> GetProducts(Guid categoryId, bool trackChanges)
    {
        var category = _repository.Category.GetCategory(categoryId, trackChanges);
        if (category is null)
            throw new CategoryNotFoundException(categoryId);

        var productsFromDb = _repository.Product.GetProducts(categoryId, trackChanges);
        var productsDto = _mapper.Map<IEnumerable<ProductDto>>(productsFromDb);

        return productsDto;
    }
}
