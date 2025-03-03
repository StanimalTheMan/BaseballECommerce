using Shared.DataTransferObjects;

namespace BaseballECommerce.Core.Services.Abstractions;

public interface IProductService
{
    IEnumerable<ProductDto> GetProducts(Guid categoryId, bool trackChanges);
}
