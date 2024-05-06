using Data.Library.Events;
using Data.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Library.API
{
    public interface IDataRepository
    {

        // Customer
        void AddCustomer(Customer customer);
        void DeleteCustomer(Customer customer);
        void UpdateCustomer(Customer customer);
        Customer GetCustomer(int id);
        List<Customer> GetAllCustomers();

        // Book
        void AddBook(Book book);
        void UpdateBook(Book book);
        void DeleteBook(int id);
        Book GetBook(int id);
        List<Book> GetAllBooks();

        // State

        void AddState(State state); 
        void UpdateState(State state);  
        void DeleteState(int id);
        List<State> GetAllState();


        // Event

        void AddEvent(EventAbstract eventAbstract);
        void UpdateEvent(EventAbstract eventAbstract);
        void DeleteEvent(EventAbstract eventAbstract);
        List<EventAbstract> GetEvents();

        

    }
}
