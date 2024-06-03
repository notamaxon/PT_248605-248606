using Data.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Implementations
{
    internal class Event : API.IEvent
    {
        public DateTime EventDate { get; set; }
        public IState State { get; set; }
        public string Id { get; set; }
        public IUser Customer { get; set; }


        public Event(IState state)
        {
            EventDate = DateTime.Now;
            State = state;
            Id = Guid.NewGuid().ToString();
        }
    }
}
