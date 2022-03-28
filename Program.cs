using System;
namespace Console_review
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sayi giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            string filler = "*";
            for (int i = 1; i <= sayi; i ++)
            {
                Console.Write("*");
                if (i == 1 || i == sayi)
                {
                    filler = "*";
                }
                else
                {
                    filler = " ";
                }
                for (int j = 2; j < sayi; j++) { Console.Write(filler); }
                Console.Write("*");
                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}