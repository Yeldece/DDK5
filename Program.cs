using System;
using System.Threading.Tasks;
using System.Globalization;
namespace Console_review
{
    class Program
    {
        static async Task Main(string[] args)
        {
            ProductManager pManager = new ProductManager();
            await pManager.GetProducts();
            List<Models.Product> productList = pManager.ProductList;
            var cultureInfo = new CultureInfo("en-US");
            DateTime dt = DateTime.ParseExact("1996-08-01 00:00:00.000", "yyyy-MM-dd HH:mm:ss.fff", cultureInfo);
        }
    }
}