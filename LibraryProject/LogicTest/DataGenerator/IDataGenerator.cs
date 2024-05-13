using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicTest.DataGenerator
{
    public interface IDataGenerator
    {
        void GenerateData(ref Logic.DataRepository dataRepository);
    }
}
