using System;
using System.Collections.Generic;
namespace Library
{
    public class Author
    {
        public string Name { get; set; }
        public string SirName { get; set; }
        public string Country { get; set; }
        public List<Book> WrittenBooks = new List<Book>();
    }
}