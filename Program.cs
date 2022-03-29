using System;
namespace Console_review
{
    class Program
    {
        static void soru6()
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
        static void soru5()
        {
            List<int> canDivide = new List<int>();
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0 && i % 3 == 0) canDivide.Add(i);
            }
            Console.WriteLine(canDivide.Count.ToString());
        }
        static void soru7()
        {
            int sayi = Convert.ToInt32(Console.ReadLine());
            for (int i = 1, j = 1; i <= sayi; j++)
            {
                if (j <= sayi)
                {
                    Console.Write("*");
                }
                else if (j > sayi)
                {
                    i++;
                    j = 1;
                    Console.WriteLine();
                }
            }

            Console.WriteLine();
        }
        static void soru8()
        {
            Console.WriteLine("Carpilacak iki sayiyi giriniz");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            int total = 0;
            for (int i = 1; i <= sayi2; i++)
            {
                total += sayi1;
            }
            Console.WriteLine(total.ToString());
        }
        static void soru9()
        {
            int sayi = Convert.ToInt32(Console.ReadLine());
            int toplam = 0;
            for (int i = 1; i <= sayi; i++)
            {
                toplam += i * i;
            }
            Console.WriteLine(toplam.ToString());
        }
        static void soru10()
        {
            double price = Convert.ToDouble(Console.ReadLine());
            if (price > 200)
            {
                price -= (price * 10 / 100);
            }
            price *= 1.18;
            Console.WriteLine(price.ToString());
        }
        static void sorArray()
        {
            int[] array = { 5, 2, 3, 4, 1 };
            foreach (int i in array)
            {
                Console.WriteLine(i.ToString());
            }
        }
        static void soru13()
        {
            int[] array = { 22, 41, 13, 52, 73 };
            int total = 0;
            foreach (int i in array)
            {
                total += i;
            }
            Console.WriteLine(total.ToString());
        }
        static void soru11()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = i; j >= 1; j--)
                {
                    if (j == 1)
                    {
                        Console.Write(j.ToString());
                    }
                    else
                    {
                        Console.Write(j.ToString() + " ");
                    }
                }
                Console.WriteLine();
            }
        }
        static void soru12()
        {
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());
            int n3 = Convert.ToInt32(Console.ReadLine());
            if (n1 < n2 && n1 < n3)
            {
                Console.WriteLine("En kucuk sayi: " + n1.ToString());
            }
            else if (n2 < n1 && n2 < n3)
            {
                Console.WriteLine("en kucuk sayi " + n2.ToString());
            }
            else
            {
                Console.WriteLine("En kucuk sayi: " + n3.ToString());
            }

        }
        static void randomGuessGame()
        {
            Random rand = new Random();
            int goal = rand.Next(1, 101);
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("tahmin giriniz, " + i.ToString() + "hakkiniz kaldi.");
                int guess = Convert.ToInt32(Console.ReadLine());

            }
        }
        static void findSmallestInAnArray()
        {
            int[] array = { 73, 12, 81, 2, 25, 91, 9, 32 };
            int smallest = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (smallest > array[i])
                {
                    smallest = array[i];
                }
            }
            Console.WriteLine("EN kucuk sayi: " + smallest.ToString());
        }
        static void loto()
        {
            int[] lotodizi = new int[6];
            Random rand = new Random();
            for (int i = 0; i < 6; i++)
            {
                int num = rand.Next(1, 50);
                for (int j = 0; j < lotodizi.Length; j++)
                {
                    if (lotodizi[j] == num)
                    {
                        i--;
                        break;
                    }
                }
                lotodizi[i] = num;
            }
            foreach (int i in lotodizi)
            {
                Console.Write(i.ToString() + ", ");
            }
        }
        static void soru17()
        {
            int[] array = { 98, -8, 12, -83, 23 };
            foreach (int i in array)
            {
                if (i > 0)
                {
Console.Write(i.ToString());
                }
            }
Console.WriteLine();
        }
        static void Main(string[] args)
        {
            loto(); Console.ReadKey();
        }
    }
}