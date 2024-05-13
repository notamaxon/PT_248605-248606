using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace DataTest
{
    internal class DataRepository : Data.IDataRepository
    {
        public Data.IDataContext dataContext = Data.AbstractBuilder.BuildDataContext();

        public void AddAuthor(Data.User author)
        {
            if (!dataContext.Authors.Contains(author))
            {
                dataContext.Authors.Add(author);
            }
        }

        public void AddBook(Data.IBook book)
        {
            dataContext.Books.Add(book.Id, book);
        }

        public void AddCustomer(Data.User customer)
        {
            if (!(dataContext.Customers.Contains(customer)))
            {
                dataContext.Customers.Add(customer);
            }
        }

        public void AddEvent(Data.EventAbstract eventAbstract)
        {
            dataContext.Events.Add(eventAbstract);
        }

        public void AddState(Data.IState state)
        {
            dataContext.States.Add(state);
        }

        public void DeleteAuthor(Data.User author)
        {
            if (dataContext.Authors.Contains(author))
            {
                dataContext.Authors.Remove(author);
            }
        }

        public void DeleteBook(Data.IBook book)
        {
            if (dataContext.Books.ContainsKey(book.Id))
            {
                dataContext.Books.Remove(book.Id, out book);
            }
        }

        public void DeleteCustomer(Data.User customer)
        {
            if (dataContext.Customers.Contains(customer))
            {
                dataContext.Customers.Remove(customer);
            }
        }

        public void DeleteEvent(Data.EventAbstract eventAbstract)
        {
            if (dataContext.Events.Contains(eventAbstract))
            {
                dataContext.Events.Remove(eventAbstract);
            }
        }

        public void DeleteState(Data.IState state)
        {
            if (dataContext.States.Contains(state))
            {
                dataContext.States.Remove(state);
            }
        }

        public List<Data.User> GetAllAuthor()
        {
            return dataContext.Authors;
        }

        public Dictionary<string, Data.IBook> GetAllBooks()
        {
            return dataContext.Books;
        }

        public List<Data.User> GetAllCustomers()
        {
            return dataContext.Customers;
        }

        public List<Data.EventAbstract> GetAllEvents()
        {
            return dataContext.Events;
        }

        public List<Data.IState> GetAllState()
        {
            return dataContext.States;
        }

        public Data.User GetAuthor(string id)
        {
            Data.User result = null;
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

        public Data.IBook GetBook(string id)
        {
            return dataContext.Books[id];
        }

        public Data.User GetCustomer(string id)
        {
            Data.User result = null;
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

        public Data.EventAbstract GetEvent(string id)
        {
            Data.EventAbstract result;
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

        public Data.IState GetState(string id)
        {
            Data.IState result = null;
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
