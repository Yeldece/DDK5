using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Console_review.Modals;
using System.Globalization;
namespace Console_review
{
    class ProductManager
    {
        public List<Product>? ProductList = new List<Product>();
        public List<Modals.Category>? categoryList = new List<Category>();
        public List<Modals.Order>? orderList = new List<Order>();
        //public List<Models.Root> rootList = new List<Root>();
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
                categoryList = await JsonSerializer.DeserializeAsync<List<Modals.Category>>(await getStream);
            }
        }
        //Get Orders from the website and fill the list
        public async Task GetOrders()
        {
            using (var httpClient = new HttpClient())
            {
                var getStream = httpClient.GetStreamAsync("https://northwind.vercel.app/api/orders");
                orderList = await JsonSerializer.DeserializeAsync<List<Modals.Order>>(await getStream);
                //rootList = await JsonSerializer.DeserializeAsync<List<Models.Root>>(await getStream);
            }
            CultureInfo cultureInfo = new CultureInfo("en-US");
            foreach (var order in orderList!)
            {
                order.OrderDateInDate = DateTime.ParseExact(order!.OrderDate!, "yyyy-MM-dd HH:mm:ss.fff", cultureInfo);
            }
        }
        public void GetTopSale(List<Order> orderList)
        {

        }
    }
}