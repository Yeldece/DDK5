using System;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
namespace SqlWithEFCore.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        [StringLength(40)]
        public string ProductName { get; set; }
        public int? SupplierID { get; set; }
        public int? CategoryID { get; set; }
        [StringLength(20)]
        public string? QuantityPerUnit { get; set; }
        public decimal? UnitPrice { get; set; }
        public short? UnitsInStock { get; set; }
        public short? UnitsOnOrder{ get; set; }
public short? ReorderLevel { get; set; }
public short Discontinued{ get; set; }
    }
}