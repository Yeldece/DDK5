using System;
using System.Collections.Generic;
namespace Library
{
    public class Book
    {
        public string Name;
        public DateTime PublicationDate { get; set; }
        public List<Author> Authors = new List<Author>();
        public Category Kind = new Category();
        public Publisher PublishedBy = new Publisher();
        public int ISBN { get; set; }
        public string Description { get; set; }


    }
    public class Category
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}