using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input 3 integers and the program will return the largest one of them.");
            int value1 = Int32.Parse(Console.ReadLine());
            int value2 = Int32.Parse(Console.ReadLine());
            int value3 = Int32.Parse(Console.ReadLine());
            if (value1 > value2 && value1 > value3)
                Console.WriteLine(value1);
            else if (value2 > value3)
                Console.WriteLine(value2);
            else
                Console.WriteLine(value3);
            Console.ReadKey(true);
        }
    }
}
