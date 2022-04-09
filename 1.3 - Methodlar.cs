//Cagatay Yildiz ile egitim 1. hafta konu methodlar
//Week one with Cagatay Yildiz, topic methods
//https://github.com/yakintech/csharp-tutorial/blob/master/HelloCSharp/MetotSorular.txt
using System;
namespace Console_review
{
    class MethodSorular
    {
        #region methodsoru1
        //﻿1) Dışarıdan bir metin alan aldığı değerdeki karakter sayısını dönen metot
        //Get a text as a parameter and return length of it
        static int MethodSoru1(string text)
        {
            int length = 0;
            foreach (char c in text)
            {
                length++;
            }
            return length;
        }
        #endregion
        #region method soru kdv
        //kvd hesapla
        //calculate tax
        static double CalculateTax(int price)
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
        #region  methodSoru2
        static string MethodSoru2(string text1, string text2)
        {
            text1 = text1.ToUpper();
            text2 = text2.ToUpper();
            string text3 = text1 + " " + text2;
            return text3;
        }
        #endregion
        #region methodSoru3
        //3) Dışarıdan bir metin alan ve aldığı metinde kaç adet "a" harfi olduğunu söyleyen metot
        //How many A in the parameter string
        static int MethodSoru3(string text)
        {
            text = text.ToLower();
            int counter = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'a')
                {
                    counter++;
                }
            }
            return counter;
        }
        #endregion
        #region  methodSoru4
        //4) Dışarıdan bir metin alan aldığı metnin sadece ilk harfini büyük diğer harflerini küçük yazacak 
        //Convert parameter string to all lowerise except first character
        static string MethodSoru4(string text)
        {
            text = text.Trim();
            string text2 = text[0].ToString().ToUpper() + text.Substring(1);
            return text2;
        }
        #endregion
        #region methodSoru7
        //stringi 
        //6) Dışarıdan bir metin alan aldığı metnin sadece ilk üç harfini döndüren metot. Uyarı: Metin 2 harfliyse sadece iki harfini döndürsün. Sistem hata vermemeli        
        //print first three character of the string parameter, if it's less then 3 print first two characters
        static string MethodSoru6(string text)
        {
            string text2 = "";
            if (text.Length > 2)
            {
                text2 = text.Substring(0, 3);
            }
            else if (text.Length == 2)
            {
                text2 = text.Substring(0, 2);
            }
            return text2;
        }
        #endregion
        #region  methodSoru11
        //Bir metni her ogesi iki karakter uzunlugunda string dizisine bolme
        //Divide a string which every items has two characters
        static string[] MethodSoru10(string text)
        {
            string[] result;
            if (text.Length % 2 == 1)
            {
                result = new string[text.Length / 2 + 1];
            }
            else
            {
                result = new string[text.Length / 2];
            }
            int even = 1;
            for (int i = 0, j = 0; i < text.Length; i++)
            {
                if (even < 3)
                {
                    result[j] += text[i];
                    even++;
                }
                else
                {
                    even = 1;
                    j++;
                    i--;
                }
            }
            return result;
        }
        #endregion
        #region methodSoru21
        //Celciusu Fahrenheit'a cevirme
        //Convert Celcius to Fahrenheit 
        static decimal MethodSoru21(decimal degreeInCelcius)
        {
            decimal degreeInF = (degreeInCelcius * 9 / 5) + 32;
            return degreeInF;
        }
        #endregion
    }
}