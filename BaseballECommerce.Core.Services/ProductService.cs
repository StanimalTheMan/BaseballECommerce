using AutoMapper;
using BaseballEcommerce.Core.Domain.Repositories;
using BaseballECommerce.Core.Services.Abstractions;
using LoggingService;

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
}
