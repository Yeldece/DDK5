using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SqlWithEFCore.Models
{
    public class Customer
    {
        [Column(TypeName = "char(5)")]
        public string CustomerID { get; set; }
        [StringLength(40)]
        public string CompanyName { get; set; }
        [StringLength(30)]

        public string? forgot { get; set; }
        public string? Image { get; set; }
    }
}