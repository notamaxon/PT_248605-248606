using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.API
{
    public interface IDataRepository
    {

        // Customer
        void AddCustomer(IUser customer);
        void DeleteCustomer(IUser customer);
        IUser GetCustomer(string id);
        List<IUser> GetAllCustomers();

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
        

    }
}
