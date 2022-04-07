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
        static void Main(string[] args)
        {
            string dataSample = "ÇAğatay vesairere * Siemens * falanlar filanlar";
            string x = dataSample.Substring(dataSample.IndexOf('*') + 1, dataSample.IndexOf('*', dataSample.IndexOf('*') + 1) - dataSample.IndexOf('*') - 1);
            Soru1();
            Console.Read();
        }
    }
}