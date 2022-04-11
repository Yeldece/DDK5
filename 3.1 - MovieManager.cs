using System;
using System.Collections.Generic;
namespace Console_review
{
    class MovieManager
    {
        //IMDB top 250 indir
        //Get IMDB top 250   
        public List<Movie> GetTop()
        {
            List<Movie> MovieList = new List<Movie>();
            using (var webClient = new System.Net.WebClient())
            {
                webClient.Headers.Add("Accept-Language", "en-us");
                string result = webClient.DownloadString("https://www.imdb.com/chart/top/");
                string tBody = "<tbody class=\"lister-list\">";
                int tbodyStartIndex = result.IndexOf(tBody);
                int tBodyEndIndex = result.IndexOf("</tbody>");
                int tbodyLength = result.Length - tbodyStartIndex;
                string tBodyContent = result.Substring(tbodyStartIndex + tBody.Length, (tBodyEndIndex - tbodyStartIndex));
                string[] trList = tBodyContent.Split("</tr>");
                foreach (var item in trList)
                {
                    string[] tdList = item.Split("</td>");
                    if (tdList.Length > 3)
                    {
                        string tdContent = tdList[1];
                        int nameStartPoint = tdContent.IndexOf(">", tdContent.IndexOf("<a")) + 1;
                        int nameEndPoint = tdContent.IndexOf("</a>");
                        string filmTitle = tdContent.Substring(nameStartPoint, nameEndPoint - nameStartPoint);
                        int yearStart = tdContent.IndexOf(">", tdContent.IndexOf("<span")) + 2;
                        int yearEnd = tdContent.LastIndexOf(")") - 1;
                        int year = Convert.ToInt32(tdContent.Substring(yearStart, yearEnd - yearStart + 1));
                        Movie movie = new Movie();
                        movie.Title = filmTitle;
                        movie.Year = year;
                        MovieList.Add(movie);
                    }
                }
            }
            return MovieList;
        }

        public void PrintMovieList(List<Movie> movieList)
        {
            if (movieList.Count() == 0)
            {
                Console.WriteLine("Sonuc Bulunamadi");
            }
            else
            {
                Console.WriteLine("Title\t\tYear");
                foreach (var item in movieList)
                {
                    Console.WriteLine($"{item.Title}\t\t{item.Year}");
                }
            }
        }
        //Film adi ile arama
        //Search by title
        public List<Movie> SearchByTitle(List<Movie> movieList, string title)
        {
            return movieList.FindAll(x => x.Title.Contains(title)).ToList();
        }

        //Yla ait filmleri arama
        //Search movie by year
        public List<Movie> SearchByYear(List<Movie> movieList, int year)
        {
            return movieList.FindAll(x => x.Year == year).ToList();
        }

        //Iki yil arasindaki filmleri bul
        //Filter between two year
        public List<Movie> FilterBetweenYears(List<Movie> movieList, int startYear, int endYear)
        {
            if (endYear < startYear)
            {
                int temp = startYear;
                startYear = endYear;
                endYear = temp;
            }
            return movieList.FindAll(x => x.Year >= startYear && x.Year <= endYear);
        }
    }
}