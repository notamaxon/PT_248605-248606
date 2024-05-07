using Data.Library;
using Data.Users;
using Logic.API;
using Test.DataGenerator;

namespace Test
{
    [TestClass]
    public class DataServiceTest
    {
        Data.Library.API.IDataRepository dataRepository = new Data.Library.DataRepository();

        [TestMethod]
        public void TestMethod1()
        {
            IDataGenerator generator = new ManualDataGenerator();
            generator.GenerateData(ref dataRepository);
            IDataService dataService = new Logic.DataService(dataRepository);
            
            Book tempBook = dataRepository.GetBook("5");
            
            dataService.BorrowBook("5", "1");
            Assert.AreEqual(1, dataRepository.GetAllEvents().Count);

            dataService.ReturnBook(tempBook, dataRepository.GetCustomer("1"));
            Assert.AreEqual(2, dataRepository.GetAllEvents().Count);

        }
    }
}