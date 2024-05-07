using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Test.DataGenerator
{
    public class ManualDataGenerator : IDataGenerator
    {
        public void GenerateData(ref Data.Library.DataContext dataContext);
        {
            DataContext context = new DataContext();

            
            Customer customer1 = new Customer("A", "B", a@gmail.com, +486567576, aleje Politechniki) ;
       
        }
    }
}
