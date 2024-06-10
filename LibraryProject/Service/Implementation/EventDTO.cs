using Service.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Implementation
{
    internal class EventDTO : IEventDTO
    {
        private object type;

        public DateTime EventDate { get; set; }
        public string StateId { get; set; }
        public string Id { get; set; }
        public string CustomerId { get; set; }

        public EventDTO(DateTime eventdate, string stateid, string id, string customerid)
        {
            this.EventDate = eventdate;
            this.StateId = stateid;
            this.Id = id;
            this.CustomerId = customerid;
            this.Type = type;
        }

    }
}
