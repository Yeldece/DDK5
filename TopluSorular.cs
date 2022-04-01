using System;
namespace Console_review
{
    class TopluSorular
    {
        #region soru6
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
        #endregion
        #region soru1
        static void soru1()
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
        static void soru2()
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
        #endregion
        #region  soru4
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
        #endregion
        #region  soru5
        static void soru5()
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
        static void soru6v2()
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
        #region  soru7
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
        static void soru9()
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
        #endregion
        #region  printAnArray
        static void sorArray()
        {
            int[] array = { 5, 2, 3, 4, 1 };
            foreach (int i in array)
            {
                Console.WriteLine(i.ToString());
            }
        }
        #endregion
        #region  soru13
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
        #endregion
        #region  soru11
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
        #endregion
        #region  soru12
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
        #endregion
        #region  GuessGame
        static void randomGuessGame()
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
        static void soru15()
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
        #endregion
        #region  soru17
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
        #endregion
        #region  soru18
        static void soru18()
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
        static void soru19()
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
        static void telefonNumarasi()
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
        #region toUpper
        static void arrayToUpper()
        {
            string[] isimler = { "cagatay", "emre", "ali", "Abdullah", "ayse" };
            string[] isimlerBuyuk = new string[isimler.Length];
            for (int i = 0; i < isimler.Length; i++)
            {
                isimlerBuyuk[i] = isimler[i].ToUpper();
            }
        }
        #endregion
        #region stringMethodSoru2
        static void stringMethodSoru2()
        {
            string[] isimler = { "cagatay", "emre", "ali", "Abdullah", "ayse" };
            int adet = 0;
            for (int i = 0; i < isimler.Length; i++)
            {
                if (isimler[i].Length <= 4)
                    adet++;
            }
        }
        #endregion
        #region  stringMethodSoru3
        static void stringMethodSoru3()
        {
            string[] isimler = { "cagatay", "emre", "ali", "Abdullah", "ayse" };
            string[] isimler2 = new string[isimler.Length];
            for (int i = 0; i < isimler.Length; i++)
            {
                isimler2[i] = isimler[i].Substring(1);
            }
        }
        #endregion
        #region  soru4
        static void stringMethodSoru4()
        {
            string[] isimler = { "cagatay", "emre", "ali", "Abdullah", "ayse" };
            int adet = 0;
            for (int i = 0; i < isimler.Length; i++)
            {
                if (isimler[i].ToLower().StartsWith('m'))
                    adet++;
            }
        }
        #endregion
        #region stringMethodSoru5
        static void stringMethodSoru5()
        {
            string[] isimler = { "Çağatay", "Şivan", "Emre", "Dilek", "Abdullah", "Mehmet", "Ece" };
            int adet = 0;
            foreach (string isim in isimler)
            {
                string[] partion = isim.ToLower().Split('a');
                if (partion.Length == 3)
                    adet++;
            }
        }
        #endregion
        #region stringMethodSoru6
        static void stringMethodSoru6()
        {
            string[] isimler = { "Çağatay", "Şivan", "Emre", "Dilek", "Abdullah", "Mehmet", "Ece" };
            string[] sonKarakterler = new string[isimler.Length];
            for (int i = 0; i < isimler.Length; i++)
            {
                sonKarakterler[i] = isimler[i].Trim().Substring(isimler[i].Length - 1, 1);
            }

        }
        #endregion
        #region  stringMethodSoru7
        static void stringMethodSoru7()
        {
            string[] isimler = { "Çağatay", "Şivan", "Emre", "Dilek", "Abdullah", "Mehmet", "Ece" };
            int adet = 0;
            foreach (string isim in isimler)
            {
                if (isim.Trim().Substring(isim.Length - 1, 1) == "e")
                    adet++;
            }
        }
        #endregion
        #region  stringMethodSoru8
        static void stringMethodSoru8()
        {
            string[] isimler = { "Çağatay", "Şivan", "Emre", "Dilek", "Abdullah", "Mehmet", "Ece" };
            for (int i = 0; i < isimler.Length; i++)
            {
                if (isimler[i].Length < 10)
                {
                    while (isimler[i].Length < 10)
                    {
                        isimler[i] += "*";
                    }
                }
            }
        }
        #endregion
        #region  stringMethodSoru9
        static void stringMethodSoru9()
        {
            string num = "+90 543 733 14 70 ";
            num = num.Replace("+90", "").Replace(" ", "");
            string formatNum = "(" + num.Substring(0, 3) + ")" + num.Substring(3);
        }
        #endregion
        #region stringMethodSoru10
        static void stringMethodSoru10()
        {
            string[] isimler = { "Çağatay", "Şivan", "Emre", "Dilek", "Abdullah", "Mehmet", "Ece" };
            string butunMetin = "";
            foreach (string isim in isimler)
            {
                butunMetin += isim + ", ";
            }
        }
        #endregion
        #region stringMethodSoru11

        static void stringMethodSoru11()
        {
            string[] isimler = { "Çağatay", "Şivan", "Emre", "Dilek", "Abdullah", "Mehmet", "Ece" };
            string[] isimlerBuyuk = new string[isimler.Length];
            for (int i = 0; i < isimler.Length; i++)
            {
                isimlerBuyuk[i].Replace('a', 'A');
            }
        }
        #endregion
        #region methodsoru2
        static int methodSoru2(string text)
        {
            {
                int uzunluk = 0;
                foreach (char c in text)
                {
                    uzunluk++;
                }
                return uzunluk;
            }
        }
        #endregion
        #region method soru1 kdv
        static double methodSoru1(int price)
        {
            double result;
            if (price > 200)
            {
                result = price * 1.08;
            }
            else
            {
                result = price * 1.18;
            }
            return result;
        }
        #endregion
        #region  methodSoru3
        static string methodSoru3(string metin1, string metin2)
        {
            metin1 = metin1.ToUpper();
            metin2 = metin2.ToUpper();
            string metin3 = metin1 + " " + metin2;
            return metin3;
        }
        #endregion
        #region methodSoru4
        static int methodSoru4(string metin)
        {
            metin = metin.ToLower();
            int sayac = 0;
            for (int i = 0; i < metin.Length; i++)
            {
                if (metin[i] == 'a')
                {
                    sayac++;
                }
            }
            return sayac;

        }
        #endregion
        #region  methodSoru5
        static string methodSoru5(string metin)
        {
            metin = metin.Trim();
            string metin2 = metin[0].ToString().ToUpper() + metin.Substring(1);
            return metin2;
        }
        #endregion
        #region methodSoru7
        static string methodSoru7(string metina)
        {
            string metinb = "";
            if (metina.Length > 2)
            {
                metinb = metina.Substring(0, 3);
            }
            else if (metina.Length == 2)
            {
                metinb = metina.Substring(0, 2);
            }
            return metinb;
        }
        #endregion
        #region  methodSoru11
        static string[] methodSoru11(string metin)
        {
            string[] sonuc;
            if (metin.Length % 2 == 1)
            {
                sonuc = new string[metin.Length / 2 + 1];
            }
            else
            {
                sonuc = new string[metin.Length / 2];
            }
            int cift = 1;
            for (int i = 0, j = 0; i < metin.Length; i++)
            {
                if (cift < 3)
                {
                    sonuc[j] += metin[i];
                    cift++;
                }
                else
                {
                    cift = 1;
                    j++;
                    i--;
                }
            }
            return sonuc;
        }
        #endregion
        #region methodSoru21
        static decimal methodSoru21(decimal degreeInCelcius)
        {
            decimal degreeInF = (degreeInCelcius * 9 / 5) + 32;
            return degreeInF;
        }
        #endregion
        // static void Main(string[] args)
        // {
        //     Console.ReadKey();
        // }
    }
}