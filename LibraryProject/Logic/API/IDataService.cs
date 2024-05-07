using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Data.Library;
using Data.Users;

namespace Logic.API
{
    public interface IDataService
    {

        public void AddBook(Book book);
        public void DeleteBook(Book book);
        public void GetBook(string id);

        public void AddCustomer(Customer customer);
        public void DeleteCustomer(Customer customer);

        public void AddEvent(Data.Library.Events.EventAbstract eventAbstract);
        public void DeleteEvent(Data.Library.Events.EventAbstract eventAbstract);

        public void BorrowBook(string bookId, string customerId);
        public void ReturnBook(string bookId, int fee, string customerId);

    }
}
