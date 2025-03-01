using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BaseballEcommerce.Core.Domain.Entities;

public class Product
{
    [Column("ProductId")]
    public Guid Id { get; set; }

    [Required(ErrorMessage = "Product name is a required field.")]
    [MaxLength(100, ErrorMessage = "Maximum length for the Name is 100 characters.")]
    public string? Name { get; set; }

    [Required(ErrorMessage = "Product description is a required field.")]
    public string Description { get; set; }

    [Required]
    [Display(Name = "Product Price")]
    [Range(1, 1000)]
    public double ListPrice { get; set; }

    [ForeignKey(nameof(Category))]
    public Guid CategoryId { get; set; }
    public Category? Category { get; set; }

    // url: how to store images of products? as string urL?
}
