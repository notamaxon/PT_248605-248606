using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Library
{
    public class DataContext
    {
        public List<Users.Customer> CustomerList { get; set; }
        public Dictionary<int, Book> Books { get; set; }

        public DataContext() { 
            CustomerList = new List<Users.Customer>();
            Books = new Dictionary<int, Book>();    
        }
    }
}
