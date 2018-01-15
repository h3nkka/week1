using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1
{
    class Program
    {
        static void Main(string[] args) //stuff
        {
            Console.WriteLine("Enter a number between 1 and 3");
            int input = Int32.Parse(Console.ReadLine());
            if (input == 1)
                Console.WriteLine("Number is one");
            else if (input == 2)
                Console.WriteLine("Number is two");
            else if (input == 3)
                Console.WriteLine("Number is three");
            else
                Console.WriteLine("Some other number");
            Console.ReadKey(true);
        }
    }
}
