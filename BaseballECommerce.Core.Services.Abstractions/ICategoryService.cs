﻿using Shared.DataTransferObjects;

namespace BaseballECommerce.Core.Services.Abstractions;

public interface ICategoryService
{
    IEnumerable<CategoryDto> GetAllCategories(bool trackChanges);
}
