using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Users
{
    public class Customer : User
    {
        public string Adress {  get; set; }

        public Customer(string id, string name, string surname, string email, string phone, string adress) : base(id, name, surname, email, phone)
        {
            Adress = adress;
        }

        public Customer() :base() {
            Adress = string.Empty;
        }   
    }

}
