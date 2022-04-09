//Cagatay Yildiz ile olan egitim surecimizin ilk haftasinda  cozdugum sorular, sorular icin
//The questions I've solved during the first week of our learning period with Cagatay Yildiz, for full version of  questions, checkout:
//https://github.com/yakintech/csharp-tutorial/blob/master/HelloCSharp/Sorular.md

using System;
namespace Console_review
{
    class TopluSorular
    {
        #region soru6
        //Kullanıcı dışarıdan bir sayı girsin. Örneğin 3 girdiğinde 3*3 lük bir kare oluştursun.
        //Create a square with stars based on input number.
        static void Soru6()
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
        #endregion
        #region soru1
        //Kullanıcı ekrandan iki sayı girecek. Bu aralıktaki sayıların toplamını ekrana yazdır.
        //write the numbers between two input number
        static void Soru1()
        {
            Console.WriteLine("Sayi giriniz");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sayi giriniz");
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
        #endregion
        #region soru2
        //Kullanıcı ekrandan bir sayı girecek. Bu sayıdan 0 a kadar olan sayıları ekrana yazdır. 6,5,4,3,1
        //print the numbers from input to 0
        static void Soru2()
        {
            Console.WriteLine("Sayi giriniz: ");
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
        #endregion
        #region soru3
        //Kullanıcı ekrandan 3 adet sayı girecek. Kac tanesi 10 dan büyük olduğunu ekrana yazdır.
        //get three numbers from input and print how many are greater than 10
        static void Soru3()
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
        #endregion
        #region  soru4
        //1 den 100 e kadar olan 2 ve 3 e bölünebilen sayıları ekrana yazdır.
        //print the numbers which can divide 2 and 3 from 1 to 100
        static void Soru4()
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
        #endregion
        #region  soru5
        //1 den 100 e kadar olan 2 ve 3 e bölünebilen kaç adet sayı var?
        //how many numbers can divide 2 and 3 from 1 to 100
        static void Soru5()
        {
            List<int> canDivide = new List<int>();
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0 && i % 3 == 0) canDivide.Add(i);
            }
            Console.WriteLine(canDivide.Count.ToString());
        }
        #endregion
        #region  soru6Version2
        //Girdiye gore kare cizme version 2
        //A different version of printing square with stars
        static void Soru6v2()
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
        #endregion
        #region  Soru7
        //Kullanıcı ekrandan iki sayı girecek. Çarpma operatörü kullanmadan iki sayıyı çarp ekrana yaz.
        //Multiply two numbers without * operand
        static void soru7()
        {
            Console.WriteLine("Carpilacak iki sayiyi sirayla giriniz");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            int total = 0;
            for (int i = 1; i <= sayi2; i++)
            {
                total += sayi1;
            }
            Console.WriteLine(total.ToString());
        }
        #endregion
        #region  soru8
        //Dışarıdan girilen 3 tane sayının ortalamasını bulan program.
        //find the average of three input number
        static void soru8()
        {
            Console.WriteLine("3 adet sayi gireceksiniz: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ikinci sayiyi giriniz");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ucuncu sayiyi giriniz");
            int sayi3 = Convert.ToInt32(Console.ReadLine());
            double average = (sayi1 + sayi2 + sayi3) / 3;
            Console.WriteLine(average.ToString());
        }
        #endregion
        #region soru9 
        //Dışarıdan girilen bir N sayısına kadar olan sayıların karelerinin toplamını hesaplayan program.
        //powers total from 1 to input number
        static void Soru9()
        {
            Console.WriteLine("Sayi giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int toplam = 0;
            for (int i = 1; i <= sayi; i++)
            {
                toplam += i * i;
            }
            Console.WriteLine(toplam.ToString());
        }
        #endregion
        #region  soru10
        //Kullanıcı dışarıdan bir fiyat girecek. Girdiği fiyatın KDV li hali (%18 i) ekrana yazacak FAKAT kullanıcının girdiği fiyat 200 üzerindeyse %10 indirim uygulayıp KDV yi öyle hesapla.
        //Take the input, calculate the tax %18, if price is greater than 200, first put %10 discount
        static void Soru10()
        {
            double price = Convert.ToDouble(Console.ReadLine());
            if (price > 200)
            {
                price -= (price * 10 / 100);
            }
            price *= 1.18;
            Console.WriteLine(price.ToString());
        }
        #endregion
        #region  printAnArray
        //bir diziyi yazdirmak
        //print an array
        static void SoruArray()
        {
            int[] array = { 5, 2, 3, 4, 1 };
            foreach (int i in array)
            {
                Console.WriteLine(i.ToString());
            }
        }
        #endregion
        #region  Soru13
        //5 elemanlı bir sayı dizisi tanımla. Dizinin elemanları toplamını ekrana yazdır
        //define an array with 5 items and print the total
        static void Soru13()
        {
            int[] array = { 22, 41, 13, 52, 73 };
            int total = 0;
            foreach (int i in array)
            {
                total += i;
            }
            Console.WriteLine(total.ToString());
        }
        #endregion
        #region  soru11
        //Aşağıdaki formu ekrana basan program.
        //print the given shape
        static void Soru11()
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
        #endregion
        #region  Soru12
        //Dışarıdan 3 tane sayı girilecek ve program en küçük sayıyı bulacak.
        //print the smallest of three given number
        static void soru12()
        {
            Console.WriteLine("Sayi giriniz");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sayi giriniz");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sayi giriniz");
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
        #endregion
        #region  GuessGame
        //tahmin oyunu
        //guess number game
        static void RandomGuessGame()
        {
            Random rand = new Random();
            int goal = rand.Next(1, 101);
            for (int i = 10; i >= 1; i--)
            {
                Console.WriteLine("Enter your guess, " + i.ToString() + "try you have left");
                int guess = Convert.ToInt32(Console.ReadLine());
                if (guess == goal)
                {
                    Console.WriteLine("Correct, You Won!");
                    break;
                }
                else if (guess > goal)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("Above");
                }
            }
        }
        #endregion
        #region  soru15-16
        //N elemanlı bir dizideki en küçük elemanı ve bu elemanın adresini (index no) bulan program.
        //Find the smallest in an array with it's index number
        static void Soru15()
        {
            int[] array = { 73, 12, 81, 2, 25, 91, 9, 32 };
            int smallest = array[0];
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (smallest > array[i])
                {
                    smallest = array[i];
                    index = i;
                }
            }
            Console.WriteLine("EN kucuk sayi: " + smallest.ToString() + " Indexi: " + index.ToString());
        }
        #endregion
        #region  loto
        //loto kuponunu doldur
        //give 6 unique numbers from 1 to 50
        static void Loto()
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
        #endregion
        #region  soru17
        //5 elemanlı bir sayı dizisi oluştur. For döngüsüyle dönerek sadece pozitif olanları ekrana yazdır.
        //print the positive numbers in an array
        static void Soru17()
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
        #endregion
        #region  soru18
        //5 elemanlı bir sayı dizisi oluştur. En büyük elemanın index numarasını ekrana yazdır.
        //print the biggest number's index in an array
        static void Soru18()
        {
            int[] array = { 102, 842, 12, 32, 41, 52, 33, 63, 8, 72, 11 };
            int biggest = array[0];
            foreach (int i in array)
            {
                if (biggest < i)
                {
                    biggest = i;
                }
            }
            Console.WriteLine("Biggest: " + biggest.ToString());
        }
        #endregion
        #region  soru19
        //Kullanıcı dışarıdan bir sayı girecek o sayı ekranda oluşacak üçgenin TABANI olacak.
        //print a triangle, base is a given number by user
        static void Soru19()
        {
            Console.WriteLine("Ucgenin tabani olacak sayiyi giriniz: ");
            int taban = Convert.ToInt32(Console.ReadLine());
            int width = taban * 2;
            for (int line = 0; line < taban; line++)
            {
                int position = width / 2 - line;
                int amount = line + 1;
                for (int j = 1; j <= width; j++)
                {
                    if (j >= position && amount > 0)
                    {
                        Console.Write("*");
                        amount--;
                    }
                    Console.Write("1");
                }
                Console.WriteLine();
            }
        }
        #endregion
        #region telefonNumarasi
        //telefon numberasi
        //Phone number formaating
        static void TelefonNumarasi()
        {
            Console.WriteLine("Telefon numaranizi basinda ulke kodu ile giriniz: ");
            string num = Console.ReadLine();
            if (!String.IsNullOrEmpty(num))
            {
                num = num.Substring(3).Trim();
                Console.WriteLine(num);
            }
        }
        #endregion
        // static void Main(string[] args)
        // {
        //     Console.ReadKey();
        // }
    }
}