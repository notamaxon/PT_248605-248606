
using Logic;

namespace LogicTest
{
    [TestClass]
    public class LogicTests
    {
        
            DataRepository dataRepository = Builder.BuildRepository();

            [TestMethod]
            public void TestMethod1()
            {
                DataGenerator.IDataGenerator generator = new DataGenerator.ManualDataGenerator();
                generator.GenerateData(ref dataRepository);
                IDataService dataService = new Logic.DataService(dataRepository);
                var tempBook = dataRepository.GetBook("5");

                dataService.BorrowBook("5", "1");
                Assert.AreEqual(1, dataRepository.GetAllEvents().Count);

                dataService.ReturnBook(tempBook, dataRepository.GetCustomer("1"));
                Assert.AreEqual(2, dataRepository.GetAllEvents().Count);

            
        }
    }
}