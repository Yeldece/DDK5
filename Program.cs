using System;
namespace Console_review
{
    class Program
    {
        static void yildizcizme()
        {
            Console.WriteLine("Sayi giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            string filler = "*";
            for (int i = 1; i <= sayi; i++)
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

        }
        static void soru1()
        {
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            if (sayi1 == sayi2)
            {
                Console.WriteLine("hata, sayilar farkli olmali!");
                return;
            }
            else if (sayi1 > sayi2)
            {
                int temp = sayi1;
                sayi1 = sayi2;
                sayi2 = temp;
            }
            int topllam = 0, i = sayi1;
            while (i <= sayi2)
            {
                topllam += i;
                i++;
            }
            Console.WriteLine(topllam.ToString());
        }
        static void soru2()
        {
            int sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi <= 0)
            {
                Console.WriteLine("hatali sayi, 0 dan buyuk olmeli");
            }
            for (; sayi >= 0; sayi--)
            {
                Console.WriteLine(sayi.ToString());
            }
        }
        static void soru3()
        {
            int[] sayilar = new int[3];
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine("sayiyigirin: ");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }
            int adet = 0;
            foreach (int i in sayilar)
            {
                if (i > 10) adet += 1;
            }
            Console.WriteLine("Sonuc: " + adet.ToString());
        }
        static void soru4()
        {
            List<int> canDivide = new List<int>();
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0 && i % 3 == 0) canDivide.Add(i);
            }
            foreach (int i in canDivide)
            {
                Console.Write(i.ToString() + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            soru4();
            Console.ReadKey();

        }
    }
}