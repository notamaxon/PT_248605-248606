using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Library
{
    public class Status
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public Book Book { get; set; }
        public StateType Availability { get; set; } = StateType.Unknown;


        public Status() {
            Id = 0;
            Date = DateTime.Now;
            Book = new Book();
            Availability = StateType.Unknown;
        }
        public Status(int id, Book book, StateType availability)
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