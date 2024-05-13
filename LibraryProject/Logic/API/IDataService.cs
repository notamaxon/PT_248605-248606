using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Logic.API
{
    public interface IDataService
    {

        public void AddBook(IBook book);
        public void DeleteBook(IBook book);
        public void GetBook(string id);

        public void AddCustomer(User customer);
        public void DeleteCustomer(User customer);

        public void AddEvent(EventAbstract eventAbstract);
        public void DeleteEvent(EventAbstract eventAbstract);

        public void BorrowBook(string bookId, string customerId);
        public void ReturnBook(IBook book, User customer, int fee = 0);

    }
}
