//Cagatay Yildiz ile olan egitim surecimiz 1. hafta konu string methodlar sorular icin bkz
//First week of our learning period with Cagatay Yildiz, source for questions checkout:
//https://github.com/yakintech/csharp-tutorial/blob/master/HelloCSharp/StringMetotSorular.txt

using System;
namespace Console_review
{
    public class StringMethods
    {
        #region toUpper
        //ToUpper methodu
        //ToUpper method
        public static void ArrayToUpper()
        {
            string[] Names = { "cagatay", "emre", "ali", "Abdullah", "ayse" };
            string[] NamesUpper = new string[Names.Length];
            for (int i = 0; i < Names.Length; i++)
            {
                NamesUpper[i] = Names[i].ToUpper();
            }
        }
        #endregion
        #region stringMethodSoru2
        // Dizide 4 harf veya altında kaç isim var?
        //How many Names are shorter than 4
        public static void StringMethodSoru2()
        {
            string[] names = { "cagatay", "emre", "ali", "Abdullah", "ayse" };
            int count = 0;
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].Length <= 4)
                    count++;
            }
        }
        #endregion
        #region  stringMethodSoru3
        // Dizinin tüm elemanlarının ilk harfini sil ve başka bir diziye at.
        //delete first characters of the array and insert them into an other array
        public static void StringMethodSoru3()
        {
            string[] names = { "cagatay", "emre", "ali", "Abdullah", "ayse" };
            string[] names2 = new string[names.Length];
            for (int i = 0; i < names.Length; i++)
            {
                names2[i] = names[i].Substring(1);
            }
        }
        #endregion
        #region  soru4
        //4) Dizide M harfi ile başlayan kaç adet isim var?
        //How many of the names starts with M
        public static void StringMethodSoru4()
        {
            string[] names = { "cagatay", "emre", "ali", "Abdullah", "ayse" };
            int count = 0;
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].ToLower().StartsWith('m'))
                    count++;
            }
        }
        #endregion
        #region stringMethodSoru5
        //5) Dizide içerisinde 2 adet a harfi geçen KAÇ eleman var?
        //How many of the names contains two A
        public static void StringMethodSoru5()
        {
            string[] names = { "Çağatay", "Şivan", "Emre", "Dilek", "Abdullah", "Mehmet", "Ece" };
            int count = 0;
            foreach (string name in names)
            {
                string[] partion = name.ToLower().Split('a');
                if (partion.Length == 3)
                    count++;
            }
        }
        #endregion
        #region stringMethodSoru6
        //6) Dizinin tüm elemanlarının sadece son harflerini başka bir diziye at.
        //Put last characters of the names array to an other array
        public static void StringMethodSoru6()
        {
            string[] names = { "Çağatay", "Şivan", "Emre", "Dilek", "Abdullah", "Mehmet", "Ece" };
            string[] lastCharacters = new string[names.Length];
            for (int i = 0; i < names.Length; i++)
            {
                lastCharacters[i] = names[i].Trim().Substring(names[i].Length - 1, 1);
            }
        }
        #endregion
        #region  stringMethodSoru7
        //7) Dizinin elemanlarından son harfi e olan kaç eleman var?
        //How many of them ends with E
        public static void StringMethodSoru7()
        {
            string[] names = { "Çağatay", "Şivan", "Emre", "Dilek", "Abdullah", "Mehmet", "Ece" };
            int count = 0;
            foreach (string name in names)
            {
                if (name.Trim().Substring(name.Length - 1, 1) == "e")
                    count++;
            }
        }
        #endregion
        #region  stringMethodSoru8
        //8) Tüm dizi elemanlarını 10 karaktere tamamla. Örneğin Ece kelimesinin kalan 7 karakterine * 
        //Fill every name to 10 character with *
        public static void StringMethodSoru8()
        {
            string[] names = { "Çağatay", "Şivan", "Emre", "Dilek", "Abdullah", "Mehmet", "Ece" };
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].Length < 10)
                {
                    while (names[i].Length < 10)
                    {
                        names[i] += "*";
                    }
                }
            }
        }
        #endregion
        #region  stringMethodSoru9
        //9) **** "+90 543 733 14 70" metnini string metotlar kullanarak (543)7331470 olarak yaz.
        //Convert "+90 543 733 14 70" to "(543)7331470" with using string methods
        public static void stringMethodSoru9()
        {
            string num = "+90 543 733 14 70 ";
            num = num.Replace("+90", "").Replace(" ", "");
            string formatNum = "(" + num.Substring(0, 3) + ")" + num.Substring(3);
        }
        #endregion
        #region stringMethodSoru10
        //10) Dizideki tüm elemanları alıp yanına virgül koyacak şekilde bir metne dönüştür
        //Print names combined with comma , between them
        public static void StringMethodSoru10()
        {
            string[] names = { "Çağatay", "Şivan", "Emre", "Dilek", "Abdullah", "Mehmet", "Ece" };
            string fullText = "";
            foreach (string name in names)
            {
                fullText += name + ", ";
            }
        }
        #endregion
        #region stringMethodSoru11
        //11) Dizinin elemanlarındaki SADECE a harflerini büyültüp elemanları başka bir diziye ata
        //Find the "a" characters, make them upper and put into an other array
        public static void StringMethodSoru11()
        {
            string[] names = { "Çağatay", "Şivan", "Emre", "Dilek", "Abdullah", "Mehmet", "Ece" };
            string[] namesUpper = new string[names.Length];
            for (int i = 0; i < names.Length; i++)
            {
                namesUpper[i].Replace('a', 'A');
            }
        }
        #endregion
    }
}