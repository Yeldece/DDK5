using System;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
<<<<<<< HEAD:6. SqlWithFCore/Models/Product.cs
namespace SqlWithEFCore.Models
=======
using System.ComponentModel.DataAnnotations.Schema;
namespace SqlWithFCore.Models
>>>>>>> 3fbb6d3820012e881dc1dd5fdad1ebb5eb0874c2:SqlWithFCore/Models/Product.cs
{
    public class Product
    {
        [Column(Order = 1)]
        public int ProductID { get; set; }
        [Column(Order = 2)]
        [StringLength(40)]
        public string ProductName { get; set; }
        [Column(Order = 3)]
        public int? SupplierID { get; set; }
        public Supplier Supplier { get; set; }
        [Column(Order = 4)]
        public int? CategoryID { get; set; }
        public Category category { get; set; }
        [Column(Order = 5)]
        [StringLength(20)]
        public string? QuantityPerUnit { get; set; }
        [Column(Order = 6, TypeName = "money")]
        public decimal? UnitPrice { get; set; }
        [Column(Order = 7)]
        public short? UnitsInStock { get; set; }
        [Column(Order = 8)]
        public short? UnitsOnOrder { get; set; }
        [Column(Order = 9)]
        public short? ReorderLevel { get; set; }
        [Column(Order = 10, TypeName = "bit")]
        public bool Discontinued { get; set; }
    }
}