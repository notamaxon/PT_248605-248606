using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Library;

namespace Data.Library.Events
{
    public abstract class EventAbstract
    {
        public DateTime EventDate { get; set; }
        public State State { get; set; }
        public int Id { get; set; }


        public EventAbstract(int id, State state) {
            EventDate = DateTime.Now;
            State = state;
            Id = id;
        }

    }
}
