using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Library
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description{ get; set; }

        public Book(string title, string author, string description) { 
            Title = title;
            Author = author;
            Description = description;
        }
       
    }
}
