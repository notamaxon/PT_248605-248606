using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    internal class Book : IBook
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public BookGenres Genre { get; set; }

        public Book(string title, string author, BookGenres genre) { 
            Id = Guid.NewGuid().ToString();
            Title = title;
            Author = author;    
            Genre = genre;    
            Author = author;    
        }
        public Book()
        {
            Id = string.Empty;
            Genre = BookGenres.none;
            Title = string.Empty;
            Author = string.Empty;
        }
    }

    public enum BookGenres
    {
        none,
        horror,
        mystery,
        thriller,
        fantasy,
        adventure,
        fiction,
        romance,
    }
}
