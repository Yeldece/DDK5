using System;
using System.ComponentModel.DataAnnotations.Schema;
namespace MyWebApp.Models;
public class Employee
{
    public int EmployeeId { get; set; }
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Address { get; set; }
}