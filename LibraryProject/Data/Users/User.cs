using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Users
{
    public abstract class User
    {
        private string name;
        private string surname;
        private string email;
        private string phone;

        public User(string name, string surname, string email, string phone)
        {
            this.name = name;
            this.surname = surname;
            this.email = email;
            this.phone = phone;
        }

        public string GetName()
        {
            return this.name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetSurname()
        {
            return this.surname;
        }

        public void SetSurname (string surname)
        {
            this.surname = surname;
        }

        public string GetEmail()
        {
            return this.email;
        }

        public void SetEmail(string email)
        {
            this.email = email;
        }

        public string GetPhone()
        {
            return this.phone;
        }

        public void SetPhone(string phone)
        {
            this.phone = phone;
        }

    }
}
