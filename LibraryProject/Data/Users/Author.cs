using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Users
{
    public class Author : User
    {     
        public string Information { get; set; }

        public Author(string id, string name, string surname, string email, string phone, string information) : base(id, name, surname, email, phone)
        {
            Information = information;
        }
        
        public Author() :base() { 
            Information = string.Empty;
        } 
    }

}
