using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    internal class Return : EventAbstract
    {
        public int Fee {  get; set; }

        public Return(State state, int fee) : base(state) { 
        {
            Fee = fee;
        }
        }
    }
}
