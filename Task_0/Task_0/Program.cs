using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_0
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Human h = new Human("Maksym");
            Console.WriteLine(h.greet("Maksym"));
            Console.ReadLine();
        }
    }
}
