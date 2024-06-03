using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.API
{
    public interface IBook
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public BookGenres Genre { get; set; }

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
