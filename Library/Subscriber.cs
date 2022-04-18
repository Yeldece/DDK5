using System;
using System.Collections.Generic;
namespace Library
{
    public class Subscriber
    {
        public string Name { get; set; }
        public string SirName { get; set; }
        public readonly string TCNo;
        public string Address { get; set; }
        public int PhoneNumber { get; set; }
        public Subscriber(string name, string sirName, string tcNo, int phoneNumber)
        {
            if (name != null && name.Length > 2)
            {
                Name = name;
            }
            else
            {
                throw new MyException("Name is wrong!");
            }
        }

        public class MyException : System.Exception
        {
            public MyException() : base() { }
            public MyException(string message) : base(message) { }
            public MyException(string message, System.Exception inner) : base(message, inner) { }
            protected MyException(
                System.Runtime.Serialization.SerializationInfo info,
                System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
        }

    }
}