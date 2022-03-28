using System;
namespace Console_review
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hangi sayiya kadar toplanacak? ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int toplam = 0;
            for (int i = 0; i <= sayi; i++)
            {
                toplam += i;
            }
            Console.WriteLine("sonuc " + toplam.ToString());
            Console.ReadKey();

        }
    }
}