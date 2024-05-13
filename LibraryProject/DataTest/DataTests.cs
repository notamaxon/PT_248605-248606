using Data;
using System.Security.Cryptography.X509Certificates;

namespace DataTest
{
    [TestClass]
    public class DataTests
    {
        private DataRepository repository = new DataRepository();
        
            [TestMethod]
            public void AddBook_BookAddedSuccessfully()
            {
                // Arrange
                var book = AbstractBuilder.BuildBook();
                book.Id = "123";
                book.Title = "Test Book";

                // Act
                repository.AddBook(book);

                // Assert
                Assert.IsTrue(repository.GetAllBooks().ContainsKey("123"));
                Assert.AreEqual(repository.GetBook("123"), book);
            }

            [TestMethod]
            public void AddCustomer_CustomerAddedSuccessfully()
            {
                // Arrange
                var customer = AbstractBuilder.BuildCustomer();
                customer.Id = "456";
                customer.Name = "Test Customer";

                // Act
                repository.AddCustomer(customer);

                // Assert
                Assert.IsTrue(repository.GetAllCustomers().Contains(customer));
                Assert.AreEqual(repository.GetCustomer("456"), customer);
            }





            [TestMethod]
            public void GetAllAuthor_NoAuthors_ReturnsEmptyList()
            {
                // Act
                var authors = repository.GetAllAuthor();

                // Assert
                Assert.IsNotNull(authors);
                Assert.AreEqual(0, authors.Count);
            }

            [TestMethod]
            public void GetAllEvents_NoEvents_ReturnsEmptyList()
            {
                // Act
                var events = repository.GetAllEvents();

                // Assert
                Assert.IsNotNull(events);
                Assert.AreEqual(0, events.Count);
            }

            [TestMethod]
            public void AddAuthor_AuthorAddedSuccessfully()
            {
                // Arrange
                var author = AbstractBuilder.BuildAuthor();
                author.Id = "999";
                author.Name = "Test Author";

                // Act
                repository.AddAuthor(author);

                // Assert
                Assert.IsTrue(repository.GetAllAuthor().Contains(author));
                Assert.AreEqual(repository.GetAuthor("999"), author);
            }


            [TestMethod]
            public void GetEvent_InvalidId_ReturnsNull()
            {
                // Arrange
                string invalidId = "999";

                // Act
                var result = repository.GetEvent(invalidId);

                // Assert
                Assert.IsNull(result);
            }



        }
    }
