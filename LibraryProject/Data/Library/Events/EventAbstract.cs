using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public abstract class EventAbstract
    {
        public DateTime EventDate { get; set; }
        public IState State { get; set; }
        public string Id { get; set; }
        public User Customer { get; set; }  


        public EventAbstract(IState state) {
            EventDate = DateTime.Now;
            State = state;
            Id = Guid.NewGuid().ToString();
        }

    }
}
