using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a year to see whether or not it's a leap year.");
            int year = Int32.Parse(Console.ReadLine());
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
                Console.WriteLine("The year is a leap year.");
            else
                Console.WriteLine("The year is not a leap year.");
            Console.ReadKey(true);
        }
    }
}
