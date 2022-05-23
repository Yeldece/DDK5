using System;
using System.Collections.Generic;
namespace Library
{
    public class Subscriber
    {
        public readonly string Name;
        public readonly string SirName;
        public readonly string TCNo;
        public string? Address;
        public string PhoneNumber;

        public Subscriber(string name, string sirName, string tcNo, string phoneNumber)
        {
            Name = name;
            SirName = sirName;
            TCNo = tcNo;
            PhoneNumber = phoneNumber;
        }

        public Subscriber(string name, string sirName, string tcNo, string phoneNumber, string address) : this(name, sirName, tcNo, phoneNumber)
        {
            Address = address;
        }
    }
}