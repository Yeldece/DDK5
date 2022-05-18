using System;
using System.ComponentModel.DataAnnotations;
namespace SqlWithFCore.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        [StringLength(15)]
        public string CategoryName { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
    }
}