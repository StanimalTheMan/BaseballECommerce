using BaseballECommerce.Core.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace BaseballECommerce.Infrastructure.Presentation.Controllers;

[Route("api/categories/{categoryId}/products")]
[ApiController]
public class ProductsController : ControllerBase
{
    private readonly IServiceManager _service;
    public ProductsController(IServiceManager service) => _service = service;

    [HttpGet]
    public IActionResult GetProductsForCategory(Guid categoryId)
    {
        var products = _service.ProductService.GetProducts(categoryId, trackChanges: false);

        return Ok(products);
    }
}
