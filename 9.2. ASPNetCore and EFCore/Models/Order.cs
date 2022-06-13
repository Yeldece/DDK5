using System;
namespace MyWebApp.Models;
public class Order
{
    public int OrderId { get; set; }
    public DateTime OrderDate { get; set; }
    public DateTime RequiredDate { get; set; }
    public string CompanyName { get; set; }
    public string Address { get; set; }
}