using Data.Library.API;
using Data.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Library
{
    public class DataContext
    {
        public List<Customer> clients = new List<Customer>();
        public Dictionary<int, Book> books = new Dictionary<int, Book>();
        public List<IEvent> events = new List<IEvent>();
    }
}
