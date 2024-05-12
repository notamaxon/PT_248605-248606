using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Author : User
    {     
        public string Information { get; set; }

        public Author(string name, string surname, string email, string phone, string information) : base(name, surname, email, phone)
        {
            Information = information;
        }
        
        public Author() :base() { 
            Information = string.Empty;
        } 
    }

}
