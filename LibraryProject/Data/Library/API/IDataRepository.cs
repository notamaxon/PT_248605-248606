using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Library.API
{
    internal interface IDataRepository
    {
        void AddCustomer(Users.Customer Customer);
        void DeleteCustomer(Users.Customer customer);
        Users.Customer GetCustomerByID(int customerID);
        List<Users.Customer> GetAllCustomers();

        void AddBook(Book book);
    }
}
