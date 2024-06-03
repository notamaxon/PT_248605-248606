using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Implementations
{
    internal class State : API.IState
    {
        public string Id { get; set; }
        public DateTime Date { get; set; }
        public API.IBook Book { get; set; }
        public API.StateType Availability { get; set; } = API.StateType.Unknown;


        public State() {
            Id = string.Empty;
            Date = DateTime.Now;
            Book = new Book();
            Availability = API.StateType.Unknown;
        }
        public State(API.IBook book, API.StateType availability)
        {
            Id = Guid.NewGuid().ToString();
            Date = DateTime.Now;
            Book = book;
            Availability = availability;
        }
    }


    
}