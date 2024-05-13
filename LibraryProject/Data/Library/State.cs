﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    internal class State : IState
    {
        public string Id { get; set; }
        public DateTime Date { get; set; }
        public IBook Book { get; set; }
        public StateType Availability { get; set; } = StateType.Unknown;


        public State() {
            Id = string.Empty;
            Date = DateTime.Now;
            Book = new Book();
            Availability = StateType.Unknown;
        }
        public State(IBook book, StateType availability)
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