using System;
using System.Collections.Generic;
namespace Library
{
    public class Publisher
    {
        public string Name { get; set; }
        public readonly DateTime CreatedOn;
        List<Book> BooksPublished = new List<Book>();
    }
}