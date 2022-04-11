using System;
namespace Console_review
{
    class Program
    {
        static void Main(string[] args)
        {
            MovieManager mvManager = new MovieManager();
            // Console.WriteLine("Enter a start year for filtering Imdb top 250: ");
            // int startingYear = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Enter an ending year for filter: ");
            // int endingYear = Convert.ToInt32(Console.ReadLine());
            //            mvManager.PrintMovieList(mvManager.FilterBetweenYears(mvManager.GetTop(), startingYear, endingYear));
            //mvManager.PrintMovieList(mvManager.GetTop());
            Console.WriteLine(mvManager.GetNumBetweenRating(mvManager.GetTop(), 0, 10));
            mvManager.PrintMovieList(mvManager.FilterBetweenRating(mvManager.GetTop(), 9.0, 9.5));
        }
    }
}