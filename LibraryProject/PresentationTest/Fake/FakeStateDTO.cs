﻿using Service.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationTest;

    internal class FakeStateDTO : IStateDTO
    {
    public string Id { get; set; }
    public DateTime Date { get; set; }
    public string BookId { get; set; }
    public bool Availability { get; set; }

    public FakeStateDTO(string id, string bookId, bool availability)
    {
        this.Id = id;
        this.Date = DateTime.Now;
        this.BookId = bookId;
        this.Availability = availability;
    }


}

