namespace BaseballEcommerce.Core.Domain.Repositories;


public interface IRepositoryManager
{
    ICategoryRepository Category { get; }
    IProductRepository Product { get; }
    void Save();
}
