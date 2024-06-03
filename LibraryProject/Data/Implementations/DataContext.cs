using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Implementations
{
    internal class DataContext : API.IDataContext
    {
        public List<API.IUser> Customers { get; set; }
        public Dictionary<string, API.IBook> Books { get; set; }
        public List<API.IUser> Authors { get; set; }
        public List<API.EventAbstract> Events { get; set; }

        public List<API.IState> States { get; set; }

        public DataContext() { 
            Authors = new List<API.IUser>();
            Customers = new List<API.IUser>();
            Books = new Dictionary<string, API.IBook>();    
            Events = new List<API.EventAbstract>();
            States = new List<API.IState> { };

        }
    }
}
