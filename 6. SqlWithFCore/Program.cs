using System;
using System.Collections.Generic;
using System.Linq;
using SqlWithEFCore.Models;
namespace SqlWithEFCore
{
    /// <summary>
    /// 
    /// </summary>
    class Program
    {
        /// <summary>
        /// entry point for the Program
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            NorthWindContext NorthWind = new();
            Category Drinks = new Category
            {
                CategoryName = "Drinks",
                Description = "All kind of drinks hot, cold"
            };

            //Add Category into table
            NorthWind.Categories.Add(Drinks);

            Supplier Thief = new Supplier
            {
                CompanyName = "Thief a.s",
                ContactName = "Super Theif",
                Country = "Nowhere"
            };

            NorthWind.Suppliers.Add(Thief);

            //Save changes into databse
            NorthWind.SaveChanges();
            Product Chai = new Product
            {
                ProductName = "Chai",
                SupplierID = 1,
                CategoryID = 1,
                QuantityPerUnit = "5",
                UnitPrice = 50,
                UnitsInStock = 5,
                UnitsOnOrder = 5,
                ReorderLevel = 3,
                Discontinued = false
            };
            NorthWind.Products.Add(Chai);
            NorthWind.SaveChanges();
            List<Product> Products = NorthWind.Products.ToList();
            List<Category> categories = new List<Category>() { new Category { CategoryName = "Phones", Description = "All kind of phones" }, new Category { CategoryName = "Tablets" }, new Category { CategoryName = "Laptops" }, new Category { CategoryName = "notebooks" } };
            NorthWind.Categories.AddRange(categories);
            NorthWind.SaveChanges();

            List<Supplier> suppliers = new List<Supplier>() { new Supplier { CompanyName = "Exportos", ContactName = "Mave Amoon" }, new Supplier { CompanyName = "Iron Extractorotos", ContactName = "Rock Broker" }, new Supplier { CompanyName = "How do you know", ContactName = "Burner Eriz" }, new Supplier { CompanyName = "Drinkitor", ContactName = "Whorner Shard" }, new Supplier { CompanyName = "Elaf Marenish", ContactName = "Elor Meranas" }, new Supplier { CompanyName = "Once Goal", ContactName = "Naren Oznel" } };
            NorthWind.AddRange(suppliers);

            NorthWind.SaveChanges();

            //Get all Suppliers
            List<Supplier> allSuppliers = NorthWind.Suppliers.ToList();
            //Write all supplier's CompanyName into console
            foreach (var supplier in allSuppliers)
            {
                Console.WriteLine(supplier.CompanyName);
            }

            //Print last Supplier's CompanyName into console
            Console.WriteLine(allSuppliers[^1].CompanyName);

            //Update a Supplier
            NorthWind.Suppliers.FirstOrDefault(x => x.CompanyName.ToLower().Contains("thief")).City = "Denowhere";
            int Affected = NorthWind.SaveChanges();

            //Delete a Supplier
            var thiefToDelete = NorthWind.Suppliers.FirstOrDefault(x => x.CompanyName.ToLower().Contains("thief"));
            if (thiefToDelete != null)
            {
                NorthWind.Suppliers.Remove(thiefToDelete);
            }

        }
    }
}