using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public abstract class AbstractBuilder
    {
        public static IBook BuildBook(string title, User author, BookGenres genre) { 
            Book book = new Book(title, author, genre);
            return book;
        }
        public static IState BuildState(IBook book, StateType availability)
        {
            State state = new State(book, availability);
            return state;
        }

        public static IDataContext BuildDataContext() { 
            return new DataContext();
        }

        public static User BuildCustomer(string name, string surname, string email, string phone, string adress) { 
            Customer customer = new Customer(name, surname, email, phone, adress);
            return customer;
        }

        public static User BuildAuthor(string name, string surname, string email, string phone, string information) {
            Author author = new Author(name, surname, email, phone, information);
            return author;
        }

        public static EventAbstract BuildBorrow(IState state) { 
            return new Borrow(state);
        }

        public static EventAbstract BuildReturn(IState state, int fee = 0)
        {
            return new Return(state, fee);
        }

    }
}
