using System;
using System.Security.Cryptography;
using System.Globalization;
namespace MusicApp
{

    public static class MusicHelpers
    {
        public static string TitleCapitalize(string title)
        {
            TextInfo myTI = new CultureInfo("tr-TR", false).TextInfo;
            return myTI.ToTitleCase(title);
        }

        public static string CreateMD5(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);
                return Convert.ToHexString(hashBytes);
            }
        }
    }
}