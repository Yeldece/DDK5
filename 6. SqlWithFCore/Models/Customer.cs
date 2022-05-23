using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
<<<<<<< HEAD:6. SqlWithFCore/Models/Customer.cs
namespace SqlWithEFCore.Models
{
    public class Customer
    {
        [Column(TypeName = "char(5)")]
=======
using Microsoft.EntityFrameworkCore;
namespace SqlWithFCore.Models
{
    public class Customer
    {
        [Column(TypeName = "char(5)", Order = 0)]
>>>>>>> 3fbb6d3820012e881dc1dd5fdad1ebb5eb0874c2:SqlWithFCore/Models/Customer.cs
        public string CustomerID { get; set; }
        [Column(Order = 1)]
        [MaxLength(40)]
        public string CompanyName { get; set; }
<<<<<<< HEAD:6. SqlWithFCore/Models/Customer.cs
        [StringLength(30)]

        public string? forgot { get; set; }
        public string? Image { get; set; }
=======
        [Column(Order = 2)]
        [MaxLength(30)]
        public string? ContactName { get; set; }
        [Column(Order = 3)]
        [MaxLength(30)]
        public string? ContactTitle { get; set; }
        [Column(Order = 4)]
        [MaxLength(60)]
        public string? Address { get; set; }
        [Column(Order = 5)]
        [MaxLength(15)]
        public string? City { get; set; }
        [Column(Order = 6)]
        [MaxLength(15)]
        public string? Region { get; set; }
        [Column(Order = 7)]
        [MaxLength(10)]
        public string? PostalCode { get; set; }
        [Column(Order = 8)]
        [MaxLength(15)]
        public string? Country { get; set; }
        [Column(Order = 9)]
        [MaxLength(24)]
        public string? Phone { get; set; }
        [Column(Order = 10)]
        [MaxLength(24)]
        public string? Fax { get; set; }
>>>>>>> 3fbb6d3820012e881dc1dd5fdad1ebb5eb0874c2:SqlWithFCore/Models/Customer.cs
    }
}