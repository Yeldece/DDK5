using System;
using System.Collections.Generic;
namespace Library
{
    public class Actions
    {
        public bool Completed = false;
        public DateTime ComplationDate
        { get; set; }
        [Flags]
        public enum Action : byte
        {
            BookGet = 1,
            BookStore = 2
        }
        public Action type;
        public DateTime ReturnDate;
        public readonly Book Book;
        public Actions(Book book, Action action, DateTime complationDate)
        {
            type = action;
            ComplationDate = complationDate;
            Book = book;
        }
    }
}