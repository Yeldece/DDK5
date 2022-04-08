using System;
namespace Console_review
{
    class DateTimeSorular
    {
        #region  Soru1
        //Dogdugumdan beri kac gun gecmis
        static int Soru1(DateTime Born)
        {
            DateTime dt = DateTime.Now;
            TimeSpan Dif = dt - Born;
            return Dif.Days;
        }
        #endregion
        #region Soru2
        //Ayin son gunu nedir?
        static string Soru2()
        {
            return new DateTime(DateTime.Now.Year, DateTime.Now.Month, new DateTime(DateTime.Now.AddMonths(1).Year, DateTime.Now.AddMonths(1).Month, 1).AddDays(-1).Day).DayOfWeek.ToString();
        }
        #endregion
        #region Soru6
        //Yilin yuzde kaci bitti
        static double Soru6()
        {
            return (double)DateTime.Now.DayOfYear / 365 * 100;
        }
        #endregion
        #region Soru7
        //Onumuzdeki ayin ilk pazartesisi
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