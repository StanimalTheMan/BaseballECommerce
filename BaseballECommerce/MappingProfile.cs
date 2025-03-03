using AutoMapper;
using BaseballEcommerce.Core.Domain.Entities;
using Shared.DataTransferObjects;

namespace BaseballECommerce;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Category, CategoryDto>();
        CreateMap<Product, ProductDto>();
    }
}
