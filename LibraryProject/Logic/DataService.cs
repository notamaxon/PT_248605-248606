using Data;
using Logic;
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
      
       

      

        void IDataService.AddBook(IBook book)
        {
            Repository.AddBook(book);  
        }

        void IDataService.DeleteBook(IBook book)
        {
            Repository.DeleteBook(book);
        }

        void IDataService.GetBook(string id)
        {
            Repository.GetAllBooks();
        }

        void IDataService.AddCustomer(User customer)
        {
            Repository.AddCustomer(customer);
        }

        void IDataService.DeleteCustomer(User customer)
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
            var book = Repository.GetBook(bookId);
            var customer = Repository.GetCustomer(customerId);
            var state = AbstractBuilder.BuildState(book, StateType.taken);
            var bookBorrow = AbstractBuilder.BuildBorrow(state);

        
            Repository.AddEvent(bookBorrow);
            Repository.AddState(state);
            Repository.DeleteBook(book);
        }

        void IDataService.ReturnBook(IBook book, User customer, int fee = 0)
        {
            var state = AbstractBuilder.BuildState(book, StateType.available);
            var returnBook = AbstractBuilder.BuildReturn(state, fee);

            Repository.AddEvent(returnBook);
            Repository.AddState(state);
            Repository.AddBook(book);
        }
        
       
    }
}
