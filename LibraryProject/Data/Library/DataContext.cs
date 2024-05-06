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
        public Dictionary<string, Book> Books { get; set; }
        public List<Events.EventAbstract> Events { get; set; }

        public DataContext() { 
            Customers = new List<Users.Customer>();
            Books = new Dictionary<string, Book>();    
            Events = new List<Events.EventAbstract>();

        }
    }
}
