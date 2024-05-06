using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Users
{
    public abstract class User
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public User(string name, string surname, string email, string phone) {

            Id = Guid.NewGuid().ToString();
            Name = name;
            Surname = surname;
            Email = email;
            Phone = phone;

       }
        
        public User() { 
            Id = string.Empty;
            Email = string.Empty;
            Phone = string.Empty;
            Name = string.Empty;
            Surname = string.Empty;
            Email = string.Empty;
            Phone = string.Empty;
        }   

    }


}
