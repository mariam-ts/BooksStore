using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    class Book
    {
        public string Author {get; set;}
        public int ISBN { get; set; }
        public double Price { get; set; }
        public string Title { get; set; }
        
        public Book(string Author, int ISBN, double Price, string Title)
        {
            this.Author = Author;
            this.ISBN = ISBN;
            this.Price = Price;
            this.Title = Title;
          
        }
        public Book()
        {
            this.Author = null;
            this.ISBN = 0;
            this.Price = 0;
            this.Title = null;

        }
    }
}
