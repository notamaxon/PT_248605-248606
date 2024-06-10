using Data.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Data.Implementation
{
    public class DataRepository : API.IDataRepository
    {
        public API.IDataContext dataContext = API.AbstractBuilder.BuildDataContext();

        public DataRepository(IDataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public void AddBook(API.IBook book)
        {
            dataContext.Books.Add(book.Id, book);
        }

        public void AddCustomer(API.IUser customer)
        {
            if (!(dataContext.Customers.Contains(customer)))
            {
                dataContext.Customers.Add(customer);
            }
        }

        public void AddEvent(API.IEvent eventAbstract)
        {
            dataContext.Events.Add(eventAbstract);
        }

        public void AddState(API.IState state)
        {
            dataContext.States.Add(state);
        }


        public void DeleteBook(API.IBook book)
        {
            if (dataContext.Books.ContainsKey(book.Id))
            {
                dataContext.Books.Remove(book.Id, out book);
            }
        }

        public void DeleteCustomer(API.IUser customer)
        {
            if (dataContext.Customers.Contains(customer))
            {
                dataContext.Customers.Remove(customer);
            }
        }

        public void DeleteEvent(API.IEvent eventAbstract)
        {
            if (dataContext.Events.Contains(eventAbstract))
            {
                dataContext.Events.Remove(eventAbstract);
            }
        }

        public void DeleteState(API.IState state)
        {
            if (dataContext.States.Contains(state))
            {
                dataContext.States.Remove(state);
            }
        }


        public Dictionary<string, API.IBook> GetAllBooks()
        {
            return dataContext.Books;
        }

        public List<API.IUser> GetAllCustomers()
        {
            return dataContext.Customers;
        }

        public List<API.IEvent> GetAllEvents()
        {
            return dataContext.Events;
        }

        public List<API.IState> GetAllState()
        {
            return dataContext.States;
        }

   

        public API.IBook GetBook(string id)
        {
            return dataContext.Books[id];
        }

        public API.IUser GetCustomer(string id)
        {
            API.IUser result = null;
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

        public API.IEvent GetEvent(string id)
        {
            API.IEvent result;
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

        public API.IState GetState(string id)
        {
            API.IState result = null;
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
