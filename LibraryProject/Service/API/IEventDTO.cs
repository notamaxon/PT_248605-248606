﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.API
{
    public interface IEventDTO
    {
        public DateTime EventDate { get; set; }
        public string StateId { get; set; }
        public string Id { get; set; }
        public string CustomerId { get; set; }


    }
}
