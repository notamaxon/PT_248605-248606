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
        public void GenerateData(ref Data.Library.API.IDataRepository dataRepository)
        {
           

            
            Data.Users.Customer customer1 = new Data.Users.Customer("A", "B", "a@gmail.com", "+486567576", "aleje Politechniki") ;
            customer1.Id = "1";
            Data.Users.Customer customer2 = new Data.Users.Customer("B", "C", "g@gmail.com", "+486566576", "aleje Politechniki 1");
            customer2.Id = "2";

            dataRepository.AddCustomer(customer1);
            dataRepository.AddCustomer(customer2);

            Data.Users.Author author1 = new Data.Users.Author("Scott", "Fitzgerald", "c@gmail.com", "+486567556", "I");
            author1.Id = "3";
            Data.Users.Author author2 = new Data.Users.Author("Noah", "Yuval ", "d@gmail.com", "+481567556", "O");
            author2.Id = "4";

            dataRepository.AddAuthor(author1);
            dataRepository.AddAuthor(author2);

            Book book1 = new Book("The Great Gatsby", author1, BookGenres.fiction);
            book1.Id = "5";
            Book book2 = new Book("Sapiens", author2, BookGenres.fantasy);
            book2.Id = "6";
            Book book3 = new Book("ABC", author2, BookGenres.mystery);
            book3.Id = "7";

            dataRepository.AddBook(book1);
            dataRepository.AddBook(book2);
            dataRepository.AddBook(book3);
            /*
            State state1 = new State(book1, StateType.taken);
            State state2 = new State(book2, StateType.available);

            dataContext.States.Add(state1);
            dataContext.States.Add(state2);

            Data.Library.Events.Borrow eventBorrow1 = new Data.Library.Events.Borrow(state1);
            Data.Library.Events.Borrow eventBorrow2 = new Data.Library.Events.Borrow(state2);

            dataContext.Events.Add(eventBorrow1);
            dataContext.Events.Add(eventBorrow2);
            */
        }
    }
}
