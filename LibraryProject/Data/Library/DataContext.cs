using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Library
{
    public class DataContext
    {
        public List<Users.Customer> Customers { get; set; }
        public List<Users.Author> Authors { get; set; }
        public Dictionary<int, Book> Books { get; set; }
        public List<Events.EventAbstract> Events { get; set; }

        public DataContext() { 
            Authors = new List<Users.Author>();
            Customers = new List<Users.Customer>();
            Books = new Dictionary<int, Book>();    
            Events = new List<Events.EventAbstract>();

        }
    }
}
