using System;
using System.ComponentModel.DataAnnotations;
<<<<<<< HEAD:6. SqlWithFCore/Models/Category.cs
namespace SqlWithEFCore.Models
=======
using System.ComponentModel.DataAnnotations.Schema;
namespace SqlWithFCore.Models
>>>>>>> 3fbb6d3820012e881dc1dd5fdad1ebb5eb0874c2:SqlWithFCore/Models/Category.cs
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