using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int value1;
            int value2;
            int value3;

            Console.WriteLine("Input three integers.");
            value1 = Int32.Parse(Console.ReadLine());
            value2 = Int32.Parse(Console.ReadLine());
            value3 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Sum of values: {0}", value1 + value2 + value3);
            Console.WriteLine("Average of values: {0}", (value1 + value2 + value3)/3F);
            Console.ReadKey(true);
        }
    }
}
