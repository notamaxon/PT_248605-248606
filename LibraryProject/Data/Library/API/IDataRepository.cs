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
        void AddCustomer(Customer customer);
        void DeleteCustomer(Customer customer);
        Customer GetCustomer(string id);
        List<Customer> GetAllCustomers();

        // Book
        void AddBook(Book book);
        void DeleteBook(Book book);
        Book GetBook(string id);
        Dictionary<string, Book> GetAllBooks();

        // State

        void AddState(State state); 
        void DeleteState(State state);
        State GetState(string id); 
        List<State> GetAllState();


        // Event

        void AddEvent(EventAbstract eventAbstract);
        void DeleteEvent(EventAbstract eventAbstract);
        EventAbstract GetEvent(string id);
        List<EventAbstract> GetAllEvents();

        // Author
        void AddAuthor (Author author);
        Author GetAuthor(string id);
        void DeleteAuthor(Author author);
        List<Author> GetAllAuthor();
        

    }
}
