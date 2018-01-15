using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter integers to sum them up. Input 0 to stop.");
            int sum = 0;
            int input = 0;
            while (true)
            {
                input = Int32.Parse(Console.ReadLine());
                if (input == 0)
                    break;
                sum += input;
                Console.WriteLine("Sum: " + sum);
            }
        }
    }
}
