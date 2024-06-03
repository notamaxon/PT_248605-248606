using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.API
{
    public interface IEvent
    {
        public DateTime EventDate { get; set; }
        public IState State { get; set; }
        public string Id { get; set; }
        public IUser Customer { get; set; }
    }
}
