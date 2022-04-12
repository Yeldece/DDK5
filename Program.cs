using System;
using System.Threading.Tasks;
namespace Console_review
{
    class Program
    {
        static async Task Main(string[] args)
        {
            ProductManager pManager = new ProductManager();
            await pManager.GetProducts();
            List<Product> productList = pManager.ProductList;
            //Fiyati 50'den kucuk kac adet urun var
            //How many product price are less than 50
            int countPriceLessFifty = productList.FindAll(x => x.unitPrice < 50).Count();
            //70

            // CategoryId si 3 ve SupplierId si 2 olan kaç adet ürün var?
            //How many of their catagoryId is = 3 and suplier = 2
            int answer2 = productList.FindAll(x => x.categoryId == 3 && x.supplierId == 2).Count();
            //1
            //Fiyatı 50-100 arasında kaç adet ürün var?
            //Price between 50 and 100
            int priceFiftyToHundred = productList.FindAll(x => x.unitPrice >= 50 && x.unitPrice < 100).Count();
            //5
            // İsmi a harfi ile başlayan ürünleri console a yazdır.
            //print out the product names which start with 'a'
            Product[] nameListStartsWithA = productList.FindAll(x => x.name.ToLower().StartsWith('a')).ToArray();
            foreach (Product p in nameListStartsWithA)
            {
                Console.WriteLine(p.name);
            }
            //İsminde a harfi geçen ürünleri ekrana yazdır
            //Product names which contain a
            var namesContainA = productList.FindAll(x => x.name.ToLower().Contains('a'));
            Console.WriteLine("Names which contain A");
            foreach (var p in namesContainA)
            {
                Console.WriteLine(p.name);
            }
            // Stok adedi 10 un altında kalan kaç ürün var?
            //How many of product's stock under 10
            int stockUnderTen = productList.FindAll(x => x.unitsInStock < 10).Count();
            //12
            // Stok adedi 10 un altında olan ürünleri console a yazdır.
            //Print the product names with stock under 10
            var stockUnderTenList = productList.FindAll(x => x.unitsInStock < 10).ToArray();
            Console.WriteLine("Warning! This products' stock under 10");
            foreach (var p in stockUnderTenList)
            {
                Console.WriteLine(p.name);
            }
            //Tüm ürünlerin ortalama fiyatı nedir?
            //What is the average price
            decimal avgPrice = productList.Average(x => x.unitPrice);
            // CategoryId si 3 olan ürünlerin ortalama fiyatı nedir?
            //What is the average price for catagory 3
            decimal avgPriceCatThree = productList.FindAll(x => x.categoryId == 3).Average(x => x.unitPrice);
        }
    }
}