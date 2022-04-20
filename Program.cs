using System;
using System.Threading.Tasks;
using System.Globalization;
using Library;
namespace Console_review
{
    class Program
    {
        static async Task Main(string[] args)
        {
            ProductManager pManager = new ProductManager();
            await pManager.GetProducts();
            await pManager.GetCategories();
            await pManager.GetOrders();
            pManager.GetTopSale(pManager.orderList);


        }
    }
}