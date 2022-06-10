using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using MyWebApp.Models;
namespace MyWebApp.Controllers
{
    public class HomeController : Controller
    {
        Northwind NorthwindContext = new();
        [HttpGet]
        public IActionResult Index()
        {
            List<Product> Products = NorthwindContext.Products.ToList();
            return View(Products);
        }
        public IActionResult Detail(int id)
        {
            Product Product = NorthwindContext.Products.Include(x => x.Category).FirstOrDefault(x => x.ProductId == id);
            return View(Product);
        }
        [HttpGet]
        public IActionResult add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Product newProduct)
        {
            var existingCategory = NorthwindContext.Categories.FirstOrDefault(x => x.CategoryId == newProduct.CategoryId);
            if (existingCategory != null)
            {
                newProduct.CategoryId = 1;
            }
            NorthwindContext.Products.Add(newProduct);
            NorthwindContext.SaveChanges();
            return View();
        }
    }
}