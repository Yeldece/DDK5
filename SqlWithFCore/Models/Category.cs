using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SqlWithFCore.Models
{
    public class Category
    {
        [Column(Order =0)]
        public int CategoryID { get; set; }
        [Column(Order =1)]
        [StringLength(15)]
        public string CategoryName { get; set; }
        [Column(Order =2,TypeName ="ntext")]
        public string? Description { get; set; }
        [Column(Order =3,TypeName ="image")]
        public string? Picture { get; set; }
    }
}