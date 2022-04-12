using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Console_review.Models;
namespace Console_review
{
    class ProductManager
    {
        public List<Product> ProductList = new List<Product>();
        public List<Models.Category> categoryList = new List<Category>();
        public List<Models.Order> orderList = new List<Order>();
        //Get json from the website and fill the list
        public async Task GetProducts()
        {
            using (var httpClient = new HttpClient())
            {
                var streamTask = httpClient.GetStreamAsync("https://northwind.vercel.app/api/products");
                ProductList = await JsonSerializer.DeserializeAsync<List<Product>>(await streamTask);
            }
        }
        //Get categories from the website and fill the list
        public async Task GetCategories()
        {
            using (var httpClient = new HttpClient())
            {
                var getStream = httpClient.GetStreamAsync("https://northwind.vercel.app/api/categories");
                categoryList = await JsonSerializer.DeserializeAsync<List<Models.Category>>(await getStream);
            }
        }
        //Get ORders from the website and fill the list
        public async Task GetOrders()
        {
            using (var httpClient = new HttpClient())
            {
                var getStream = httpClient.GetStreamAsync("https://northwind.vercel.app/api/orders");
                orderList = await JsonSerializer.DeserializeAsync<List<Models.Order>>(await getStream);
            }

        }
    }
}