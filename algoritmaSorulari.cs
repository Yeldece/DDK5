using System;
namespace Console_review
{
    class AlgoritmaSorulari
    {
        #region Soru1
        //10 kez Hello world!
        static void Soru1()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Hello World!");
            }
        }
        #endregion
        #region  Soru2
        //Girilen sayiya kadar olan cift sayilar
        static void Soru2()
        {
            Console.WriteLine("Bir sayi giriniz: ");
            int Num = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i < Num; i += 2)
            {
                Console.Write(i.ToString() + " ");
            }
        }
        #endregion
        #region  Soru3
        // Girilen sayiyi tersten yazin
        static void Soru3()
        {
            Console.WriteLine("Bir sayi giriniz");
            //sayinin int olduguna eminiz
            string Num = Console.ReadLine();
            string ReversedNum = "";
            for (int i = Num.Length - 1; i >= 0; i--)
            {
                ReversedNum += Num[i];
            }
            Console.WriteLine(ReversedNum);
        }
        #endregion
        #region  Soru4
        // Girilen sayinin pozitifligi
        static void Soru4()
        {
            Console.WriteLine("Bir sayi giriniz: ");
            int Num = Convert.ToInt32(Console.ReadLine());
            if (Num > 0)
            {
                Console.WriteLine("Sayiniz " + Num + " pozitif bir sayi.");
            }
            else if (Num == 0)
            {
                Console.WriteLine("Sayiniz " + Num);
            }
            else
            {
                Console.WriteLine("sayiniz " + Num + "negatif bir sayi");
            }
        }
        #endregion
        #region  Soru5
        //Girilen fiyatin kdv li hali
        static void Soru5()
        {
            Console.WriteLine("Bir sayi giriniz: ");
            double Num = Convert.ToDouble(Console.ReadLine());
            double FinalPrice = Num * 1.18;
            Console.WriteLine(FinalPrice);
        }
        #endregion
        #region  Soru6
        //Vize ve final ortalamasi
        static void Soru6()
        {
            Console.WriteLine("Vize notu icin  bir sayi giriniz: ");
            int Vize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Final notu icin bir sayi giriniz: ");
            int Final = Convert.ToInt32(Console.ReadLine());
            double Result = (double)Vize * 0.30 + (double)Final * 0.70;
            Console.WriteLine(Result);
        }
        #endregion
        #region Soru7
        //Girilen sayi tek mi cift mi
        static void Soru7()
        {
            Console.WriteLine("Bir sayi giriniz: ");
            int Num = Convert.ToInt32(Console.ReadLine());
            if (Num % 2 == 0)
            {
                Console.WriteLine("Sayi cift");
            }
            else
            {
                Console.WriteLine("Sayi tek");
            }
        }
        #endregion
        #region Soru8
        //Ucgenin alani
        static void Soru8()
        {
            Console.WriteLine("Ucgenin tabani nedir: ");
            int Base = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ucgenin yuksekligi nedir: ");
            int Height = Convert.ToInt32(Console.ReadLine());
            double Area = (double)Base * (double)Height / 2;
            Console.WriteLine("Alan " + Area);
        }
        #endregion
        #region Soru9
        //Tam bolunuyor mu
        static void Soru9()
        {
            Console.WriteLine("Bir sayi giriniz: ");
            int Num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bir sayi giriniz: ");
            int Num2 = Convert.ToInt32(Console.ReadLine());
            if (Num1 % Num2 == 0)
            {
                Console.WriteLine("Tam bolunuyor");
            }
            else
            {
                Console.WriteLine("tam bolunemiyor, kalan " + Num1 % Num2);
            }
        }
        #endregion
        #region  Soru10
        //* olmadan 5 ile carpma
        static void Soru10()
        {
            Console.WriteLine("Bir sayi giriniz: ");
            int Num = Convert.ToInt32(Console.ReadLine());
            int Total = 0;
            for (int i = 0; i < 5; i++)
            {
                Total += Num;
            }
            Console.WriteLine(Total);
        }
        #endregion
        #region Soru11
        //Sayi kac basamakli
        static void Soru11()
        {
            Console.WriteLine("Bir sayi giriniz: ");
            string Num = Console.ReadLine();
            //int girildigine eminiz
            int Digits = Num.Length;
            Console.WriteLine("Sayi " + Digits + " Basamakli");
        }
        #endregion
        #region Soru12
        //Girilen sayiya kadar olan asal sayilar
        static void Soru12()
        {
            Console.WriteLine("Bir sayi giriniz: ");
            int Num = Convert.ToInt32(Console.ReadLine());
            if (Num == 0 || Num == 1 || Num == 2)
            {
                Console.WriteLine("sayi " + Num);
            }
            for (int i = 2; i <= Num; i++)
            {
                //Takip icin bir bayrak
                bool CanDivide = false;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        CanDivide = true;
                        break;
                    }
                }
                if (!CanDivide)
                    Console.Write(i + " ");
            }
        }
        #endregion
        #region Soru13
        //Dizideki en kucuk
        static void Soru13()
        {
            int[] Nums = { 21, 88, 73, 12, 85, 2, 25, 91, 9, 32 };
            int Smallest = Nums[0];
            int Position = 0;
            //Sadece Position degiskeni uzerinden de cozulebilir Nums[Position]
            for (int i = 0; i < Nums.Length; i++)
            {
                if (Nums[i] < Smallest)
                {
                    Smallest = Nums[i];
                    Position = i;
                }
            }
            Console.WriteLine("EN kucuk sayi: " + Smallest + " Indexi: " + Position);
        }
        #endregion
        #region Soru14
        //Diziyi tersine cevir
        static void Soru14()
        {
            int[] Nums = { 21, 88, 73, 12, 85, 2, 25, 91, 9, 32 };
            Console.WriteLine("Orijinal dizi");
            PrintIntArray(Nums);
            for (int i = 0; i < Nums.Length && i < Nums.Length - (i + 1); i++)
            {
                int temp = Nums[i];
                Nums[i] = Nums[Nums.Length - (i + 1)];
                Nums[Nums.Length - (i + 1)] = temp;
            }
            Console.WriteLine("tersine cevirildikten sonra:");
            PrintIntArray(Nums);

            static void PrintIntArray(int[] NumArray)
            {
                foreach (int i in NumArray)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();

            }
        }
        #endregion
        #region Soru15
        //Disaridan girilen cumlede kac kelime var
        static void Soru15()
        {
            Console.WriteLine("Bir cumle giriniz");
            string Sentence = Console.ReadLine();
            int WordAmount = Sentence.Trim().Split(" ").Length;
            Console.WriteLine("Cumlenizde " + WordAmount + "keilme var");
        }
        #endregion
        #region  Soru16
        //Girilen 5> basamak buyuk sayinin 1-son basamak aralarindaki rakamlarin toplami
        static void Soru16()
        {
            Console.WriteLine("Bir sayi giriniz");
            //sayinin int olduguna eminiz
            string Num = Console.ReadLine();
            int Total = 0;
            for (int i = 1; i < Num.Length - 1; i++)
            {
                Total += Convert.ToInt32(Char.GetNumericValue(Num[i]));
            }
            Console.WriteLine("Toplam " + Total);
        }
        #endregion
        #region Soru17
        //Faktoriel
        static void Soru17()
        {
            Console.WriteLine("Bir sayi giriniz: ");
            int Num = Convert.ToInt32(Console.ReadLine());
            if (Num == 0 || Num == 1)
            {
                Console.WriteLine(Num + "! = 1");
                return;
            }
            int Result = Factorial(Num);
            static int Factorial(int Number)
            {
                if (Number > 1)
                {
                    return Number * Factorial(Number - 1);
                }
                return 1;
            }
            Console.WriteLine(Result);
        }
        #endregion
        #region Soru18
        //Soruda verilen sekli cizme
        static void Soru18()
        {
            int Num = 1;
            //satir dongusu
            for (int i = 1; i <= 5; i++)
            {
                //situn dongusu
                for (int j = 1; j <= 5; j++)
                {
                    if (j <= i)
                    {
                        Console.Write(Num + " ");
                        Num++;
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
        #endregion
        #region  Soru19
        //Verieln sekli cizme
        static void Soru19()
        {
            int Num = 2;
            //satir dongusu
            for (int i = 1; i <= 5; i++)
            {
                //situn dongusu
                for (int j = 1; j <= 5; j++)
                {
                    Console.Write(Num + " ");
                    Num += i;
                }
                Console.WriteLine();
                Num = i + 2;
            }
        }
        #endregion
        #region  Soru20
        static void Soru20()
        {
            int Num = Convert.ToInt32(Console.ReadLine());
            int Basamak = 0;
            int TempNum = Num;
            while (TempNum % 10 < 10)
            {
                TempNum %= 10;
                Basamak++;
            }

        }
        #endregion
    }
}