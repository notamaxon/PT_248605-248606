using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    internal class Borrow : EventAbstract
    {
      public DateTime FreeReturnDate { get; set; }

        public Borrow(IState state) : base(state)
        {
            FreeReturnDate = EventDate.AddDays(60);
        }
    }
}
