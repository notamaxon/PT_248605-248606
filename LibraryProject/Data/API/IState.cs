using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.API
{
    public interface IState
    {
        public string Id { get; set; }
        public DateTime Date { get; set; }
        public IBook Book { get; set; }
        public StateType Availability { get; set; }

    }
    public enum StateType
    {
        Unknown,
        available,
        taken,
    }
}
