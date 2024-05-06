using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Library.API
{
    public interface IEvent
    {
        DateTime EventDate { get; set; }

    }
}
