using System.ComponentModel.DataAnnotations.Schema;
namespace MyWebApp.Models;
public class Category
{
    public int CategoryId { get; set; }
    public string? CategoryName { get; set; }
    [Column(TypeName = "ntext")]
    public string? Description { get; set; }
    //define a navigation property
    public virtual ICollection<Product> Products { get; set; }
    public Category()
    {
        Products = new HashSet<Product>();
    }
}