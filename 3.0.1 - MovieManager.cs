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
                        string tdTitle = tdList[1];
                        int nameStartPoint = tdTitle.IndexOf(">", tdTitle.IndexOf("<a")) + 1;
                        int nameEndPoint = tdTitle.IndexOf("</a>");
                        string filmTitle = tdTitle.Substring(nameStartPoint, nameEndPoint - nameStartPoint);
                        int yearStart = tdTitle.IndexOf(">", tdTitle.IndexOf("<span")) + 2;
                        int yearEnd = tdTitle.LastIndexOf(")") - 1;
                        int year = Convert.ToInt32(tdTitle.Substring(yearStart, yearEnd - yearStart + 1));
                        //float rating=Convert.ToDouble(tdList[2].Substring(tdList[2].IndexOf(">",tdList[2].IndexOf("<strong"))));
                        int ratingStart = tdList[2].IndexOf("ratings\">");
                        string rating = tdList[2].Substring(ratingStart + 9, tdList[2].LastIndexOf("</strong>") - 9 - ratingStart);
                        Movie movie = new Movie();
                        movie.Title = filmTitle;
                        movie.Year = year;
                        movie.Rating = (float)Convert.ToDouble(rating);
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
                Console.WriteLine("Title\t\tYear\tRating");
                movieList = movieList.OrderBy(x => x.Rating).ToList();
                foreach (var item in movieList)
                {
                    Console.WriteLine($"{item.Title}\t\t{item.Year}\t{item.Rating,0:F1}");
                }
            }
        }
        #region Soru1
        //Film adi ile arama
        //Search by title
        public List<Movie> SearchByTitle(List<Movie> movieList, string title)
        {
            return movieList.FindAll(x => x.Title.Contains(title)).ToList();
        }
        #endregion
        #region Soru2
        //Yla ait filmleri arama
        //Search movie by year
        public List<Movie> SearchByYear(List<Movie> movieList, int year)
        {
            return movieList.FindAll(x => x.Year == year).ToList();
        }
        #endregion
        #region Soru3
        //Iki yil arasindaki filmleri bul
        //Filter between two year
        public List<Movie> FilterBetweenYears(List<Movie> movieList, int startYear, int endYear)
        {
            return movieList.FindAll(x => x.Year >= startYear && x.Year <= endYear);
        }
        #endregion
        #region Soru4
        //Filmlerin rating ortalamasini donduren method
        //Average of the ratings
        public float GetAverageRating(List<Movie> movieList)
        {
            return movieList.Average(x => x.Rating);
        }
        #endregion
        #region Soru5
        //Iki rating arasinda kac film var
        //How many movies between two rating
        public int GetNumBetweenRating(List<Movie> movieList, double startRating, double endRating)
        {
            return movieList.FindAll(x => x.Rating >= startRating && x.Rating <= endRating).Count();
        }
        #endregion
        #region Soru6
        //Iki rating arasindaki filmleri filtrele
        //Filter movies between two rating
        public List<Movie> FilterBetweenRating(List<Movie> movieList, double startRating, double endRating)
        {
            return movieList.FindAll(x => x.Rating >= startRating && x.Rating <= endRating);
        }
        #endregion
    }
}