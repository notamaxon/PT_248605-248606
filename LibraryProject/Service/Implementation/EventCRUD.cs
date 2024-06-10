using Data.API;
using Service.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Implementation
{
    internal class EventCRUD : IEventCRUD
    {
        private IDataRepository dataRepository;

        public EventCRUD(IDataRepository dataRepository)
        {
            this.dataRepository = dataRepository;
        }
    }
}
