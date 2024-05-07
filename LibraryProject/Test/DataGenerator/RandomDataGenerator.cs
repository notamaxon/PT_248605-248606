using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Test.DataGenerator
{
    public class RandomDataGenerator : IDataGenerator
    {
        private int numberOfCustomers = 3;
        private int numberOfBooks = 5;
        private int numberOfAuthors = 2;
        public void GenerateData(ref Data.Library.DataContext dataContext)
        {
            Random random = new Random();
            for (int i = 0; i < numberOfCustomers; i++)
            {
                Data.Users.Customer customer = new Data.Users.Customer();
                customer.Adress = random.Next(10000, 100000).ToString();
                customer.Email = random.Next(10000, 100000).ToString();
                customer.Surname = random.Next(10000,100000).ToString();
                customer.Phone = random.Next(10000, 100000).ToString();
                customer.Name = random.Next(10000, 100000).ToString();

                dataContext.Customers.Add(customer);
            }

            for (int i = 0; i < numberOfAuthors; i++)
            {
                Data.Users.Author author = new Data.Users.Author();
                author.Information = random.Next(10000, 100000).ToString();
                author.Email = random.Next(10000, 100000).ToString();
                author.Surname = random.Next(10000, 100000).ToString();
                author.Phone = random.Next(10000, 100000).ToString();
                author.Name = random.Next(10000, 100000).ToString();

                dataContext.Authors.Add(author);
            }

            for (int i = 0;i < numberOfBooks;i++) {
                Data.Library.Book book = new Data.Library.Book();
                book.Author = dataContext.Authors[random.Next(0, dataContext.Authors.Count)];
                Array genreValues = Enum.GetValues(typeof(Data.Library.BookGenres));
                book.Genre = (Data.Library.BookGenres)genreValues.GetValue(random.Next(genreValues.Length));
                book.Title = random.Next(10000, 100000).ToString();

                dataContext.Books.Add(book.Id, book);
            }
        }
    }
}
