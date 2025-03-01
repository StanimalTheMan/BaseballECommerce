using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace BaseballEcommerce.Core.Domain.Entities;

public class Category
{
    [Column("CategoryId")]
    public Guid Id { get; set; }

    [Required(ErrorMessage = "Category name is a required field.")]
    [MaxLength(60, ErrorMessage = "Maximum length for the Name is 60 characters.")]
    public string? Name { get; set; }

    public ICollection<Product>? Products { get; set; }
}