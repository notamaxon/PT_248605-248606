using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data  
{
    internal class Customer : User
    {
        public string Adress {  get; set; }

        public Customer(string name, string surname, string email, string phone, string adress) : base(name, surname, email, phone)
        {
            Adress = adress;
        }

        public Customer() :base() {
            Adress = string.Empty;
        }   
    }

}
