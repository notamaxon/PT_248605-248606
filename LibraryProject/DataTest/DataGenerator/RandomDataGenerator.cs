using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace DataTest.DataGenerator
{
    public class RandomDataGenerator : IDataGenerator
    {
        private int numberOfCustomers = 3;
        private int numberOfBooks = 5;
        private int numberOfAuthors = 2;
        public void GenerateData(ref Data.IDataRepository dataRepository)
        {
            Random random = new Random();
            for (int i = 0; i < numberOfCustomers; i++)
            {
                var customer = AbstractBuilder.BuildCustomer(random.Next(10000, 100000).ToString(),
                                                             random.Next(10000, 100000).ToString(),
                                                             random.Next(10000, 100000).ToString(),
                                                             random.Next(10000, 100000).ToString(),
                                                             random.Next(10000, 100000).ToString());

                dataRepository.AddCustomer(customer);
            }

            for (int i = 0; i < numberOfAuthors; i++)
            {
                var author = AbstractBuilder.BuildAuthor(random.Next(10000, 100000).ToString(),
                                                         random.Next(10000, 100000).ToString(),
                                                         random.Next(10000, 100000).ToString(),
                                                         random.Next(10000, 100000).ToString(),
                                                         random.Next(10000, 100000).ToString());
         

                dataRepository.AddAuthor(author);
            }

            for (int i = 0;i < numberOfBooks;i++) {
                var book = AbstractBuilder.BuildBook();
                book.Author = dataRepository.GetAllAuthor()[random.Next(0, dataRepository.GetAllAuthor().Count)];
                Array genreValues = Enum.GetValues(typeof(Data.BookGenres));
                book.Genre = (Data.BookGenres)genreValues.GetValue(random.Next(genreValues.Length));
                book.Title = random.Next(10000, 100000).ToString();

                dataRepository.AddBook(book);
            }
        }
    }
}
