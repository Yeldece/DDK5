using System;
namespace Console_review
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sayi giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int toplam = 0;
            for (int i = 0; i <= sayi; i++)
            {
                if (i % 2 == 0) toplam += i;
            }
            Console.WriteLine("sonuc " + toplam.ToString());
            Console.ReadKey();

        }
    }
}