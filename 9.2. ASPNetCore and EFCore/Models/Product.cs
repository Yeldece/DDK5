using System.ComponentModel.DataAnnotations.Schema;
namespace MyWebApp.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        [Column(TypeName = "nvarchar(40)")]
        public string ProductName { get; set; }
        [Column("UnitPrice", TypeName = "real")]
        public decimal? Cost { get; set; }
        [Column("UnitsInStock")]
        public short? Stock { get; set; }
        public bool Discontinued { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}