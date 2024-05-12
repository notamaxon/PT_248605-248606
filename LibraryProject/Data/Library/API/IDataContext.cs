using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public interface IDataContext
    {
        public List<Customer> Customers { get; set; }
        public Dictionary<string, Book> Books { get; set; }
        public List<Author> Authors { get; set; }
        public List<EventAbstract> Events { get; set; }
        public List<State> States { get; set; }
    }
}
