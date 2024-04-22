using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Users
{
    public class Customer : User
    {
        private int CustomerID;
        public Customer(string name, string surname, string email, string phone, int CustomerID) : base(name, surname, email, phone)
        {
            this.CustomerID = CustomerID;   
        }

        public int GetCustomerID()
        {
            return this.CustomerID;
        }
        
        public void SetCustomerID(int CustomerID)
        {
            this.CustomerID = CustomerID;
        }
    }
}
