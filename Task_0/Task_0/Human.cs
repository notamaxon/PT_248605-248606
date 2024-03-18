using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_0
{
   public class Human
    {
        String name;
        public Human(string name)
        {
            this.name = name;
        }

        public String greet(String who)
        {

            return name + " greets " + who;

        }
    }
}
