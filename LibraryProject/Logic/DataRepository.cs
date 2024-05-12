using Data.Library.Events;
using Data.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Data.Library
{
    internal class DataRepository : API.IDataRepository
    {
        public DataContext dataContext = new DataContext();

        public void AddAuthor(Author author)
        {
            if (!(dataContext.Authors.Contains(author))) {
                dataContext.Authors.Add(author);
            }
        }

        public void AddBook(Book book)
        {
            dataContext.Books.Add(book.Id, book);
        }

        public void AddCustomer(Customer customer)
        {
            if (!(dataContext.Customers.Contains(customer)))
            {
                dataContext.Customers.Add(customer);
            }
        }

        public void AddEvent(EventAbstract eventAbstract)
        {
            dataContext.Events.Add(eventAbstract);
        }

        public void AddState(State state)
        {
            dataContext.States.Add(state);
        }

        public void DeleteAuthor(Author author)
        {
            if (dataContext.Authors.Contains(author)) {
                dataContext.Authors.Remove(author);
            }
        }

        public void DeleteBook(Book book)
        {
            if (dataContext.Books.ContainsKey(book.Id)) {
                dataContext.Books.Remove(book.Id, out book);
            }
        }

        public void DeleteCustomer(Customer customer)
        {
            if (dataContext.Customers.Contains(customer)) {
                dataContext.Customers.Remove(customer);
            }
        }

        public void DeleteEvent(EventAbstract eventAbstract)
        {
            if (dataContext.Events.Contains(eventAbstract)) {
                dataContext.Events.Remove(eventAbstract);   
            }
        }

        public void DeleteState(State state)
        {
            if (dataContext.States.Contains(state)) { 
                dataContext.States.Remove(state);
            }
        }

        public List<Author> GetAllAuthor()
        {
            return dataContext.Authors;
        }

        public Dictionary<string, Book> GetAllBooks()
        {
            return dataContext.Books;
        }

        public List<Customer> GetAllCustomers()
        {
            return dataContext.Customers;
        }

        public List<EventAbstract> GetAllEvents()
        {
            return dataContext.Events;
        }

        public List<State> GetAllState()
        {
            return dataContext.States;
        }

        public Author GetAuthor(string id)
        {
            var result = new Author();
            foreach (var x in dataContext.Authors)
            {
                if (x.Id == id)
                {
                    result = x;
                    break;
                }
            }
            return result;
        }

        public Book GetBook(string id)
        {
            return dataContext.Books[id];
        }

        public Customer GetCustomer(string id)
        {
            var result = new Customer();
            foreach(var x in dataContext.Customers)
{
                if (x.Id == id)
                {
                    result = x;
                    break;
                }
            }
            return result;
        }

        public EventAbstract GetEvent(string id)
        {
            EventAbstract result;
            foreach (var x in dataContext.Events)
            {
                if (x.Id == id)
                {
                    result = x;
                    return result;
                }
            }
            return null;
            
        }

        public State GetState(string id)
        {
            var result = new State();
            foreach (var x in dataContext.States)
            {
                if (x.Id == id)
                {
                    result = x;
                    break;
                }
            }
            return result;
        }
        
    }
}
