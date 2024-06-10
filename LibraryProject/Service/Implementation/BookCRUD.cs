using Data.API;
using Service.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Implementation
{
    internal class BookCRUD : IBookCRUD
    {
        private IDataRepository dataRepository;

        public BookCRUD(IDataRepository dataRepository)
        {
            this.dataRepository = dataRepository;
        }
    }
}
