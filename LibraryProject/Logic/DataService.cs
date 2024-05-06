using Data.Library;
using Data.Library.API;
using Data.Library.Events;
using Data.Users;
using Logic.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class DataService : IDataService
    {

        public IDataRepository Repository { get; set; }
        public DataService()
        {
            Repository = new DataRepository();
        }
        public DataService(IDataRepository repository) {
            Repository = repository;
        }
      
        // Book

        

        void IDataService.AddBook(Book book)
        {
            Repository.AddBook(book);  
        }

        void IDataService.DeleteBook(Book book)
        {
            Repository.DeleteBook(book);
        }

        void IDataService.AddCustomer(Customer customer)
        {
            Repository.AddCustomer(customer);
        }

        void IDataService.DeleteCustomer(Customer customer)
        {
            Repository.DeleteBook(customer);
        }

        void IDataService.AddEvent(EventAbstract eventAbstract)
        {
            Repository.AddEvent(eventAbstract);
        }

        void IDataService.DeleteEvent(EventAbstract eventAbstract)
        {
            Repository.DeleteEvent(eventAbstract);
        }

        void IDataService.BorrowBook(Book book)
        {
            Book book = Repository.GetBook(book);
            Customer customer = Repository.GetCustomer(customer);
            State state = new State(book, StateType.taken);
            Borrow bookBorrow = new Borrow(state);

            Repository.DeleteBook(book);
            Repository.AddEvent();
            Repository.AddState(state);
        }

        void IDataService.ReturnBook(Book book)
        {
            
        }
    }
}
