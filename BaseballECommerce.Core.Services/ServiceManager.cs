using BaseballEcommerce.Core.Domain.Repositories;
using BaseballECommerce.Core.Services.Abstractions;
using LoggingService;

namespace BaseballECommerce.Core.Services;

public sealed class ServiceManager : IServiceManager
{
    private readonly Lazy<ICategoryService> _categoryService;
    private readonly Lazy<IProductService> _productService;

    public ServiceManager(IRepositoryManager repositoryManager, ILoggerManager logger)
    {
        _categoryService = new Lazy<ICategoryService>(() => new CategoryService(repositoryManager, logger));
        _productService = new Lazy<IProductService>(() => new ProductService(repositoryManager, logger));
    }

    public ICategoryService CategoryService => _categoryService.Value;
    public IProductService ProductService => _productService.Value;
}
