//Cagatay Yildiz ile olan egitim surecimiz 2. hafta konu DateTime soru cozumlerim, kaynak icin bkz
//Second week on the learning period with Cagatay Yildiz, for questions' source checkout:
//https://github.com/yakintech/csharp-tutorial/blob/master/HelloCSharp/DateTimeAlistirma.txt
using System;
namespace Console_review
{
    class DateTimeSorular
    {
        #region  Soru1
        //Dogdugumdan beri kac gun gecmis
        //How many days passed till I born
        static int Soru1(DateTime born)
        {
            DateTime dt = DateTime.Now;
            TimeSpan Dif = dt - born;
            return Dif.Days;
        }
        #endregion
        #region Soru2
        //Ayin son gunu nedir?
        //What is the last day of the month
        static string Soru2()
        {
            return new DateTime(DateTime.Now.Year, DateTime.Now.Month, new DateTime(DateTime.Now.AddMonths(1).Year, DateTime.Now.AddMonths(1).Month, 1).AddDays(-1).Day).DayOfWeek.ToString();
        }
        #endregion
        #region Soru6
        //Yilin yuzde kaci bitti
        //what percentage of the current year are we
        static double Soru6()
        {
            return (double)DateTime.Now.DayOfYear / 365 * 100;
        }
        #endregion
        #region Soru7
        //Onumuzdeki ayin ilk pazartesisi
        //First monday of the next month
        static int Soru7()
        {
            DateTime dt = new DateTime(DateTime.Now.AddMonths(1).Year, DateTime.Now.AddMonths(1).Month, 1);
            while (dt.DayOfWeek != DayOfWeek.Monday)
            {
                dt = dt.AddDays(1);
            }
            return dt.Day;
        }
        #endregion
        #region Soru9
        //9) Her ay 120 TL sunucu ödemesi yapılmaktadır. Ağustos ayı sonrası sunucu ücretleri %25 zamlanacaktır. Yıl sonuna kadar toplam sunucu ödemesi ne kadar olacaktır?
        //Server price is 120TL per month, after August it will be %25 more, what are we going to pay till end of this year
        static double Soru9()
        {
            DateTime dt = DateTime.Now;
            double total = 0;
            do
            {
                total += 120;
                if (dt.Month > 8)
                {
                    total += 120 % 25 / 100;
                }
                dt = dt.AddMonths(1);
            } while (dt.Month != 1);
            return total;
        }
        #endregion
    }
}