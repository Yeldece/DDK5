using System;
namespace Library
{
    public static class SubscribeManager
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="sirName"></param>
        /// <param name="tcNo"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="address"></param>
        /// <returns></returns>
        public static Subscriber MakeSubscription(string name, string sirName, string tcNo, string phoneNumber, string address = null)
        {
            if (!(ValidateTC(tcNo) && name.Length <= 2 && sirName.Length <= 2))
            {
                throw new FormatException(message: "One of the parameters out of format");
            }
            if (String.IsNullOrWhiteSpace(address))
            {
                return new Subscriber(name, sirName, tcNo, phoneNumber);
            }
            else
            {
                return new Subscriber(name, sirName, tcNo, phoneNumber, address);
            }
        }

        static bool ValidateTC(string tcNo)
        {
            try
            {
                Convert.ToUInt32(tcNo);
            }
            catch (Exception)
            {
                Console.WriteLine("Enter a vaild TCNO");
            }
            return false;
        }

    }
}