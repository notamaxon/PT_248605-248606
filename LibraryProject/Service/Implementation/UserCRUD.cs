using Data.API;
using Service.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Implementation
{
    internal class UserCRUD : IUserCRUD
    {
        private IDataRepository dataRepository;

        public UserCRUD(IDataRepository dataRepository)
        {
            this.dataRepository = dataRepository;
        }
    }
}
