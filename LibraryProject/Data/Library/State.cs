﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Library
{
    public class State
    {
        public string Id { get; set; }
        public DateTime Date { get; set; }
        public Book Book { get; set; }
        public StateType Availability { get; set; } = StateType.Unknown;


        public State() {
            Id = string.Empty;
            Date = DateTime.Now;
            Book = new Book();
            Availability = StateType.Unknown;
        }
        public State(Book book, StateType availability)
        {
            Id = Guid.NewGuid().ToString();
            Date = DateTime.Now;
            Book = book;
            Availability = availability;
        }
    }


    public enum StateType {
        Unknown,
        available,
        taken,
    }
}