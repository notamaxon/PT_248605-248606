using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Data;
using Microsoft.VisualBasic;
using static System.Formats.Asn1.AsnWriter;

namespace DataTest.DataGenerator
{
    public class ManualDataGenerator : IDataGenerator
    {
        public void GenerateData(ref Data.IDataRepository dataRepository)
        {
           

            
            var customer1 = Data.AbstractBuilder.BuildCustomer("A", "B", "a@gmail.com", "+486567576", "aleje Politechniki") ;
            customer1.Id = "1";
            var customer2 = Data.AbstractBuilder.BuildCustomer("B", "C", "g@gmail.com", "+486566576", "aleje Politechniki 1");
            customer2.Id = "2";

            dataRepository.AddCustomer(customer1);
            dataRepository.AddCustomer(customer2);

            var author1 = Data.AbstractBuilder.BuildAuthor("Scott", "Fitzgerald", "c@gmail.com", "+486567556", "I");
            author1.Id = "3";
            var author2 = Data.AbstractBuilder.BuildAuthor("Noah", "Yuval ", "d@gmail.com", "+481567556", "O");
            author2.Id = "4";

            dataRepository.AddAuthor(author1);
            dataRepository.AddAuthor(author2);

            IBook book1 = Data.AbstractBuilder.BuildBook("The Great Gatsby", author1, BookGenres.fiction);
            book1.Id = "5";
            IBook book2 = Data.AbstractBuilder.BuildBook("Sapiens", author2, BookGenres.fantasy);
            book2.Id = "6";
            IBook book3 = Data.AbstractBuilder.BuildBook("ABC", author2, BookGenres.mystery);
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
