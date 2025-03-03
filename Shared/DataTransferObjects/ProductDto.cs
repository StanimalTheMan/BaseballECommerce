namespace Shared.DataTransferObjects;

public record ProductDto(Guid id, string Name, string Description, double ListPrice, string ImageUrl, int StockQuantity);
