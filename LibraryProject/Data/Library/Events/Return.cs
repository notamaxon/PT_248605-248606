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

        public Return(IState state, int fee=0) : base(state) { 
        {
            Fee = fee;
        }
        }
    }
}
