using System;
using System.ComponentModel.DataAnnotations;
<<<<<<< HEAD:6. SqlWithFCore/Models/Supplier.cs
namespace SqlWithEFCore.Models
=======
using System.ComponentModel.DataAnnotations.Schema;
namespace SqlWithFCore.Models
>>>>>>> 3fbb6d3820012e881dc1dd5fdad1ebb5eb0874c2:SqlWithFCore/Models/Supplier.cs
{
    public class Supplier
    {
        [Column(Order = 1)]
        public int SupplierID { get; set; }
        [Column(Order = 2)]
        [StringLength(40)]
        public string CompanyName { get; set; }
        [Column(Order = 3)]
        [StringLength(30)]
        public string? ContactName { get; set; }
        [Column(Order = 4)]
        [StringLength(30)]
        public string? ContactTitle { get; set; }
        [Column(Order = 5)]
        [StringLength(60)]
        public string? Address { get; set; }
        [Column(Order = 6)]
        [StringLength(15)]
        public string? City { get; set; }
        [Column(Order = 7)]
        [StringLength(15)]
        public string? Region { get; set; }
        [Column(Order = 8)]
        [StringLength(10)]
        public string? PostalCode { get; set; }
        [Column(Order = 9)]
        [StringLength(15)]
        public string? Country { get; set; }
        [Column(Order = 10)]
        [StringLength(24)]
        public string? Phone { get; set; }
        [Column(Order = 11)]
        [StringLength(24)]
        public string? Fax { get; set; }
        [Column(Order = 12, TypeName = "ntext")]
        public string? HomePage { get; set; }
    }
}