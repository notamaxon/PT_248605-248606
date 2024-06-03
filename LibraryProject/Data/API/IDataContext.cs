using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.API
{
    public interface IDataContext
    {
        public List<IUser> Customers { get; set; }
        public Dictionary<string, IBook> Books { get; set; }
        public List<IUser> Authors { get; set; }
        public List<EventAbstract> Events { get; set; }
        public List<IState> States { get; set; }
    }
}
