using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Data
{
    internal class DataRepository : IDataRepository
    {
        public IDataContext dataContext = AbstractBuilder.BuildDataContext();

        public void AddAuthor(User author)
        {
            if (!dataContext.Authors.Contains(author))
            {
                dataContext.Authors.Add(author);
            }
        }

        public void AddBook(IBook book)
        {
            dataContext.Books.Add(book.Id, book);
        }

        public void AddCustomer(User customer)
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

        public void AddState(IState state)
        {
            dataContext.States.Add(state);
        }

        public void DeleteAuthor(User author)
        {
            if (dataContext.Authors.Contains(author))
            {
                dataContext.Authors.Remove(author);
            }
        }

        public void DeleteBook(IBook book)
        {
            if (dataContext.Books.ContainsKey(book.Id))
            {
                dataContext.Books.Remove(book.Id, out book);
            }
        }

        public void DeleteCustomer(User customer)
        {
            if (dataContext.Customers.Contains(customer))
            {
                dataContext.Customers.Remove(customer);
            }
        }

        public void DeleteEvent(EventAbstract eventAbstract)
        {
            if (dataContext.Events.Contains(eventAbstract))
            {
                dataContext.Events.Remove(eventAbstract);
            }
        }

        public void DeleteState(IState state)
        {
            if (dataContext.States.Contains(state))
            {
                dataContext.States.Remove(state);
            }
        }

        public List<User> GetAllAuthor()
        {
            return dataContext.Authors;
        }

        public Dictionary<string, IBook> GetAllBooks()
        {
            return dataContext.Books;
        }

        public List<User> GetAllCustomers()
        {
            return dataContext.Customers;
        }

        public List<EventAbstract> GetAllEvents()
        {
            return dataContext.Events;
        }

        public List<IState> GetAllState()
        {
            return dataContext.States;
        }

        public User GetAuthor(string id)
        {
            User result = null;
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

        public IBook GetBook(string id)
        {
            return dataContext.Books[id];
        }

        public User GetCustomer(string id)
        {
            User result = null;
            foreach (var x in dataContext.Customers)
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

        public IState GetState(string id)
        {
            IState result = null;
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
