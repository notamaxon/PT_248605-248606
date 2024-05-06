using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Library
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; } = "";
        public BookGenre Genre { get; set; }

        public Book(string title, string author, BookGenre genre, string description) { 
            Title = title;
            Author = author;
            Description = description;
            Genre = genre;
        }
       
    }

    public enum BookGenre   
    {
        fantasy,
        scienceFiction,
        mystery,
        horror,
        romance,
        thriller,
        adventure,

    }
}
