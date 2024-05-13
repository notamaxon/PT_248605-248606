using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public interface IDataContext
    {
        public List<User> Customers { get; set; }
        public Dictionary<string, IBook> Books { get; set; }
        public List<User> Authors { get; set; }
        public List<EventAbstract> Events { get; set; }
        public List<IState> States { get; set; }
    }
}
