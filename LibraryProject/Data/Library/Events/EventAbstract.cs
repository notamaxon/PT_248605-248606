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
        public State State { get; set; }
        public string Id { get; set; }
        public Customer Customer { get; set; }  


        public EventAbstract(State state) {
            EventDate = DateTime.Now;
            State = state;
            Id = Guid.NewGuid().ToString();
        }

    }
}
