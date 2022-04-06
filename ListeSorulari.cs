using System;
using System.Collections.Generic;
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
                string input = Console.ReadLine();
                if (input.ToLower() == "start")
                {
                    break;
                }
                else if (!String.IsNullOrEmpty(input) && input.Length > 2 && Words.Contains(input))
                {
                    Words.Add(input);
                }
            }
            Random rnd = new Random();
            string Word = Words[rnd.Next(0, 10)];
            int TryChance = 10;
            while (TryChance > 0)
            {

            }
        }
    }
}