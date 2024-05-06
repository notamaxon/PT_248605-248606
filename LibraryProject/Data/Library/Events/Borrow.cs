using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Library.Events
{
    public class Borrow : EventAbstract
    {
      public DateTime FreeReturnDate { get; set; }

        public Borrow(int id, State state) : base(id, state)
        {
            FreeReturnDate = EventDate.AddDays(60);
        }
    }
}
