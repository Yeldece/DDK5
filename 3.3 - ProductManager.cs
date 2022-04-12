using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
namespace Console_review
{
    class ProductManager
    {
        public List<Product> ProductList = new List<Product>();
        public async Task GetProducts()
        {
            using (var httpClient = new HttpClient())
            {
                var streamTask = httpClient.GetStreamAsync("https://northwind.vercel.app/api/products");
                ProductList = await JsonSerializer.DeserializeAsync<List<Product>>(await streamTask);
            }
        }
    }
}