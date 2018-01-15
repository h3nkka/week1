using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intarray = { 1, 2, 33, 44, 55, 68, 77, 96, 100 };
            foreach (int i in intarray)
            {
                Console.WriteLine(i + "{0}", i % 2 == 0 ? " HEP" : "");
            }
            Console.ReadKey(true);
        }
    }
}
