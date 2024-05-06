﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Library
{
    public class State
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public Book Book { get; set; }
        public StateType Availability { get; set; } = StateType.Unknown;


        public State() {
            Id = 0;
            Date = DateTime.Now;
            Book = new Book();
            Availability = StateType.Unknown;
        }
        public State(int id, Book book, StateType availability)
        {
            Id = id;
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