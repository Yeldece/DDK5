using System;
using System.ComponentModel.DataAnnotations;
<<<<<<< HEAD:6. SqlWithFCore/Models/Employee.cs
namespace SqlWithEFCore.Models
=======
using System.ComponentModel.DataAnnotations.Schema;
namespace SqlWithFCore.Models
>>>>>>> 3fbb6d3820012e881dc1dd5fdad1ebb5eb0874c2:SqlWithFCore/Models/Employee.cs
{
    public class Employee
    {
        [Column(Order = 0)]
        public int EmployeeID { get; set; }
        [Column(Order = 1)]
        [StringLength(20)]
        public string LastName { get; set; }
        [StringLength(10)]
        public string FirstName { get; set; }
        [Column(Order = 3)]
        [StringLength(30)]
        public string? Title { get; set; }
        [Column(Order = 4)]
        [StringLength(25)]
        public string? TitleOfCourtesy { get; set; }
        [Column(Order = 5, TypeName = "datetime")]
        public DateTime? BirthDate { get; set; }
        [Column(Order = 6, TypeName = "datetime")]
        public DateTime? HireDate { get; set; }
        [Column(Order = 7)]
        [StringLength(60)]
        public string? Address { get; set; }
        [Column(Order = 8)]
        [StringLength(15)]
        public string? City { get; set; }
        [Column(Order = 9)]
        [StringLength(15)]
        public string? Region { get; set; }
        [Column(Order = 10)]
        [StringLength(10)]
        public string? PostalCode { get; set; }
        [Column(Order = 11)]
        [StringLength(15)]
        public string? Country { get; set; }
        [Column(Order = 12)]
        [StringLength(24)]
        public string? HomePhone { get; set; }
        [Column(Order = 13)]
        [StringLength(4)]
        public string? Extension { get; set; }
        [Column(Order = 14, TypeName = "image")]
        public string? Photo { get; set; }
        [Column(Order = 17)]
        [StringLength(255)]
        public string? PhotoPath { get; set; }
        [Column(Order = 15, TypeName = "ntext")]
        public string? Notes { get; set; }
        [Column(Order = 16)]
        public int? ReportsTo { get; set; }
    }
}