using System;
using Library;
using ClothShoping;
namespace Console_review
{
    class Program
    {
        public static void Main(string[] args)
        {
            SubscribeManager.MakeSubscription("demo", "Sirdemo", "1000000000", "5455455555");
            Shoes snicker = new();
            fileManager fl = new(@"File Operations\cities.txt");
            fl.CountryHasTopCity();


            Shoes
        }
    }
}