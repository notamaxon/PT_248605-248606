using Data.Library.Events;
using Data.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Library
{
    public class DataRepository : API.IDataRepository
    {
        DataContext dataContext = new DataContext();
        public void AddBook(Book book)
        {
            throw new NotImplementedException();
        }

        public void AddCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public void AddEvent(EventAbstract eventAbstract)
        {
            throw new NotImplementedException();
        }

        public void AddState(State state)
        {
            throw new NotImplementedException();
        }

        public void DeleteBook(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public void DeleteEvent(EventAbstract eventAbstract)
        {
            throw new NotImplementedException();
        }

        public void DeleteState(int id)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetAllBooks()
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAllCustomers()
        {
            throw new NotImplementedException();
        }

        public List<State> GetAllState()
        {
            throw new NotImplementedException();
        }

        public Book GetBook(int id)
        {
            throw new NotImplementedException();
        }

        public Customer GetCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public List<EventAbstract> GetEvents()
        {
            throw new NotImplementedException();
        }

        public void UpdateBook(Book book)
        {
            throw new NotImplementedException();
        }

        public void UpdateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public void UpdateEvent(EventAbstract eventAbstract)
        {
            throw new NotImplementedException();
        }

        public void UpdateState(State state)
        {
            throw new NotImplementedException();
        }
    }
}
