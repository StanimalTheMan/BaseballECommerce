namespace BaseballECommerce.Core.Services.Abstractions;

public interface IServiceManager
{
    ICategoryService CategoryService { get; }
    IProductService ProductService { get; }
}
