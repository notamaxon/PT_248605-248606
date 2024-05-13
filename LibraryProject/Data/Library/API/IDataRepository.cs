using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public interface IDataRepository
    {

        // Customer
        void AddCustomer(User customer);
        void DeleteCustomer(User customer);
        User GetCustomer(string id);
        List<User> GetAllCustomers();

        // Book
        void AddBook(IBook book);
        void DeleteBook(IBook book);
        IBook GetBook(string id);
        Dictionary<string, IBook> GetAllBooks();

        // State

        void AddState(IState state); 
        void DeleteState(IState state);
        IState GetState(string id); 
        List<IState> GetAllState();


        // Event

        void AddEvent(EventAbstract eventAbstract);
        void DeleteEvent(EventAbstract eventAbstract);
        EventAbstract GetEvent(string id);
        List<EventAbstract> GetAllEvents();

        // Author
        void AddAuthor (User author);
        User GetAuthor(string id);
        void DeleteAuthor(User author);
        List<User> GetAllAuthor();
        

    }
}
