using System;
using System.Collections.Generic;
using System.Linq;
namespace Console_review
{
    class ListeSorulari
    {
        static void Soru1()
        {
            List<string> Words = new List<string>();
            while (Words.Count < 11)
            {
                Console.WriteLine("Kelime giriniz veya baslamak icin `start`");
                string input = Console.ReadLine().Trim().ToLower();
                if (input == "start")
                {
                    break;
                }
                else if (!String.IsNullOrEmpty(input) && input.Length > 2 && !Words.Contains(input))
                {
                    Words.Add(input);
                }
                else
                {
                    Console.WriteLine("Girdide hata");
                }
            }
            Random rnd = new Random();
            string Word = Words[rnd.Next(0, Words.Count)];
            char[] WordChar = new char[Word.Length];
            Array.Fill(WordChar, '-');
            int TryChance = 10;
            while (TryChance > 0 && WordChar.Contains('-'))
            {
                Console.WriteLine(String.Join("", WordChar));
                Console.WriteLine("Tahmin harfi giriniz");
                string Guess = Console.ReadLine().Trim().ToLower();
                if (Guess.Length == 1 && Char.IsLetter(Convert.ToChar(Guess)))
                {
                    if (Word.IndexOf(Guess) != -1)
                    {
                        int i = Word.IndexOf(Guess);
                        int Total = 0;
                        do
                        {
                            WordChar[i] = Convert.ToChar(Guess);
                            i = Word.IndexOf(Guess, i + 1);
                            Total++;
                        } while (i != -1);
                        Console.WriteLine($"tebrikler {Total} adet bulundu");
                    }
                    else
                    {
                        TryChance--;
                        Console.WriteLine($"Bulunamadi, kalan hak {TryChance}");
                    }
                }
                else
                {
                    Console.WriteLine("Girdide hata var, tekrar deneyin");
                }
            }
            if (TryChance == 0)
            {
                Console.WriteLine($"Elendiniz! Dogru cevap {Word}");
            }
            else
            {
                Console.WriteLine($"Tebrikler, Kelime {Word}");
            }

        }
        #region Soru2
        //Imdb den top 250 listesini cekmek,
        //kod sahibi github.com/yakintek
        static void Soru2()
        {
            List<string> films = new List<string>();

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
                        for (int i = 0; i < tdList.Length; i++)
                        {
                            //i == 1 se yani 2. hücreye geçtiysem ( Film ismini oradan alacağım.)
                            if (i == 1)
                            {
                                string tdContent = tdList[i];
                                int aEnd = tdContent.IndexOf("</a>");

                                string filmSubContent = tdContent.Substring(0, aEnd);
                                int upperLastIndex = filmSubContent.LastIndexOf(">") + 1;
                                string filmTitle = filmSubContent.Substring(upperLastIndex, filmSubContent.Length - upperLastIndex);
                                films.Add(filmTitle);
                            }
                        }
                    }
                }
            }
            //1) Kullanıcın ekrandan girdiği adede göre film göstereceğim. Yani kullanıcı 10 girerse SADECE ilk 10 film gösterilecek
            //Console.WriteLine("Lütfen gösterilmesini istediğiniz film adedini giriniz!");
            //int showCount = Convert.ToInt32(Console.ReadLine());
            //Take metodu bana alınacak data sayısını söyler.
            // List<string> showFilms = films.Take(showCount).ToList();
            //2)  Listede 10lu bir sayfalama olduğunu var sayıyorum. Kullanıcı dışarıdan sayfa sayısını girdiğinde o sayfa sayısına ait filmleri göstereceğim.
            //Console.WriteLine("Lütfen kaçıncı sayfayı görmek istediğinizi belirtiniz!");
            //int pageNumber = Convert.ToInt32(Console.ReadLine());
            //List<string> showFilms = films.Skip(10).Take(10).ToList();
            // Kullanıcı aradığı filmi girsin. İçerisinde o kelime geçenleri listele
            Console.WriteLine("Lütfen aradığınız filmi belirtiniz!");
            string searchWord = Console.ReadLine().ToLower();
            List<string> showFilms = films.Where(q => q.ToLower().Contains(searchWord)).ToList();

            foreach (var item in showFilms)
            {
                Console.WriteLine(item);
            }
        }
        #endregion
        //keyinfo
        static void keyinfo()
        {
            ConsoleKeyInfo inf;
            do
            {
                inf = Console.ReadKey();
                Console.WriteLine(inf.Key + " was pressed");
            } while (true);
        }
        #region DersSoru1
        //ders ici soru 1 rastgele numara ata
        static List<int> DersSoru1()
        {
            ///<summary>///
            /// returns List{int} with 100 unique integer from 1 to 1000///
            //<summary>///
            List<int> Nums = new List<int>();
            Random rnd = new Random();
            for (int i = 0; i < 100; i++)
            {
                int RandInt = rnd.Next(-1000, 1001);
                if (!Nums.Contains(RandInt))
                {
                    Nums.Add(RandInt);
                }
                else
                {
                    i--;
                }
            }
            return Nums;
        }
        #endregion
        #region  DersSoru3
        //Sayilarin ortalamasi
        static double DersSoru3()
        {
            List<int> Nums = DersSoru1();
            int Total = 0;
            foreach (int i in Nums)
            {
                Total += i;
            }
            return (double)Total / Nums.Count;
        }
        #endregion
        //Sayilari ekrana bas
        static void DersSoru4()
        {
            List<int> Nums = DersSoru1();
            for (int i = 0; i < Nums.Count; i++)
            {
                Console.Write($"{Nums[i]} ");
                if (i % 10 == 0)
                {
                    Console.WriteLine();
                }
            }
        }
        static void DersSoru5()
        {
            List<int> Nums = DersSoru1().OrderBy(x => x).ToList();
            for (int i = 0; i < Nums.Count; i++)
            {
                Console.Write($"{Nums[i]} ");
                if (i % 20 == 0)
                {
                    Console.WriteLine();
                }
            }
        }
        static void DersSoru9()
        {
            List<int> Nums = DersSoru1().Where(x => x >= 50 && x <= 70).ToList();
            for (int i = 0; i < Nums.Count; i++)
            {
                Console.Write($"{Nums[i]} ");
                if (i % 20 == 0)
                {
                    Console.WriteLine();
                }
            }
        }
        static void Main(string[] args)
        {
            DersSoru9();
            Console.Read();
        }
    }
}