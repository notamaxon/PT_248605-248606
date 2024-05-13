using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTest.DataGenerator
{
    public interface IDataGenerator
    {
        void GenerateData(ref Data.IDataRepository dataRepository);
    }
}
