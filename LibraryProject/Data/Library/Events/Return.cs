using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Library.Events
{
    public class Return : EventAbstract
    {
        public int Fee {  get; set; }

        public Return(int id, State state, int fee) : base(id, state) { 
        {
            Fee = fee;
        }
        }
    }
}
