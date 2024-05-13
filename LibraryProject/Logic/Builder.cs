using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Builder : Data.AbstractBuilder 
    {
        public static DataRepository BuildRepository() { 
            return new DataRepository();
        }
    }
}
