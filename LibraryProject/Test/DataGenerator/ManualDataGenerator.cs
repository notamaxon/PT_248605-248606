using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Data;
using Data.Library;
using Microsoft.VisualBasic;
using static System.Formats.Asn1.AsnWriter;

namespace Test.DataGenerator
{
    public class ManualDataGenerator : IDataGenerator
    {
        public void GenerateData(ref Data.Library.DataContext dataContext)
        {
           

            
            Data.Users.Customer customer1 = new Data.Users.Customer("A", "B", "a@gmail.com", "+486567576", "aleje Politechniki") ;
            customer1.Id = "1";
            Data.Users.Customer customer2 = new Data.Users.Customer("B", "C", "g@gmail.com", "+486566576", "aleje Politechniki 1");
            customer2.Id = "2";

            dataContext.Customers.Add(customer1);
            dataContext.Customers.Add(customer2);

            Data.Users.Author author1 = new Data.Users.Author("Scott", "Fitzgerald", "c@gmail.com", "+486567556", "I");
            author1.Id = "3";
            Data.Users.Author author2 = new Data.Users.Author("Noah", "Yuval ", "d@gmail.com", "+481567556", "O");
            author2.Id = "4";

            dataContext.Authors.Add(author1);
            dataContext.Authors.Add(author2);

            Book book1 = new Book("The Great Gatsby", author1, BookGenres.fiction);
            Book book2 = new Book("The Great Gatsby", author2, BookGenres.fantasy);

            dataContext.Books.Add(book1.Id, book1);
            dataContext.Books.Add(book2.Id, book2);

            State state1 = new State(book1, StateType.taken);
            State state2 = new State(book2, StateType.available);

            dataContext.States.Add(state1);
            dataContext.States.Add(state2);

            Data.Library.Events.Borrow eventBorrow1 = new Data.Library.Events.Borrow(state1);
            Data.Library.Events.Borrow eventBorrow2 = new Data.Library.Events.Borrow(state2);

            dataContext.Events.Add(eventBorrow1);
            dataContext.Events.Add(eventBorrow2);

        }
    }
}
