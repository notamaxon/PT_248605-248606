using Data.Library;
using Data.Library.API;
using Data.Library.Events;
using Data.Users;
using Logic.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
      
       

      

        void IDataService.AddBook(Book book)
        {
            Repository.AddBook(book);  
        }

        void IDataService.DeleteBook(Book book)
        {
            Repository.DeleteBook(book);
        }

        void IDataService.GetBook(string id)
        {
            Repository.GetAllBooks();
        }

        void IDataService.AddCustomer(Customer customer)
        {
            Repository.AddCustomer(customer);
        }

        void IDataService.DeleteCustomer(Customer customer)
        {
            Repository.DeleteCustomer(customer);
        }

        void IDataService.AddEvent(EventAbstract eventAbstract)
        {
            Repository.AddEvent(eventAbstract);
        }

        void IDataService.DeleteEvent(EventAbstract eventAbstract)
        {
            Repository.DeleteEvent(eventAbstract);
        }

        void IDataService.BorrowBook(string bookId, string customerId)
        {
            Book book = Repository.GetBook(bookId);
            Customer customer = Repository.GetCustomer(customerId);
            State state = new State(book, StateType.taken);
            Borrow bookBorrow = new Borrow(state);

        
            Repository.AddEvent(bookBorrow);
            Repository.AddState(state);
            Repository.DeleteBook(book);
        }

        void IDataService.ReturnBook(string bookId, int fee, string customerId)
        {
            Book book = Repository.GetBook(bookId);
            Customer customer = Repository.GetCustomer(customerId);
            State state = new State(book, StateType.available);
            Return returnBook = new Return(state, fee);

            Repository.AddEvent(returnBook);
            Repository.AddState(state);
            Repository.AddBook(book);
        }
        
       
    }
}
