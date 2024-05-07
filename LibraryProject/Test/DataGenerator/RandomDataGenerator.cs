using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.DataGenerator
{
    public class RandomDataGenerator : IDataGenerator
    {
        private int numberOfCustomers = 3;
        private int numberOfBooks = 5;
        public void GenerateData(ref Data.Library.DataContext dataContext)
        {
            
        }
    }
}
