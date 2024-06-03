using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.API
{
    public abstract class AbstractBuilder
    {
        public static IBook BuildBook(string title, string author, BookGenres genre) { 
            Implementations.Book book = new Implementations.Book(title, author, genre);
            return book;
        }

        public static IBook BuildBook() { 
            return new Implementations.Book();
        }
        public static IState BuildState(IBook book, StateType availability)
        {
            Implementations.State state = new Implementations.State(book, availability);
            return state;
        }
        public static IState BuildState()
        {
            return new Implementations.State();
        }
        public static IDataContext BuildDataContext() { 
            return new Implementations.DataContext();
        }

        public static IUser BuildCustomer(string name, string email, string phone) { 
            Implementations.User customer = new Implementations.User(name, email, phone);
            return customer;
        }

        public static IUser BuildCustomer()
        {
            return new Implementations.User();
        }

        public static EventAbstract BuildBorrow(IState state) { 
            return new Implementations.Borrow(state);
        }

        public static EventAbstract BuildReturn(IState state, int fee = 0)
        {
            return new Implementations.Return(state, fee);
        }

    }
}
