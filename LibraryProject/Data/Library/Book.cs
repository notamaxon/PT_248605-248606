using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Library
{
    internal class Book
    {
        private string Title { get; set; }
        private string Author { get; set; }
        private string Description{ get; set; }

        public Book(string title, string author, string description) { 
            Title = title;
            Author = author;
            Description = description;
        }
       
    }
}
