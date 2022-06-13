using System;
using Microsoft.AspNetCore.Mvc;
using MyWebApp.Models;

namespace MyWebApp.Controllers;
public class OrderController : Controller
{
    private Northwind NWContext = new();
    [HttpGet]
    public IActionResult Index()
    {

        var OrderList = NWContext.Orders.ToArray();
        if (OrderList.Length == 0)
        {
            return View();
        }
        return View(OrderList);
    }
    [HttpGet]
    public IActionResult Add()
    {
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> Add(Order Order)
    {
        NWContext.Orders.Add(Order);
        await NWContext.SaveChangesAsync();
        return Redirect("/order");
    }

    [HttpGet]
    [Route("/order/{id}")]
    public async Task<IActionResult> Update(int id)
    {
        if (id == null)
        {
            return BadRequest();
        }
        var Order = await NWContext.Orders.FindAsync(id);
        if (Order == null)
        {
            return NotFound();
        }
        return View(Order);
    }
    [HttpPost]
    [Route("/order/{id}")]
    public IActionResult Update(int id, Order Order)
    {
        if (id != Order.OrderId)
        {
            return BadRequest();
        }
        NWContext.Orders.Update(Order);
        NWContext.SaveChanges();
        return Redirect("/order");
    }
}