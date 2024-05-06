using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Library
{
    public abstract class EventAbstract
    {
       public DateTime EventDate { get; set; }
       public State State { get; set; }
       public int Id { get; set; }

       

    }
}
