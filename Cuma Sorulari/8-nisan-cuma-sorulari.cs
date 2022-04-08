using System;
using System.Collections.Generic;
using System.Linq;
namespace Console_review
{
    class FridayQuestions
    {
        #region Soru1
        //1) 2010 ile 2022 arasında mesai saatleri içerisinde (09:00-18:00) 1000 adet RANDOM TARİH oluştur ve bir tarih listesine ata
        static List<DateTime> Soru1(int length = 1000)
        {
            List<DateTime> dateList = new List<DateTime>();
            Random rnd = new Random();
            for (int i = 0; i < length; i++)
            {
                int year = rnd.Next(2010, 2023);
                int month = rnd.Next(1, 13);
                int day = rnd.Next(1, DateTime.DaysInMonth(year, month) + 1);
                dateList.Add(new DateTime(year, month, day, rnd.Next(09, 18), 0, 0));
            }
            return dateList;
        }
        #endregion
        #region Soru2
        //2) Bu listede cumartesi ve pazar olmasın!
        static List<DateTime> Soru2(List<DateTime> dateList)
        {
            dateList.RemoveAll(x => x.DayOfWeek != DayOfWeek.Sunday && x.DayOfWeek != DayOfWeek.Saturday);
            return dateList;
        }
        #endregion
        #region Soru3
        //3) Bu listenin içerisinde tarihlerin kaçı şubat ayı içerisindedir?
        static int Soru3(List<DateTime> dateList)
        {
            return dateList.FindAll(x => x.Month == 2).Count();
        }
        #endregion
        #region Soru4
        //        4) Bu listenin içerisindeki tarihlerin kaçı 12:00 (öğlen) den öncedir
        static int Soru4(List<DateTime> dateList)
        {
            return dateList.Where(x => x.Hour < 12).Count();
        }
        #endregion
        static void Main(string[] args)
        {
        }
    }
}