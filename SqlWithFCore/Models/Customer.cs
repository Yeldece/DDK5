using System;
using System.ComponentModel.DataAnnotations;
namespace SqlWithFCore.Models
{
    public class Customer
    {
        [Colomn(type = "char(5)")]
        public string CustomerID { get; set; }
        [StringLength(40)]
        public string CompanyName { get; set; }
        [StringLength(30)]

        public string?  { get; set; }
    public string? Image { get; set; }
}
}