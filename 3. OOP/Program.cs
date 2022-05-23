using System;
namespace Console_review
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            MovieManager mvg = new MovieManager();
            var list = await mvg.GetTop();
            Console.Read();
        }
    }
}