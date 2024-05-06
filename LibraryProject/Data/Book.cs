using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Book
    {
        public string Title{ get; set; }
        public string Description { get; set; }
        public Users.User Author { get; set; }
        public BookGenres Genre { get; set; }

        public Book()
        {
            Genre = BookGenres.none;
            Title = string.Empty;
            Description = string.Empty;
            Author = new Users.Author();
        }
    }

    public enum BookGenres {
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
