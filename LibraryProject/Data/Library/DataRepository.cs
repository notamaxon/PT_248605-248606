using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Library
{
    internal class DataRepository {

        
        public List<Book> GetBooks() { return new List<Book>(); }
        
        public void AddBook(string title, string author, string description) { }
        public void UpdateBook(Book book) { }
        public void DeleteBook(Book book) { }
    }
}
